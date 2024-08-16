namespace PerformanceTracker
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUserName;
        private Button btnAddHoursHome;
        private Button btnReports;
        private Button btnLogout;
        private Button btnAddSubjects;
        private Label lblDescription;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            lblUserName = new Label();
            btnAddHoursHome = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            btnAddSubjects = new Button();
            lblDescription = new Label();
            btnViewHours = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(93, 92);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(282, 50);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Welcome, User";
            lblUserName.Click += lblUserName_Click;
            // 
            // btnAddHoursHome
            // 
            btnAddHoursHome.BackColor = Color.Navy;
            btnAddHoursHome.FlatStyle = FlatStyle.Flat;
            btnAddHoursHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddHoursHome.ForeColor = Color.White;
            btnAddHoursHome.Image = (Image)resources.GetObject("btnAddHoursHome.Image");
            btnAddHoursHome.ImageAlign = ContentAlignment.TopCenter;
            btnAddHoursHome.Location = new Point(93, 245);
            btnAddHoursHome.Name = "btnAddHoursHome";
            btnAddHoursHome.Padding = new Padding(3);
            btnAddHoursHome.Size = new Size(168, 127);
            btnAddHoursHome.TabIndex = 2;
            btnAddHoursHome.Text = "Add Hours";
            btnAddHoursHome.TextAlign = ContentAlignment.BottomCenter;
            btnAddHoursHome.UseVisualStyleBackColor = false;
            btnAddHoursHome.Click += btnAddHoursHome_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Navy;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.TopCenter;
            btnReports.Location = new Point(483, 245);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(3);
            btnReports.Size = new Size(168, 127);
            btnReports.TabIndex = 3;
            btnReports.Text = "Generate Reports";
            btnReports.TextAlign = ContentAlignment.BottomCenter;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Navy;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(835, 42);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 35);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAddSubjects
            // 
            btnAddSubjects.BackColor = Color.Navy;
            btnAddSubjects.FlatStyle = FlatStyle.Flat;
            btnAddSubjects.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSubjects.ForeColor = Color.White;
            btnAddSubjects.Image = (Image)resources.GetObject("btnAddSubjects.Image");
            btnAddSubjects.ImageAlign = ContentAlignment.TopCenter;
            btnAddSubjects.Location = new Point(680, 245);
            btnAddSubjects.Name = "btnAddSubjects";
            btnAddSubjects.Padding = new Padding(3);
            btnAddSubjects.Size = new Size(168, 127);
            btnAddSubjects.TabIndex = 5;
            btnAddSubjects.Text = "Add Subjects";
            btnAddSubjects.TextAlign = ContentAlignment.BottomCenter;
            btnAddSubjects.UseVisualStyleBackColor = false;
            btnAddSubjects.Click += btnAddSubjects_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(174, 487);
            lblDescription.MaximumSize = new Size(600, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(585, 112);
            lblDescription.TabIndex = 6;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            lblDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnViewHours
            // 
            btnViewHours.BackColor = Color.Navy;
            btnViewHours.FlatStyle = FlatStyle.Flat;
            btnViewHours.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewHours.ForeColor = Color.White;
            btnViewHours.Image = (Image)resources.GetObject("btnViewHours.Image");
            btnViewHours.ImageAlign = ContentAlignment.TopCenter;
            btnViewHours.Location = new Point(286, 245);
            btnViewHours.Name = "btnViewHours";
            btnViewHours.Padding = new Padding(3);
            btnViewHours.Size = new Size(168, 127);
            btnViewHours.TabIndex = 7;
            btnViewHours.Text = "View Hours";
            btnViewHours.TextAlign = ContentAlignment.BottomCenter;
            btnViewHours.UseVisualStyleBackColor = false;
            btnViewHours.Click += btnViewHours_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 753);
            Controls.Add(btnViewHours);
            Controls.Add(lblDescription);
            Controls.Add(btnAddSubjects);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnAddHoursHome);
            Controls.Add(lblUserName);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewHours;
    }
}
