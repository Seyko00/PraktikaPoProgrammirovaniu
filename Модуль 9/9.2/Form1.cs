using System;
using System.Data;
using System.Windows.Forms;

namespace _9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Database.Initialize();
            LoadProjects();
            LoadEmployees();
            LoadTasks();
        }

        private void LoadProjects()
        {
            dataGridProjects.DataSource = Database.ExecuteQuery("SELECT * FROM Projects");
        }

        private void LoadEmployees()
        {
            dataGridEmployees.DataSource = Database.ExecuteQuery("SELECT * FROM Employees");
        }

        private void LoadTasks()
        {
            dataGridTasks.DataSource = Database.ExecuteQuery(
                "SELECT Tasks.Id, Tasks.Title, Tasks.Status, Projects.Name AS Project, Employees.FullName AS Employee " +
                "FROM Tasks LEFT JOIN Projects ON Tasks.ProjectId = Projects.Id " +
                "LEFT JOIN Employees ON Tasks.EmployeeId = Employees.Id");
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            string name = txtProjectName.Text;
            string desc = txtProjectDesc.Text;
            if (name == "") { MessageBox.Show("Введите название проекта!"); return; }

            string sql = "INSERT INTO Projects (Name, Description) VALUES ('" + name + "', '" + desc + "')";
            Database.ExecuteNonQuery(sql);
            LoadProjects();
            txtProjectName.Text = "";
            txtProjectDesc.Text = "";
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtEmployeeName.Text;
            string pos = txtEmployeePos.Text;
            if (name == "") { MessageBox.Show("Введите имя сотрудника!"); return; }

            string sql = "INSERT INTO Employees (FullName, Position) VALUES ('" + name + "', '" + pos + "')";
            Database.ExecuteNonQuery(sql);
            LoadEmployees();
            txtEmployeeName.Text = "";
            txtEmployeePos.Text = "";
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text;
            string status = cmbStatus.Text;
            int projId;
            int empId;

            if (!int.TryParse(txtProjectId.Text, out projId) || !int.TryParse(txtEmployeeId.Text, out empId))
            {
                MessageBox.Show("Введите корректные ID проекта и сотрудника!");
                return;
            }

            string sql = "INSERT INTO Tasks (Title, Status, ProjectId, EmployeeId) VALUES ('" + title + "', '" + status + "', " + projId + ", " + empId + ")";
            Database.ExecuteNonQuery(sql);
            LoadTasks();
            txtTaskTitle.Text = "";
            txtProjectId.Text = "";
            txtEmployeeId.Text = "";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataTable dt = Database.ExecuteQuery(
                "SELECT Projects.Name AS Project, COUNT(Tasks.Id) AS TotalTasks, " +
                "SUM(CASE WHEN Tasks.Status = 'Выполнено' THEN 1 ELSE 0 END) AS DoneTasks " +
                "FROM Projects LEFT JOIN Tasks ON Projects.Id = Tasks.ProjectId GROUP BY Projects.Name;");
            dataGridReport.DataSource = dt;
        }
    }
}
