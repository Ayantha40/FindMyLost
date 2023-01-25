namespace FindMyLost
{
    partial class editcolorpick
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editcolorpick));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlSelected = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblSmallScreen = new System.Windows.Forms.Label();
            this.picColors = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColors)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlSelected);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(331, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 217);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Color";
            // 
            // pnlSelected
            // 
            this.pnlSelected.Location = new System.Drawing.Point(23, 39);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Size = new System.Drawing.Size(152, 147);
            this.pnlSelected.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(45)))));
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Exo 2 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(410, 326);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(111, 43);
            this.btnSelect.TabIndex = 34;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // lblSmallScreen
            // 
            this.lblSmallScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallScreen.Location = new System.Drawing.Point(437, 45);
            this.lblSmallScreen.Name = "lblSmallScreen";
            this.lblSmallScreen.Size = new System.Drawing.Size(84, 55);
            this.lblSmallScreen.TabIndex = 32;
            // 
            // picColors
            // 
            this.picColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picColors.Image = ((System.Drawing.Image)(resources.GetObject("picColors.Image")));
            this.picColors.Location = new System.Drawing.Point(19, 45);
            this.picColors.Name = "picColors";
            this.picColors.Size = new System.Drawing.Size(300, 300);
            this.picColors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picColors.TabIndex = 31;
            this.picColors.TabStop = false;
            // 
            // editcolorpick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(540, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblSmallScreen);
            this.Controls.Add(this.picColors);
            this.Name = "editcolorpick";
            this.Text = "editcolorpick";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel pnlSelected;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblSmallScreen;
        private System.Windows.Forms.PictureBox picColors;
    }
}