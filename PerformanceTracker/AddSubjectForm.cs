using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PerformanceTracker
{
    public partial class AddSubjectForm : Form
    {
        private BindingList<Subject> subjects;
        private Dictionary<string, string> userStore;
        private string userName;
        private List<StudyRecord> studyRecords;

        public AddSubjectForm(Dictionary<string, string> userStore, string username, List<string> subjectNames)
        {
            InitializeComponent();
            this.userStore = userStore;
            this.userName = username;
            subjects = new BindingList<Subject>(subjectNames.ConvertAll(name => new Subject(name)));
            RefreshSubjectsList();
        }

        private void RefreshSubjectsList()
        {
            dataGridViewSubjects.DataSource = null;
            dataGridViewSubjects.DataSource = subjects;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newSubjectName = txtSubject.Text.Trim();
            if (!string.IsNullOrEmpty(newSubjectName))
            {
                subjects.Add(new Subject(newSubjectName));
                RefreshSubjectsList();
                txtSubject.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a subject to add.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGridViewSubjects.SelectedCells[0].RowIndex;
                Subject currentSubject = subjects[selectedIndex];

                string updatedSubjectName = txtSubject.Text.Trim();
                if (!string.IsNullOrEmpty(updatedSubjectName))
                {
                    currentSubject.Name = updatedSubjectName;
                    RefreshSubjectsList();
                    txtSubject.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a subject to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGridViewSubjects.SelectedCells[0].RowIndex;
                subjects.RemoveAt(selectedIndex);
                RefreshSubjectsList();
                txtSubject.Clear();
            }
            else
            {
                MessageBox.Show("Please select a subject to delete.");
            }
        }

        private void dataGridViewSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSubjects.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGridViewSubjects.SelectedCells[0].RowIndex;
                Subject selectedSubject = subjects[selectedIndex];
                txtSubject.Text = selectedSubject.Name;
            }
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
    public class Subject
    {
        public string Name { get; set; }

        public Subject(string name)
        {
            Name = name;
        }
    }
}