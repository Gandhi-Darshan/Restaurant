namespace Restaurant
{
    partial class Registration
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
            Passwordtxt = new TextBox();
            Gmailtxt = new TextBox();
            LastNametxt = new TextBox();
            FirstNametxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Cancelbtn = new Button();
            ConfirmPasswordtxt = new TextBox();
            label1 = new Label();
            label6 = new Label();
            LoginLinklbl = new LinkLabel();
            SignUpbtn = new Button();
            LnameError = new ErrorProvider(components);
            FnameError = new ErrorProvider(components);
            mailError = new ErrorProvider(components);
            PassErrror = new ErrorProvider(components);
            CpassError = new ErrorProvider(components);
            label7 = new Label();
            UnameTxt = new TextBox();
            UnameError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)LnameError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FnameError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PassErrror).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CpassError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UnameError).BeginInit();
            SuspendLayout();
            // 
            // Passwordtxt
            // 
            Passwordtxt.Location = new Point(165, 240);
            Passwordtxt.Margin = new Padding(2, 3, 2, 3);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(182, 27);
            Passwordtxt.TabIndex = 4;
            // 
            // Gmailtxt
            // 
            Gmailtxt.Location = new Point(165, 177);
            Gmailtxt.Margin = new Padding(2, 3, 2, 3);
            Gmailtxt.Name = "Gmailtxt";
            Gmailtxt.Size = new Size(182, 27);
            Gmailtxt.TabIndex = 3;
            // 
            // LastNametxt
            // 
            LastNametxt.Location = new Point(165, 123);
            LastNametxt.Margin = new Padding(2, 3, 2, 3);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(182, 27);
            LastNametxt.TabIndex = 2;
            LastNametxt.Validating += LastNametxt_Validating;
            // 
            // FirstNametxt
            // 
            FirstNametxt.Location = new Point(165, 72);
            FirstNametxt.Margin = new Padding(2, 3, 2, 3);
            FirstNametxt.Name = "FirstNametxt";
            FirstNametxt.Size = new Size(182, 27);
            FirstNametxt.TabIndex = 1;
            FirstNametxt.Validating += FirstNametxt_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 181);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 18;
            label5.Text = "Gmail :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 244);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 17;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 127);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 16;
            label3.Text = "Last name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 15;
            label2.Text = "First Name :";
            // 
            // Cancelbtn
            // 
            Cancelbtn.BackColor = Color.Red;
            Cancelbtn.Location = new Point(250, 371);
            Cancelbtn.Margin = new Padding(2, 3, 2, 3);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(97, 43);
            Cancelbtn.TabIndex = 7;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = false;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // ConfirmPasswordtxt
            // 
            ConfirmPasswordtxt.Location = new Point(165, 307);
            ConfirmPasswordtxt.Margin = new Padding(2, 3, 2, 3);
            ConfirmPasswordtxt.Name = "ConfirmPasswordtxt";
            ConfirmPasswordtxt.Size = new Size(182, 27);
            ConfirmPasswordtxt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 317);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 25;
            label1.Text = "Rewrite Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 440);
            label6.Name = "label6";
            label6.Size = new Size(176, 20);
            label6.TabIndex = 26;
            label6.Text = "Already Have an Account";
            // 
            // LoginLinklbl
            // 
            LoginLinklbl.AutoSize = true;
            LoginLinklbl.Location = new Point(248, 440);
            LoginLinklbl.Name = "LoginLinklbl";
            LoginLinklbl.Size = new Size(46, 20);
            LoginLinklbl.TabIndex = 8;
            LoginLinklbl.TabStop = true;
            LoginLinklbl.Text = "Login";
            LoginLinklbl.LinkClicked += LoginLinklbl_LinkClicked;
            // 
            // SignUpbtn
            // 
            SignUpbtn.BackColor = Color.FromArgb(128, 255, 128);
            SignUpbtn.Location = new Point(30, 371);
            SignUpbtn.Margin = new Padding(2, 3, 2, 3);
            SignUpbtn.Name = "SignUpbtn";
            SignUpbtn.Size = new Size(97, 43);
            SignUpbtn.TabIndex = 6;
            SignUpbtn.Text = "Sign Up";
            SignUpbtn.UseVisualStyleBackColor = false;
            SignUpbtn.Click += SignUpbtn_Click;
            // 
            // LnameError
            // 
            LnameError.ContainerControl = this;
            // 
            // FnameError
            // 
            FnameError.ContainerControl = this;
            // 
            // mailError
            // 
            mailError.ContainerControl = this;
            // 
            // PassErrror
            // 
            PassErrror.ContainerControl = this;
            // 
            // CpassError
            // 
            CpassError.ContainerControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 33);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 27;
            label7.Text = "User Name :";
            // 
            // UnameTxt
            // 
            UnameTxt.Location = new Point(165, 29);
            UnameTxt.Margin = new Padding(2, 3, 2, 3);
            UnameTxt.Name = "UnameTxt";
            UnameTxt.Size = new Size(182, 27);
            UnameTxt.TabIndex = 28;
            // 
            // UnameError
            // 
            UnameError.ContainerControl = this;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(393, 536);
            Controls.Add(UnameTxt);
            Controls.Add(label7);
            Controls.Add(SignUpbtn);
            Controls.Add(LoginLinklbl);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(ConfirmPasswordtxt);
            Controls.Add(Passwordtxt);
            Controls.Add(Gmailtxt);
            Controls.Add(LastNametxt);
            Controls.Add(FirstNametxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cancelbtn);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ((System.ComponentModel.ISupportInitialize)LnameError).EndInit();
            ((System.ComponentModel.ISupportInitialize)FnameError).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailError).EndInit();
            ((System.ComponentModel.ISupportInitialize)PassErrror).EndInit();
            ((System.ComponentModel.ISupportInitialize)CpassError).EndInit();
            ((System.ComponentModel.ISupportInitialize)UnameError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Passwordtxt;
        private TextBox Gmailtxt;
        private TextBox LastNametxt;
        private TextBox FirstNametxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button Cancelbtn;
        private TextBox ConfirmPasswordtxt;
        private Label label1;
        private Label label6;
        private LinkLabel LoginLinklbl;
        private Button SignUpbtn;
        private ErrorProvider LnameError;
        private ErrorProvider FnameError;
        private ErrorProvider mailError;
        private ErrorProvider PassErrror;
        private ErrorProvider CpassError;
        private TextBox UnameTxt;
        private Label label7;
        private ErrorProvider UnameError;
    }
}