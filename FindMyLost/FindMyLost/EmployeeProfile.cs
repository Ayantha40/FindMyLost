using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMyLost
{
    public partial class EmployeeProfile : Form
    {
        public EmployeeProfile()
        {
            InitializeComponent();
        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void lblTelNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditUserPic_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {

            }
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
