using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCustomerProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection("Server=DESKTOP-9B3JVRI;initial Catalog=MyDbCustomer;integrated Security=true");

		private void btnListele_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Select * From TblDepartment", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			if(rdbActive.Checked || rdbPassive.Checked) { 
			connection.Open();
			SqlCommand command = new SqlCommand("insert into TblDepartment (DepartmentName,DepartmentStatus) Values (@p1,@p2)", connection);
			command.Parameters.AddWithValue("@p1", txtName.Text);
			if (rdbActive.Checked)
			{
				command.Parameters.AddWithValue("@p2", "True");
			}
			if (rdbPassive.Checked)
			{
				command.Parameters.AddWithValue("@p2", "False");
			}
			command.ExecuteNonQuery();
			MessageBox.Show("Departman başarılı bir şekilde Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			connection.Close();
			}
			else
			{
				MessageBox.Show("Lütfen Bir Durum Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if(txtCategoryID.Text != "")
			{
				connection.Open();
				SqlCommand command = new SqlCommand("Delete From TblDepartment Where DepartmentID=@p1", connection);
				command.Parameters.AddWithValue("@p1",txtCategoryID.Text);
				command.ExecuteNonQuery();
				MessageBox.Show("Departman başarılı bir şekilde Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				connection.Close();
			}
			else
			{
				MessageBox.Show("Lütfen ID alanını boş geçmeyin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("Update TblDepartment Set DepartmentName=@p1 where DepartmentID=@p2", connection);
			command.Parameters.AddWithValue("@p1", txtName.Text);
			command.Parameters.AddWithValue("@p2", txtCategoryID.Text);
			command.ExecuteNonQuery();
			MessageBox.Show("Departman başarılı bir şekilde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			connection.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 frm = new Form2();
			frm.ShowDialog();
		}
	}
}
