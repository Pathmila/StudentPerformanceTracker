namespace PerformanceTracker
{
    partial class AddHours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHours));
            lblTitleSignup = new Label();
            lblDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblStudyHours = new Label();
            noStudyHours = new NumericUpDown();
            lblBreaksHours = new Label();
            lblSubject = new Label();
            cmbSubjects = new ComboBox();
            noBreakHours = new NumericUpDown();
            btnSave = new Button();
            btnHome = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)noStudyHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noBreakHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitleSignup
            // 
            lblTitleSignup.AutoSize = true;
            lblTitleSignup.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitleSignup.ForeColor = Color.Navy;
            lblTitleSignup.Location = new Point(318, 80);
            lblTitleSignup.Name = "lblTitleSignup";
            lblTitleSignup.Size = new Size(312, 56);
            lblTitleSignup.TabIndex = 8;
            lblTitleSignup.Text = "Add Your Hours";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(341, 299);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(46, 20);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(341, 337);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // lblStudyHours
            // 
            lblStudyHours.AutoSize = true;
            lblStudyHours.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudyHours.Location = new Point(336, 471);
            lblStudyHours.Name = "lblStudyHours";
            lblStudyHours.Size = new Size(99, 20);
            lblStudyHours.TabIndex = 11;
            lblStudyHours.Text = "Study Hours:";
            // 
            // noStudyHours
            // 
            noStudyHours.DecimalPlaces = 1;
            noStudyHours.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            noStudyHours.Location = new Point(341, 511);
            noStudyHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            noStudyHours.Name = "noStudyHours";
            noStudyHours.Size = new Size(255, 27);
            noStudyHours.TabIndex = 2;
            // 
            // lblBreaksHours
            // 
            lblBreaksHours.AutoSize = true;
            lblBreaksHours.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreaksHours.Location = new Point(341, 564);
            lblBreaksHours.Name = "lblBreaksHours";
            lblBreaksHours.Size = new Size(99, 20);
            lblBreaksHours.TabIndex = 13;
            lblBreaksHours.Text = "Break Hours:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(341, 386);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(64, 20);
            lblSubject.TabIndex = 14;
            lblSubject.Text = "Subject:";
            // 
            // cmbSubjects
            // 
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(341, 421);
            cmbSubjects.Name = "cmbSubjects";
            cmbSubjects.Size = new Size(255, 28);
            cmbSubjects.TabIndex = 15;
            // 
            // noBreakHours
            // 
            noBreakHours.DecimalPlaces = 1;
            noBreakHours.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            noBreakHours.Location = new Point(341, 599);
            noBreakHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            noBreakHours.Name = "noBreakHours";
            noBreakHours.Size = new Size(255, 27);
            noBreakHours.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Navy;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(341, 660);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(255, 35);
            btnSave.TabIndex = 17;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Navy;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(713, 29);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(100, 35);
            btnHome.TabIndex = 19;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Navy;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(838, 29);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 35);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(425, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // AddHours
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 753);
            Controls.Add(pictureBox1);
            Controls.Add(btnHome);
            Controls.Add(btnLogout);
            Controls.Add(btnSave);
            Controls.Add(noBreakHours);
            Controls.Add(cmbSubjects);
            Controls.Add(lblSubject);
            Controls.Add(lblBreaksHours);
            Controls.Add(noStudyHours);
            Controls.Add(lblStudyHours);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDate);
            Controls.Add(lblTitleSignup);
            Name = "AddHours";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddHours";
            ((System.ComponentModel.ISupportInitialize)noStudyHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)noBreakHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleSignup;
        private Label lblDate;
        private DateTimePicker dateTimePicker1;
        private Label lblStudyHours;
        private NumericUpDown noStudyHours;
        private Label lblBreaksHours;
        private Label lblSubject;
        private ComboBox cmbSubjects;
        private NumericUpDown noBreakHours;
        private Button btnSave;
        private Button btnHome;
        private Button btnLogout;
        private PictureBox pictureBox1;
    }
}