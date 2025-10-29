namespace _9._2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProjects;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.DataGridView dataGridProjects;
        private System.Windows.Forms.DataGridView dataGridEmployees;
        private System.Windows.Forms.DataGridView dataGridTasks;
        private System.Windows.Forms.DataGridView dataGridReport;

        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectDesc;
        private System.Windows.Forms.Button btnAddProject;

        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeePos;
        private System.Windows.Forms.Button btnAddEmployee;

        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtProjectId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.tabTasks = new System.Windows.Forms.TabPage();

            this.dataGridProjects = new System.Windows.Forms.DataGridView();
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            this.dataGridTasks = new System.Windows.Forms.DataGridView();
            this.dataGridReport = new System.Windows.Forms.DataGridView();

            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectDesc = new System.Windows.Forms.TextBox();
            this.btnAddProject = new System.Windows.Forms.Button();

            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeePos = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();

            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReport)).BeginInit();
            this.SuspendLayout();

            // TabControl
            this.tabControl.Controls.Add(this.tabProjects);
            this.tabControl.Controls.Add(this.tabEmployees);
            this.tabControl.Controls.Add(this.tabTasks);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;

            // ==== TAB 1: PROJECTS ====
            this.tabProjects.Text = "Проекты";
            this.tabProjects.Controls.Add(this.dataGridProjects);
            this.tabProjects.Controls.Add(this.txtProjectName);
            this.tabProjects.Controls.Add(this.txtProjectDesc);
            this.tabProjects.Controls.Add(this.btnAddProject);

            this.dataGridProjects.Location = new System.Drawing.Point(10, 10);
            this.dataGridProjects.Size = new System.Drawing.Size(500, 300);

            this.txtProjectName.Location = new System.Drawing.Point(520, 20);
            this.txtProjectName.Width = 200;
            this.txtProjectName.Text = "Название проекта";

            this.txtProjectDesc.Location = new System.Drawing.Point(520, 60);
            this.txtProjectDesc.Width = 200;
            this.txtProjectDesc.Text = "Описание";

            this.btnAddProject.Location = new System.Drawing.Point(520, 100);
            this.btnAddProject.Text = "Добавить проект";
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);

            // ==== TAB 2: EMPLOYEES ====
            this.tabEmployees.Text = "Сотрудники";
            this.tabEmployees.Controls.Add(this.dataGridEmployees);
            this.tabEmployees.Controls.Add(this.txtEmployeeName);
            this.tabEmployees.Controls.Add(this.txtEmployeePos);
            this.tabEmployees.Controls.Add(this.btnAddEmployee);

            this.dataGridEmployees.Location = new System.Drawing.Point(10, 10);
            this.dataGridEmployees.Size = new System.Drawing.Size(500, 300);

            this.txtEmployeeName.Location = new System.Drawing.Point(520, 20);
            this.txtEmployeeName.Width = 200;
            this.txtEmployeeName.Text = "ФИО";

            this.txtEmployeePos.Location = new System.Drawing.Point(520, 60);
            this.txtEmployeePos.Width = 200;
            this.txtEmployeePos.Text = "Должность";

            this.btnAddEmployee.Location = new System.Drawing.Point(520, 100);
            this.btnAddEmployee.Text = "Добавить сотрудника";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);

            // ==== TAB 3: TASKS ====
            this.tabTasks.Text = "Задачи";
            this.tabTasks.Controls.Add(this.dataGridTasks);
            this.tabTasks.Controls.Add(this.txtTaskTitle);
            this.tabTasks.Controls.Add(this.cmbStatus);
            this.tabTasks.Controls.Add(this.txtProjectId);
            this.tabTasks.Controls.Add(this.txtEmployeeId);
            this.tabTasks.Controls.Add(this.btnAddTask);
            this.tabTasks.Controls.Add(this.dataGridReport);
            this.tabTasks.Controls.Add(this.btnReport);

            this.dataGridTasks.Location = new System.Drawing.Point(10, 10);
            this.dataGridTasks.Size = new System.Drawing.Size(500, 300);

            this.txtTaskTitle.Location = new System.Drawing.Point(520, 20);
            this.txtTaskTitle.Width = 200;
            this.txtTaskTitle.Text = "Название задачи";

            this.cmbStatus.Location = new System.Drawing.Point(520, 60);
            this.cmbStatus.Width = 200;
            this.cmbStatus.Items.AddRange(new string[] { "Новая", "В процессе", "Выполнено" });
            this.cmbStatus.SelectedIndex = 0;

            this.txtProjectId.Location = new System.Drawing.Point(520, 100);
            this.txtProjectId.Width = 200;
            this.txtProjectId.Text = "ID проекта";

            this.txtEmployeeId.Location = new System.Drawing.Point(520, 140);
            this.txtEmployeeId.Width = 200;
            this.txtEmployeeId.Text = "ID сотрудника";

            this.btnAddTask.Location = new System.Drawing.Point(520, 180);
            this.btnAddTask.Text = "Добавить задачу";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);

            this.btnReport.Location = new System.Drawing.Point(520, 230);
            this.btnReport.Text = "Отчёт по проектам";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);

            this.dataGridReport.Location = new System.Drawing.Point(10, 320);
            this.dataGridReport.Size = new System.Drawing.Size(750, 100);

            // ==== FORM ====
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Text = "Управление проектами";

            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
