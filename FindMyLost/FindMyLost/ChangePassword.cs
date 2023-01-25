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

namespace FindMyLost
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

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
        }

        private void tlpFirstName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOld_Click(object sender, EventArgs e)
        {

        }

        private void txtNP_TextChanged(object sender, EventArgs e)
        {
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
    }
}
