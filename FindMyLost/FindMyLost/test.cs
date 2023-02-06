using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FindMyLost
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        string m;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            m = Interaction.InputBox("Enter name", "LMS");
            if (m == "")
            {
                MessageBox.Show("Unable");
            }
        }
    }
}
