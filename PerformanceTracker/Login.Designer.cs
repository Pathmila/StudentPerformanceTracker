namespace PerformanceTracker
{
    partial class Login
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
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblTitleLogin = new Label();
            btnSignup = new Button();
            txtPassword = new TextBox();
            Password = new Label();
            txtUsername = new TextBox();
            lblusername = new Label();
            lblCreateAccount = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitleLogin
            // 
            lblTitleLogin.AutoSize = true;
            lblTitleLogin.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitleLogin.ForeColor = Color.Navy;
            lblTitleLogin.Location = new Point(405, 77);
            lblTitleLogin.Name = "lblTitleLogin";
            lblTitleLogin.Size = new Size(179, 56);
            lblTitleLogin.TabIndex = 8;
            lblTitleLogin.Text = "Welcome";
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Navy;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(364, 509);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(255, 35);
            btnSignup.TabIndex = 15;
            btnSignup.Text = "LOGIN";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnlogin_click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(364, 435);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(255, 27);
            txtPassword.TabIndex = 14;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(364, 394);
            Password.Name = "Password";
            Password.Size = new Size(80, 20);
            Password.TabIndex = 13;
            Password.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(364, 342);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(255, 27);
            txtUsername.TabIndex = 12;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(364, 301);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(84, 20);
            lblusername.TabIndex = 11;
            lblusername.Text = "Username:";
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Cursor = Cursors.Hand;
            lblCreateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCreateAccount.ForeColor = Color.Navy;
            lblCreateAccount.Location = new Point(396, 574);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(188, 20);
            lblCreateAccount.TabIndex = 16;
            lblCreateAccount.Text = "Create Your New Account";
            lblCreateAccount.Click += createAccount_click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(441, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(982, 753);
            Controls.Add(pictureBox1);
            Controls.Add(lblCreateAccount);
            Controls.Add(btnSignup);
            Controls.Add(txtPassword);
            Controls.Add(Password);
            Controls.Add(txtUsername);
            Controls.Add(lblusername);
            Controls.Add(lblTitleLogin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleLogin;
        private Button btnSignup;
        private TextBox txtPassword;
        private Label Password;
        private TextBox txtUsername;
        private Label lblusername;
        private Label lblCreateAccount;
        private PictureBox pictureBox1;
    }
}
