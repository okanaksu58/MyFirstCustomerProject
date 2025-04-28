namespace MyFirstCustomerProject
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.myDbCustomerDataSet = new MyFirstCustomerProject.MyDbCustomerDataSet();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnListele = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEmployeeID = new System.Windows.Forms.TextBox();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtSalary = new System.Windows.Forms.TextBox();
			this.txtDepartmentID = new System.Windows.Forms.TextBox();
			this.tblEmployeeTableAdapter = new MyFirstCustomerProject.MyDbCustomerDataSetTableAdapters.TblEmployeeTableAdapter();
			this.myDbCustomerDataSet1 = new MyFirstCustomerProject.MyDbCustomerDataSet1();
			this.tblEmployeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tblEmployeeTableAdapter1 = new MyFirstCustomerProject.MyDbCustomerDataSet1TableAdapters.TblEmployeeTableAdapter();
			this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myDbCustomerDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myDbCustomerDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeSurnameDataGridViewTextBoxColumn,
            this.employeeCityDataGridViewTextBoxColumn,
            this.employeeSalaryDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.tblEmployeeBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(140, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(643, 236);
			this.dataGridView1.TabIndex = 0;
			// 
			// tblEmployeeBindingSource
			// 
			this.tblEmployeeBindingSource.DataMember = "TblEmployee";
			this.tblEmployeeBindingSource.DataSource = this.myDbCustomerDataSet;
			// 
			// myDbCustomerDataSet
			// 
			this.myDbCustomerDataSet.DataSetName = "MyDbCustomerDataSet";
			this.myDbCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnEkle
			// 
			this.btnEkle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnEkle.Location = new System.Drawing.Point(12, 12);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(118, 39);
			this.btnEkle.TabIndex = 1;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.Location = new System.Drawing.Point(12, 76);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(118, 39);
			this.btnSil.TabIndex = 2;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Location = new System.Drawing.Point(12, 139);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(118, 39);
			this.btnGuncelle.TabIndex = 3;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnListele
			// 
			this.btnListele.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnListele.Location = new System.Drawing.Point(12, 209);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(118, 39);
			this.btnListele.TabIndex = 4;
			this.btnListele.Text = "Listele";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(62, 272);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "EmployeeID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(33, 311);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Employee Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(12, 351);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 19);
			this.label3.TabIndex = 7;
			this.label3.Text = "Employee Surname:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(48, 390);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 19);
			this.label4.TabIndex = 8;
			this.label4.Text = "Employee City:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(32, 430);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 19);
			this.label5.TabIndex = 9;
			this.label5.Text = "Employee Salary:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(43, 471);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(117, 19);
			this.label6.TabIndex = 10;
			this.label6.Text = "Department ID:";
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.Location = new System.Drawing.Point(189, 270);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.Size = new System.Drawing.Size(149, 20);
			this.txtEmployeeID.TabIndex = 11;
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Location = new System.Drawing.Point(189, 310);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(149, 20);
			this.txtEmployeeName.TabIndex = 12;
			// 
			// txtEmployeeSurname
			// 
			this.txtEmployeeSurname.Location = new System.Drawing.Point(189, 352);
			this.txtEmployeeSurname.Name = "txtEmployeeSurname";
			this.txtEmployeeSurname.Size = new System.Drawing.Size(149, 20);
			this.txtEmployeeSurname.TabIndex = 13;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(189, 391);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(149, 20);
			this.txtCity.TabIndex = 14;
			// 
			// txtSalary
			// 
			this.txtSalary.Location = new System.Drawing.Point(189, 431);
			this.txtSalary.Name = "txtSalary";
			this.txtSalary.Size = new System.Drawing.Size(149, 20);
			this.txtSalary.TabIndex = 15;
			// 
			// txtDepartmentID
			// 
			this.txtDepartmentID.Location = new System.Drawing.Point(189, 472);
			this.txtDepartmentID.Name = "txtDepartmentID";
			this.txtDepartmentID.Size = new System.Drawing.Size(149, 20);
			this.txtDepartmentID.TabIndex = 16;
			// 
			// tblEmployeeTableAdapter
			// 
			this.tblEmployeeTableAdapter.ClearBeforeFill = true;
			// 
			// myDbCustomerDataSet1
			// 
			this.myDbCustomerDataSet1.DataSetName = "MyDbCustomerDataSet1";
			this.myDbCustomerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblEmployeeBindingSource1
			// 
			this.tblEmployeeBindingSource1.DataMember = "TblEmployee";
			this.tblEmployeeBindingSource1.DataSource = this.myDbCustomerDataSet1;
			// 
			// tblEmployeeTableAdapter1
			// 
			this.tblEmployeeTableAdapter1.ClearBeforeFill = true;
			// 
			// employeeIDDataGridViewTextBoxColumn
			// 
			this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
			this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
			this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
			this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// employeeNameDataGridViewTextBoxColumn
			// 
			this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
			this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
			this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
			// 
			// employeeSurnameDataGridViewTextBoxColumn
			// 
			this.employeeSurnameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeSurname";
			this.employeeSurnameDataGridViewTextBoxColumn.HeaderText = "EmployeeSurname";
			this.employeeSurnameDataGridViewTextBoxColumn.Name = "employeeSurnameDataGridViewTextBoxColumn";
			// 
			// employeeCityDataGridViewTextBoxColumn
			// 
			this.employeeCityDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCity";
			this.employeeCityDataGridViewTextBoxColumn.HeaderText = "EmployeeCity";
			this.employeeCityDataGridViewTextBoxColumn.Name = "employeeCityDataGridViewTextBoxColumn";
			// 
			// employeeSalaryDataGridViewTextBoxColumn
			// 
			this.employeeSalaryDataGridViewTextBoxColumn.DataPropertyName = "EmployeeSalary";
			this.employeeSalaryDataGridViewTextBoxColumn.HeaderText = "EmployeeSalary";
			this.employeeSalaryDataGridViewTextBoxColumn.Name = "employeeSalaryDataGridViewTextBoxColumn";
			// 
			// departmentIDDataGridViewTextBoxColumn
			// 
			this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
			this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
			this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 524);
			this.Controls.Add(this.txtDepartmentID);
			this.Controls.Add(this.txtSalary);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtEmployeeSurname);
			this.Controls.Add(this.txtEmployeeName);
			this.Controls.Add(this.txtEmployeeID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnListele);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form2";
			this.Text = "FrmEmployee";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myDbCustomerDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myDbCustomerDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnListele;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtEmployeeID;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.TextBox txtEmployeeSurname;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtSalary;
		private System.Windows.Forms.TextBox txtDepartmentID;
		private MyDbCustomerDataSet myDbCustomerDataSet;
		private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
		private MyDbCustomerDataSetTableAdapters.TblEmployeeTableAdapter tblEmployeeTableAdapter;
		private MyDbCustomerDataSet1 myDbCustomerDataSet1;
		private System.Windows.Forms.BindingSource tblEmployeeBindingSource1;
		private MyDbCustomerDataSet1TableAdapters.TblEmployeeTableAdapter tblEmployeeTableAdapter1;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeSurnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeSalaryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
	}
}