using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace MyFirstCustomerProject
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection("Server=DESKTOP-9B3JVRI;initial Catalog=MyDbCustomer;integrated Security=true");

		private void Form2_Load(object sender, EventArgs e)
		{
			// TODO: Bu kod satırı 'myDbCustomerDataSet1.TblEmployee' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

			// TODO: Bu kod satırı 'myDbCustomerDataSet.TblEmployee' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


		}

		private void btnListele_Click(object sender, EventArgs e)
		{
			this.tblEmployeeTableAdapter1.Fill(this.myDbCustomerDataSet1.TblEmployee);
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("insert into TblEmployee (EmployeeName,EmployeeSurname,EmployeeCity,EmployeeSalary,DepartmentID) Values (@p1,@p2,@p3,@p4,@p5)", connection);
			command.Parameters.AddWithValue("@p1", txtEmployeeName.Text);
			command.Parameters.AddWithValue("@p2", txtEmployeeSurname.Text);
			command.Parameters.AddWithValue("@p3", txtCity.Text);
			command.Parameters.AddWithValue("@p4", txtSalary.Text);
			command.Parameters.AddWithValue("@p5", txtDepartmentID.Text);
			command.ExecuteNonQuery();
			MessageBox.Show("Departman başarılı bir şekilde Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

			connection.Close();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("Delete From TblEmployee Where EmployeeID=@p1", connection);
			command.Parameters.AddWithValue("@p1", txtEmployeeID.Text);
			command.ExecuteNonQuery();
			MessageBox.Show("Departman başarılı bir şekilde Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

			connection.Close();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("Update TblEmployee Set EmployeeName=@p1,EmployeeSurname=@p2,EmployeeCity=@p3,EmployeeSalary=@p4,DepartmentID=@p5 where EmployeeID=@p6", connection);
			command.Parameters.AddWithValue("@p1", txtEmployeeName.Text);
			command.Parameters.AddWithValue("@p2", txtEmployeeSurname.Text);
			command.Parameters.AddWithValue("@p3", txtCity.Text);
			command.Parameters.AddWithValue("@p4", txtSalary.Text);
			command.Parameters.AddWithValue("@p5", txtDepartmentID.Text);
			command.Parameters.AddWithValue("@p6", txtEmployeeID.Text);
			command.ExecuteNonQuery();
			MessageBox.Show("Departman başarılı bir şekilde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			connection.Close();
		}
	}
}
