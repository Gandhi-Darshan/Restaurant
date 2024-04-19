namespace Restaurant
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            ActionsGB = new GroupBox();
            reportbtn = new Button();
            tablebtn = new Button();
            EmpBtn = new Button();
            panel1 = new Panel();
            TakeOutCheck = new CheckBox();
            groupBox1 = new GroupBox();
            SearchCat = new ComboBox();
            SearchType = new ComboBox();
            DelBtn = new Button();
            PriceTxt = new TextBox();
            TypeCMB = new ComboBox();
            updatebtn = new Button();
            addbtn = new Button();
            label5 = new Label();
            Dnametxt = new TextBox();
            CatCMB = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DesTxt = new TextBox();
            label6 = new Label();
            DishImageBox = new PictureBox();
            MenuLst = new DataGridView();
            panel2 = new Panel();
            logoutbtn = new Button();
            label1 = new Label();
            BrowseBtn = new Button();
            ImageFilter = new OpenFileDialog();
            ActionsGB.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DishImageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MenuLst).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ActionsGB
            // 
            ActionsGB.BackColor = SystemColors.ActiveCaption;
            ActionsGB.Controls.Add(reportbtn);
            ActionsGB.Controls.Add(tablebtn);
            ActionsGB.Controls.Add(EmpBtn);
            ActionsGB.Location = new Point(12, 3);
            ActionsGB.Margin = new Padding(3, 4, 3, 4);
            ActionsGB.Name = "ActionsGB";
            ActionsGB.Padding = new Padding(3, 4, 3, 4);
            ActionsGB.Size = new Size(161, 615);
            ActionsGB.TabIndex = 11;
            ActionsGB.TabStop = false;
            ActionsGB.Text = " ";
            // 
            // reportbtn
            // 
            reportbtn.Location = new Point(38, 157);
            reportbtn.Margin = new Padding(3, 4, 3, 4);
            reportbtn.Name = "reportbtn";
            reportbtn.Size = new Size(86, 31);
            reportbtn.TabIndex = 2;
            reportbtn.Text = "Reports";
            reportbtn.UseVisualStyleBackColor = true;
            reportbtn.Click += reportbtn_Click;
            // 
            // tablebtn
            // 
            tablebtn.Location = new Point(38, 91);
            tablebtn.Margin = new Padding(3, 4, 3, 4);
            tablebtn.Name = "tablebtn";
            tablebtn.Size = new Size(86, 31);
            tablebtn.TabIndex = 1;
            tablebtn.Text = "Table";
            tablebtn.UseVisualStyleBackColor = true;
            tablebtn.Click += tablebtn_Click;
            // 
            // EmpBtn
            // 
            EmpBtn.Location = new Point(38, 29);
            EmpBtn.Margin = new Padding(3, 4, 3, 4);
            EmpBtn.Name = "EmpBtn";
            EmpBtn.Size = new Size(86, 31);
            EmpBtn.TabIndex = 0;
            EmpBtn.Text = "Employee";
            EmpBtn.UseVisualStyleBackColor = true;
            EmpBtn.Click += EmpBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TakeOutCheck);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(DishImageBox);
            panel1.Controls.Add(MenuLst);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BrowseBtn);
            panel1.Location = new Point(189, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 759);
            panel1.TabIndex = 10;
            // 
            // TakeOutCheck
            // 
            TakeOutCheck.AutoSize = true;
            TakeOutCheck.Location = new Point(187, 455);
            TakeOutCheck.Name = "TakeOutCheck";
            TakeOutCheck.Size = new Size(207, 24);
            TakeOutCheck.TabIndex = 18;
            TakeOutCheck.Text = "Will Available for Take Out";
            TakeOutCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SearchCat);
            groupBox1.Controls.Add(SearchType);
            groupBox1.Controls.Add(DelBtn);
            groupBox1.Controls.Add(PriceTxt);
            groupBox1.Controls.Add(TypeCMB);
            groupBox1.Controls.Add(updatebtn);
            groupBox1.Controls.Add(addbtn);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Dnametxt);
            groupBox1.Controls.Add(CatCMB);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DesTxt);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(416, 95);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(517, 399);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
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
            SearchCat.SelectedIndexChanged += SearchCat_SelectedIndexChanged_1;
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
            // DelBtn
            // 
            DelBtn.BackColor = Color.LightCoral;
            DelBtn.Location = new Point(296, 352);
            DelBtn.Margin = new Padding(3, 4, 3, 4);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(107, 39);
            DelBtn.TabIndex = 21;
            DelBtn.Text = "Remove";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // PriceTxt
            // 
            PriceTxt.BackColor = SystemColors.AppWorkspace;
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
            // updatebtn
            // 
            updatebtn.BackColor = Color.LightCoral;
            updatebtn.Location = new Point(296, 304);
            updatebtn.Margin = new Padding(3, 4, 3, 4);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(107, 39);
            updatebtn.TabIndex = 12;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.LightCoral;
            addbtn.Location = new Point(296, 257);
            addbtn.Margin = new Padding(3, 4, 3, 4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(107, 39);
            addbtn.TabIndex = 4;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 233);
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
            label2.Location = new Point(7, 80);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Dish Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 152);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Dish Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 80);
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
            DesTxt.Size = new Size(277, 132);
            DesTxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 152);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 7;
            label6.Text = "Category";
            // 
            // DishImageBox
            // 
            DishImageBox.Image = (Image)resources.GetObject("DishImageBox.Image");
            DishImageBox.Location = new Point(17, 95);
            DishImageBox.Margin = new Padding(3, 4, 3, 4);
            DishImageBox.Name = "DishImageBox";
            DishImageBox.Size = new Size(392, 343);
            DishImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DishImageBox.TabIndex = 17;
            DishImageBox.TabStop = false;
            // 
            // MenuLst
            // 
            MenuLst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MenuLst.Location = new Point(17, 515);
            MenuLst.Margin = new Padding(3, 4, 3, 4);
            MenuLst.Name = "MenuLst";
            MenuLst.RowHeadersWidth = 51;
            MenuLst.RowTemplate.Height = 25;
            MenuLst.Size = new Size(915, 215);
            MenuLst.TabIndex = 15;
            MenuLst.CellContentClick += MenuLst_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(logoutbtn);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(929, 79);
            panel2.TabIndex = 0;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.LightCoral;
            logoutbtn.Location = new Point(798, 17);
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
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Menu Items";
            // 
            // BrowseBtn
            // 
            BrowseBtn.BackColor = Color.LightCoral;
            BrowseBtn.Location = new Point(17, 455);
            BrowseBtn.Margin = new Padding(3, 4, 3, 4);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(107, 39);
            BrowseBtn.TabIndex = 13;
            BrowseBtn.Text = "Browse Image";
            BrowseBtn.UseVisualStyleBackColor = false;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // ImageFilter
            // 
            ImageFilter.FileName = "ImageFilter";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1193, 791);
            Controls.Add(ActionsGB);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ActionsGB.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DishImageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MenuLst).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ActionsGB;
        private Button reportbtn;
        private Button tablebtn;
        private Button EmpBtn;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button DelBtn;
        private TextBox PriceTxt;
        private Button BrowseBtn;
        private ComboBox TypeCMB;
        private Button updatebtn;
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
        private DataGridView MenuLst;
        private Panel panel2;
        private Button logoutbtn;
        private Label label1;
        private OpenFileDialog ImageFilter;
        private CheckBox TakeOutCheck;
        private ComboBox SearchCat;
        private ComboBox SearchType;
    }
}