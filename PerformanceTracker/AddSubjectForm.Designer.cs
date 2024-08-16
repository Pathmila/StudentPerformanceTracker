namespace PerformanceTracker
{
    partial class AddSubjectForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSubject;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewSubjects = new DataGridView();
            txtSubject = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblSubject = new Label();
            lblTitleSignup = new Label();
            btnHome = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSubjects
            // 
            dataGridViewSubjects.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubjects.Location = new Point(260, 216);
            dataGridViewSubjects.Name = "dataGridViewSubjects";
            dataGridViewSubjects.RowHeadersWidth = 51;
            dataGridViewSubjects.Size = new Size(240, 426);
            dataGridViewSubjects.TabIndex = 0;
            dataGridViewSubjects.CellClick += dataGridViewSubjects_CellClick;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(524, 257);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(150, 27);
            txtSubject.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(524, 304);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Navy;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(524, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Navy;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(524, 404);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(524, 226);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(60, 20);
            lblSubject.TabIndex = 5;
            lblSubject.Text = "Subject";
            // 
            // lblTitleSignup
            // 
            lblTitleSignup.AutoSize = true;
            lblTitleSignup.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitleSignup.ForeColor = Color.Navy;
            lblTitleSignup.Location = new Point(287, 92);
            lblTitleSignup.Name = "lblTitleSignup";
            lblTitleSignup.Size = new Size(349, 56);
            lblTitleSignup.TabIndex = 22;
            lblTitleSignup.Text = "Add Your Subjects";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Navy;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(684, 35);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(100, 35);
            btnHome.TabIndex = 21;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Navy;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(800, 35);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 35);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AddSubjectForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(982, 753);
            Controls.Add(lblTitleSignup);
            Controls.Add(btnHome);
            Controls.Add(btnLogout);
            Controls.Add(lblSubject);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSubject);
            Controls.Add(dataGridViewSubjects);
            Name = "AddSubjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subject Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitleSignup;
        private Button btnHome;
        private Button btnLogout;
    }
}