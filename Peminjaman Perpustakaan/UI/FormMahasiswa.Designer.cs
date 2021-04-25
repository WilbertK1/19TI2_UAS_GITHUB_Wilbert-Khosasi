namespace Peminjaman_Perpustakaan
{
    partial class FormMahasiswa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMahasiswa));
            this.lblDataTransaksi = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNoID = new System.Windows.Forms.TextBox();
            this.lblKelas = new System.Windows.Forms.Label();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnHalamanUtama = new System.Windows.Forms.Button();
            this.dgvDataMahasiswa = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KelasMahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNB = new System.Windows.Forms.Label();
            this.lblNBmhs = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataTransaksi
            // 
            this.lblDataTransaksi.AutoSize = true;
            this.lblDataTransaksi.Font = new System.Drawing.Font("Vineta BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTransaksi.Location = new System.Drawing.Point(395, 29);
            this.lblDataTransaksi.Name = "lblDataTransaksi";
            this.lblDataTransaksi.Size = new System.Drawing.Size(429, 43);
            this.lblDataTransaksi.TabIndex = 16;
            this.lblDataTransaksi.Text = "Data Mahasiswa";
            this.lblDataTransaksi.Click += new System.EventHandler(this.lblDataTransaksi_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.BackColor = System.Drawing.Color.White;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(105, 156);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(60, 20);
            this.lblNama.TabIndex = 17;
            this.lblNama.Text = "Nama:";
            // 
            // txtNoID
            // 
            this.txtNoID.BackColor = System.Drawing.Color.White;
            this.txtNoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoID.Location = new System.Drawing.Point(171, 97);
            this.txtNoID.Name = "txtNoID";
            this.txtNoID.Size = new System.Drawing.Size(271, 26);
            this.txtNoID.TabIndex = 18;
            this.txtNoID.TextChanged += new System.EventHandler(this.txtNoID_TextChanged);
            this.txtNoID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNoID_KeyUp);
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.BackColor = System.Drawing.Color.White;
            this.lblKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelas.Location = new System.Drawing.Point(105, 217);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(58, 20);
            this.lblKelas.TabIndex = 19;
            this.lblKelas.Text = "Kelas:";
            // 
            // txtKelas
            // 
            this.txtKelas.BackColor = System.Drawing.Color.White;
            this.txtKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelas.Location = new System.Drawing.Point(171, 217);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.ReadOnly = true;
            this.txtKelas.Size = new System.Drawing.Size(271, 26);
            this.txtKelas.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "No ID Mahasiswa:";
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.White;
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(171, 156);
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = true;
            this.txtNama.Size = new System.Drawing.Size(271, 26);
            this.txtNama.TabIndex = 22;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNoID_TextChanged);
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPeminjaman.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjaman.Location = new System.Drawing.Point(16, 282);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(210, 79);
            this.btnPeminjaman.TabIndex = 23;
            this.btnPeminjaman.Text = "Peminjaman";
            this.btnPeminjaman.UseVisualStyleBackColor = false;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPengembalian.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengembalian.Location = new System.Drawing.Point(305, 282);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(210, 79);
            this.btnPengembalian.TabIndex = 24;
            this.btnPengembalian.Text = "Pengembalian";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // btnHalamanUtama
            // 
            this.btnHalamanUtama.BackColor = System.Drawing.Color.GhostWhite;
            this.btnHalamanUtama.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHalamanUtama.Location = new System.Drawing.Point(863, 282);
            this.btnHalamanUtama.Name = "btnHalamanUtama";
            this.btnHalamanUtama.Size = new System.Drawing.Size(210, 79);
            this.btnHalamanUtama.TabIndex = 25;
            this.btnHalamanUtama.Text = "Halaman Utama";
            this.btnHalamanUtama.UseVisualStyleBackColor = false;
            this.btnHalamanUtama.Click += new System.EventHandler(this.btnHalamanUtama_Click);
            // 
            // dgvDataMahasiswa
            // 
            this.dgvDataMahasiswa.AllowUserToAddRows = false;
            this.dgvDataMahasiswa.AllowUserToDeleteRows = false;
            this.dgvDataMahasiswa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataMahasiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataMahasiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.IDMahasiswa,
            this.NamaMahasiswa,
            this.KelasMahasiswa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataMahasiswa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataMahasiswa.Location = new System.Drawing.Point(488, 94);
            this.dgvDataMahasiswa.Name = "dgvDataMahasiswa";
            this.dgvDataMahasiswa.ReadOnly = true;
            this.dgvDataMahasiswa.Size = new System.Drawing.Size(585, 140);
            this.dgvDataMahasiswa.TabIndex = 26;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Visible = false;
            // 
            // IDMahasiswa
            // 
            this.IDMahasiswa.HeaderText = "ID Mahasiswa";
            this.IDMahasiswa.Name = "IDMahasiswa";
            this.IDMahasiswa.ReadOnly = true;
            this.IDMahasiswa.Visible = false;
            // 
            // NamaMahasiswa
            // 
            this.NamaMahasiswa.HeaderText = "Nama";
            this.NamaMahasiswa.Name = "NamaMahasiswa";
            this.NamaMahasiswa.ReadOnly = true;
            // 
            // KelasMahasiswa
            // 
            this.KelasMahasiswa.HeaderText = "Kelas";
            this.KelasMahasiswa.Name = "KelasMahasiswa";
            this.KelasMahasiswa.ReadOnly = true;
            // 
            // lblNB
            // 
            this.lblNB.AutoSize = true;
            this.lblNB.BackColor = System.Drawing.Color.Black;
            this.lblNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNB.ForeColor = System.Drawing.Color.Red;
            this.lblNB.Location = new System.Drawing.Point(479, 247);
            this.lblNB.Name = "lblNB";
            this.lblNB.Size = new System.Drawing.Size(594, 20);
            this.lblNB.TabIndex = 27;
            this.lblNB.Text = "^No ID sengaja disembunyikan untuk menghindari pemakaian ID orang !!!";
            // 
            // lblNBmhs
            // 
            this.lblNBmhs.AutoSize = true;
            this.lblNBmhs.BackColor = System.Drawing.Color.Black;
            this.lblNBmhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNBmhs.ForeColor = System.Drawing.Color.Red;
            this.lblNBmhs.Location = new System.Drawing.Point(168, 123);
            this.lblNBmhs.Name = "lblNBmhs";
            this.lblNBmhs.Size = new System.Drawing.Size(289, 18);
            this.lblNBmhs.TabIndex = 28;
            this.lblNBmhs.Text = "^teken enter saja setelah mengetik ID";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.GhostWhite;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(589, 282);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(210, 79);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1117, 568);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblNBmhs);
            this.Controls.Add(this.lblNB);
            this.Controls.Add(this.dgvDataMahasiswa);
            this.Controls.Add(this.btnHalamanUtama);
            this.Controls.Add(this.btnPengembalian);
            this.Controls.Add(this.btnPeminjaman);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.txtNoID);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblDataTransaksi);
            this.Name = "FormMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMahasiswa";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataTransaksi;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNoID;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnHalamanUtama;
        private System.Windows.Forms.DataGridView dgvDataMahasiswa;
        private System.Windows.Forms.Label lblNB;
        private System.Windows.Forms.Label lblNBmhs;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMahasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMahasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KelasMahasiswa;
    }
}