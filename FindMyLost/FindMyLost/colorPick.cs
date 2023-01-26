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

        public colorPick()
        {
            InitializeComponent();
        }

        public Color clr;
        string form = ListItem.form;
        string form2 = EditLostItemDescription.form;
        string form3 = ClaimItem.form;

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
            if (form == "ListItem")
            {
                ListItem.pb1.BackColor = pnlSelected.BackColor;
            }
            else if (form2 == "EditItem")
            {
                EditLostItemDescription.pb1.BackColor = pnlSelected.BackColor;
            }
            else if (form3 == "ClaimItem")
            {
                ClaimItem.Colour.BackColor = pnlSelected.BackColor;
            }
        }
    }
}
