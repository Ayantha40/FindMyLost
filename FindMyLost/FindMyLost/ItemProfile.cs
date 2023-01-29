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
    public partial class ItemProfile : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public ItemProfile()
        {
            InitializeComponent();
        }

        public static string itemID = "";
        string SelectedItemID = ItemList.SelectedItemID;

        private void ItemProfile_Load(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBytes;

                string sql = "SELECT * FROM Lost_Item WHERE item_id = '" + SelectedItemID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    var myColor = Color.FromArgb(Convert.ToInt32(dr["item_colour"]));
                    pbColor.BackColor = myColor;

                    lblCategory.Text = dr["item_category"].ToString();
                    lblID.Text = dr["item_id"].ToString();
                    lblBrand.Text = dr["item_brand"].ToString();
                    lblLocation.Text = dr["last_seen_location"].ToString();
                    lblAdditionInfo.Text = dr["additional_info"].ToString();


                    imageBytes = (byte[])dr["item_picture"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image img = Image.FromStream(ms);
                    pbItemPic.Image = img;

                    itemID = SelectedItemID;

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



        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditLostItemDescription ed = new EditLostItemDescription();
            ed.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Item?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE from Lost_Item WHERE item_id = '" + SelectedItemID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item deleted.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {

            }
        }

        private void ItemProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
