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
    public partial class ClaimList : Form //MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public ClaimList()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            //skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green700, Primary.Green700, Accent.LightBlue100, TextShade.WHITE);
        }

        private void ClaimList_Load(object sender, EventArgs e)
        {
            lvClaimList.FullRowSelect = true;

            try
            {
                string sql = "SELECT claim_id, claimer_name, item_category, item_colour, item_brand, last_Seen_location FROM Claim";
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

                    lvClaimList.Items.Add(item);
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

        public static string SelectedClaimID;

        private void lvClaimList_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = lvClaimList.SelectedItems[0];
            SelectedClaimID = item.SubItems[0].Text;
            Dashboard.ShowClaimProfile();
        }
    }
}
