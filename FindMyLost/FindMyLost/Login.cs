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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FindMyLost
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string emp_id = txtempid.Text;
            string sql = "select * from Employee where employee_id = '" + txtempid.Text + "' and password = '" + txtpassword.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Open();
            cmd.ExecuteNonQuery();

            if ((ds.Tables[0].Rows.Count != 0) && (txtpassword.Text != "") && (txtempid.Text != ""))
            {
                this.Hide();
                EditLostItemDescription m = new EditLostItemDescription();
                m.Show();
            }

            else
            {
                MessageBox.Show("Invalid Employee ID or Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
