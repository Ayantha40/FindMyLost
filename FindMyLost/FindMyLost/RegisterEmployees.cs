using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace FindMyLost
{
    public partial class RegisterEmployees : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public RegisterEmployees()
        {
            InitializeComponent();
        }

        private void btnEditUserPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;.*.png;)|*.jpg;*.jpeg;.*.gif;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbUserImage.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void btnEditUserPic_MouseEnter(object sender, EventArgs e)
        {
            btnEditUserPic.ForeColor = Color.Black;
        }

        private void btnEditUserPic_MouseLeave(object sender, EventArgs e)
        {
            btnEditUserPic.ForeColor = Color.White;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || txtMobileNum.Text == "" || txtTelNumber.Text == "" || pbUserImage.Image == null || cbPosition.Text == "")
            {
                MessageBox.Show("Please fill in all the employee details!", "LostBadu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    var employee_image = pbUserImage.Image;
                    byte[] imageBytes;
                    MemoryStream ms = new MemoryStream();
                    employee_image.Save(ms, ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();

                    string sql = "INSERT INTO Employee (first_name, last_name, email, address, mobile_number, telephone_number, password, picture, position) VALUES ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtEmail.Text + "', '" + txtAddress.Text + "', '" + txtMobileNum.Text + "', '" + txtTelNumber.Text + "', 'aaAA12!@', @image, '" + cbPosition.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@image", imageBytes);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Registration Successful!", "LostBadu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "LostBadu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
