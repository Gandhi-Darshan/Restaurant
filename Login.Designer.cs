namespace Restaurant
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginBtn = new Button();
            label2 = new Label();
            Passtxt = new TextBox();
            Unametxt = new TextBox();
            label5 = new Label();
            label1 = new Label();
            RegisterLinklbl = new LinkLabel();
            CloseBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DimGray;
            LoginBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.Location = new Point(143, 377);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(205, 51);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(179, 318);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 17;
            label2.Text = "Password :";
            // 
            // Passtxt
            // 
            Passtxt.Location = new Point(328, 318);
            Passtxt.Name = "Passtxt";
            Passtxt.Size = new Size(223, 27);
            Passtxt.TabIndex = 2;
            // 
            // Unametxt
            // 
            Unametxt.Location = new Point(328, 235);
            Unametxt.Name = "Unametxt";
            Unametxt.Size = new Size(223, 27);
            Unametxt.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(179, 235);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 20;
            label5.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 458);
            label1.Name = "label1";
            label1.Size = new Size(278, 20);
            label1.TabIndex = 25;
            label1.Text = "Don't have an account create one Today ";
            // 
            // RegisterLinklbl
            // 
            RegisterLinklbl.AutoSize = true;
            RegisterLinklbl.Location = new Point(498, 458);
            RegisterLinklbl.Name = "RegisterLinklbl";
            RegisterLinklbl.Size = new Size(76, 20);
            RegisterLinklbl.TabIndex = 5;
            RegisterLinklbl.TabStop = true;
            RegisterLinklbl.Text = "Click Here";
            RegisterLinklbl.LinkClicked += RegisterLinklbl_LinkClicked;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.IndianRed;
            CloseBtn.DialogResult = DialogResult.Cancel;
            CloseBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            CloseBtn.Location = new Point(369, 377);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(205, 51);
            CloseBtn.TabIndex = 4;
            CloseBtn.Text = "Exit";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(214, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(715, 557);
            Controls.Add(pictureBox1);
            Controls.Add(CloseBtn);
            Controls.Add(RegisterLinklbl);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(Passtxt);
            Controls.Add(Unametxt);
            Controls.Add(label5);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private Label label2;
        private TextBox Passtxt;
        private TextBox Unametxt;
        private Label label5;
        private Label label1;
        private LinkLabel RegisterLinklbl;
        private Button CloseBtn;
        private PictureBox pictureBox1;
    }
}