using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace FindMyLost
{
    public partial class Dashboard : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Dashboard()
        {
            InitializeComponent();
            leftBorder = new Panel();
            leftBorder.Size = new Size(7, 75);
            SideMenu.Controls.Add(leftBorder);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        bool isITAdmin = Login.isITAdmin;
        string employeeID = Login.empId;
        private IconButton currentbtn;
        private Panel leftBorder;
        string currentPage;

        private void BtnSelect(object btn)
        {
            if (btn != null)
            {
                BtnUnselect();
                currentbtn = (IconButton)btn;
                currentbtn.BackColor = Color.FromArgb(20, 20, 20);
                leftBorder.BackColor = Color.FromArgb(50, 128, 45);
                leftBorder.Location = new Point(0, currentbtn.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();
                iconCurrentPage.IconChar = currentbtn.IconChar;
                lblCurrentPage.Text = currentPage;
            }
        }

        private void BtnUnselect()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(15, 15, 15);
            }
        }

        private void CloseMenu()
        {
            panelMenu.Visible = false;
            btnMenu.BackColor = Color.FromArgb(10, 10, 10);
        }

        private void Reset()
        {
            BtnUnselect();
            leftBorder.Visible = false;
            iconCurrentPage.IconChar = IconChar.Home;
            lblCurrentPage.Text = "HOME";
            CloseMenu();
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            //panelTheme.Visible = false;
            //panelMenu.Size = new Size(318, 389);
            try
            {
                panelMenu.Visible = false;
                if (isITAdmin == true)
                {
                    btnListItem.Visible = false;
                }
                else
                {
                    btnRegister.Visible = false;
                    btnEmployeeList.Visible = false;
                }

                byte[] imageBytes;

                string sql = "SELECT * FROM Employee WHERE employee_id = '" + employeeID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblEmployeeID.Text = employeeID;
                    lblName.Text = dr["first_name"].ToString() + " " + dr["last_name"].ToString();
                    lblEmail.Text = dr["email"].ToString();

                    imageBytes = (byte[])dr["picture"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image img = Image.FromStream(ms);
                    pbUser.Image = img;
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            panelMenu.Location = new Point((btnMenu.Location.X - 236), 0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            currentPage = "REGISTER EMPLOYEES";
            BtnSelect(sender);
            CloseMenu();

            RegisterEmployees register = new RegisterEmployees() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            register.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1028, 933);
            panelForm.Controls.Add(register);
            register.Show();
        }

        private void btnClaimItem_Click(object sender, EventArgs e)
        {
            currentPage = "CLAIM AN ITEM";
            BtnSelect(sender);
            CloseMenu();

            ClaimItem claimItem = new ClaimItem() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            claimItem.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1596, 897);
            panelForm.Controls.Add(claimItem);
            claimItem.Show();
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {
            currentPage = "ITEM LIST";
            BtnSelect(sender);
            CloseMenu();

            ItemList itemList = new ItemList() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            itemList.FormBorderStyle = FormBorderStyle.None;
            itemList.ControlBox = false;
            this.Size = new Size(1209, 850);
            panelForm.Controls.Add(itemList);
            itemList.Show();
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            currentPage = "EMPLOYEE LIST";
            BtnSelect(sender);
            CloseMenu();

            EmployeeList empList = new EmployeeList() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            empList.ControlBox = false;
            this.Size = new Size(1197, 836);
            panelForm.Controls.Add(empList);
            empList.Show();
        }

        private void btnClaimList_Click(object sender, EventArgs e)
        {
            currentPage = "CLAIM LIST";
            BtnSelect(sender);
            CloseMenu();

            ClaimList claimList = new ClaimList() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            claimList.ControlBox = false;
            this.Size = new Size(1343, 846);
            panelForm.Controls.Add(claimList);
            claimList.Show();
        }

        private void btnListItem_Click(object sender, EventArgs e)
        {
            currentPage = "LIST A LOST ITEM";
            BtnSelect(sender);
            CloseMenu();

            ListItem listItem = new ListItem() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            listItem.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1335, 1035);
            panelForm.Controls.Add(listItem);
            listItem.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            currentPage = "EDIT PROFILE";
            BtnSelect(sender);
            leftBorder.Visible = false;
            CloseMenu();

            EditProfile editProfile = new EditProfile() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            editProfile.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1013, 817);
            panelForm.Controls.Add(editProfile);
            editProfile.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            currentPage = "CHANGE PASSWORD";
            BtnSelect(sender);
            leftBorder.Visible = false;
            CloseMenu();

            ChangePassword changePassword = new ChangePassword() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            changePassword.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1301, 656);
            panelForm.Controls.Add(changePassword);
            changePassword.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Logout?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void SideMenu_Click(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void panelForm_Click(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible == false)
            {
                panelMenu.Location = new Point((btnMenu.Location.X - 236), 0);
                panelMenu.Visible = true;
                btnMenu.BackColor = Color.FromArgb(20, 20, 20);
            }
            else
            {
                CloseMenu();
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
