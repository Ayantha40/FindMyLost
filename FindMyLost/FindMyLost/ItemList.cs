using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Configuration;
using System.Data.SqlClient;

namespace FindMyLost
{
    public partial class ItemList : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public ItemList()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green700, Primary.Green700, Accent.LightBlue100, TextShade.WHITE);
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            lvItemList.FullRowSelect = true;

            try
            {
                string sql = "SELECT item_id, item_category, item_colour, item_brand, last_seen_location FROM Lost_Item";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr.GetInt32(0).ToString());
                    item.SubItems.Add(dr.GetString(1));
                    item.SubItems.Add(dr.GetString(2));
                    item.SubItems.Add(dr.GetString(3));
                    item.SubItems.Add(dr.GetString(4));

                    lvItemList.Items.Add(item);
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

        public static string SelectedItemID;

        
        private void lvItemList_MouseClick(object sender, MouseEventArgs e)
        {
            lvItemList.Refresh(); //doesn't work
            ListViewItem item = lvItemList.SelectedItems[0];
            SelectedItemID = item.SubItems[0].Text;
            ItemProfile itemProfile = new ItemProfile();
            itemProfile.Show();
            
         
        }

        private void lvItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
