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
    public partial class ClaimItem : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public static PictureBox Colour;
        public static string form;

        public ClaimItem()
        {
            InitializeComponent();
            Colour = pbColor;
        }

        private void pbColorPicker_Click(object sender, EventArgs e)
        {
            form = "ClaimItem";
            colorPick cp = new colorPick();
            cp.Show();
        }

        private void btnEditItemPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;.*.png;)|*.jpg;*.jpeg;.*.gif;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbItemPic.Image = new Bitmap(opnfd.FileName);
            }
        }

        string category;

        private void radioClothing_CheckedChanged(object sender, EventArgs e)
        {
            category = radioClothing.Text;
        }

        private void radioElec_CheckedChanged(object sender, EventArgs e)
        {
            category = radioElec.Text;
        }

        private void radioBag_CheckedChanged(object sender, EventArgs e)
        {
            category = radioBag.Text;
        }

        private void radioAccessories_CheckedChanged(object sender, EventArgs e)
        {
            category = radioAccessories.Text;
        }

        private void radioAnimal_CheckedChanged(object sender, EventArgs e)
        {
            category = radioAnimal.Text;
        }

        private void radioDocuments_CheckedChanged(object sender, EventArgs e)
        {
            category = radioDocuments.Text;
        }

        private void radioOther_CheckedChanged(object sender, EventArgs e)
        {
            category = radioOther.Text;
        }

        private void btnPublishClaim_Click(object sender, EventArgs e)
        {
            string item_color = pbColor.BackColor.ToString();

            if (txtName.Text == "" || txtAddress.Text == "" || txtPhoneNum.Text == "" || category == "" || item_color == "Transparent")
            {
                MessageBox.Show("Please fill in all the employee details!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    var item_image = pbItemPic.Image;
                    byte[] imageBytes;
                    MemoryStream ms = new MemoryStream();
                    item_image.Save(ms, ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();



                    string sql = "INSERT INTO Claim (claimer_name, claimer_address, claimer_phone_number, item_category, item_colour, item_picture, last_seen_location, item_brand, additional_info) VALUES ('" + txtName.Text + "', '" + txtAddress.Text + "', '" + txtPhoneNum.Text + "', '" + category + "', '" + item_color + "', @image, '" + txtLocation.Text + "', '" + txtBrand.Text + "', '" + txtAddInfo.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@image", imageBytes);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Claim Published Successfully!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEditItemPic_MouseEnter(object sender, EventArgs e)
        {
            btnEditItemPic.ForeColor = Color.Black;
        }

        private void btnEditItemPic_MouseLeave(object sender, EventArgs e)
        {
            btnEditItemPic.ForeColor = Color.White;
        }
    }
}
