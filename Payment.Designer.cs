namespace Restaurant
{
    partial class Payment
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
            label1 = new Label();
            UnameTxt = new TextBox();
            AmountTxt = new TextBox();
            label2 = new Label();
            CardNumTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CVVTxt = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(108, 125);
            label1.Name = "label1";
            label1.Size = new Size(155, 23);
            label1.TabIndex = 0;
            label1.Text = "CardHolder Name";
            // 
            // UnameTxt
            // 
            UnameTxt.Location = new Point(269, 125);
            UnameTxt.Name = "UnameTxt";
            UnameTxt.Size = new Size(125, 27);
            UnameTxt.TabIndex = 1;
            // 
            // AmountTxt
            // 
            AmountTxt.Enabled = false;
            AmountTxt.Location = new Point(266, 175);
            AmountTxt.Name = "AmountTxt";
            AmountTxt.Size = new Size(125, 27);
            AmountTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(108, 182);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 2;
            label2.Text = "Payable Amount";
            // 
            // CardNumTxt
            // 
            CardNumTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CardNumTxt.Location = new Point(266, 229);
            CardNumTxt.Name = "CardNumTxt";
            CardNumTxt.Size = new Size(221, 27);
            CardNumTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(108, 236);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 4;
            label3.Text = "Card Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(108, 312);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 6;
            label4.Text = "Expire Date";
            // 
            // CVVTxt
            // 
            CVVTxt.Location = new Point(588, 309);
            CVVTxt.Name = "CVVTxt";
            CVVTxt.Size = new Size(112, 27);
            CVVTxt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(510, 312);
            label5.Name = "label5";
            label5.Size = new Size(43, 23);
            label5.TabIndex = 8;
            label5.Text = "CVV";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(239, 305);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Location = new Point(108, 383);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(297, 383);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(CVVTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CardNumTxt);
            Controls.Add(label3);
            Controls.Add(AmountTxt);
            Controls.Add(label2);
            Controls.Add(UnameTxt);
            Controls.Add(label1);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UnameTxt;
        private TextBox AmountTxt;
        private Label label2;
        private TextBox CardNumTxt;
        private Label label3;
        private Label label4;
        private TextBox CVVTxt;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}