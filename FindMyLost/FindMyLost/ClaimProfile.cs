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
    public partial class ClaimProfile : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public ClaimProfile()
        {
            InitializeComponent();
        }

        string SelectedClaimID = ClaimList.SelectedClaimID;

        private void ClaimProfile_Load(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBytes;

                string sql = "SELECT * FROM Claim WHERE claim_id = '" + SelectedClaimID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtCategory.Text = dr["item_category"].ToString();
                    txtColour.Text = dr["item_colour"].ToString();
                    txtLastSeen.Text = dr["last_seen_location"].ToString();
                    txtBrand.Text = dr["item_brand"].ToString();
                    txtAddInfo.Text = dr["additional_info"].ToString();
                    txtName.Text = dr["claimer_name"].ToString();
                    txtPhoneNum.Text = dr["claimer_phone_number"].ToString();
                    txtAddress.Text = dr["claimer_address"].ToString();

                    imageBytes = (byte[])dr["item_picture"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image img = Image.FromStream(ms);
                    pbItemPic.Image = img;
                }
                else
                {
                    MessageBox.Show("Invalid Claim ID.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        }

        private void btnMatch_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete the claim?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM Claim WHERE claim_id = '" + SelectedClaimID + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Claim deleted!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    this.Hide();
                    ClaimList claimList = new ClaimList();
                    claimList.Show();
                }
            }
        }

        private void ClaimProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClaimList claimList = new ClaimList();
            claimList.Show();
        }
    }
}
