namespace Restaurant
{
    partial class BookTable
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
            TableList = new DataGridView();
            label7 = new Label();
            PaymentBtn = new Button();
            SearchBox = new ComboBox();
            TIDTxt = new TextBox();
            label1 = new Label();
            CapTxt = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            logoutbtn = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)TableList).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TableList
            // 
            TableList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableList.Location = new Point(47, 144);
            TableList.Name = "TableList";
            TableList.RowHeadersWidth = 51;
            TableList.RowTemplate.Height = 29;
            TableList.Size = new Size(328, 198);
            TableList.TabIndex = 0;
            TableList.CellContentClick += TableList_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 148);
            label7.Name = "label7";
            label7.Size = new Size(136, 20);
            label7.TabIndex = 48;
            label7.Text = "Book the Table For ";
            // 
            // PaymentBtn
            // 
            PaymentBtn.Location = new Point(395, 334);
            PaymentBtn.Name = "PaymentBtn";
            PaymentBtn.Size = new Size(94, 29);
            PaymentBtn.TabIndex = 50;
            PaymentBtn.Text = "Payment";
            PaymentBtn.UseVisualStyleBackColor = true;
            PaymentBtn.Click += PaymentBtn_Click;
            // 
            // SearchBox
            // 
            SearchBox.FormattingEnabled = true;
            SearchBox.Items.AddRange(new object[] { "4", "6", "8", "10" });
            SearchBox.Location = new Point(398, 177);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(151, 28);
            SearchBox.TabIndex = 51;
            SearchBox.SelectedIndexChanged += SearchBox_SelectedIndexChanged;
            // 
            // TIDTxt
            // 
            TIDTxt.BackColor = SystemColors.AppWorkspace;
            TIDTxt.Enabled = false;
            TIDTxt.Location = new Point(395, 238);
            TIDTxt.Margin = new Padding(3, 4, 3, 4);
            TIDTxt.Name = "TIDTxt";
            TIDTxt.Size = new Size(154, 27);
            TIDTxt.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 215);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 52;
            label1.Text = "Table ID";
            // 
            // CapTxt
            // 
            CapTxt.BackColor = SystemColors.AppWorkspace;
            CapTxt.Enabled = false;
            CapTxt.Location = new Point(395, 300);
            CapTxt.Margin = new Padding(3, 4, 3, 4);
            CapTxt.Name = "CapTxt";
            CapTxt.Size = new Size(154, 27);
            CapTxt.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 277);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 54;
            label2.Text = "Capacity";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(logoutbtn);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(545, 79);
            panel2.TabIndex = 56;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.LightCoral;
            logoutbtn.Location = new Point(430, 17);
            logoutbtn.Margin = new Padding(3, 4, 3, 4);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(107, 39);
            logoutbtn.TabIndex = 4;
            logoutbtn.Text = "Log Out";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 17);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 0;
            label3.Text = "Menu Items";
            // 
            // BookTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(583, 384);
            Controls.Add(panel2);
            Controls.Add(CapTxt);
            Controls.Add(label2);
            Controls.Add(TIDTxt);
            Controls.Add(label1);
            Controls.Add(SearchBox);
            Controls.Add(PaymentBtn);
            Controls.Add(label7);
            Controls.Add(TableList);
            Name = "BookTable";
            Text = "BookTable";
            Load += BookTable_Load;
            ((System.ComponentModel.ISupportInitialize)TableList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TableList;
        private Label label7;
        private Button PaymentBtn;
        private ComboBox SearchBox;
        private TextBox TIDTxt;
        private Label label1;
        private TextBox CapTxt;
        private Label label2;
        private Panel panel2;
        private Button logoutbtn;
        private Label label3;
    }
}