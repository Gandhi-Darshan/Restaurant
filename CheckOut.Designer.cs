namespace Restaurant
{
    partial class itemlist
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
            label9 = new Label();
            TlALbl = new Label();
            OrderList = new ListBox();
            label1 = new Label();
            label3 = new Label();
            DIDlbl = new Label();
            DiDAmountlbl = new Label();
            label8 = new Label();
            FinalAmount = new Label();
            PaymentBtn = new Button();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(524, 107);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 38;
            label9.Text = "Total Amount";
            // 
            // TlALbl
            // 
            TlALbl.AutoSize = true;
            TlALbl.Location = new Point(633, 107);
            TlALbl.Name = "TlALbl";
            TlALbl.Size = new Size(17, 20);
            TlALbl.TabIndex = 37;
            TlALbl.Text = "0";
            // 
            // OrderList
            // 
            OrderList.FormattingEnabled = true;
            OrderList.ItemHeight = 20;
            OrderList.Location = new Point(28, 23);
            OrderList.Name = "OrderList";
            OrderList.Size = new Size(470, 384);
            OrderList.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 142);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 40;
            label1.Text = "+ Tax";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(633, 142);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 39;
            label3.Text = "13%";
            // 
            // DIDlbl
            // 
            DIDlbl.AutoSize = true;
            DIDlbl.Location = new Point(505, 172);
            DIDlbl.Name = "DIDlbl";
            DIDlbl.Size = new Size(118, 20);
            DIDlbl.TabIndex = 42;
            DIDlbl.Text = "Dine In Discount";
            // 
            // DiDAmountlbl
            // 
            DiDAmountlbl.AutoSize = true;
            DiDAmountlbl.Location = new Point(633, 172);
            DiDAmountlbl.Name = "DiDAmountlbl";
            DiDAmountlbl.Size = new Size(37, 20);
            DiDAmountlbl.TabIndex = 41;
            DiDAmountlbl.Text = "10%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(506, 216);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 44;
            label8.Text = "Payable Amount";
            // 
            // FinalAmount
            // 
            FinalAmount.AutoSize = true;
            FinalAmount.Location = new Point(633, 216);
            FinalAmount.Name = "FinalAmount";
            FinalAmount.Size = new Size(17, 20);
            FinalAmount.TabIndex = 43;
            FinalAmount.Text = "0";
            // 
            // PaymentBtn
            // 
            PaymentBtn.Location = new Point(529, 378);
            PaymentBtn.Name = "PaymentBtn";
            PaymentBtn.Size = new Size(94, 29);
            PaymentBtn.TabIndex = 45;
            PaymentBtn.Text = "Book Table";
            PaymentBtn.UseVisualStyleBackColor = true;
            PaymentBtn.Click += PaymentBtn_Click;
            // 
            // itemlist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PaymentBtn);
            Controls.Add(label8);
            Controls.Add(FinalAmount);
            Controls.Add(DIDlbl);
            Controls.Add(DiDAmountlbl);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(TlALbl);
            Controls.Add(OrderList);
            Name = "itemlist";
            Text = "itemlist";
            Load += itemlist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label TlALbl;
        private ListBox OrderList;
        private Label label1;
        private Label label3;
        private Label DIDlbl;
        private Label DiDAmountlbl;
        private Label label8;
        private Label FinalAmount;
        private Button PaymentBtn;
    }
}