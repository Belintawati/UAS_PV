/*
 * Created by SharpDevelop.
 * User: Belintawati Zelda
 * Date: 09/06/2022
 * Time: 12:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProgramUAS_PV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = ratarata; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from data_mhs";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"data_mhs") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_mhs";
				}
				else {
					MessageBox.Show("Data tabel sedang kosong");
				}
			}
			catch (Exception ex){
				MessageBox.Show("Data tidak dapat dimasukkan");
				MessageBox.Show(ex.ToString());
			}
		}
		public void CariData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from data_mhs where Id like '%"+cari.Text+"%' or Nama like '%"+cari.Text+"%'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds,"data_mhs") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_mhs";
				}
				else {
					MessageBox.Show("Data tabel tidak ditemukan");
				}
			}
			catch (Exception ex){
				MessageBox.Show("Data tidak dapat dimasukkan");
				MessageBox.Show(ex.ToString());
				}
		}
		public void Bersihkan(){
			id.Text= Convert.ToString(incrementValueId());
			nama.Text="";
			nim.Text="";
			tanggal.Text="";
			jk.Text="";
			alamat.Text="";
			jumlah.Text="";
			total.Text="";
			rata.Text="";
			ReadData();
			}
		void MunculJk()
		{
			jk.Items.Add("PRIA");
			jk.Items.Add("WANITA");
		}
		public MainForm()
		{
			InitializeComponent();
			co.Open();
			ReadData();
			Bersihkan();
			MunculJk();
		}			
	/* TOMBOL SIMPAN */
		void SimpanClick(object sender, EventArgs e)
		{
			// Memeriksa apakah kolom text kosong?
			if (id.Text.Trim() == "" || nama.Text.Trim() == "" || nim.Text.Trim() == "" || tanggal.Text.Trim() == "" || jk.Text.Trim() == "" || alamat.Text.Trim() == "" || jumlah.Text.Trim() == "" || total.Text.Trim() == "" || rata.Text.Trim() == "")
			{
				MessageBox.Show("Mohon isikan dahulu kolom-kolom yang tersedia");
			}
			else
			{
				/* insert data */
				try{
					mycommand.Connection=co;
					mycommand.CommandText="insert into data_mhs values('"+id.Text+"','"+nama.Text+"','"+nim.Text+"','"+tanggal.Text+"','"+jk.Text+"','"+alamat.Text+"','"+jumlah.Text+"','"+total.Text+"','"+rata.Text+"')";
					myadapter.SelectCommand= mycommand;
					if (mycommand.ExecuteNonQuery()==1){
						MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						ReadData();
						Bersihkan();
					}
				}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				nama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				nim.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
				tanggal.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
				jk.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
				alamat.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
				jumlah.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
				total.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
				rata.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		/* TOMBOL UBAH */
		void UbahClick(object sender, EventArgs e)
		{
			// Memeriksa apakah kolom text kosong?
			if (id.Text.Trim() == "" || nama.Text.Trim() == "" || nim.Text.Trim() == "" || tanggal.Text.Trim() == "" || jk.Text.Trim() == "" || alamat.Text.Trim() == "" || jumlah.Text.Trim() == "" || total.Text.Trim() == "" || rata.Text.Trim() == "")
			{
				MessageBox.Show("Mohon isikan dahulu kolom-kolom yang tersedia");
			}
			else
			{
				/* update data */
				try{
					mycommand.Connection=co;
					mycommand.CommandText="update data_mhs set Id='"+id.Text+"', Nama='"+nama.Text+"', Nim='"+nim.Text+"', TanggalLahir='"+tanggal.Text+"', JenisKelamin='"+jk.Text+"', Alamat='"+alamat.Text+"', JlhSKS='"+jumlah.Text+"', TotalNilai='"+total.Text+"', Rata='"+rata.Text+"' where Id='"+id.Text+"'";
					myadapter.SelectCommand= mycommand;
					if (mycommand.ExecuteNonQuery()==1){
						MessageBox.Show("Update data berhasil","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						ReadData();
						Bersihkan();
					}
				}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		/* TOMBOL HAPUS */
		void HapusClick(object sender, EventArgs e)
		{
			// Memeriksa apakah yakin menghapus?
			if(MessageBox.Show(nama.Text+" Yakin ingin dihapus ?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				mycommand.Connection=co;
				mycommand.CommandText="delete from data_mhs where Id='"+id.Text+"'";
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					Bersihkan();
			}
		}
		}
		private int incrementValueId(){
			int temp = 0;
			try{
				MySqlConnection db = new MySqlConnection("Server = localhost; Database = ratarata; Uid = root;");
				db.Open();
				MySqlCommand dbcmd = db.CreateCommand();
				string sql = "select max(Id) from data_mhs";
				dbcmd.CommandText = sql;
				MySqlDataReader reader = dbcmd.ExecuteReader();
				while(reader.Read()){
					if(!reader.IsDBNull(0)){
						return Convert.ToInt16(reader.GetString(0))+ 1;
					}
				}
				return 0;
			}
			catch(MySqlException error){
				MessageBox.Show(error.ToString());
				return 0;
			}
		}
		
		void HitungClick(object sender, EventArgs e)
		{
			float total_nilai = float.Parse(total.Text);
			float jumlahsks = float.Parse(jumlah.Text);
			float rata2 = total_nilai / jumlahsks;
			rata.Text = rata2.ToString();
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			CariData();
		}
		
		void RefreshClick(object sender, EventArgs e)
		{
			Bersihkan();
		}
		
		void NimKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar)&& e.KeyChar != (char) Keys.Back;
		}
	}
}
