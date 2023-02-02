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

        public static string empId = "";
        public static bool isITAdmin;

        private void btnlogin_Click(object sender, EventArgs e)
        {
            empId = txtempid.Text;
            string sql = "select * from Employee where employee_id = '" + txtempid.Text + "' and password = '" + txtpassword.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() && (txtpassword.Text != "") && (txtempid.Text != ""))
            {

                if (dr["position"].ToString() == "Employee")
                {
                    isITAdmin = false;
                }
                else
                {
                    isITAdmin = true;
                }
                Dashboard db= new Dashboard();
                db.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Employee ID or Password", "FindMyLost", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            conn.Close();

        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '●')
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '●';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
