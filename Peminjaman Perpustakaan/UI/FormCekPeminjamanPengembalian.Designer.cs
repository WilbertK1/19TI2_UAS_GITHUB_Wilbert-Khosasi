namespace Peminjaman_Perpustakaan
{
    partial class FormCekPeminjamanPengembalian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDataPeminjaman = new System.Windows.Forms.Label();
            this.dgvPeminjaman = new System.Windows.Forms.DataGridView();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenulisBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.btnHapusPeminjaman = new System.Windows.Forms.Button();
            this.btnHapusPengembalian = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.dgvPengembalian = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDataPengembalian = new System.Windows.Forms.Label();
            this.btnHalamanUtama = new System.Windows.Forms.Button();
            this.gbPilihan = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengembalian)).BeginInit();
            this.gbPilihan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataPeminjaman
            // 
            this.lblDataPeminjaman.AutoSize = true;
            this.lblDataPeminjaman.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPeminjaman.Location = new System.Drawing.Point(428, 9);
            this.lblDataPeminjaman.Name = "lblDataPeminjaman";
            this.lblDataPeminjaman.Size = new System.Drawing.Size(247, 33);
            this.lblDataPeminjaman.TabIndex = 1;
            this.lblDataPeminjaman.Text = "Data Peminjaman";
            this.lblDataPeminjaman.Visible = false;
            // 
            // dgvPeminjaman
            // 
            this.dgvPeminjaman.AllowUserToAddRows = false;
            this.dgvPeminjaman.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPeminjaman.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPeminjaman.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPeminjaman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeminjaman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeminjaman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tanggal,
            this.IDMahasiswa,
            this.NoSeri,
            this.NamaBuku,
            this.PenulisBuku});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeminjaman.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvPeminjaman.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPeminjaman.Location = new System.Drawing.Point(287, 42);
            this.dgvPeminjaman.Name = "dgvPeminjaman";
            this.dgvPeminjaman.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeminjaman.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPeminjaman.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvPeminjaman.Size = new System.Drawing.Size(582, 150);
            this.dgvPeminjaman.TabIndex = 20;
            this.dgvPeminjaman.UseWaitCursor = true;
            this.dgvPeminjaman.Visible = false;
            this.dgvPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeminjaman_CellClick);
            this.dgvPeminjaman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeminjaman_CellContentClick);
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.ReadOnly = true;
            // 
            // IDMahasiswa
            // 
            this.IDMahasiswa.HeaderText = "ID Mahasiswa";
            this.IDMahasiswa.Name = "IDMahasiswa";
            this.IDMahasiswa.ReadOnly = true;
            // 
            // NoSeri
            // 
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoSeri.DefaultCellStyle = dataGridViewCellStyle19;
            this.NoSeri.HeaderText = "No Seri";
            this.NoSeri.Name = "NoSeri";
            this.NoSeri.ReadOnly = true;
            // 
            // NamaBuku
            // 
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaBuku.DefaultCellStyle = dataGridViewCellStyle20;
            this.NamaBuku.HeaderText = "Nama Buku";
            this.NamaBuku.Name = "NamaBuku";
            this.NamaBuku.ReadOnly = true;
            // 
            // PenulisBuku
            // 
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenulisBuku.DefaultCellStyle = dataGridViewCellStyle21;
            this.PenulisBuku.HeaderText = "Penulis Buku";
            this.PenulisBuku.Name = "PenulisBuku";
            this.PenulisBuku.ReadOnly = true;
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.BackColor = System.Drawing.Color.White;
            this.btnPeminjaman.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjaman.Location = new System.Drawing.Point(22, 30);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(178, 62);
            this.btnPeminjaman.TabIndex = 21;
            this.btnPeminjaman.Text = "Teken Untuk Melihat Data Peminjaman";
            this.btnPeminjaman.UseVisualStyleBackColor = false;
            this.btnPeminjaman.UseWaitCursor = true;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // btnHapusPeminjaman
            // 
            this.btnHapusPeminjaman.BackColor = System.Drawing.Color.FloralWhite;
            this.btnHapusPeminjaman.Enabled = false;
            this.btnHapusPeminjaman.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusPeminjaman.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHapusPeminjaman.Location = new System.Drawing.Point(704, 208);
            this.btnHapusPeminjaman.Name = "btnHapusPeminjaman";
            this.btnHapusPeminjaman.Size = new System.Drawing.Size(165, 45);
            this.btnHapusPeminjaman.TabIndex = 23;
            this.btnHapusPeminjaman.Text = "Hapus Data";
            this.btnHapusPeminjaman.UseVisualStyleBackColor = false;
            this.btnHapusPeminjaman.Visible = false;
            this.btnHapusPeminjaman.Click += new System.EventHandler(this.btnHapusPeminjaman_Click_1);
            // 
            // btnHapusPengembalian
            // 
            this.btnHapusPengembalian.BackColor = System.Drawing.Color.FloralWhite;
            this.btnHapusPengembalian.Enabled = false;
            this.btnHapusPengembalian.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusPengembalian.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHapusPengembalian.Location = new System.Drawing.Point(704, 470);
            this.btnHapusPengembalian.Name = "btnHapusPengembalian";
            this.btnHapusPengembalian.Size = new System.Drawing.Size(165, 45);
            this.btnHapusPengembalian.TabIndex = 27;
            this.btnHapusPengembalian.Text = "Hapus Data";
            this.btnHapusPengembalian.UseVisualStyleBackColor = false;
            this.btnHapusPengembalian.Visible = false;
            this.btnHapusPengembalian.Click += new System.EventHandler(this.btnHapusPengembalian_Click);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.White;
            this.btnPengembalian.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengembalian.Location = new System.Drawing.Point(22, 293);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(178, 62);
            this.btnPengembalian.TabIndex = 26;
            this.btnPengembalian.Text = "Teken Untuk Melihat Data Pengembalian";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.UseWaitCursor = true;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // dgvPengembalian
            // 
            this.dgvPengembalian.AllowUserToAddRows = false;
            this.dgvPengembalian.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPengembalian.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvPengembalian.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPengembalian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPengembalian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengembalian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPengembalian.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvPengembalian.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPengembalian.Location = new System.Drawing.Point(287, 305);
            this.dgvPengembalian.Name = "dgvPengembalian";
            this.dgvPengembalian.ReadOnly = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPengembalian.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPengembalian.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvPengembalian.Size = new System.Drawing.Size(582, 150);
            this.dgvPengembalian.TabIndex = 25;
            this.dgvPengembalian.UseWaitCursor = true;
            this.dgvPengembalian.Visible = false;
            this.dgvPengembalian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPengembalian_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tanggal";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Mahasiswa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn3.HeaderText = "No Seri";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nama Buku";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewTextBoxColumn5.HeaderText = "Penulis Buku";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // lblDataPengembalian
            // 
            this.lblDataPengembalian.AutoSize = true;
            this.lblDataPengembalian.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPengembalian.Location = new System.Drawing.Point(428, 271);
            this.lblDataPengembalian.Name = "lblDataPengembalian";
            this.lblDataPengembalian.Size = new System.Drawing.Size(268, 33);
            this.lblDataPengembalian.TabIndex = 24;
            this.lblDataPengembalian.Text = "Data Pengembalian";
            this.lblDataPengembalian.Visible = false;
            // 
            // btnHalamanUtama
            // 
            this.btnHalamanUtama.BackColor = System.Drawing.Color.FloralWhite;
            this.btnHalamanUtama.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHalamanUtama.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHalamanUtama.Location = new System.Drawing.Point(22, 527);
            this.btnHalamanUtama.Name = "btnHalamanUtama";
            this.btnHalamanUtama.Size = new System.Drawing.Size(178, 62);
            this.btnHalamanUtama.TabIndex = 28;
            this.btnHalamanUtama.Text = "Kembali";
            this.btnHalamanUtama.UseVisualStyleBackColor = false;
            this.btnHalamanUtama.UseWaitCursor = true;
            this.btnHalamanUtama.Click += new System.EventHandler(this.btnHalamanUtama_Click);
            // 
            // gbPilihan
            // 
            this.gbPilihan.Controls.Add(this.btnHalamanUtama);
            this.gbPilihan.Controls.Add(this.btnPengembalian);
            this.gbPilihan.Controls.Add(this.btnPeminjaman);
            this.gbPilihan.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPilihan.Location = new System.Drawing.Point(12, 12);
            this.gbPilihan.Name = "gbPilihan";
            this.gbPilihan.Size = new System.Drawing.Size(229, 595);
            this.gbPilihan.TabIndex = 29;
            this.gbPilihan.TabStop = false;
            this.gbPilihan.Text = "PILIHAN !!!";
            this.gbPilihan.UseWaitCursor = true;
            // 
            // FormCekPeminjamanPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 702);
            this.Controls.Add(this.gbPilihan);
            this.Controls.Add(this.btnHapusPengembalian);
            this.Controls.Add(this.dgvPengembalian);
            this.Controls.Add(this.lblDataPengembalian);
            this.Controls.Add(this.btnHapusPeminjaman);
            this.Controls.Add(this.dgvPeminjaman);
            this.Controls.Add(this.lblDataPeminjaman);
            this.Name = "FormCekPeminjamanPengembalian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCekPeminjamanPengembalian";
            this.Load += new System.EventHandler(this.FormCekPeminjamanPengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengembalian)).EndInit();
            this.gbPilihan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataPeminjaman;
        private System.Windows.Forms.DataGridView dgvPeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMahasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenulisBuku;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnHapusPeminjaman;
        private System.Windows.Forms.Button btnHapusPengembalian;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.DataGridView dgvPengembalian;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblDataPengembalian;
        private System.Windows.Forms.Button btnHalamanUtama;
        private System.Windows.Forms.GroupBox gbPilihan;
    }
}