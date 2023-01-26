namespace FindMyLost
{
    partial class ColorPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPicker));
            this.SeletedColor = new System.Windows.Forms.GroupBox();
            this.panelSelectedColor = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSmallScreen = new System.Windows.Forms.Label();
            this.pbColors = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SeletedColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColors)).BeginInit();
            this.SuspendLayout();
            // 
            // SeletedColor
            // 
            this.SeletedColor.Controls.Add(this.panelSelectedColor);
            this.SeletedColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SeletedColor.Location = new System.Drawing.Point(392, 131);
            this.SeletedColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SeletedColor.Name = "SeletedColor";
            this.SeletedColor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SeletedColor.Size = new System.Drawing.Size(217, 210);
            this.SeletedColor.TabIndex = 127;
            this.SeletedColor.TabStop = false;
            this.SeletedColor.Text = "Selected Color";
            // 
            // panelSelectedColor
            // 
            this.panelSelectedColor.Location = new System.Drawing.Point(22, 48);
            this.panelSelectedColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSelectedColor.Name = "panelSelectedColor";
            this.panelSelectedColor.Size = new System.Drawing.Size(174, 128);
            this.panelSelectedColor.TabIndex = 6;
            // 
            // lblSmallScreen
            // 
            this.lblSmallScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallScreen.Location = new System.Drawing.Point(513, 41);
            this.lblSmallScreen.Name = "lblSmallScreen";
            this.lblSmallScreen.Size = new System.Drawing.Size(96, 73);
            this.lblSmallScreen.TabIndex = 126;
            // 
            // pbColors
            // 
            this.pbColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbColors.Image = ((System.Drawing.Image)(resources.GetObject("pbColors.Image")));
            this.pbColors.Location = new System.Drawing.Point(41, 41);
            this.pbColors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbColors.Name = "pbColors";
            this.pbColors.Size = new System.Drawing.Size(300, 300);
            this.pbColors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbColors.TabIndex = 125;
            this.pbColors.TabStop = false;
            this.pbColors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbColors_MouseDown);
            this.pbColors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbColors_MouseMove);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(45)))));
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Exo 2", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(41, 390);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(568, 52);
            this.btnSelect.TabIndex = 128;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(650, 482);
            this.Controls.Add(this.SeletedColor);
            this.Controls.Add(this.lblSmallScreen);
            this.Controls.Add(this.pbColors);
            this.Controls.Add(this.btnSelect);
            this.Name = "ColorPicker";
            this.Text = "ColorPicker";
            this.SeletedColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SeletedColor;
        private System.Windows.Forms.FlowLayoutPanel panelSelectedColor;
        private System.Windows.Forms.Label lblSmallScreen;
        private System.Windows.Forms.PictureBox pbColors;
        private System.Windows.Forms.Button btnSelect;
    }
}