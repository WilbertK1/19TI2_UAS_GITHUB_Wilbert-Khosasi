namespace Peminjaman_Perpustakaan
{
    partial class FormPengembalian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPengembalian));
            this.btnKembali = new System.Windows.Forms.Button();
            this.dgvCekPeminjaman = new System.Windows.Forms.DataGridView();
            this.btnCek = new System.Windows.Forms.Button();
            this.lblDataPengembalianBuku = new System.Windows.Forms.Label();
            this.btnResetData = new System.Windows.Forms.Button();
            this.txtIDMahasiswa = new System.Windows.Forms.TextBox();
            this.gbPilihan = new System.Windows.Forms.GroupBox();
            this.btnSebelumnya = new System.Windows.Forms.Button();
            this.lblNBBuku = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtPenulisBuku = new System.Windows.Forms.TextBox();
            this.lblPenulisBuku = new System.Windows.Forms.Label();
            this.txtNamaBuku = new System.Windows.Forms.TextBox();
            this.lblNamaBuku = new System.Windows.Forms.Label();
            this.txtNoSeriBuku = new System.Windows.Forms.TextBox();
            this.lblNomorSeriBuku = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblNB = new System.Windows.Forms.Label();
            this.TanggalPinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoIDMahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSeriBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenulisBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCekPeminjaman)).BeginInit();
            this.gbPilihan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.MintCream;
            this.btnKembali.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnKembali.Enabled = false;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(316, 35);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(190, 45);
            this.btnKembali.TabIndex = 10;
            this.btnKembali.Text = "Kembalikan Buku";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.UseWaitCursor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // dgvCekPeminjaman
            // 
            this.dgvCekPeminjaman.AllowUserToAddRows = false;
            this.dgvCekPeminjaman.AllowUserToDeleteRows = false;
            this.dgvCekPeminjaman.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCekPeminjaman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCekPeminjaman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCekPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCekPeminjaman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TanggalPinjam,
            this.NoIDMahasiswa,
            this.NoSeriBuku,
            this.NamaBuku,
            this.PenulisBuku});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCekPeminjaman.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCekPeminjaman.Location = new System.Drawing.Point(689, 132);
            this.dgvCekPeminjaman.Name = "dgvCekPeminjaman";
            this.dgvCekPeminjaman.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCekPeminjaman.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCekPeminjaman.Size = new System.Drawing.Size(582, 162);
            this.dgvCekPeminjaman.TabIndex = 39;
            this.dgvCekPeminjaman.UseWaitCursor = true;
            this.dgvCekPeminjaman.Visible = false;
            this.dgvCekPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCekBuku_CellClick);
            // 
            // btnCek
            // 
            this.btnCek.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCek.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCek.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCek.Location = new System.Drawing.Point(688, 83);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(583, 31);
            this.btnCek.TabIndex = 38;
            this.btnCek.Text = "TEKAN UNTUK MELIHAT DATA BUKU PEMINAJAMAN";
            this.btnCek.UseVisualStyleBackColor = false;
            this.btnCek.UseWaitCursor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // lblDataPengembalianBuku
            // 
            this.lblDataPengembalianBuku.AutoSize = true;
            this.lblDataPengembalianBuku.Font = new System.Drawing.Font("Vineta BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPengembalianBuku.Location = new System.Drawing.Point(341, 20);
            this.lblDataPengembalianBuku.Name = "lblDataPengembalianBuku";
            this.lblDataPengembalianBuku.Size = new System.Drawing.Size(659, 43);
            this.lblDataPengembalianBuku.TabIndex = 35;
            this.lblDataPengembalianBuku.Text = "Data Pengembalian Buku";
            this.lblDataPengembalianBuku.UseWaitCursor = true;
            // 
            // btnResetData
            // 
            this.btnResetData.BackColor = System.Drawing.Color.MintCream;
            this.btnResetData.Enabled = false;
            this.btnResetData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetData.Location = new System.Drawing.Point(0, 35);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(191, 45);
            this.btnResetData.TabIndex = 20;
            this.btnResetData.Text = "Reset Data";
            this.btnResetData.UseVisualStyleBackColor = false;
            this.btnResetData.UseWaitCursor = true;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // txtIDMahasiswa
            // 
            this.txtIDMahasiswa.BackColor = System.Drawing.Color.White;
            this.txtIDMahasiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMahasiswa.Location = new System.Drawing.Point(134, 80);
            this.txtIDMahasiswa.Name = "txtIDMahasiswa";
            this.txtIDMahasiswa.ReadOnly = true;
            this.txtIDMahasiswa.Size = new System.Drawing.Size(438, 26);
            this.txtIDMahasiswa.TabIndex = 43;
            this.txtIDMahasiswa.UseWaitCursor = true;
            // 
            // gbPilihan
            // 
            this.gbPilihan.Controls.Add(this.btnResetData);
            this.gbPilihan.Controls.Add(this.btnKembali);
            this.gbPilihan.Controls.Add(this.btnSebelumnya);
            this.gbPilihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPilihan.Location = new System.Drawing.Point(8, 356);
            this.gbPilihan.Name = "gbPilihan";
            this.gbPilihan.Size = new System.Drawing.Size(801, 116);
            this.gbPilihan.TabIndex = 40;
            this.gbPilihan.TabStop = false;
            this.gbPilihan.Text = "PILIHAN !!!";
            this.gbPilihan.UseWaitCursor = true;
            // 
            // btnSebelumnya
            // 
            this.btnSebelumnya.BackColor = System.Drawing.Color.MintCream;
            this.btnSebelumnya.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSebelumnya.Location = new System.Drawing.Point(611, 35);
            this.btnSebelumnya.Name = "btnSebelumnya";
            this.btnSebelumnya.Size = new System.Drawing.Size(190, 45);
            this.btnSebelumnya.TabIndex = 11;
            this.btnSebelumnya.Text = "Batal";
            this.btnSebelumnya.UseVisualStyleBackColor = false;
            this.btnSebelumnya.UseWaitCursor = true;
            this.btnSebelumnya.Click += new System.EventHandler(this.btnSebelumnya_Click);
            // 
            // lblNBBuku
            // 
            this.lblNBBuku.AutoSize = true;
            this.lblNBBuku.BackColor = System.Drawing.Color.Black;
            this.lblNBBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNBBuku.ForeColor = System.Drawing.Color.Red;
            this.lblNBBuku.Location = new System.Drawing.Point(131, 244);
            this.lblNBBuku.Name = "lblNBBuku";
            this.lblNBBuku.Size = new System.Drawing.Size(256, 16);
            this.lblNBBuku.TabIndex = 34;
            this.lblNBBuku.Text = "^ NB: 1x pengembalian untuk 1 buku";
            this.lblNBBuku.UseWaitCursor = true;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.BackColor = System.Drawing.Color.White;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(15, 83);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(113, 20);
            this.lblNama.TabIndex = 42;
            this.lblNama.Text = "ID Mahasiswa:";
            this.lblNama.UseWaitCursor = true;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Enabled = false;
            this.dtpTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Location = new System.Drawing.Point(134, 119);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(438, 26);
            this.dtpTanggal.TabIndex = 26;
            this.dtpTanggal.UseWaitCursor = true;
            // 
            // txtPenulisBuku
            // 
            this.txtPenulisBuku.BackColor = System.Drawing.Color.White;
            this.txtPenulisBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenulisBuku.Location = new System.Drawing.Point(134, 268);
            this.txtPenulisBuku.Name = "txtPenulisBuku";
            this.txtPenulisBuku.ReadOnly = true;
            this.txtPenulisBuku.Size = new System.Drawing.Size(438, 26);
            this.txtPenulisBuku.TabIndex = 32;
            this.txtPenulisBuku.UseWaitCursor = true;
            // 
            // lblPenulisBuku
            // 
            this.lblPenulisBuku.AutoSize = true;
            this.lblPenulisBuku.BackColor = System.Drawing.Color.White;
            this.lblPenulisBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenulisBuku.Location = new System.Drawing.Point(27, 271);
            this.lblPenulisBuku.Name = "lblPenulisBuku";
            this.lblPenulisBuku.Size = new System.Drawing.Size(105, 20);
            this.lblPenulisBuku.TabIndex = 31;
            this.lblPenulisBuku.Text = "Penulis Buku:";
            this.lblPenulisBuku.UseWaitCursor = true;
            // 
            // txtNamaBuku
            // 
            this.txtNamaBuku.BackColor = System.Drawing.Color.White;
            this.txtNamaBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaBuku.Location = new System.Drawing.Point(134, 209);
            this.txtNamaBuku.Name = "txtNamaBuku";
            this.txtNamaBuku.ReadOnly = true;
            this.txtNamaBuku.Size = new System.Drawing.Size(438, 26);
            this.txtNamaBuku.TabIndex = 30;
            this.txtNamaBuku.UseWaitCursor = true;
            // 
            // lblNamaBuku
            // 
            this.lblNamaBuku.AutoSize = true;
            this.lblNamaBuku.BackColor = System.Drawing.Color.White;
            this.lblNamaBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaBuku.Location = new System.Drawing.Point(36, 209);
            this.lblNamaBuku.Name = "lblNamaBuku";
            this.lblNamaBuku.Size = new System.Drawing.Size(96, 20);
            this.lblNamaBuku.TabIndex = 29;
            this.lblNamaBuku.Text = "Nama Buku:";
            this.lblNamaBuku.UseWaitCursor = true;
            // 
            // txtNoSeriBuku
            // 
            this.txtNoSeriBuku.BackColor = System.Drawing.Color.White;
            this.txtNoSeriBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoSeriBuku.Location = new System.Drawing.Point(134, 160);
            this.txtNoSeriBuku.Name = "txtNoSeriBuku";
            this.txtNoSeriBuku.ReadOnly = true;
            this.txtNoSeriBuku.Size = new System.Drawing.Size(438, 26);
            this.txtNoSeriBuku.TabIndex = 28;
            this.txtNoSeriBuku.UseWaitCursor = true;
            // 
            // lblNomorSeriBuku
            // 
            this.lblNomorSeriBuku.AutoSize = true;
            this.lblNomorSeriBuku.BackColor = System.Drawing.Color.White;
            this.lblNomorSeriBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomorSeriBuku.Location = new System.Drawing.Point(59, 160);
            this.lblNomorSeriBuku.Name = "lblNomorSeriBuku";
            this.lblNomorSeriBuku.Size = new System.Drawing.Size(69, 20);
            this.lblNomorSeriBuku.TabIndex = 27;
            this.lblNomorSeriBuku.Text = "No Seri :";
            this.lblNomorSeriBuku.UseWaitCursor = true;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.BackColor = System.Drawing.Color.White;
            this.lblTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(4, 119);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(124, 20);
            this.lblTanggal.TabIndex = 25;
            this.lblTanggal.Text = "Tanggal Hari Ini:";
            this.lblTanggal.UseWaitCursor = true;
            // 
            // lblNB
            // 
            this.lblNB.AutoSize = true;
            this.lblNB.BackColor = System.Drawing.Color.Black;
            this.lblNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNB.ForeColor = System.Drawing.Color.Red;
            this.lblNB.Location = new System.Drawing.Point(685, 303);
            this.lblNB.Name = "lblNB";
            this.lblNB.Size = new System.Drawing.Size(409, 40);
            this.lblNB.TabIndex = 44;
            this.lblNB.Text = "^Klik Tabel Diatas Sesuai Dengan ID Anda\r\nJika tidak sesuai maka datanya tidak ak" +
    "an muncul";
            this.lblNB.Visible = false;
            // 
            // TanggalPinjam
            // 
            this.TanggalPinjam.HeaderText = "Tanggal Pinjam";
            this.TanggalPinjam.Name = "TanggalPinjam";
            this.TanggalPinjam.ReadOnly = true;
            // 
            // NoIDMahasiswa
            // 
            this.NoIDMahasiswa.HeaderText = "ID Mahasiswa";
            this.NoIDMahasiswa.Name = "NoIDMahasiswa";
            this.NoIDMahasiswa.ReadOnly = true;
            // 
            // NoSeriBuku
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoSeriBuku.DefaultCellStyle = dataGridViewCellStyle2;
            this.NoSeriBuku.HeaderText = "No Seri Buku";
            this.NoSeriBuku.Name = "NoSeriBuku";
            this.NoSeriBuku.ReadOnly = true;
            // 
            // NamaBuku
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaBuku.DefaultCellStyle = dataGridViewCellStyle3;
            this.NamaBuku.HeaderText = "Nama Buku";
            this.NamaBuku.Name = "NamaBuku";
            this.NamaBuku.ReadOnly = true;
            // 
            // PenulisBuku
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenulisBuku.DefaultCellStyle = dataGridViewCellStyle4;
            this.PenulisBuku.HeaderText = "Penulis Buku";
            this.PenulisBuku.Name = "PenulisBuku";
            this.PenulisBuku.ReadOnly = true;
            // 
            // FormPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1294, 600);
            this.Controls.Add(this.lblNB);
            this.Controls.Add(this.dgvCekPeminjaman);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.lblDataPengembalianBuku);
            this.Controls.Add(this.txtIDMahasiswa);
            this.Controls.Add(this.gbPilihan);
            this.Controls.Add(this.lblNBBuku);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.txtPenulisBuku);
            this.Controls.Add(this.lblPenulisBuku);
            this.Controls.Add(this.txtNamaBuku);
            this.Controls.Add(this.lblNamaBuku);
            this.Controls.Add(this.txtNoSeriBuku);
            this.Controls.Add(this.lblNomorSeriBuku);
            this.Controls.Add(this.lblTanggal);
            this.Name = "FormPengembalian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPengembalian";
            this.Load += new System.EventHandler(this.FormPengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCekPeminjaman)).EndInit();
            this.gbPilihan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.DataGridView dgvCekPeminjaman;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Label lblDataPengembalianBuku;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.TextBox txtIDMahasiswa;
        private System.Windows.Forms.GroupBox gbPilihan;
        private System.Windows.Forms.Button btnSebelumnya;
        private System.Windows.Forms.Label lblNBBuku;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox txtPenulisBuku;
        private System.Windows.Forms.Label lblPenulisBuku;
        private System.Windows.Forms.TextBox txtNamaBuku;
        private System.Windows.Forms.Label lblNamaBuku;
        private System.Windows.Forms.TextBox txtNoSeriBuku;
        private System.Windows.Forms.Label lblNomorSeriBuku;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblNB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalPinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoIDMahasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSeriBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenulisBuku;
    }
}