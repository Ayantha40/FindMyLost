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
    public partial class EditProfile : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public EditProfile()
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

        private void EditProfile_Load(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBytes;

                string sql = "SELECT * FROM Employee WHERE employee_id = '" + EmployeeList.SelectedEmployeeID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtFirstName.Text = dr["first_name"].ToString();
                    txtLastName.Text = dr["last_name"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtAddress.Text = dr["address"].ToString();
                    txtMobileNum.Text = dr["mobile_number"].ToString();
                    txtTelNumber.Text = dr["telephone_number"].ToString();

                    imageBytes = (byte[])dr["picture"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image img = Image.FromStream(ms);
                    pbUserImage.Image = img;
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE Employee SET first_name = '" + txtFirstName.Text + "', last_name = '" + txtLastName.Text + "', email = '" + txtEmail.Text + "', address = '" + txtAddress.Text + "', mobile_number = '" + txtMobileNum.Text + "', telephone_number = '" + txtTelNumber.Text + "', picture = @image WHERE employee_id = '" + EmployeeList.SelectedEmployeeID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                var img = pbUserImage.Image;
                byte[] imageBytes;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Jpeg);
                imageBytes = ms.ToArray();

                cmd.Parameters.AddWithValue("@image", imageBytes);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee details updated successfully!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void EditProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmployeeProfile ep = new EmployeeProfile();
            ep.Show();
        }
    }
}
