namespace Restaurant
{
    partial class TableManagment
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
            ActionsGB = new GroupBox();
            reportbtn = new Button();
            menubtn = new Button();
            EmpBtn = new Button();
            panel2 = new Panel();
            logoutbtn = new Button();
            label1 = new Label();
            TableLst = new DataGridView();
            EIDCmb = new ComboBox();
            label6 = new Label();
            CapcityTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            delbtn = new Button();
            updatebtn = new Button();
            addbtn = new Button();
            label4 = new Label();
            label5 = new Label();
            ENameTxt = new TextBox();
            SalaryTxt = new TextBox();
            OccupiedCheck = new CheckBox();
            TableIDTxt = new TextBox();
            label7 = new Label();
            SearchCap = new ComboBox();
            ActionsGB.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TableLst).BeginInit();
            SuspendLayout();
            // 
            // ActionsGB
            // 
            ActionsGB.BackColor = SystemColors.ActiveCaption;
            ActionsGB.Controls.Add(reportbtn);
            ActionsGB.Controls.Add(menubtn);
            ActionsGB.Controls.Add(EmpBtn);
            ActionsGB.Location = new Point(12, 13);
            ActionsGB.Margin = new Padding(3, 4, 3, 4);
            ActionsGB.Name = "ActionsGB";
            ActionsGB.Padding = new Padding(3, 4, 3, 4);
            ActionsGB.Size = new Size(161, 467);
            ActionsGB.TabIndex = 12;
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
            // menubtn
            // 
            menubtn.Location = new Point(38, 91);
            menubtn.Margin = new Padding(3, 4, 3, 4);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(86, 31);
            menubtn.TabIndex = 1;
            menubtn.Text = "Menu";
            menubtn.UseVisualStyleBackColor = true;
            menubtn.Click += menubtn_Click;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(logoutbtn);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(179, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(929, 79);
            panel2.TabIndex = 13;
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
            // TableLst
            // 
            TableLst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableLst.Location = new Point(189, 113);
            TableLst.Margin = new Padding(3, 4, 3, 4);
            TableLst.Name = "TableLst";
            TableLst.RowHeadersWidth = 51;
            TableLst.RowTemplate.Height = 25;
            TableLst.Size = new Size(453, 433);
            TableLst.TabIndex = 26;
            TableLst.CellContentClick += TableLst_CellContentClick;
            // 
            // EIDCmb
            // 
            EIDCmb.BackColor = Color.DarkGray;
            EIDCmb.FormattingEnabled = true;
            EIDCmb.Items.AddRange(new object[] { "Head Chef", "Sous Chef", "Kitchen Helper", "Waiter", "Manager" });
            EIDCmb.Location = new Point(648, 362);
            EIDCmb.Margin = new Padding(3, 4, 3, 4);
            EIDCmb.Name = "EIDCmb";
            EIDCmb.Size = new Size(235, 28);
            EIDCmb.TabIndex = 25;
            EIDCmb.SelectedIndexChanged += EIDCmb_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(648, 338);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 22;
            label6.Text = "Employee ID";
            // 
            // CapcityTxt
            // 
            CapcityTxt.BackColor = SystemColors.AppWorkspace;
            CapcityTxt.Location = new Point(648, 289);
            CapcityTxt.Margin = new Padding(3, 4, 3, 4);
            CapcityTxt.Name = "CapcityTxt";
            CapcityTxt.Size = new Size(239, 27);
            CapcityTxt.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(648, 265);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 17;
            label3.Text = "Capacity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(648, 117);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 16;
            label2.Text = "Search By Capacity";
            // 
            // delbtn
            // 
            delbtn.BackColor = Color.LightCoral;
            delbtn.Location = new Point(930, 280);
            delbtn.Margin = new Padding(3, 4, 3, 4);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(107, 39);
            delbtn.TabIndex = 16;
            delbtn.Text = "Remove";
            delbtn.UseVisualStyleBackColor = false;
            delbtn.Click += delbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.LightCoral;
            updatebtn.Location = new Point(930, 207);
            updatebtn.Margin = new Padding(3, 4, 3, 4);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(107, 39);
            updatebtn.TabIndex = 15;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.LightCoral;
            addbtn.Location = new Point(930, 135);
            addbtn.Margin = new Padding(3, 4, 3, 4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(107, 39);
            addbtn.TabIndex = 14;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(648, 414);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 28;
            label4.Text = "Employee Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(648, 494);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 30;
            label5.Text = "Employee Name";
            // 
            // ENameTxt
            // 
            ENameTxt.BackColor = SystemColors.AppWorkspace;
            ENameTxt.Enabled = false;
            ENameTxt.Location = new Point(648, 438);
            ENameTxt.Margin = new Padding(3, 4, 3, 4);
            ENameTxt.Name = "ENameTxt";
            ENameTxt.Size = new Size(239, 27);
            ENameTxt.TabIndex = 31;
            // 
            // SalaryTxt
            // 
            SalaryTxt.BackColor = SystemColors.AppWorkspace;
            SalaryTxt.Enabled = false;
            SalaryTxt.Location = new Point(648, 519);
            SalaryTxt.Margin = new Padding(3, 4, 3, 4);
            SalaryTxt.Name = "SalaryTxt";
            SalaryTxt.Size = new Size(239, 27);
            SalaryTxt.TabIndex = 32;
            // 
            // OccupiedCheck
            // 
            OccupiedCheck.AutoSize = true;
            OccupiedCheck.Checked = true;
            OccupiedCheck.CheckState = CheckState.Checked;
            OccupiedCheck.Location = new Point(936, 364);
            OccupiedCheck.Name = "OccupiedCheck";
            OccupiedCheck.Size = new Size(108, 24);
            OccupiedCheck.TabIndex = 33;
            OccupiedCheck.Text = "Is Occupied";
            OccupiedCheck.UseVisualStyleBackColor = true;
            // 
            // TableIDTxt
            // 
            TableIDTxt.BackColor = SystemColors.AppWorkspace;
            TableIDTxt.Enabled = false;
            TableIDTxt.Location = new Point(648, 213);
            TableIDTxt.Margin = new Padding(3, 4, 3, 4);
            TableIDTxt.Name = "TableIDTxt";
            TableIDTxt.Size = new Size(239, 27);
            TableIDTxt.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(648, 189);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 34;
            label7.Text = "Table ID :";
            // 
            // SearchCap
            // 
            SearchCap.BackColor = Color.DarkGray;
            SearchCap.FormattingEnabled = true;
            SearchCap.Items.AddRange(new object[] { "4", "6", "8", "10" });
            SearchCap.Location = new Point(648, 141);
            SearchCap.Margin = new Padding(3, 4, 3, 4);
            SearchCap.Name = "SearchCap";
            SearchCap.Size = new Size(235, 28);
            SearchCap.TabIndex = 27;
            SearchCap.SelectedIndexChanged += SearchCap_SelectedIndexChanged;
            // 
            // TableManagment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1121, 610);
            Controls.Add(TableIDTxt);
            Controls.Add(label7);
            Controls.Add(OccupiedCheck);
            Controls.Add(SalaryTxt);
            Controls.Add(ENameTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(delbtn);
            Controls.Add(SearchCap);
            Controls.Add(updatebtn);
            Controls.Add(TableLst);
            Controls.Add(addbtn);
            Controls.Add(EIDCmb);
            Controls.Add(label6);
            Controls.Add(CapcityTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(ActionsGB);
            Name = "TableManagment";
            Text = "TableManagment";
            Load += TableManagment_Load;
            ActionsGB.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TableLst).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox ActionsGB;
        private Button reportbtn;
        private Button menubtn;
        private Button EmpBtn;
        private Panel panel2;
        private Button logoutbtn;
        private Label label1;
        private DataGridView TableLst;
        private ComboBox EIDCmb;
        private Label label6;
        private TextBox CapcityTxt;
        private Label label3;
        private Label label2;
        private Button delbtn;
        private Button updatebtn;
        private Button addbtn;
        private Label label4;
        private Label label5;
        private TextBox ENameTxt;
        private TextBox SalaryTxt;
        private CheckBox OccupiedCheck;
        private TextBox TableIDTxt;
        private Label label7;
        private ComboBox SearchCap;
    }
}