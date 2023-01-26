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
    public partial class EditLostItemDescription : Form
    {
        public static PictureBox pb1;
        public static string form;
        
        public EditLostItemDescription()
        {
            InitializeComponent();
            pb1 = pictureBox3;
         
        }

        private void EditLostItemDescription_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string ImageLocation = "";

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageLocation = ofd.FileName;
                imgItem.ImageLocation = ImageLocation;
            }
        }

        private void radioClothing_CheckedChanged(object sender, EventArgs e)
        {
            txtCategory.Text = radioClothing.Text;
        }

        private void radioElec_CheckedChanged(object sender, EventArgs e)
        {
            txtCategory.Text = radioElec.Text;
        }

        private void radioBag_CheckedChanged(object sender, EventArgs e)
        {
            txtCategory.Text = radioBag.Text;
        }

        private void radioAccessories_CheckedChanged(object sender, EventArgs e)
        {
            txtCategory.Text = radioAccessories.Text;
        }

        private void radioAnimal_CheckedChanged(object sender, EventArgs e)
        {
            txtCategory.Text = radioAnimal.Text;
        }

        private void radioDocuments_CheckedChanged(object sender, EventArgs e)
        {
            txtCategory.Text = radioDocuments.Text;
        }

        private void radioOther_CheckedChanged(object sender, EventArgs e)
        {
            txtCategory.Text = radioOther.Text;
        }

        private void picPick_Click(object sender, EventArgs e)
        {
            form = "EditItem";
            colorPick cp = new colorPick();
            cp.Show();
        }
        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            // pictureBox3.BackColor = Color.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtCategory.Text != "") && (txtBrand.Text != "") /*&& (txtColor.Text != "")*/)
            {
                MessageBox.Show("Confirm Updation?", "FindMyLost", MessageBoxButtons.YesNo);
            }
            else
            {
                MessageBox.Show("Please fill all in fields marked with a * ", "FindMyLost");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
            //txtColor.Clear();
            txtBrand.Clear();
            txtItemID.Clear();
            txtAdditional.Clear();
            txtLocation.Clear();
            imgItem.ImageLocation = "";
            pictureBox3.BackColor = Color.Empty;
        }
    }
}

