namespace ManagerCafe
{
	partial class fTableManager
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
			if(disposing && (components != null))
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thoonhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtLogOut = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.livBill = new System.Windows.Forms.ListView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cbSwithtable = new System.Windows.Forms.ComboBox();
			this.btnSWithTable = new System.Windows.Forms.Button();
			this.nmDiscount = new System.Windows.Forms.NumericUpDown();
			this.btnDiscount = new System.Windows.Forms.Button();
			this.btnCheckOut = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
			this.btnAdd = new System.Windows.Forms.Button();
			this.cbFood = new System.Windows.Forms.ComboBox();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
			this.menuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thoonhToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(968, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
			this.adminToolStripMenuItem.Text = "Admin";
			this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
			// 
			// thoonhToolStripMenuItem
			// 
			this.thoonhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.txtLogOut});
			this.thoonhToolStripMenuItem.Name = "thoonhToolStripMenuItem";
			this.thoonhToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
			this.thoonhToolStripMenuItem.Text = "Thông tin tài khoản";
			// 
			// thôngTinCáNhânToolStripMenuItem
			// 
			this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
			this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
			this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
			// 
			// txtLogOut
			// 
			this.txtLogOut.Name = "txtLogOut";
			this.txtLogOut.Size = new System.Drawing.Size(216, 26);
			this.txtLogOut.Text = "Đăng xuất";
			this.txtLogOut.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.livBill);
			this.panel2.Location = new System.Drawing.Point(512, 97);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(446, 489);
			this.panel2.TabIndex = 2;
			// 
			// livBill
			// 
			this.livBill.HideSelection = false;
			this.livBill.Location = new System.Drawing.Point(0, 0);
			this.livBill.Name = "livBill";
			this.livBill.Size = new System.Drawing.Size(446, 486);
			this.livBill.TabIndex = 0;
			this.livBill.UseCompatibleStateImageBehavior = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.cbSwithtable);
			this.panel3.Controls.Add(this.btnSWithTable);
			this.panel3.Controls.Add(this.nmDiscount);
			this.panel3.Controls.Add(this.btnDiscount);
			this.panel3.Controls.Add(this.btnCheckOut);
			this.panel3.Location = new System.Drawing.Point(512, 589);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(445, 58);
			this.panel3.TabIndex = 3;
			// 
			// cbSwithtable
			// 
			this.cbSwithtable.FormattingEnabled = true;
			this.cbSwithtable.Location = new System.Drawing.Point(6, 31);
			this.cbSwithtable.Name = "cbSwithtable";
			this.cbSwithtable.Size = new System.Drawing.Size(116, 24);
			this.cbSwithtable.TabIndex = 6;
			// 
			// btnSWithTable
			// 
			this.btnSWithTable.Location = new System.Drawing.Point(6, 3);
			this.btnSWithTable.Name = "btnSWithTable";
			this.btnSWithTable.Size = new System.Drawing.Size(116, 26);
			this.btnSWithTable.TabIndex = 5;
			this.btnSWithTable.Text = "Chuyển bàn";
			this.btnSWithTable.UseVisualStyleBackColor = true;
			// 
			// nmDiscount
			// 
			this.nmDiscount.Location = new System.Drawing.Point(166, 32);
			this.nmDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nmDiscount.Name = "nmDiscount";
			this.nmDiscount.Size = new System.Drawing.Size(116, 22);
			this.nmDiscount.TabIndex = 4;
			this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nmDiscount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnDiscount
			// 
			this.btnDiscount.Location = new System.Drawing.Point(166, 3);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(116, 26);
			this.btnDiscount.TabIndex = 4;
			this.btnDiscount.Text = "Giãm giá";
			this.btnDiscount.UseVisualStyleBackColor = true;
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.Location = new System.Drawing.Point(326, 3);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(116, 51);
			this.btnCheckOut.TabIndex = 3;
			this.btnCheckOut.Text = "Thanh toán";
			this.btnCheckOut.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.nmFoodCount);
			this.panel4.Controls.Add(this.btnAdd);
			this.panel4.Controls.Add(this.cbFood);
			this.panel4.Controls.Add(this.cbCategory);
			this.panel4.Location = new System.Drawing.Point(512, 31);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(446, 60);
			this.panel4.TabIndex = 4;
			// 
			// nmFoodCount
			// 
			this.nmFoodCount.Location = new System.Drawing.Point(309, 18);
			this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nmFoodCount.Name = "nmFoodCount";
			this.nmFoodCount.Size = new System.Drawing.Size(79, 22);
			this.nmFoodCount.TabIndex = 3;
			this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(187, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(116, 51);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Thêm món";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// cbFood
			// 
			this.cbFood.FormattingEnabled = true;
			this.cbFood.Location = new System.Drawing.Point(3, 30);
			this.cbFood.Name = "cbFood";
			this.cbFood.Size = new System.Drawing.Size(178, 24);
			this.cbFood.TabIndex = 1;
			// 
			// cbCategory
			// 
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(3, 3);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(178, 24);
			this.cbCategory.TabIndex = 0;
			// 
			// flpTable
			// 
			this.flpTable.Location = new System.Drawing.Point(12, 31);
			this.flpTable.Name = "flpTable";
			this.flpTable.Size = new System.Drawing.Size(500, 615);
			this.flpTable.TabIndex = 5;
			// 
			// fTableManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 659);
			this.Controls.Add(this.flpTable);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "fTableManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm quản lý cafe";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thoonhToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem txtLogOut;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView livBill;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox cbSwithtable;
		private System.Windows.Forms.Button btnSWithTable;
		private System.Windows.Forms.NumericUpDown nmDiscount;
		private System.Windows.Forms.Button btnDiscount;
		private System.Windows.Forms.Button btnCheckOut;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.NumericUpDown nmFoodCount;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbFood;
		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.FlowLayoutPanel flpTable;
	}
}