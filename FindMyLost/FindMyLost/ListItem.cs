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
            pb1 = pbColor;
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
            cmbColor.SelectedIndex = -1;
            imgItem.Image = Properties.Resources.item_placeholder;
            pbColor.BackColor = Color.Empty;
            radioClothing.Checked = false;
            radioElec.Checked = false;
            radioBag.Checked = false;
            radioAnimal.Checked = false;
            radioDocuments.Checked = false;
            radioAccessories.Checked = false;
            radioOther.Checked = false;
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
                        MessageBox.Show("Item Listed!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                        btnReset_Click(sender, e);
                    }              
            }
            else
            {
                MessageBox.Show("Please fill all in fields marked with a *", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            btnBrowse.BackColor = Color.FromArgb(23, 23, 23);
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item_color = cmbColor.Text;
            if (item_color == "Red")
            {
                pbColor.BackColor = Color.FromArgb(80, 0, 0);
            }
            else if (item_color == "Orange")
            {
                pbColor.BackColor = Color.FromArgb(203, 92, 12);
            }
            else if (item_color == "Yellow")
            {
                pbColor.BackColor = Color.FromArgb(217, 181, 30);
            }
            else if (item_color == "Green")
            {
                pbColor.BackColor = Color.FromArgb(73, 94, 53);
            }
            else if (item_color == "Blue")
            {
                pbColor.BackColor = Color.FromArgb(0, 51, 102);
            }
            else if (item_color == "Purple")
            {
                pbColor.BackColor = Color.FromArgb(52, 32, 72);
            }
            else if (item_color == "Pink")
            {
                pbColor.BackColor = Color.FromArgb(241, 145, 155);
            }
            else if (item_color == "Beige")
            {
                pbColor.BackColor = Color.FromArgb(145, 121, 77);
            }
            else if (item_color == "Brown")
            {
                pbColor.BackColor = Color.FromArgb(68, 33, 18);
            }
            else if (item_color == "Gray")
            {
                pbColor.BackColor = Color.FromArgb(50, 50, 50);
            }
            else if (item_color == "Black")
            {
                pbColor.BackColor = Color.FromArgb(0, 0, 0);
            }
            else if (item_color == "White")
            {
                pbColor.BackColor = Color.FromArgb(255, 255, 255);
            }
        }
    }
}
