using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PerformanceTracker
{
    public partial class PredictPerformanceForm : Form
    {
        private Dictionary<string, string> userStore;
        private string userName;
        private List<StudyRecord> studyRecords;
        private List<string> subjects;

        public PredictPerformanceForm(Dictionary<string, string> userStore, string username, List<StudyRecord> records, List<string> subjects)
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

        private void btnPredict_Click(object sender, EventArgs e)
        {
            string selectedSubject = cmbSubjects.SelectedItem?.ToString();
            if (selectedSubject == null)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            var weeklyRecords = studyRecords
                .Where(r => r.Subject == selectedSubject)
                .GroupBy(r => GetWeekOfMonth(r.Date))
                .Select(g => new WeeklyRecord
                {
                    Week = g.Key,
                    TotalStudyHours = g.Sum(r => r.StudyHours),
                    TotalBreakHours = g.Sum(r => r.BreakHours)
                })
                .OrderBy(r => r.Week)
                .ToList();

            dataGridView1.DataSource = new BindingList<WeeklyRecord>(weeklyRecords);

            decimal totalStudyHours = weeklyRecords.Sum(r => r.TotalStudyHours);
            decimal totalBreakHours = weeklyRecords.Sum(r => r.TotalBreakHours);
            lblPredictedGrade.Text = "Predicted Grade: " + PredictGrade(totalStudyHours, totalBreakHours);
        }

        private int GetWeekOfMonth(DateTime date)
        {
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            return (date.Day + (int)firstDayOfMonth.DayOfWeek - 1) / 7 + 1;
        }

        private string PredictGrade(decimal totalStudyHours, decimal totalBreakHours)
        {
            if (totalBreakHours == 0)
            {
                // If there are no break hours, avoid division by zero
                if (totalStudyHours >= 18)
                    return "A";
                else if (totalStudyHours >= 15)
                    return "B";
                else if (totalStudyHours >= 10)
                    return "C";
                else if (totalStudyHours >= 5)
                    return "D";
                else
                    return "F";
            }

            // Calculate the ratio of study hours to break hours
            decimal ratio = totalStudyHours / totalBreakHours;

            if (ratio >= 3m) // Example: For a better balance, study hours should be at least 3 times the break hours
                return "A";
            else if (ratio >= 2.5m)
                return "B";
            else if (ratio >= 2m)
                return "C";
            else if (ratio >= 1.5m)
                return "D";
            else
                return "F";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(userStore, userName, studyRecords);
            home.Show();
            this.Hide();
        }
    }

    public class WeeklyRecord
    {
        public int Week { get; set; }
        public decimal TotalStudyHours { get; set; }
        public decimal TotalBreakHours { get; set; }
    }
}
