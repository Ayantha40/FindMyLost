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
    public partial class ColorPicker : Form
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

        public Color clr;
        string form;
        string form2;
        string form3;

        private void pbColors_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pbColors.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            lblSmallScreen.BackColor = clr;
        }

        private void pbColors_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pbColors.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            panelSelectedColor.BackColor = clr;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Color Selected");
            this.Close();
            if (form == "ClaimItem")
            {
                //ClaimItem.Colour.BackColor = panelSelectedColor.BackColor;
            }
            else if (form2 == "ListItem")
            {
                ListItem.pb1.BackColor = panelSelectedColor.BackColor;
            }
            else if (form3 == "EditLostItem")
            {
                //EditLostItemDescription.pb1.BackColor = panelSelectedColor.BackColor;
            }
        }
    }
}
