using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PerformanceTracker
{
    public partial class UpdateHours : Form
    {
        private Dictionary<string, string> userStore;
        private string userName;
        private List<StudyRecord> studyRecords;
        private StudyRecord currentRecord;
        private List<string> subjects;

        public UpdateHours(Dictionary<string, string> userStore, string username, List<StudyRecord> records, StudyRecord record, List<string> subjects)
        {
            InitializeComponent();
            this.userStore = userStore;
            this.userName = username;
            this.studyRecords = records;
            this.currentRecord = record;
            this.subjects = subjects;
            PopulateSubjects();

            // Set initial values
            dateTimePicker1.Value = currentRecord.Date;
            cmbSubjects.SelectedItem = currentRecord.Subject;
            noStudyHours.Value = currentRecord.StudyHours;
            noBreakHours.Value = currentRecord.BreakHours;
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
                .Where(r => r.Date == selectedDate && r != currentRecord)
                .Sum(r => r.StudyHours + r.BreakHours);

            if (totalHoursForDay + studyHours + breakHours > 24)
            {
                MessageBox.Show("Total hours for the selected date exceed 24 hours. Please adjust your input.");
                return;
            }

            currentRecord.Date = selectedDate;
            currentRecord.Subject = selectedSubject;
            currentRecord.StudyHours = studyHours;
            currentRecord.BreakHours = breakHours;

            MessageBox.Show("Record updated successfully!");
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
