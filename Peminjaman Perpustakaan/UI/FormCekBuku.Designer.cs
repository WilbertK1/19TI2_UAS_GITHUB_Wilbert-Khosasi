namespace Peminjaman_Perpustakaan
{
    partial class FormCekBuku
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSeriBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPenulis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDataBuku = new System.Windows.Forms.Label();
            this.btnMasukkan = new System.Windows.Forms.Button();
            this.txtNamaPenulis = new System.Windows.Forms.TextBox();
            this.txtNamaBuku = new System.Windows.Forms.TextBox();
            this.txtNoSeriBuku = new System.Windows.Forms.TextBox();
            this.lblNamaPenulis = new System.Windows.Forms.Label();
            this.lblNamaBuku = new System.Windows.Forms.Label();
            this.lblNoSeriBuku = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.lblJumlah = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuku
            // 
            this.dgvBuku.AllowUserToAddRows = false;
            this.dgvBuku.AllowUserToDeleteRows = false;
            this.dgvBuku.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuku.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.NoSeriBuku,
            this.NamaBuku,
            this.NamaPenulis,
            this.Sisa});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuku.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBuku.Location = new System.Drawing.Point(128, 65);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuku.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBuku.Size = new System.Drawing.Size(546, 168);
            this.dgvBuku.TabIndex = 3;
            this.dgvBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuku_CellClick);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Visible = false;
            // 
            // NoSeriBuku
            // 
            this.NoSeriBuku.HeaderText = "No Seri Buku";
            this.NoSeriBuku.Name = "NoSeriBuku";
            this.NoSeriBuku.ReadOnly = true;
            // 
            // NamaBuku
            // 
            this.NamaBuku.HeaderText = "Nama Buku";
            this.NamaBuku.Name = "NamaBuku";
            this.NamaBuku.ReadOnly = true;
            // 
            // NamaPenulis
            // 
            this.NamaPenulis.HeaderText = "Nama Penulis";
            this.NamaPenulis.Name = "NamaPenulis";
            this.NamaPenulis.ReadOnly = true;
            // 
            // Sisa
            // 
            this.Sisa.HeaderText = "Sisa";
            this.Sisa.Name = "Sisa";
            this.Sisa.ReadOnly = true;
            // 
            // lblDataBuku
            // 
            this.lblDataBuku.AutoSize = true;
            this.lblDataBuku.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBuku.Location = new System.Drawing.Point(344, 20);
            this.lblDataBuku.Name = "lblDataBuku";
            this.lblDataBuku.Size = new System.Drawing.Size(137, 30);
            this.lblDataBuku.TabIndex = 2;
            this.lblDataBuku.Text = "Data Buku";
            // 
            // btnMasukkan
            // 
            this.btnMasukkan.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasukkan.Location = new System.Drawing.Point(525, 559);
            this.btnMasukkan.Name = "btnMasukkan";
            this.btnMasukkan.Size = new System.Drawing.Size(149, 53);
            this.btnMasukkan.TabIndex = 21;
            this.btnMasukkan.Text = "MASUKKAN";
            this.btnMasukkan.UseVisualStyleBackColor = true;
            this.btnMasukkan.Visible = false;
            this.btnMasukkan.Click += new System.EventHandler(this.btnMasukkan_Click);
            // 
            // txtNamaPenulis
            // 
            this.txtNamaPenulis.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPenulis.Location = new System.Drawing.Point(280, 446);
            this.txtNamaPenulis.Name = "txtNamaPenulis";
            this.txtNamaPenulis.Size = new System.Drawing.Size(394, 31);
            this.txtNamaPenulis.TabIndex = 20;
            this.txtNamaPenulis.Visible = false;
            // 
            // txtNamaBuku
            // 
            this.txtNamaBuku.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaBuku.Location = new System.Drawing.Point(280, 392);
            this.txtNamaBuku.Name = "txtNamaBuku";
            this.txtNamaBuku.Size = new System.Drawing.Size(394, 31);
            this.txtNamaBuku.TabIndex = 19;
            this.txtNamaBuku.Visible = false;
            // 
            // txtNoSeriBuku
            // 
            this.txtNoSeriBuku.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoSeriBuku.Location = new System.Drawing.Point(280, 341);
            this.txtNoSeriBuku.Name = "txtNoSeriBuku";
            this.txtNoSeriBuku.Size = new System.Drawing.Size(394, 31);
            this.txtNoSeriBuku.TabIndex = 18;
            this.txtNoSeriBuku.Visible = false;
            // 
            // lblNamaPenulis
            // 
            this.lblNamaPenulis.AutoSize = true;
            this.lblNamaPenulis.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPenulis.Location = new System.Drawing.Point(132, 449);
            this.lblNamaPenulis.Name = "lblNamaPenulis";
            this.lblNamaPenulis.Size = new System.Drawing.Size(142, 24);
            this.lblNamaPenulis.TabIndex = 17;
            this.lblNamaPenulis.Text = "Nama Penulis:";
            this.lblNamaPenulis.Visible = false;
            // 
            // lblNamaBuku
            // 
            this.lblNamaBuku.AutoSize = true;
            this.lblNamaBuku.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaBuku.Location = new System.Drawing.Point(150, 399);
            this.lblNamaBuku.Name = "lblNamaBuku";
            this.lblNamaBuku.Size = new System.Drawing.Size(124, 24);
            this.lblNamaBuku.TabIndex = 16;
            this.lblNamaBuku.Text = "Nama Buku:";
            this.lblNamaBuku.Visible = false;
            // 
            // lblNoSeriBuku
            // 
            this.lblNoSeriBuku.AutoSize = true;
            this.lblNoSeriBuku.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSeriBuku.Location = new System.Drawing.Point(138, 344);
            this.lblNoSeriBuku.Name = "lblNoSeriBuku";
            this.lblNoSeriBuku.Size = new System.Drawing.Size(136, 24);
            this.lblNoSeriBuku.TabIndex = 15;
            this.lblNoSeriBuku.Text = "No Seri Buku:";
            this.lblNoSeriBuku.Visible = false;
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnKembali.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(525, 258);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(149, 56);
            this.btnKembali.TabIndex = 14;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHapus.Enabled = false;
            this.btnHapus.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(332, 258);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(149, 56);
            this.btnHapus.TabIndex = 13;
            this.btnHapus.Text = "Hapus Buku";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTambah.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(128, 258);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(149, 53);
            this.btnTambah.TabIndex = 12;
            this.btnTambah.Text = "Tambah Buku";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtJumlah
            // 
            this.txtJumlah.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.Location = new System.Drawing.Point(280, 501);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(394, 31);
            this.txtJumlah.TabIndex = 23;
            this.txtJumlah.Visible = false;
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(195, 501);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(79, 24);
            this.lblJumlah.TabIndex = 22;
            this.lblJumlah.Text = "Jumlah:";
            this.lblJumlah.Visible = false;
            // 
            // FormCekBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.btnMasukkan);
            this.Controls.Add(this.txtNamaPenulis);
            this.Controls.Add(this.txtNamaBuku);
            this.Controls.Add(this.txtNoSeriBuku);
            this.Controls.Add(this.lblNamaPenulis);
            this.Controls.Add(this.lblNamaBuku);
            this.Controls.Add(this.lblNoSeriBuku);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvBuku);
            this.Controls.Add(this.lblDataBuku);
            this.Name = "FormCekBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCekBuku";
            this.Load += new System.EventHandler(this.FormCekBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuku;
        private System.Windows.Forms.Label lblDataBuku;
        private System.Windows.Forms.Button btnMasukkan;
        private System.Windows.Forms.TextBox txtNamaPenulis;
        private System.Windows.Forms.TextBox txtNamaBuku;
        private System.Windows.Forms.TextBox txtNoSeriBuku;
        private System.Windows.Forms.Label lblNamaPenulis;
        private System.Windows.Forms.Label lblNamaBuku;
        private System.Windows.Forms.Label lblNoSeriBuku;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSeriBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPenulis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sisa;
    }
}