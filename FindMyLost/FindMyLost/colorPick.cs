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
    public partial class colorPick : Form
    {
        public static colorPick instance;

        public colorPick()
        {
            InitializeComponent();
            instance = this;
        }

        public Color clr;

        private void picColors_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)picColors.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            lblSmallScreen.BackColor = clr;
        }

        private void picColors_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)picColors.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            pnlSelected.BackColor = clr;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Color Selected");
            this.Close();
            ListItem.instance.pb1.BackColor = pnlSelected.BackColor;
            //ListItem.instance.tb1.Text = "selected";
        }
    }
}
