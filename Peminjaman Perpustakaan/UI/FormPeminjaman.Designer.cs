namespace Peminjaman_Perpustakaan
{
    partial class FormPeminjaman
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPeminjaman));
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblNomorSeriBuku = new System.Windows.Forms.Label();
            this.txtNoSeriBuku = new System.Windows.Forms.TextBox();
            this.lblNamaBuku = new System.Windows.Forms.Label();
            this.txtNamaBuku = new System.Windows.Forms.TextBox();
            this.txtPenulisBuku = new System.Windows.Forms.TextBox();
            this.lblPenulisBuku = new System.Windows.Forms.Label();
            this.dgvPeminjaman = new System.Windows.Forms.DataGridView();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Seri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_Buku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penulis_Buku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTambahData = new System.Windows.Forms.Button();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapusData = new System.Windows.Forms.Button();
            this.lblNBBuku = new System.Windows.Forms.Label();
            this.lblDataTransaksi = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.dgvCekBuku = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenulisBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResetList = new System.Windows.Forms.Button();
            this.gbPilihan = new System.Windows.Forms.GroupBox();
            this.lblNBSeri = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtIDMahasiswa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCekBuku)).BeginInit();
            this.gbPilihan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.BackColor = System.Drawing.Color.White;
            this.lblTanggal.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(2, 108);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(129, 18);
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "Tanggal Hari Ini:";
            this.lblTanggal.UseWaitCursor = true;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Location = new System.Drawing.Point(149, 108);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(438, 25);
            this.dtpTanggal.TabIndex = 1;
            this.dtpTanggal.UseWaitCursor = true;
            // 
            // lblNomorSeriBuku
            // 
            this.lblNomorSeriBuku.AutoSize = true;
            this.lblNomorSeriBuku.BackColor = System.Drawing.Color.White;
            this.lblNomorSeriBuku.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomorSeriBuku.Location = new System.Drawing.Point(25, 154);
            this.lblNomorSeriBuku.Name = "lblNomorSeriBuku";
            this.lblNomorSeriBuku.Size = new System.Drawing.Size(106, 18);
            this.lblNomorSeriBuku.TabIndex = 2;
            this.lblNomorSeriBuku.Text = "No Seri Buku:";
            this.lblNomorSeriBuku.UseWaitCursor = true;
            // 
            // txtNoSeriBuku
            // 
            this.txtNoSeriBuku.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoSeriBuku.Location = new System.Drawing.Point(149, 149);
            this.txtNoSeriBuku.Name = "txtNoSeriBuku";
            this.txtNoSeriBuku.Size = new System.Drawing.Size(438, 25);
            this.txtNoSeriBuku.TabIndex = 3;
            this.txtNoSeriBuku.UseWaitCursor = true;
            this.txtNoSeriBuku.TextChanged += new System.EventHandler(this.txtNoSeriBuku_TextChanged);
            this.txtNoSeriBuku.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNoSeriBuku_KeyUp);
            // 
            // lblNamaBuku
            // 
            this.lblNamaBuku.AutoSize = true;
            this.lblNamaBuku.BackColor = System.Drawing.Color.White;
            this.lblNamaBuku.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaBuku.Location = new System.Drawing.Point(33, 204);
            this.lblNamaBuku.Name = "lblNamaBuku";
            this.lblNamaBuku.Size = new System.Drawing.Size(98, 18);
            this.lblNamaBuku.TabIndex = 4;
            this.lblNamaBuku.Text = "Nama Buku:";
            this.lblNamaBuku.UseWaitCursor = true;
            // 
            // txtNamaBuku
            // 
            this.txtNamaBuku.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaBuku.Location = new System.Drawing.Point(149, 204);
            this.txtNamaBuku.Name = "txtNamaBuku";
            this.txtNamaBuku.ReadOnly = true;
            this.txtNamaBuku.Size = new System.Drawing.Size(438, 25);
            this.txtNamaBuku.TabIndex = 5;
            this.txtNamaBuku.UseWaitCursor = true;
            // 
            // txtPenulisBuku
            // 
            this.txtPenulisBuku.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenulisBuku.Location = new System.Drawing.Point(149, 257);
            this.txtPenulisBuku.Name = "txtPenulisBuku";
            this.txtPenulisBuku.ReadOnly = true;
            this.txtPenulisBuku.Size = new System.Drawing.Size(438, 25);
            this.txtPenulisBuku.TabIndex = 7;
            this.txtPenulisBuku.UseWaitCursor = true;
            // 
            // lblPenulisBuku
            // 
            this.lblPenulisBuku.AutoSize = true;
            this.lblPenulisBuku.BackColor = System.Drawing.Color.White;
            this.lblPenulisBuku.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenulisBuku.Location = new System.Drawing.Point(26, 262);
            this.lblPenulisBuku.Name = "lblPenulisBuku";
            this.lblPenulisBuku.Size = new System.Drawing.Size(105, 18);
            this.lblPenulisBuku.TabIndex = 6;
            this.lblPenulisBuku.Text = "Penulis Buku:";
            this.lblPenulisBuku.UseWaitCursor = true;
            // 
            // dgvPeminjaman
            // 
            this.dgvPeminjaman.AllowUserToAddRows = false;
            this.dgvPeminjaman.AllowUserToDeleteRows = false;
            this.dgvPeminjaman.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPeminjaman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeminjaman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeminjaman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tanggal,
            this.No_Seri,
            this.Nama_Buku,
            this.Penulis_Buku,
            this.JumlahBuku});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeminjaman.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPeminjaman.Location = new System.Drawing.Point(5, 313);
            this.dgvPeminjaman.Name = "dgvPeminjaman";
            this.dgvPeminjaman.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeminjaman.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPeminjaman.Size = new System.Drawing.Size(620, 186);
            this.dgvPeminjaman.TabIndex = 8;
            this.dgvPeminjaman.UseWaitCursor = true;
            this.dgvPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeminjaman_CellClick);
            this.dgvPeminjaman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeminjaman_CellContentClick);
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal Peminjaman";
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.ReadOnly = true;
            // 
            // No_Seri
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Seri.DefaultCellStyle = dataGridViewCellStyle2;
            this.No_Seri.HeaderText = "No Seri";
            this.No_Seri.Name = "No_Seri";
            this.No_Seri.ReadOnly = true;
            // 
            // Nama_Buku
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama_Buku.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nama_Buku.HeaderText = "Nama Buku";
            this.Nama_Buku.Name = "Nama_Buku";
            this.Nama_Buku.ReadOnly = true;
            // 
            // Penulis_Buku
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penulis_Buku.DefaultCellStyle = dataGridViewCellStyle4;
            this.Penulis_Buku.HeaderText = "Penulis Buku";
            this.Penulis_Buku.Name = "Penulis_Buku";
            this.Penulis_Buku.ReadOnly = true;
            // 
            // JumlahBuku
            // 
            this.JumlahBuku.HeaderText = "Jumlah Buku";
            this.JumlahBuku.Name = "JumlahBuku";
            this.JumlahBuku.ReadOnly = true;
            // 
            // btnTambahData
            // 
            this.btnTambahData.BackColor = System.Drawing.Color.MintCream;
            this.btnTambahData.Enabled = false;
            this.btnTambahData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahData.Location = new System.Drawing.Point(-1, 25);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(191, 45);
            this.btnTambahData.TabIndex = 9;
            this.btnTambahData.Text = "Tambah Data";
            this.btnTambahData.UseVisualStyleBackColor = false;
            this.btnTambahData.UseWaitCursor = true;
            this.btnTambahData.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnPinjam
            // 
            this.btnPinjam.BackColor = System.Drawing.Color.MintCream;
            this.btnPinjam.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnPinjam.Enabled = false;
            this.btnPinjam.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPinjam.Location = new System.Drawing.Point(199, 213);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(190, 45);
            this.btnPinjam.TabIndex = 10;
            this.btnPinjam.Text = "Pinjam Buku";
            this.btnPinjam.UseVisualStyleBackColor = false;
            this.btnPinjam.UseWaitCursor = true;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.MintCream;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(392, 121);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(190, 45);
            this.btnBatal.TabIndex = 11;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.UseWaitCursor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnHapusData
            // 
            this.btnHapusData.BackColor = System.Drawing.Color.MintCream;
            this.btnHapusData.Enabled = false;
            this.btnHapusData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusData.Location = new System.Drawing.Point(392, 25);
            this.btnHapusData.Name = "btnHapusData";
            this.btnHapusData.Size = new System.Drawing.Size(191, 45);
            this.btnHapusData.TabIndex = 12;
            this.btnHapusData.Text = "Hapus Data";
            this.btnHapusData.UseVisualStyleBackColor = false;
            this.btnHapusData.UseWaitCursor = true;
            this.btnHapusData.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // lblNBBuku
            // 
            this.lblNBBuku.AutoSize = true;
            this.lblNBBuku.BackColor = System.Drawing.Color.Black;
            this.lblNBBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNBBuku.ForeColor = System.Drawing.Color.Crimson;
            this.lblNBBuku.Location = new System.Drawing.Point(146, 233);
            this.lblNBBuku.Name = "lblNBBuku";
            this.lblNBBuku.Size = new System.Drawing.Size(241, 16);
            this.lblNBBuku.TabIndex = 13;
            this.lblNBBuku.Text = "^ NB: 1x peminjaman untuk 1 buku";
            this.lblNBBuku.UseWaitCursor = true;
            // 
            // lblDataTransaksi
            // 
            this.lblDataTransaksi.AutoSize = true;
            this.lblDataTransaksi.BackColor = System.Drawing.Color.White;
            this.lblDataTransaksi.Font = new System.Drawing.Font("Vineta BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTransaksi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDataTransaksi.Location = new System.Drawing.Point(356, 9);
            this.lblDataTransaksi.Name = "lblDataTransaksi";
            this.lblDataTransaksi.Size = new System.Drawing.Size(613, 43);
            this.lblDataTransaksi.TabIndex = 15;
            this.lblDataTransaksi.Text = "Data Peminjaman Buku";
            this.lblDataTransaksi.UseWaitCursor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 525);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 18);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "TOTAL BUKU: ";
            this.lblTotal.UseWaitCursor = true;
            // 
            // txtJumlah
            // 
            this.txtJumlah.BackColor = System.Drawing.SystemColors.Control;
            this.txtJumlah.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.Location = new System.Drawing.Point(149, 525);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.ReadOnly = true;
            this.txtJumlah.Size = new System.Drawing.Size(438, 25);
            this.txtJumlah.TabIndex = 17;
            this.txtJumlah.UseWaitCursor = true;
            // 
            // btnCek
            // 
            this.btnCek.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCek.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCek.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCek.Location = new System.Drawing.Point(665, 71);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(583, 31);
            this.btnCek.TabIndex = 18;
            this.btnCek.Text = "TEKAN UNTUK MELIHAT DATA BUKU";
            this.btnCek.UseVisualStyleBackColor = false;
            this.btnCek.UseWaitCursor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // dgvCekBuku
            // 
            this.dgvCekBuku.AllowUserToAddRows = false;
            this.dgvCekBuku.AllowUserToDeleteRows = false;
            this.dgvCekBuku.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCekBuku.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCekBuku.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCekBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCekBuku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.NoSeri,
            this.NamaBuku,
            this.PenulisBuku,
            this.Sisa});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCekBuku.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCekBuku.Enabled = false;
            this.dgvCekBuku.Location = new System.Drawing.Point(666, 120);
            this.dgvCekBuku.Name = "dgvCekBuku";
            this.dgvCekBuku.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCekBuku.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCekBuku.Size = new System.Drawing.Size(582, 150);
            this.dgvCekBuku.TabIndex = 19;
            this.dgvCekBuku.UseWaitCursor = true;
            this.dgvCekBuku.Visible = false;
            this.dgvCekBuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCekBuku_CellContentClick_1);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // NoSeri
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoSeri.DefaultCellStyle = dataGridViewCellStyle8;
            this.NoSeri.HeaderText = "No Seri";
            this.NoSeri.Name = "NoSeri";
            this.NoSeri.ReadOnly = true;
            // 
            // NamaBuku
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaBuku.DefaultCellStyle = dataGridViewCellStyle9;
            this.NamaBuku.HeaderText = "Nama Buku";
            this.NamaBuku.Name = "NamaBuku";
            this.NamaBuku.ReadOnly = true;
            // 
            // PenulisBuku
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenulisBuku.DefaultCellStyle = dataGridViewCellStyle10;
            this.PenulisBuku.HeaderText = "Penulis Buku";
            this.PenulisBuku.Name = "PenulisBuku";
            this.PenulisBuku.ReadOnly = true;
            // 
            // Sisa
            // 
            this.Sisa.HeaderText = "Sisa Buku";
            this.Sisa.Name = "Sisa";
            this.Sisa.ReadOnly = true;
            // 
            // btnResetList
            // 
            this.btnResetList.BackColor = System.Drawing.Color.MintCream;
            this.btnResetList.Enabled = false;
            this.btnResetList.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetList.Location = new System.Drawing.Point(0, 121);
            this.btnResetList.Name = "btnResetList";
            this.btnResetList.Size = new System.Drawing.Size(191, 45);
            this.btnResetList.TabIndex = 20;
            this.btnResetList.Text = "Reset Data List";
            this.btnResetList.UseVisualStyleBackColor = false;
            this.btnResetList.UseWaitCursor = true;
            this.btnResetList.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbPilihan
            // 
            this.gbPilihan.BackColor = System.Drawing.Color.FloralWhite;
            this.gbPilihan.Controls.Add(this.btnTambahData);
            this.gbPilihan.Controls.Add(this.btnHapusData);
            this.gbPilihan.Controls.Add(this.btnResetList);
            this.gbPilihan.Controls.Add(this.btnPinjam);
            this.gbPilihan.Controls.Add(this.btnBatal);
            this.gbPilihan.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPilihan.Location = new System.Drawing.Point(666, 312);
            this.gbPilihan.Name = "gbPilihan";
            this.gbPilihan.Size = new System.Drawing.Size(582, 258);
            this.gbPilihan.TabIndex = 21;
            this.gbPilihan.TabStop = false;
            this.gbPilihan.Text = "PILIHAN !!!";
            this.gbPilihan.UseWaitCursor = true;
            this.gbPilihan.Enter += new System.EventHandler(this.gbPilihan_Enter);
            // 
            // lblNBSeri
            // 
            this.lblNBSeri.AutoSize = true;
            this.lblNBSeri.BackColor = System.Drawing.Color.Black;
            this.lblNBSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNBSeri.ForeColor = System.Drawing.Color.Crimson;
            this.lblNBSeri.Location = new System.Drawing.Point(146, 178);
            this.lblNBSeri.Name = "lblNBSeri";
            this.lblNBSeri.Size = new System.Drawing.Size(291, 16);
            this.lblNBSeri.TabIndex = 22;
            this.lblNBSeri.Text = "^NB: Untuk edit pilih button reset data list";
            this.lblNBSeri.UseWaitCursor = true;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.BackColor = System.Drawing.Color.White;
            this.lblNama.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(19, 74);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(112, 18);
            this.lblNama.TabIndex = 23;
            this.lblNama.Text = "ID Mahasiswa:";
            this.lblNama.UseWaitCursor = true;
            // 
            // txtIDMahasiswa
            // 
            this.txtIDMahasiswa.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMahasiswa.Location = new System.Drawing.Point(149, 69);
            this.txtIDMahasiswa.Name = "txtIDMahasiswa";
            this.txtIDMahasiswa.ReadOnly = true;
            this.txtIDMahasiswa.Size = new System.Drawing.Size(438, 25);
            this.txtIDMahasiswa.TabIndex = 24;
            this.txtIDMahasiswa.UseWaitCursor = true;
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1298, 603);
            this.Controls.Add(this.txtIDMahasiswa);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNBSeri);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.gbPilihan);
            this.Controls.Add(this.dgvCekBuku);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDataTransaksi);
            this.Controls.Add(this.lblNBBuku);
            this.Controls.Add(this.dgvPeminjaman);
            this.Controls.Add(this.txtPenulisBuku);
            this.Controls.Add(this.lblPenulisBuku);
            this.Controls.Add(this.txtNamaBuku);
            this.Controls.Add(this.lblNamaBuku);
            this.Controls.Add(this.txtNoSeriBuku);
            this.Controls.Add(this.lblNomorSeriBuku);
            this.Controls.Add(this.lblTanggal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPeminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Peminjaman ";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FormPeminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCekBuku)).EndInit();
            this.gbPilihan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label lblNomorSeriBuku;
        private System.Windows.Forms.TextBox txtNoSeriBuku;
        private System.Windows.Forms.Label lblNamaBuku;
        private System.Windows.Forms.TextBox txtNamaBuku;
        private System.Windows.Forms.TextBox txtPenulisBuku;
        private System.Windows.Forms.Label lblPenulisBuku;
        private System.Windows.Forms.DataGridView dgvPeminjaman;
        private System.Windows.Forms.Button btnTambahData;
        private System.Windows.Forms.Button btnPinjam;
        private System.Windows.Forms.Button btnHapusData;
        private System.Windows.Forms.Label lblNBBuku;
        private System.Windows.Forms.Label lblDataTransaksi;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.DataGridView dgvCekBuku;
        private System.Windows.Forms.Button btnResetList;
        private System.Windows.Forms.GroupBox gbPilihan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label lblNBSeri;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtIDMahasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenulisBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Seri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Buku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penulis_Buku;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBuku;
    }
}