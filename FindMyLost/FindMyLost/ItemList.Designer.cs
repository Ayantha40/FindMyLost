namespace FindMyLost
{
    partial class ItemList
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
            this.lvItemList = new MaterialSkin.Controls.MaterialListView();
            this.ItemID = new System.Windows.Forms.ColumnHeader();
            this.Category = new System.Windows.Forms.ColumnHeader();
            this.Color = new System.Windows.Forms.ColumnHeader();
            this.Brand = new System.Windows.Forms.ColumnHeader();
            this.LastSeen = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvItemList
            // 
            this.lvItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemID,
            this.Category,
            this.Color,
            this.Brand,
            this.LastSeen});
            this.lvItemList.Depth = 0;
            this.lvItemList.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvItemList.FullRowSelect = true;
            this.lvItemList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvItemList.HideSelection = false;
            this.lvItemList.Location = new System.Drawing.Point(16, 70);
            this.lvItemList.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lvItemList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvItemList.MouseState = MaterialSkin.MouseState.OUT;
            this.lvItemList.Name = "lvItemList";
            this.lvItemList.OwnerDraw = true;
            this.lvItemList.Size = new System.Drawing.Size(850, 600);
            this.lvItemList.TabIndex = 1;
            this.lvItemList.UseCompatibleStateImageBehavior = false;
            this.lvItemList.View = System.Windows.Forms.View.Details;
            this.lvItemList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvItemList_MouseClick);
            // 
            // ItemID
            // 
            this.ItemID.Text = "Item ID";
            this.ItemID.Width = 110;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 170;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.Width = 120;
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            this.Brand.Width = 180;
            // 
            // LastSeen
            // 
            this.LastSeen.Text = "Last Seen Location";
            this.LastSeen.Width = 270;
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 688);
            this.Controls.Add(this.lvItemList);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITEM LIST";
            this.Load += new System.EventHandler(this.ItemList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView lvItemList;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader LastSeen;
    }
}