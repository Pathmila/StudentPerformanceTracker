namespace PerformanceTracker
{
    partial class PredictPerformanceForm
    {
        private System.ComponentModel.IContainer components = null;

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
            lblSubject = new Label();
            cmbSubjects = new ComboBox();
            btnPredict = new Button();
            dataGridView1 = new DataGridView();
            lblPredictedGrade = new Label();
            lblTitleSignup = new Label();
            btnHome = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubject.Location = new Point(198, 214);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(64, 20);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Subject:";
            // 
            // cmbSubjects
            // 
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(198, 248);
            cmbSubjects.Name = "cmbSubjects";
            cmbSubjects.Size = new Size(255, 28);
            cmbSubjects.TabIndex = 1;
            // 
            // btnPredict
            // 
            btnPredict.BackColor = Color.Navy;
            btnPredict.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPredict.ForeColor = Color.White;
            btnPredict.Location = new Point(198, 292);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(255, 35);
            btnPredict.TabIndex = 2;
            btnPredict.Text = "Predict";
            btnPredict.UseVisualStyleBackColor = false;
            btnPredict.Click += btnPredict_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(198, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(600, 200);
            dataGridView1.TabIndex = 3;
            // 
            // lblPredictedGrade
            // 
            lblPredictedGrade.AutoSize = true;
            lblPredictedGrade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPredictedGrade.Location = new Point(198, 567);
            lblPredictedGrade.Name = "lblPredictedGrade";
            lblPredictedGrade.Size = new Size(125, 20);
            lblPredictedGrade.TabIndex = 4;
            lblPredictedGrade.Text = "Predicted Grade:";
            // 
            // lblTitleSignup
            // 
            lblTitleSignup.AutoSize = true;
            lblTitleSignup.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitleSignup.ForeColor = Color.Navy;
            lblTitleSignup.Location = new Point(310, 72);
            lblTitleSignup.Name = "lblTitleSignup";
            lblTitleSignup.Size = new Size(391, 56);
            lblTitleSignup.TabIndex = 8;
            lblTitleSignup.Text = "Generate You Report";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Navy;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(713, 28);
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
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(838, 28);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 35);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // PredictPerformanceForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(982, 753);
            Controls.Add(btnHome);
            Controls.Add(btnLogout);
            Controls.Add(lblTitleSignup);
            Controls.Add(lblPredictedGrade);
            Controls.Add(dataGridView1);
            Controls.Add(btnPredict);
            Controls.Add(cmbSubjects);
            Controls.Add(lblSubject);
            Name = "PredictPerformanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prediction Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPredictedGrade;
        private Label lblTitleSignup;
        private Button btnLogout;
        private Button btnHome;
    }
}
