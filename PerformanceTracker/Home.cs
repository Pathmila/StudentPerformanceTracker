using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PerformanceTracker
{
    public partial class Home : Form
    {
        // In-memory storage for user data
        private Dictionary<string, string> userStore;
        private string userName;
        private List<StudyRecord> studyRecords;
        private List<string> subjects = new List<string> { "Math", "Science", "History", "English", "Art" };

        public Home(Dictionary<string, string> userStore, string username)
        {
            InitializeComponent();
            this.userStore = userStore;
            this.userName = username;
            this.studyRecords = new List<StudyRecord>();

            if (userStore.TryGetValue(username, out string storedUserName))
            {
                this.userName = storedUserName;
                lblUserName.Text = "Welcome, " + userName;
            }
            else
            {
                MessageBox.Show("User not found.");
                this.Close(); // Close the form if the user is not found
            }
        }

        public Home(Dictionary<string, string> userStore, string username, List<StudyRecord> records)
        {
            InitializeComponent();
            this.userStore = userStore;
            this.userName = username;
            this.studyRecords = records;

            if (userStore.TryGetValue(username, out string storedUserName))
            {
                this.userName = storedUserName;
                lblUserName.Text = "Welcome, " + userName;
            }
            else
            {
                MessageBox.Show("User not found.");
                this.Close(); // Close the form if the user is not found
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Initialize anything if necessary
        }

        private void btnAddHoursHome_Click(object sender, EventArgs e)
        {
            // Add functionality to navigate to Add Hours form
            AddHours addHours = new AddHours(userStore, userName, studyRecords, subjects);
            addHours.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // Add functionality to generate reports
            PredictPerformanceForm predictPerformanceForm = new PredictPerformanceForm(userStore, userName, studyRecords, subjects);
            predictPerformanceForm.Show();
            this.Hide();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Add functionality to logout
            this.Close();
        }

        private void btnAddSubjects_Click(object sender, EventArgs e)
        {
            // Add functionality to add subjects
            AddSubjectForm subjectManagementForm = new AddSubjectForm(userStore, userName, subjects);
            subjectManagementForm.Show(); // Show as dialog to wait for user action
            this.Hide();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnViewHours_Click(object sender, EventArgs e)
        {
            ViewRecordsForm viewRecordForm = new ViewRecordsForm(userStore, userName, studyRecords, subjects);
            viewRecordForm.Show();
            this.Hide();
        }
    }
}