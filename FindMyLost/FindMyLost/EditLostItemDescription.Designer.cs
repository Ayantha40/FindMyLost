namespace FindMyLost
{
    partial class EditLostItemDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLostItemDescription));
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.tlpFirstName = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.radioDocuments = new System.Windows.Forms.RadioButton();
            this.radioClothing = new System.Windows.Forms.RadioButton();
            this.radioBag = new System.Windows.Forms.RadioButton();
            this.radioAccessories = new System.Windows.Forms.RadioButton();
            this.radioAnimal = new System.Windows.Forms.RadioButton();
            this.radioElec = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picPick = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.imgItem = new System.Windows.Forms.PictureBox();
            this.txtAdditional = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tlpFirstName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPick)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.ForeColor = System.Drawing.Color.White;
            this.txtCategory.Location = new System.Drawing.Point(3, 11);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(180, 15);
            this.txtCategory.TabIndex = 167;
            // 
            // tlpFirstName
            // 
            this.tlpFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tlpFirstName.ColumnCount = 1;
            this.tlpFirstName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFirstName.Controls.Add(this.txtCategory, 0, 1);
            this.tlpFirstName.ForeColor = System.Drawing.Color.White;
            this.tlpFirstName.Location = new System.Drawing.Point(306, 133);
            this.tlpFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpFirstName.Name = "tlpFirstName";
            this.tlpFirstName.RowCount = 3;
            this.tlpFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFirstName.Size = new System.Drawing.Size(186, 39);
            this.tlpFirstName.TabIndex = 166;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlpFirstName);
            this.groupBox1.Controls.Add(this.radioOther);
            this.groupBox1.Controls.Add(this.radioDocuments);
            this.groupBox1.Controls.Add(this.radioClothing);
            this.groupBox1.Controls.Add(this.radioBag);
            this.groupBox1.Controls.Add(this.radioAccessories);
            this.groupBox1.Controls.Add(this.radioAnimal);
            this.groupBox1.Controls.Add(this.radioElec);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(33, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 197);
            this.groupBox1.TabIndex = 170;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category *";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioOther
            // 
            this.radioOther.AutoSize = true;
            this.radioOther.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioOther.Location = new System.Drawing.Point(201, 122);
            this.radioOther.Name = "radioOther";
            this.radioOther.Size = new System.Drawing.Size(60, 20);
            this.radioOther.TabIndex = 13;
            this.radioOther.Text = "Other";
            this.radioOther.UseVisualStyleBackColor = true;
            // 
            // radioDocuments
            // 
            this.radioDocuments.AutoSize = true;
            this.radioDocuments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioDocuments.Location = new System.Drawing.Point(367, 77);
            this.radioDocuments.Name = "radioDocuments";
            this.radioDocuments.Size = new System.Drawing.Size(96, 20);
            this.radioDocuments.TabIndex = 12;
            this.radioDocuments.Text = "Documents";
            this.radioDocuments.UseVisualStyleBackColor = true;
            // 
            // radioClothing
            // 
            this.radioClothing.ForeColor = System.Drawing.Color.Black;
            this.radioClothing.Location = new System.Drawing.Point(19, 27);
            this.radioClothing.Name = "radioClothing";
            this.radioClothing.Size = new System.Drawing.Size(110, 36);
            this.radioClothing.TabIndex = 7;
            this.radioClothing.Text = "Clothing";
            this.radioClothing.UseVisualStyleBackColor = true;
            // 
            // radioBag
            // 
            this.radioBag.AutoSize = true;
            this.radioBag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioBag.Location = new System.Drawing.Point(367, 34);
            this.radioBag.Name = "radioBag";
            this.radioBag.Size = new System.Drawing.Size(115, 20);
            this.radioBag.TabIndex = 11;
            this.radioBag.Text = "Bags/ Luggage";
            this.radioBag.UseVisualStyleBackColor = true;
            // 
            // radioAccessories
            // 
            this.radioAccessories.AutoSize = true;
            this.radioAccessories.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioAccessories.Location = new System.Drawing.Point(19, 77);
            this.radioAccessories.Name = "radioAccessories";
            this.radioAccessories.Size = new System.Drawing.Size(94, 20);
            this.radioAccessories.TabIndex = 8;
            this.radioAccessories.Text = "Accessories";
            this.radioAccessories.UseVisualStyleBackColor = true;
            // 
            // radioAnimal
            // 
            this.radioAnimal.AutoSize = true;
            this.radioAnimal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioAnimal.Location = new System.Drawing.Point(201, 77);
            this.radioAnimal.Name = "radioAnimal";
            this.radioAnimal.Size = new System.Drawing.Size(107, 20);
            this.radioAnimal.TabIndex = 10;
            this.radioAnimal.Text = "Animals/ Pets";
            this.radioAnimal.UseVisualStyleBackColor = true;
            // 
            // radioElec
            // 
            this.radioElec.AutoSize = true;
            this.radioElec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioElec.Location = new System.Drawing.Point(201, 34);
            this.radioElec.Name = "radioElec";
            this.radioElec.Size = new System.Drawing.Size(91, 20);
            this.radioElec.TabIndex = 9;
            this.radioElec.Text = "Electronics";
            this.radioElec.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.picPick);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(33, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 87);
            this.groupBox2.TabIndex = 171;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color *";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(306, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 30);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // picPick
            // 
            this.picPick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.picPick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPick.Image = ((System.Drawing.Image)(resources.GetObject("picPick.Image")));
            this.picPick.Location = new System.Drawing.Point(464, 39);
            this.picPick.Name = "picPick";
            this.picPick.Size = new System.Drawing.Size(27, 25);
            this.picPick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPick.TabIndex = 17;
            this.picPick.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Exo 2 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 23);
            this.label1.TabIndex = 169;
            this.label1.Text = " EDIT LOST ITEM INFORMATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrand.ForeColor = System.Drawing.Color.White;
            this.txtBrand.Location = new System.Drawing.Point(3, 11);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(180, 15);
            this.txtBrand.TabIndex = 167;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtBrand, 0, 1);
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(306, 20);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(186, 39);
            this.tableLayoutPanel3.TabIndex = 167;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(33, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 81);
            this.groupBox3.TabIndex = 173;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brand *";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBrowse);
            this.groupBox4.Controls.Add(this.imgItem);
            this.groupBox4.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(33, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(509, 196);
            this.groupBox4.TabIndex = 175;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Upload Image";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(45)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Exo 2 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(97, 74);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(133, 46);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "BROWSE ";
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // imgItem
            // 
            this.imgItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgItem.Location = new System.Drawing.Point(312, 21);
            this.imgItem.Name = "imgItem";
            this.imgItem.Size = new System.Drawing.Size(180, 158);
            this.imgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgItem.TabIndex = 3;
            this.imgItem.TabStop = false;
            // 
            // txtAdditional
            // 
            this.txtAdditional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtAdditional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdditional.ForeColor = System.Drawing.Color.White;
            this.txtAdditional.Location = new System.Drawing.Point(3, 33);
            this.txtAdditional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdditional.Multiline = true;
            this.txtAdditional.Name = "txtAdditional";
            this.txtAdditional.Size = new System.Drawing.Size(252, 59);
            this.txtAdditional.TabIndex = 167;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txtAdditional, 0, 1);
            this.tableLayoutPanel5.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(73, 42);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(258, 127);
            this.tableLayoutPanel5.TabIndex = 167;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(45)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Exo 2 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(624, 629);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 43);
            this.btnCancel.TabIndex = 176;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(45)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Exo 2 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(765, 629);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 43);
            this.btnUpdate.TabIndex = 172;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel5);
            this.groupBox5.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(548, 427);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(337, 196);
            this.groupBox5.TabIndex = 174;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Additional Information";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.ForeColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(3, 11);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(238, 15);
            this.txtLocation.TabIndex = 167;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtLocation, 0, 1);
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(73, 20);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(258, 39);
            this.tableLayoutPanel4.TabIndex = 167;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel4);
            this.groupBox6.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox6.Location = new System.Drawing.Point(548, 340);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(337, 81);
            this.groupBox6.TabIndex = 177;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Last seen location";
            // 
            // EditLostItemDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(896, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditLostItemDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditLostItemDescription";
            this.Load += new System.EventHandler(this.EditLostItemDescription_Load);
            this.tlpFirstName.ResumeLayout(false);
            this.tlpFirstName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPick)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TableLayoutPanel tlpFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOther;
        private System.Windows.Forms.RadioButton radioDocuments;
        private System.Windows.Forms.RadioButton radioClothing;
        private System.Windows.Forms.RadioButton radioBag;
        private System.Windows.Forms.RadioButton radioAccessories;
        private System.Windows.Forms.RadioButton radioAnimal;
        private System.Windows.Forms.RadioButton radioElec;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picPick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox imgItem;
        private System.Windows.Forms.TextBox txtAdditional;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}