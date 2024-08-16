using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PerformanceTracker
{
    public partial class ViewRecordsForm : Form
    {
        private Dictionary<string, string> userStore;
        private string userName;
        private List<StudyRecord> studyRecords;
        private List<string> subjects;

        public ViewRecordsForm(Dictionary<string, string> userStore, string username, List<StudyRecord> records, List<string> subjects)
        {
            InitializeComponent();
            this.userStore = userStore;
            this.userName = username;
            this.studyRecords = records;
            this.subjects = subjects;

            dataGridView1.DataSource = new BindingList<StudyRecord>(studyRecords);
        }

        private void ViewRecordsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["Date"].HeaderText = "Date";
            dataGridView1.Columns["Subject"].HeaderText = "Subject";
            dataGridView1.Columns["StudyHours"].HeaderText = "Study Hours";
            dataGridView1.Columns["BreakHours"].HeaderText = "Break Hours";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddHours addHours = new AddHours(userStore, userName, studyRecords, subjects);
            addHours.FormClosed += AddHours_FormClosed;
            addHours.Show();
            this.Hide();
        }

        private void AddHours_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Update the DataGridView after the AddHours form is closed
            dataGridView1.DataSource = new BindingList<StudyRecord>(studyRecords);
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                StudyRecord selectedRecord = (StudyRecord)dataGridView1.SelectedRows[0].DataBoundItem;
                UpdateHours updateHours = new UpdateHours(userStore, userName, studyRecords, selectedRecord, subjects);
                updateHours.FormClosed += UpdateHours_FormClosed;
                updateHours.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }
        }

        private void UpdateHours_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Update the DataGridView after the UpdateHours form is closed
            dataGridView1.DataSource = new BindingList<StudyRecord>(studyRecords);
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Show a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Proceed with deletion
                    StudyRecord selectedRecord = (StudyRecord)dataGridView1.SelectedRows[0].DataBoundItem;
                    studyRecords.Remove(selectedRecord);
                    dataGridView1.DataSource = new BindingList<StudyRecord>(studyRecords);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }
    }
}
