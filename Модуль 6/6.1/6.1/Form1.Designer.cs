namespace _6._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
		private void InitializeComponent()
		{
			this.dgvEmployees = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPosition = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.numSalary = new System.Windows.Forms.NumericUpDown();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSaveDb = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvEmployees
			// 
			this.dgvEmployees.AllowUserToAddRows = false;
			this.dgvEmployees.AllowUserToDeleteRows = false;
			this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			|	System.Windows.Forms.AnchorStyles.Left) 
			|	System.Windows.Forms.AnchorStyles.Right)));
			this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmployees.Location = new System.Drawing.Point(12, 12);
			this.dgvEmployees.MultiSelect = false;
			this.dgvEmployees.Name = "dgvEmployees";
			this.dgvEmployees.ReadOnly = true;
			this.dgvEmployees.RowHeadersVisible = false;
			this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEmployees.Size = new System.Drawing.Size(776, 240);
			this.dgvEmployees.TabIndex = 0;
			this.dgvEmployees.SelectionChanged += new System.EventHandler(this.dgvEmployees_SelectionChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 267);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "ФИО";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(90, 264);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(250, 20);
			this.txtName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 295);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Должность";
			// 
			// txtPosition
			// 
			this.txtPosition.Location = new System.Drawing.Point(90, 292);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(250, 20);
			this.txtPosition.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 323);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Отдел";
			// 
			// txtDepartment
			// 
			this.txtDepartment.Location = new System.Drawing.Point(90, 320);
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(250, 20);
			this.txtDepartment.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(361, 267);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Дата рождения";
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthDate.Location = new System.Drawing.Point(466, 264);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(120, 20);
			this.dtpBirthDate.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(361, 295);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Зарплата";
			// 
			// numSalary
			// 
			this.numSalary.DecimalPlaces = 2;
			this.numSalary.Increment = new decimal(new int[] {
				100,
				0,
				0,
				0});
			this.numSalary.Location = new System.Drawing.Point(466, 292);
			this.numSalary.Maximum = new decimal(new int[] {
				100000000,
				0,
				0,
				0});
			this.numSalary.Name = "numSalary";
			this.numSalary.Size = new System.Drawing.Size(120, 20);
			this.numSalary.TabIndex = 10;
			this.numSalary.ThousandsSeparator = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 360);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 30);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(118, 360);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(100, 30);
			this.btnUpdate.TabIndex = 12;
			this.btnUpdate.Text = "Изменить";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(224, 360);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 30);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSaveDb
			// 
			this.btnSaveDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveDb.Location = new System.Drawing.Point(688, 408);
			this.btnSaveDb.Name = "btnSaveDb";
			this.btnSaveDb.Size = new System.Drawing.Size(100, 30);
			this.btnSaveDb.TabIndex = 14;
			this.btnSaveDb.Text = "Сохранить";
			this.btnSaveDb.UseVisualStyleBackColor = true;
			this.btnSaveDb.Click += new System.EventHandler(this.btnSaveDb_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSaveDb);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.numSalary);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpBirthDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDepartment);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPosition);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvEmployees);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Учет сотрудников";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.DataGridView dgvEmployees;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPosition;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDepartment;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numSalary;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSaveDb;
    }
}

