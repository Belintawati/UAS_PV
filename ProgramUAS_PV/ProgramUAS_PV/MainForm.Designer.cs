/*
 * Created by SharpDevelop.
 * User: Belintawati Zelda
 * Date: 09/06/2022
 * Time: 12:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProgramUAS_PV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.TextBox();
			this.nama = new System.Windows.Forms.TextBox();
			this.nim = new System.Windows.Forms.TextBox();
			this.tanggal = new System.Windows.Forms.TextBox();
			this.alamat = new System.Windows.Forms.TextBox();
			this.jumlah = new System.Windows.Forms.TextBox();
			this.total = new System.Windows.Forms.TextBox();
			this.rata = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.simpan = new System.Windows.Forms.Button();
			this.ubah = new System.Windows.Forms.Button();
			this.hapus = new System.Windows.Forms.Button();
			this.hitung = new System.Windows.Forms.Button();
			this.jk = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cari = new System.Windows.Forms.TextBox();
			this.refresh = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.LemonChiffon;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.LemonChiffon;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.LemonChiffon;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nim";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.LemonChiffon;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 262);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tanggal Lahir";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.LemonChiffon;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 335);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Jenis Kelamin";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.LemonChiffon;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 403);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(148, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Alamat";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.LemonChiffon;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 466);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Jumlah SKS Diambil";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.LemonChiffon;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 531);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(148, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "Total Nilai";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.LemonChiffon;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 600);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(148, 23);
			this.label9.TabIndex = 8;
			this.label9.Text = "Rata-Rata";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Bisque;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(12, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(1392, 51);
			this.label10.TabIndex = 9;
			this.label10.Text = "Rata-Rata Nilai Mahasiswa";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// id
			// 
			this.id.BackColor = System.Drawing.Color.LightSalmon;
			this.id.Location = new System.Drawing.Point(263, 70);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(305, 26);
			this.id.TabIndex = 10;
			// 
			// nama
			// 
			this.nama.BackColor = System.Drawing.Color.LightSalmon;
			this.nama.Location = new System.Drawing.Point(263, 124);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(305, 26);
			this.nama.TabIndex = 11;
			// 
			// nim
			// 
			this.nim.BackColor = System.Drawing.Color.LightSalmon;
			this.nim.Location = new System.Drawing.Point(263, 190);
			this.nim.Name = "nim";
			this.nim.Size = new System.Drawing.Size(305, 26);
			this.nim.TabIndex = 12;
			this.nim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NimKeyPress);
			// 
			// tanggal
			// 
			this.tanggal.BackColor = System.Drawing.Color.LightSalmon;
			this.tanggal.Location = new System.Drawing.Point(263, 259);
			this.tanggal.Name = "tanggal";
			this.tanggal.Size = new System.Drawing.Size(305, 26);
			this.tanggal.TabIndex = 13;
			// 
			// alamat
			// 
			this.alamat.BackColor = System.Drawing.Color.LightSalmon;
			this.alamat.Location = new System.Drawing.Point(263, 400);
			this.alamat.Name = "alamat";
			this.alamat.Size = new System.Drawing.Size(305, 26);
			this.alamat.TabIndex = 14;
			// 
			// jumlah
			// 
			this.jumlah.BackColor = System.Drawing.Color.LightSalmon;
			this.jumlah.Location = new System.Drawing.Point(263, 463);
			this.jumlah.Name = "jumlah";
			this.jumlah.Size = new System.Drawing.Size(305, 26);
			this.jumlah.TabIndex = 15;
			// 
			// total
			// 
			this.total.BackColor = System.Drawing.Color.LightSalmon;
			this.total.Location = new System.Drawing.Point(263, 528);
			this.total.Name = "total";
			this.total.Size = new System.Drawing.Size(305, 26);
			this.total.TabIndex = 16;
			// 
			// rata
			// 
			this.rata.BackColor = System.Drawing.Color.LightSalmon;
			this.rata.Location = new System.Drawing.Point(263, 597);
			this.rata.Name = "rata";
			this.rata.Size = new System.Drawing.Size(305, 26);
			this.rata.TabIndex = 17;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 666);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1392, 310);
			this.dataGridView1.TabIndex = 20;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// simpan
			// 
			this.simpan.BackColor = System.Drawing.Color.PeachPuff;
			this.simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpan.Location = new System.Drawing.Point(735, 216);
			this.simpan.Name = "simpan";
			this.simpan.Size = new System.Drawing.Size(129, 38);
			this.simpan.TabIndex = 21;
			this.simpan.Text = "SIMPAN";
			this.simpan.UseVisualStyleBackColor = false;
			this.simpan.Click += new System.EventHandler(this.SimpanClick);
			// 
			// ubah
			// 
			this.ubah.BackColor = System.Drawing.Color.PeachPuff;
			this.ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ubah.Location = new System.Drawing.Point(735, 304);
			this.ubah.Name = "ubah";
			this.ubah.Size = new System.Drawing.Size(129, 38);
			this.ubah.TabIndex = 22;
			this.ubah.Text = "UBAH";
			this.ubah.UseVisualStyleBackColor = false;
			this.ubah.Click += new System.EventHandler(this.UbahClick);
			// 
			// hapus
			// 
			this.hapus.BackColor = System.Drawing.Color.PeachPuff;
			this.hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hapus.Location = new System.Drawing.Point(735, 400);
			this.hapus.Name = "hapus";
			this.hapus.Size = new System.Drawing.Size(129, 38);
			this.hapus.TabIndex = 23;
			this.hapus.Text = "HAPUS";
			this.hapus.UseVisualStyleBackColor = false;
			this.hapus.Click += new System.EventHandler(this.HapusClick);
			// 
			// hitung
			// 
			this.hitung.BackColor = System.Drawing.Color.PeachPuff;
			this.hitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hitung.Location = new System.Drawing.Point(735, 496);
			this.hitung.Name = "hitung";
			this.hitung.Size = new System.Drawing.Size(129, 38);
			this.hitung.TabIndex = 24;
			this.hitung.Text = "HITUNG";
			this.hitung.UseVisualStyleBackColor = false;
			this.hitung.Click += new System.EventHandler(this.HitungClick);
			// 
			// jk
			// 
			this.jk.BackColor = System.Drawing.Color.LightSalmon;
			this.jk.FormattingEnabled = true;
			this.jk.Location = new System.Drawing.Point(263, 332);
			this.jk.Name = "jk";
			this.jk.Size = new System.Drawing.Size(121, 28);
			this.jk.TabIndex = 25;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.cari);
			this.groupBox1.Location = new System.Drawing.Point(603, 103);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(385, 67);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cari Data";
			// 
			// cari
			// 
			this.cari.BackColor = System.Drawing.Color.PeachPuff;
			this.cari.Location = new System.Drawing.Point(6, 25);
			this.cari.Name = "cari";
			this.cari.Size = new System.Drawing.Size(373, 26);
			this.cari.TabIndex = 0;
			this.cari.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// refresh
			// 
			this.refresh.BackColor = System.Drawing.Color.PeachPuff;
			this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refresh.Location = new System.Drawing.Point(735, 585);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(129, 38);
			this.refresh.TabIndex = 27;
			this.refresh.Text = "REFRESH";
			this.refresh.UseVisualStyleBackColor = false;
			this.refresh.Click += new System.EventHandler(this.RefreshClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(1416, 988);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.jk);
			this.Controls.Add(this.hitung);
			this.Controls.Add(this.hapus);
			this.Controls.Add(this.ubah);
			this.Controls.Add(this.simpan);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.rata);
			this.Controls.Add(this.total);
			this.Controls.Add(this.jumlah);
			this.Controls.Add(this.alamat);
			this.Controls.Add(this.tanggal);
			this.Controls.Add(this.nim);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.id);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "ProgramUAS_PV";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.TextBox cari;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox jk;
		private System.Windows.Forms.Button hitung;
		private System.Windows.Forms.Button hapus;
		private System.Windows.Forms.Button ubah;
		private System.Windows.Forms.Button simpan;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox rata;
		private System.Windows.Forms.TextBox total;
		private System.Windows.Forms.TextBox jumlah;
		private System.Windows.Forms.TextBox alamat;
		private System.Windows.Forms.TextBox tanggal;
		private System.Windows.Forms.TextBox nim;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox id;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
