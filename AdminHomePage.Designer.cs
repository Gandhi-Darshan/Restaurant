namespace Restaurant
{
    partial class AdminHomePage
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            SearchBtn = new Button();
            EmpListView = new DataGridView();
            rolecmboc = new ComboBox();
            delbtn = new Button();
            updatebtn = new Button();
            salarytxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            addbtn = new Button();
            phonetxt = new TextBox();
            emailtxt = new TextBox();
            Enametxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            logoutbtn = new Button();
            label1 = new Label();
            ActionsGB = new GroupBox();
            reportbtn = new Button();
            tablebtn = new Button();
            menubtn = new Button();
            EnameError = new ErrorProvider(components);
            EmailError = new ErrorProvider(components);
            NumError = new ErrorProvider(components);
            SalaryError = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpListView).BeginInit();
            panel2.SuspendLayout();
            ActionsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EnameError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryError).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(SearchBtn);
            panel1.Controls.Add(EmpListView);
            panel1.Controls.Add(rolecmboc);
            panel1.Controls.Add(delbtn);
            panel1.Controls.Add(updatebtn);
            panel1.Controls.Add(salarytxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(addbtn);
            panel1.Controls.Add(phonetxt);
            panel1.Controls.Add(emailtxt);
            panel1.Controls.Add(Enametxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(173, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 627);
            panel1.TabIndex = 8;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.LightCoral;
            SearchBtn.Location = new Point(517, 539);
            SearchBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(107, 39);
            SearchBtn.TabIndex = 16;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // EmpListView
            // 
            EmpListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpListView.Location = new Point(15, 99);
            EmpListView.Margin = new Padding(3, 4, 3, 4);
            EmpListView.Name = "EmpListView";
            EmpListView.RowHeadersWidth = 51;
            EmpListView.RowTemplate.Height = 25;
            EmpListView.Size = new Size(453, 400);
            EmpListView.TabIndex = 15;
            EmpListView.CellContentClick += EmpListView_CellContentClick;
            // 
            // rolecmboc
            // 
            rolecmboc.BackColor = Color.DarkGray;
            rolecmboc.FormattingEnabled = true;
            rolecmboc.Items.AddRange(new object[] { "Head Chef", "Sous Chef", "Kitchen Helper", "Waiter", "Manager" });
            rolecmboc.Location = new Point(474, 349);
            rolecmboc.Margin = new Padding(3, 4, 3, 4);
            rolecmboc.Name = "rolecmboc";
            rolecmboc.Size = new Size(235, 28);
            rolecmboc.TabIndex = 14;
            // 
            // delbtn
            // 
            delbtn.BackColor = Color.LightCoral;
            delbtn.Location = new Point(360, 539);
            delbtn.Margin = new Padding(3, 4, 3, 4);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(107, 39);
            delbtn.TabIndex = 13;
            delbtn.Text = "Remove";
            delbtn.UseVisualStyleBackColor = false;
            delbtn.Click += delbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.LightCoral;
            updatebtn.Location = new Point(192, 539);
            updatebtn.Margin = new Padding(3, 4, 3, 4);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(107, 39);
            updatebtn.TabIndex = 12;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // salarytxt
            // 
            salarytxt.BackColor = SystemColors.AppWorkspace;
            salarytxt.Location = new Point(474, 419);
            salarytxt.Margin = new Padding(3, 4, 3, 4);
            salarytxt.Name = "salarytxt";
            salarytxt.Size = new Size(239, 27);
            salarytxt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(474, 395);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 8;
            label5.Text = "Salary ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(474, 325);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 7;
            label6.Text = "Employee Role ";
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.LightCoral;
            addbtn.Location = new Point(27, 539);
            addbtn.Margin = new Padding(3, 4, 3, 4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(107, 39);
            addbtn.TabIndex = 4;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // phonetxt
            // 
            phonetxt.BackColor = SystemColors.AppWorkspace;
            phonetxt.Location = new Point(474, 272);
            phonetxt.Margin = new Padding(3, 4, 3, 4);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(239, 27);
            phonetxt.TabIndex = 6;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = SystemColors.AppWorkspace;
            emailtxt.Location = new Point(474, 199);
            emailtxt.Margin = new Padding(3, 4, 3, 4);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(239, 27);
            emailtxt.TabIndex = 5;
            // 
            // Enametxt
            // 
            Enametxt.BackColor = SystemColors.AppWorkspace;
            Enametxt.Location = new Point(474, 127);
            Enametxt.Margin = new Padding(3, 4, 3, 4);
            Enametxt.Name = "Enametxt";
            Enametxt.Size = new Size(239, 27);
            Enametxt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(474, 248);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 175);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Email ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 103);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Employee Name";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(logoutbtn);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(862, 79);
            panel2.TabIndex = 0;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.LightCoral;
            logoutbtn.Location = new Point(599, 17);
            logoutbtn.Margin = new Padding(3, 4, 3, 4);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(107, 39);
            logoutbtn.TabIndex = 4;
            logoutbtn.Text = "Back";
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
            // ActionsGB
            // 
            ActionsGB.Controls.Add(reportbtn);
            ActionsGB.Controls.Add(tablebtn);
            ActionsGB.Controls.Add(menubtn);
            ActionsGB.Location = new Point(5, 11);
            ActionsGB.Margin = new Padding(3, 4, 3, 4);
            ActionsGB.Name = "ActionsGB";
            ActionsGB.Padding = new Padding(3, 4, 3, 4);
            ActionsGB.Size = new Size(161, 615);
            ActionsGB.TabIndex = 9;
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
            // menubtn
            // 
            menubtn.Location = new Point(38, 29);
            menubtn.Margin = new Padding(3, 4, 3, 4);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(86, 31);
            menubtn.TabIndex = 0;
            menubtn.Text = "Menu";
            menubtn.UseVisualStyleBackColor = true;
            menubtn.Click += menubtn_Click;
            // 
            // EnameError
            // 
            EnameError.ContainerControl = this;
            // 
            // EmailError
            // 
            EmailError.ContainerControl = this;
            // 
            // NumError
            // 
            NumError.ContainerControl = this;
            // 
            // SalaryError
            // 
            SalaryError.ContainerControl = this;
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(914, 641);
            Controls.Add(ActionsGB);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminHomePage";
            Text = "AdminHomePage";
            Load += AdminHomePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpListView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ActionsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EnameError).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailError).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumError).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox rolecmboc;
        private Button delbtn;
        private Button updatebtn;
        private TextBox salarytxt;
        private Label label5;
        private Label label6;
        private Button addbtn;
        private TextBox phonetxt;
        private TextBox emailtxt;
        private TextBox Enametxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button logoutbtn;
        private Label label1;
        private GroupBox ActionsGB;
        private Button reportbtn;
        private Button tablebtn;
        private Button menubtn;
        private ErrorProvider EnameError;
        private ErrorProvider EmailError;
        private ErrorProvider NumError;
        private ErrorProvider SalaryError;
        private DataGridView EmpListView;
        private Button SearchBtn;
    }
}