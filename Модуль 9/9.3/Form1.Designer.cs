namespace _9._3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridTasks;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dateDue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridTasks = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dateDue = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTasks
            // 
            this.dataGridTasks.ColumnHeadersHeight = 29;
            this.dataGridTasks.Location = new System.Drawing.Point(10, 10);
            this.dataGridTasks.MultiSelect = false;
            this.dataGridTasks.Name = "dataGridTasks";
            this.dataGridTasks.RowHeadersWidth = 51;
            this.dataGridTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTasks.Size = new System.Drawing.Size(500, 300);
            this.dataGridTasks.TabIndex = 0;
            this.dataGridTasks.SelectionChanged += new System.EventHandler(this.dataGridTasks_SelectionChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(530, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(240, 22);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Название задачи";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(530, 60);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(240, 60);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.Text = "Описание";
            // 
            // cmbPriority
            // 
            this.cmbPriority.Items.AddRange(new object[] {
            "Низкий",
            "Средний",
            "Высокий"});
            this.cmbPriority.Location = new System.Drawing.Point(530, 140);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(240, 24);
            this.cmbPriority.TabIndex = 3;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Items.AddRange(new object[] {
            "Новая",
            "В процессе",
            "Выполнено"});
            this.cmbStatus.Location = new System.Drawing.Point(530, 180);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(240, 24);
            this.cmbStatus.TabIndex = 4;
            // 
            // dateDue
            // 
            this.dateDue.Location = new System.Drawing.Point(530, 220);
            this.dateDue.Name = "dateDue";
            this.dateDue.Size = new System.Drawing.Size(240, 22);
            this.dateDue.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(530, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(630, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(730, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.dataGridTasks);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dateDue);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form1";
            this.Text = "Управление задачами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
