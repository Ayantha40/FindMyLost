using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace FindMyLost
{
    public partial class ChangePassword : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public ChangePassword()
        {
            InitializeComponent();
        }

        string empID = Login.empId;

        private static Regex PasswordValidation()
        {
            string pattern = "^.*(?=.{7,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
            //string pattern = "^.*(?=.{7,})(?=.*\\d)(?=.*[a-zA-Z])(?=.*[!*@#$%^&+=]).*$";
            //string pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex vaildate_password = PasswordValidation();


        private void ChangePassword_Load(object sender, EventArgs e)
        {
            lblCorrect.Hide();
            lblWrong.Hide();
            lblCorrect2.Hide();
            lblWrong2.Hide();
            lblCorrect0.Hide();
            lblWrong0.Hide();

            string sql = "SELECT * FROM Employee WHERE employee_id = '" + empID + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtOldPassword.Text = dr["password"].ToString();
            }

        }   

        private void tlpFirstName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOld_Click(object sender, EventArgs e)
        {

        }

        private void txtNP_TextChanged(object sender, EventArgs e)
        {

            // new password has atleast 7 characters
            if (txtNP.TextLength < 7)
            {
                lbl7Char.Text = "❌";
                lbl7Char.ForeColor = Color.Red;
            }
            else
            {
                lbl7Char.Text = "✔";
                lbl7Char.ForeColor = Color.LawnGreen;
            }

            // new password has atleast 1 number
            if (txtNP.Text.Any(char.IsDigit) == false)
            {
                lbl1num.Text = "❌";
                lbl1num.ForeColor = Color.Red;
            }
            else
            {
                lbl1num.Text = "✔";
                lbl1num.ForeColor = Color.LawnGreen;
            }

            // new password has atleast 1 uppercase letter
            if (txtNP.Text.Any(char.IsUpper) == false)
            {
                lbl1uppercase.Text = "❌";
                lbl1uppercase.ForeColor = Color.Red;
            }
            else
            {
                lbl1uppercase.Text = "✔";
                lbl1uppercase.ForeColor = Color.LawnGreen;
            }

            // new password has atleast 1 special character

            string newPwd = txtNP.Text;
            Match match = Regex.Match(newPwd, "[^a-z0-9]", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                lbl1splchar.Text = "✔";
                lbl1splchar.ForeColor = Color.LawnGreen;
            }
            else
            {
                lbl1splchar.Text = "❌";
                lbl1splchar.ForeColor = Color.Red;
            }

            // new password is not the same as old
            if (txtOldPassword.Text == txtNP.Text)
            {
                lblNew.Text = "❌";
                lblNew.ForeColor = Color.Red;
            }
            else
            {
                lblNew.Text = "✔";
                lblNew.ForeColor = Color.LawnGreen;
            }





            if (vaildate_password.IsMatch(txtNP.Text) != true)
            {
                lblWrong.Show();
                txtNP.Focus();
                return;
            }

            else
            {
                lblWrong.Hide();
                lblCorrect.Show();

            }
        }

        private void txtCNP_TextChanged(object sender, EventArgs e)
        {
            if (txtCNP.Text == txtNP.Text)
            {
                lblCorrect2.Show();
                lblWrong2.Hide();

            }
            else
            {
                lblWrong2.Show();
                lblCorrect2.Hide();
            }
        }

        private void btnViewOP_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.PasswordChar == '●')
            {
                txtOldPassword.PasswordChar = '\0';
                txtNP.PasswordChar = '●';
                txtCNP.PasswordChar = '●';
            }
            else
            {
                txtOldPassword.PasswordChar = '●';
            }
        }

        private void btnViewNP_Click(object sender, EventArgs e)
        {
            if (txtNP.PasswordChar == '●')
            {
                txtNP.PasswordChar = '\0';
                txtOldPassword.PasswordChar = '●';
                txtCNP.PasswordChar = '●';
            }
            else
            {
                txtNP.PasswordChar = '●';
            }
        }

        private void btnViewCNP_Click(object sender, EventArgs e)
        {
            if (txtCNP.PasswordChar == '●')
            {
                txtCNP.PasswordChar = '\0';
                txtNP.PasswordChar = '●';
                txtOldPassword.PasswordChar = '●';
            }
            else
            {
                txtCNP.PasswordChar = '●';
            }
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if ((vaildate_password.IsMatch(txtNP.Text) != true))
            {
                MessageBox.Show("New password does not match criteria");
            }
            else if (txtNP.Text != txtCNP.Text)
            {
                MessageBox.Show("Passwords do not match");
            }

            else
            {
                try
                {
                    

                    string sql = "UPDATE Employee SET password = '" + txtNP.Text + "' WHERE employee_id = '" + empID + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your password has been changed successfully", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
                
                

            }
        }
    }
}
