namespace PerformanceTracker
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            lblusername = new Label();
            txtUsername = new TextBox();
            Password = new Label();
            txtPassword = new TextBox();
            lblRePassword = new Label();
            txtRePassword = new TextBox();
            btnSignup = new Button();
            lblTitleSignup = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(350, 312);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(84, 20);
            lblusername.TabIndex = 0;
            lblusername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(350, 353);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(255, 27);
            txtUsername.TabIndex = 1;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(350, 405);
            Password.Name = "Password";
            Password.Size = new Size(80, 20);
            Password.TabIndex = 2;
            Password.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(350, 446);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';  // Added to mask password input
            txtPassword.Size = new Size(255, 27);
            txtPassword.TabIndex = 3;
            // 
            // lblRePassword
            // 
            lblRePassword.AutoSize = true;
            lblRePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRePassword.Location = new Point(350, 499);
            lblRePassword.Name = "lblRePassword";
            lblRePassword.Size = new Size(143, 20);
            lblRePassword.TabIndex = 4;
            lblRePassword.Text = "Re Enter Password:";
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(350, 541);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.PasswordChar = '*';  // Added to mask password input
            txtRePassword.Size = new Size(255, 27);
            txtRePassword.TabIndex = 5;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Navy;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(350, 608);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(255, 35);
            btnSignup.TabIndex = 6;
            btnSignup.Text = "SIGN UP";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_click;
            // 
            // lblTitleSignup
            // 
            lblTitleSignup.AutoSize = true;
            lblTitleSignup.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitleSignup.ForeColor = Color.Navy;
            lblTitleSignup.Location = new Point(279, 67);
            lblTitleSignup.Name = "lblTitleSignup";
            lblTitleSignup.Size = new Size(388, 56);
            lblTitleSignup.TabIndex = 7;
            lblTitleSignup.Text = "Create Your Account";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(425, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(982, 753);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitleSignup);
            Controls.Add(btnSignup);
            Controls.Add(txtRePassword);
            Controls.Add(lblRePassword);
            Controls.Add(txtPassword);
            Controls.Add(Password);
            Controls.Add(txtUsername);
            Controls.Add(lblusername);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Your Account";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private TextBox txtUsername;
        private Label Password;
        private TextBox txtPassword;
        private Label lblRePassword;
        private TextBox txtRePassword;
        private Button btnSignup;
        private Label lblTitleSignup;
        private PictureBox pictureBox1;
    }
}
