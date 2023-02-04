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
    public partial class test : Form
    {
        public static TableLayoutPanel tlp;
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemList editProfile = new ItemList() { TopLevel = false, TopMost = true };
            tlp.Controls.Clear();
            editProfile.FormBorderStyle = FormBorderStyle.None;
            tlp.Controls.Add(editProfile, 0, 0);
            editProfile.Show();
        }
        public static void ShowItemProfile()
        {
            ItemProfile editProfile = new ItemProfile() { TopLevel = false, TopMost = true };
            editProfile.FormBorderStyle = FormBorderStyle.None;
            tlp.Controls.Add(editProfile, 1, 0);
            editProfile.Show();
        }
    }
}
