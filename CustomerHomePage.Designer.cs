namespace Restaurant
{
    partial class CustomerHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHomePage));
            panel2 = new Panel();
            TackOutRadio = new RadioButton();
            DineInOrder = new RadioButton();
            logoutbtn = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            DishImageBox = new PictureBox();
            groupBox2 = new GroupBox();
            confirmOrderBtn = new Button();
            label9 = new Label();
            TlALbl = new Label();
            QunTxt = new TextBox();
            label7 = new Label();
            SearchCat = new ComboBox();
            SearchType = new ComboBox();
            PriceTxt = new TextBox();
            TypeCMB = new ComboBox();
            addbtn = new Button();
            label5 = new Label();
            Dnametxt = new TextBox();
            CatCMB = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DesTxt = new TextBox();
            label6 = new Label();
            MenuItemLst = new DataGridView();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DishImageBox).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuItemLst).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(TackOutRadio);
            panel2.Controls.Add(DineInOrder);
            panel2.Controls.Add(logoutbtn);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1083, 119);
            panel2.TabIndex = 1;
            // 
            // TackOutRadio
            // 
            TackOutRadio.AutoSize = true;
            TackOutRadio.Location = new Point(981, 60);
            TackOutRadio.Name = "TackOutRadio";
            TackOutRadio.Size = new Size(87, 24);
            TackOutRadio.TabIndex = 6;
            TackOutRadio.Text = "Take Out";
            TackOutRadio.UseVisualStyleBackColor = true;
            TackOutRadio.CheckedChanged += TackOutRadio_CheckedChanged;
            // 
            // DineInOrder
            // 
            DineInOrder.AutoSize = true;
            DineInOrder.Checked = true;
            DineInOrder.Location = new Point(889, 60);
            DineInOrder.Name = "DineInOrder";
            DineInOrder.Size = new Size(77, 24);
            DineInOrder.TabIndex = 5;
            DineInOrder.TabStop = true;
            DineInOrder.Text = "Dine In";
            DineInOrder.UseVisualStyleBackColor = true;
            DineInOrder.CheckedChanged += DineInOrder_CheckedChanged;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.LightCoral;
            logoutbtn.Location = new Point(960, 8);
            logoutbtn.Margin = new Padding(3, 4, 3, 4);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(107, 39);
            logoutbtn.TabIndex = 4;
            logoutbtn.Text = "Log Out";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee List";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DishImageBox);
            groupBox1.Location = new Point(14, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(605, 399);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // DishImageBox
            // 
            DishImageBox.Image = (Image)resources.GetObject("DishImageBox.Image");
            DishImageBox.Location = new Point(23, 23);
            DishImageBox.Name = "DishImageBox";
            DishImageBox.Size = new Size(576, 366);
            DishImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DishImageBox.TabIndex = 0;
            DishImageBox.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(confirmOrderBtn);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(TlALbl);
            groupBox2.Controls.Add(QunTxt);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(SearchCat);
            groupBox2.Controls.Add(SearchType);
            groupBox2.Controls.Add(PriceTxt);
            groupBox2.Controls.Add(TypeCMB);
            groupBox2.Controls.Add(addbtn);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(Dnametxt);
            groupBox2.Controls.Add(CatCMB);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(DesTxt);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(625, 139);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(470, 399);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = " ";
            // 
            // confirmOrderBtn
            // 
            confirmOrderBtn.BackColor = Color.LightCoral;
            confirmOrderBtn.BackgroundImage = (Image)resources.GetObject("confirmOrderBtn.BackgroundImage");
            confirmOrderBtn.BackgroundImageLayout = ImageLayout.Stretch;
            confirmOrderBtn.Location = new Point(389, 354);
            confirmOrderBtn.Margin = new Padding(3, 4, 3, 4);
            confirmOrderBtn.Name = "confirmOrderBtn";
            confirmOrderBtn.Size = new Size(65, 37);
            confirmOrderBtn.TabIndex = 28;
            confirmOrderBtn.UseVisualStyleBackColor = false;
            confirmOrderBtn.Click += confirmOrderBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(305, 319);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 27;
            label9.Text = "Quantity";
            // 
            // TlALbl
            // 
            TlALbl.AutoSize = true;
            TlALbl.Location = new Point(389, 319);
            TlALbl.Name = "TlALbl";
            TlALbl.Size = new Size(17, 20);
            TlALbl.TabIndex = 26;
            TlALbl.Text = "0";
            // 
            // QunTxt
            // 
            QunTxt.BackColor = SystemColors.AppWorkspace;
            QunTxt.Location = new Point(248, 257);
            QunTxt.Margin = new Padding(3, 4, 3, 4);
            QunTxt.Name = "QunTxt";
            QunTxt.Size = new Size(206, 27);
            QunTxt.TabIndex = 25;
            QunTxt.Text = "1";
            QunTxt.TextChanged += QunTxt_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 234);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 24;
            label7.Text = "Quantity";
            // 
            // SearchCat
            // 
            SearchCat.BackColor = Color.DarkGray;
            SearchCat.FormattingEnabled = true;
            SearchCat.Items.AddRange(new object[] { "Soup", "Appitaizier", "Main Course", "Dessert" });
            SearchCat.Location = new Point(248, 28);
            SearchCat.Margin = new Padding(3, 4, 3, 4);
            SearchCat.Name = "SearchCat";
            SearchCat.Size = new Size(206, 28);
            SearchCat.TabIndex = 23;
            SearchCat.Text = "Search By Category";
            SearchCat.SelectedIndexChanged += SearchCat_SelectedIndexChanged;
            // 
            // SearchType
            // 
            SearchType.BackColor = Color.DarkGray;
            SearchType.FormattingEnabled = true;
            SearchType.Items.AddRange(new object[] { "Vegetarian", "NonVegetarian" });
            SearchType.Location = new Point(6, 28);
            SearchType.Margin = new Padding(3, 4, 3, 4);
            SearchType.Name = "SearchType";
            SearchType.Size = new Size(202, 28);
            SearchType.TabIndex = 22;
            SearchType.Text = "Search By Type";
            SearchType.SelectedIndexChanged += SearchType_SelectedIndexChanged;
            // 
            // PriceTxt
            // 
            PriceTxt.BackColor = SystemColors.AppWorkspace;
            PriceTxt.Enabled = false;
            PriceTxt.Location = new Point(248, 104);
            PriceTxt.Margin = new Padding(3, 4, 3, 4);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(206, 27);
            PriceTxt.TabIndex = 19;
            // 
            // TypeCMB
            // 
            TypeCMB.BackColor = Color.DarkGray;
            TypeCMB.FormattingEnabled = true;
            TypeCMB.Items.AddRange(new object[] { "Vegetarian", "NonVegetarian" });
            TypeCMB.Location = new Point(11, 176);
            TypeCMB.Margin = new Padding(3, 4, 3, 4);
            TypeCMB.Name = "TypeCMB";
            TypeCMB.Size = new Size(202, 28);
            TypeCMB.TabIndex = 18;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.LightCoral;
            addbtn.Location = new Point(238, 354);
            addbtn.Margin = new Padding(3, 4, 3, 4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(132, 35);
            addbtn.TabIndex = 4;
            addbtn.Text = "Add to Cart";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 234);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 8;
            label5.Text = "Ingridiants";
            // 
            // Dnametxt
            // 
            Dnametxt.BackColor = SystemColors.AppWorkspace;
            Dnametxt.Location = new Point(7, 104);
            Dnametxt.Margin = new Padding(3, 4, 3, 4);
            Dnametxt.Name = "Dnametxt";
            Dnametxt.Size = new Size(206, 27);
            Dnametxt.TabIndex = 4;
            // 
            // CatCMB
            // 
            CatCMB.BackColor = Color.DarkGray;
            CatCMB.Enabled = false;
            CatCMB.FormattingEnabled = true;
            CatCMB.Items.AddRange(new object[] { "Soup", "Appitaizier", "Main Course", "Dessert" });
            CatCMB.Location = new Point(248, 176);
            CatCMB.Margin = new Padding(3, 4, 3, 4);
            CatCMB.Name = "CatCMB";
            CatCMB.Size = new Size(206, 28);
            CatCMB.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 81);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Dish Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 153);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Dish Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 81);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Price ";
            // 
            // DesTxt
            // 
            DesTxt.BackColor = SystemColors.AppWorkspace;
            DesTxt.Location = new Point(11, 257);
            DesTxt.Margin = new Padding(3, 4, 3, 4);
            DesTxt.Multiline = true;
            DesTxt.Name = "DesTxt";
            DesTxt.Size = new Size(202, 132);
            DesTxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 153);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 7;
            label6.Text = "Category";
            // 
            // MenuItemLst
            // 
            MenuItemLst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MenuItemLst.Location = new Point(13, 552);
            MenuItemLst.Name = "MenuItemLst";
            MenuItemLst.RowHeadersWidth = 51;
            MenuItemLst.RowTemplate.Height = 29;
            MenuItemLst.Size = new Size(1082, 155);
            MenuItemLst.TabIndex = 5;
            MenuItemLst.CellContentClick += MenuItemLst_CellContentClick;
            // 
            // CustomerHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1106, 714);
            Controls.Add(MenuItemLst);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerHomePage";
            Text = "CustomerHomePage";
            Load += CustomerHomePage_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DishImageBox).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuItemLst).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private RadioButton TackOutRadio;
        private RadioButton DineInOrder;
        private Button logoutbtn;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox SearchCat;
        private ComboBox SearchType;
        private TextBox PriceTxt;
        private ComboBox TypeCMB;
        private Button addbtn;
        private Label label5;
        private TextBox Dnametxt;
        private ComboBox CatCMB;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox DesTxt;
        private Label label6;
        private PictureBox DishImageBox;
        private DataGridView MenuItemLst;
        private Label label9;
        private Label TlALbl;
        private TextBox QunTxt;
        private Label label7;
        private Button confirmOrderBtn;
    }
}