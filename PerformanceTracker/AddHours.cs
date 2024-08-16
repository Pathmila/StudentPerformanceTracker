using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PerformanceTracker
{
    public partial class AddHours : Form
    {
        private Dictionary<string, string> userStore;
        private string userName;
        private List<StudyRecord> studyRecords;
        private List<string> subjects;

        public AddHours(Dictionary<string, string> userStore, string username, List<StudyRecord> records, List<string> subjects)
        {
            InitializeComponent();
            this.userStore = userStore;
            this.userName = username;
            this.studyRecords = records;
            this.subjects = subjects;
            PopulateSubjects();
        }

        private void PopulateSubjects()
        {
            cmbSubjects.Items.Clear();
            cmbSubjects.Items.AddRange(subjects.ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            string selectedSubject = cmbSubjects.SelectedItem?.ToString();
            decimal studyHours = noStudyHours.Value;
            decimal breakHours = noBreakHours.Value;

            if (selectedSubject == null)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            decimal totalHoursForDay = studyRecords
                .Where(r => r.Date == selectedDate)
                .Sum(r => r.StudyHours + r.BreakHours);

            if (totalHoursForDay + studyHours + breakHours > 24)
            {
                MessageBox.Show("Total hours for the selected date exceed 24 hours. Please adjust your input.");
                return;
            }

            StudyRecord existingRecord = studyRecords
                .FirstOrDefault(r => r.Date == selectedDate && r.Subject == selectedSubject);

            if (existingRecord != null)
            {
                existingRecord.StudyHours += studyHours;
                existingRecord.BreakHours += breakHours;
            }
            else
            {
                StudyRecord newRecord = new StudyRecord
                {
                    Date = selectedDate,
                    Subject = selectedSubject,
                    StudyHours = studyHours,
                    BreakHours = breakHours
                };
                studyRecords.Add(newRecord);
            }

            MessageBox.Show("Record saved successfully!");
            ViewRecordsForm viewRecordForm = new ViewRecordsForm(userStore, userName, studyRecords, subjects);
            viewRecordForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Corrected: Pass subjects list to Home form
            Home home = new Home(userStore, userName, studyRecords);
            home.Show();
            this.Hide();
        }
    }

    public class StudyRecord
    {
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public decimal StudyHours { get; set; }
        public decimal BreakHours { get; set; }
    }
}
