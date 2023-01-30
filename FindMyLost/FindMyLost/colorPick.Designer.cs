namespace FindMyLost
{
    partial class colorPick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(colorPick));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlSelected = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSmallScreen = new System.Windows.Forms.Label();
            this.picColors = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColors)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlSelected);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(378, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(217, 222);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Color";
            // 
            // pnlSelected
            // 
            this.pnlSelected.Location = new System.Drawing.Point(23, 49);
            this.pnlSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Size = new System.Drawing.Size(174, 143);
            this.pnlSelected.TabIndex = 6;
            // 
            // lblSmallScreen
            // 
            this.lblSmallScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallScreen.Location = new System.Drawing.Point(499, 65);
            this.lblSmallScreen.Name = "lblSmallScreen";
            this.lblSmallScreen.Size = new System.Drawing.Size(96, 73);
            this.lblSmallScreen.TabIndex = 7;
            // 
            // picColors
            // 
            this.picColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picColors.Image = ((System.Drawing.Image)(resources.GetObject("picColors.Image")));
            this.picColors.Location = new System.Drawing.Point(22, 65);
            this.picColors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picColors.Name = "picColors";
            this.picColors.Size = new System.Drawing.Size(300, 300);
            this.picColors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picColors.TabIndex = 6;
            this.picColors.TabStop = false;
            this.picColors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picColors_MouseDown);
            this.picColors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picColors_MouseMove);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(45)))));
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Exo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(468, 398);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(127, 57);
            this.btnSelect.TabIndex = 30;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // colorPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(617, 490);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSmallScreen);
            this.Controls.Add(this.picColors);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "colorPick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "colorPick";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel pnlSelected;
        private System.Windows.Forms.Label lblSmallScreen;
        private System.Windows.Forms.PictureBox picColors;
        private System.Windows.Forms.Button btnSelect;
    }
}