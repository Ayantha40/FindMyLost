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
    public partial class EditLostItemDescription : Form
    {
        public static PictureBox pb1;
        public static string form;

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public EditLostItemDescription()
        {
            InitializeComponent();
            pb1 = pbColor;
         
        }

        private void EditLostItemDescription_Load(object sender, EventArgs e)
        {
            //to check if color is getting retrieved
            //it is 
            //yay
            try
            {
                byte[] imageBytes;

                string sql = "SELECT * FROM Lost_Item WHERE item_id = '" + ItemProfile.itemID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    var myColor = Color.FromArgb(Convert.ToInt32(dr["item_colour"]));
                    pbColor.BackColor = myColor;

                    txtCategory.Text = dr["item_category"].ToString();
                    txtLocation.Text = dr["last_seen_location"].ToString();
                    txtBrand.Text = dr["item_brand"].ToString();
                    txtAdditional.Text = dr["additional_info"].ToString();

                    imageBytes = (byte[])dr["item_picture"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image img = Image.FromStream(ms);
                    imgItem.Image = img;
                }
                else
                {
                    MessageBox.Show("Invalid Item ID.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            btnBrowse.BackColor = Color.Black;
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

        private void picPick_Click(object sender, EventArgs e)
        {
            form = "EditItem";
            colorPick cp = new colorPick();
            cp.Show();
        }
        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((category != "") && (txtBrand.Text != "") && (pbColor.BackColor != Color.Empty))
            {
                try
                {
                    int argb = pbColor.BackColor.ToArgb();

                    string sql = "UPDATE Lost_Item SET item_category = '" + category + "', item_colour = '" + argb + "', item_picture =  @image , last_seen_location = '" + txtLocation.Text + "', item_brand = '" + txtBrand.Text + "', additional_info = '" + txtAdditional.Text + "' WHERE item_id = '" + ItemProfile.itemID + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    var img = imgItem.Image;
                    byte[] imageBytes;
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();

                    cmd.Parameters.AddWithValue("@image", imageBytes);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item details updated successfully!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Please fill all in fields marked with a * ", "FindMyLost");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details update process cancelled", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }
    }
}

