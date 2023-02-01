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
    public partial class ListItem : Form
    {
        public static PictureBox pb1;
        public static string form;

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public ListItem()
        {
            InitializeComponent();
            //instance = this;
            pb1 = pbColor;
            //tb1 = txtColor;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string ImageLocation = "";

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageLocation = ofd.FileName;
                imgItem.ImageLocation = ImageLocation;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBrand.Clear();
            txtAdditional.Clear();
            txtLocation.Clear();
            imgItem.ImageLocation = "";
            pbColor.BackColor = Color.Empty;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((category != "") && (txtBrand.Text != "") && (cmbColor.Text != ""))
            {
                    try
                    {
                        var item_image = imgItem.Image;
                        byte[] imageBytes;
                        MemoryStream ms = new MemoryStream();
                        item_image.Save(ms, ImageFormat.Jpeg);
                        imageBytes = ms.ToArray();

                        string sql = "INSERT INTO Lost_Item (item_category, item_colour, item_picture, last_seen_location, item_brand, additional_info) VALUES ('" + category + "', '" + cmbColor.Text + "', @image,'" + txtLocation.Text + "','" + txtBrand.Text + "','" + txtAdditional.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@image", imageBytes);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item Listed", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Please fill all in fields marked with a *");
            }
        }

        private void radioClothing_CheckedChanged(object sender, EventArgs e)
        {

        }

        string category;
        private void radioClothing_Click(object sender, EventArgs e)
        {
            category = radioClothing.Text;
        }

        private void radioElec_Click(object sender, EventArgs e)
        {
            category = radioElec.Text;
        }

        private void radioBag_Click(object sender, EventArgs e)
        {
            category = radioBag.Text;
        }

        private void radioAccessories_Click(object sender, EventArgs e)
        {
            category = radioAccessories.Text;
        }

        private void radioAnimal_Click(object sender, EventArgs e)
        {
            category = radioAnimal.Text;
        }

        private void radioDocuments_Click(object sender, EventArgs e)
        {
            category = radioDocuments.Text;
        }

        private void radioOther_Click(object sender, EventArgs e)
        {
            category = radioOther.Text;
        }



        private void ListItem_Load(object sender, EventArgs e)
        {
            pbColor.BackColor = Color.Empty;
        }


        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_MouseEnter(object sender, EventArgs e)
        {
            btnBrowse.ForeColor = Color.Black;
            btnBrowse.BackColor = Color.White;
        }

        private void btnBrowse_MouseLeave(object sender, EventArgs e)
        {
            btnBrowse.ForeColor = Color.White;
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item_color = cmbColor.Text;
            Color colour = Color.FromName(item_color);
            pbColor.BackColor = colour;
        }
    }
}
