namespace PerformanceTracker
{
    partial class UpdateHours
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
            btnSave = new Button();
            noBreakHours = new NumericUpDown();
            cmbSubjects = new ComboBox();
            lblSubject = new Label();
            lblBreaksHours = new Label();
            noStudyHours = new NumericUpDown();
            lblStudyHours = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblDate = new Label();
            lblTitleSignup = new Label();
            btnHome = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)noBreakHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noStudyHours).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Navy;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(353, 625);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(255, 35);
            btnSave.TabIndex = 27;
            btnSave.Text = "UPDATE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // noBreakHours
            // 
            noBreakHours.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            noBreakHours.Location = new Point(353, 556);
            noBreakHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            noBreakHours.Name = "noBreakHours";
            noBreakHours.Size = new Size(255, 27);
            noBreakHours.TabIndex = 26;
            // 
            // cmbSubjects
            // 
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(353, 362);
            cmbSubjects.Name = "cmbSubjects";
            cmbSubjects.Size = new Size(255, 28);
            cmbSubjects.TabIndex = 25;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(353, 327);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(64, 20);
            lblSubject.TabIndex = 24;
            lblSubject.Text = "Subject:";
            // 
            // lblBreaksHours
            // 
            lblBreaksHours.AutoSize = true;
            lblBreaksHours.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreaksHours.Location = new Point(353, 517);
            lblBreaksHours.Name = "lblBreaksHours";
            lblBreaksHours.Size = new Size(99, 20);
            lblBreaksHours.TabIndex = 23;
            lblBreaksHours.Text = "Break Hours:";
            // 
            // noStudyHours
            // 
            noStudyHours.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            noStudyHours.Location = new Point(353, 457);
            noStudyHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            noStudyHours.Name = "noStudyHours";
            noStudyHours.Size = new Size(255, 27);
            noStudyHours.TabIndex = 22;
            // 
            // lblStudyHours
            // 
            lblStudyHours.AutoSize = true;
            lblStudyHours.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudyHours.Location = new Point(348, 416);
            lblStudyHours.Name = "lblStudyHours";
            lblStudyHours.Size = new Size(99, 20);
            lblStudyHours.TabIndex = 21;
            lblStudyHours.Text = "Study Hours:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(353, 267);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(353, 222);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(46, 20);
            lblDate.TabIndex = 19;
            lblDate.Text = "Date:";
            // 
            // lblTitleSignup
            // 
            lblTitleSignup.AutoSize = true;
            lblTitleSignup.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitleSignup.ForeColor = Color.Navy;
            lblTitleSignup.Location = new Point(292, 74);
            lblTitleSignup.Name = "lblTitleSignup";
            lblTitleSignup.Size = new Size(372, 56);
            lblTitleSignup.TabIndex = 18;
            lblTitleSignup.Text = "Update Your Hours";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Navy;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(710, 32);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(100, 35);
            btnHome.TabIndex = 29;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Navy;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(835, 32);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 35);
            btnLogout.TabIndex = 28;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // UpdateHours
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 753);
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
            Name = "UpdateHours";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateHours";
            ((System.ComponentModel.ISupportInitialize)noBreakHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)noStudyHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private NumericUpDown noBreakHours;
        private ComboBox cmbSubjects;
        private Label lblSubject;
        private Label lblBreaksHours;
        private NumericUpDown noStudyHours;
        private Label lblStudyHours;
        private DateTimePicker dateTimePicker1;
        private Label lblDate;
        private Label lblTitleSignup;
        private Button btnHome;
        private Button btnLogout;
    }
}