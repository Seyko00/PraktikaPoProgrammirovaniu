using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Timers;

namespace _9._3
{
    public partial class Form1 : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private System.Timers.Timer deadlineTimer;

        public Form1()
        {
            InitializeComponent();
            LoadTasksToGrid();

            // Таймер для проверки сроков каждые 30 секунд
            deadlineTimer = new System.Timers.Timer(30000);
            deadlineTimer.Elapsed += CheckDeadlines;
            deadlineTimer.Start();
        }

        private void LoadTasksToGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Название");
            dt.Columns.Add("Описание");
            dt.Columns.Add("Приоритет");
            dt.Columns.Add("Дата выполнения");
            dt.Columns.Add("Статус");

            foreach (TaskItem t in tasks)
            {
                dt.Rows.Add(t.Title, t.Description, t.Priority, t.DueDate.ToShortDateString(), t.Status);
            }

            dataGridTasks.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Введите название задачи!");
                return;
            }

            TaskItem t = new TaskItem
            {
                Title = txtTitle.Text,
                Description = txtDesc.Text,
                Priority = cmbPriority.Text,
                DueDate = dateDue.Value,
                Status = cmbStatus.Text
            };

            tasks.Add(t);
            LoadTasksToGrid();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridTasks.CurrentRow == null) return;
            int index = dataGridTasks.CurrentRow.Index;
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                LoadTasksToGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridTasks.CurrentRow == null) return;
            int index = dataGridTasks.CurrentRow.Index;
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].Title = txtTitle.Text;
                tasks[index].Description = txtDesc.Text;
                tasks[index].Priority = cmbPriority.Text;
                tasks[index].Status = cmbStatus.Text;
                tasks[index].DueDate = dateDue.Value;
                LoadTasksToGrid();
            }
        }

        private void dataGridTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridTasks.CurrentRow == null) return;
            int index = dataGridTasks.CurrentRow.Index;
            if (index >= 0 && index < tasks.Count)
            {
                TaskItem t = tasks[index];
                txtTitle.Text = t.Title;
                txtDesc.Text = t.Description;
                cmbPriority.Text = t.Priority;
                cmbStatus.Text = t.Status;
                dateDue.Value = t.DueDate;
            }
        }

        private void ClearFields()
        {
            txtTitle.Text = "";
            txtDesc.Text = "";
            cmbPriority.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            dateDue.Value = DateTime.Now;
        }

        private void CheckDeadlines(object sender, ElapsedEventArgs e)
        {
            foreach (TaskItem t in tasks)
            {
                if (t.Status != "Выполнено" && (t.DueDate - DateTime.Now).TotalDays <= 1)
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        MessageBox.Show($"Срок задачи '{t.Title}' истекает завтра!", "Напоминание");
                    }));
                }
            }
        }
    }

    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
    }
}
