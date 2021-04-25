namespace Peminjaman_Perpustakaan
{
    partial class FormCekMahasiswa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMahasiswa = new System.Windows.Forms.Label();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KelasMahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.lblIDMahasiswa = new System.Windows.Forms.Label();
            this.lblNamaMahasiswa = new System.Windows.Forms.Label();
            this.lblKelasMahasiswa = new System.Windows.Forms.Label();
            this.txtIDMahasiswa = new System.Windows.Forms.TextBox();
            this.txtNamaMahasiswa = new System.Windows.Forms.TextBox();
            this.txtKelasMahasiswa = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMahasiswa
            // 
            this.lblMahasiswa.AutoSize = true;
            this.lblMahasiswa.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMahasiswa.Location = new System.Drawing.Point(302, 9);
            this.lblMahasiswa.Name = "lblMahasiswa";
            this.lblMahasiswa.Size = new System.Drawing.Size(203, 30);
            this.lblMahasiswa.TabIndex = 0;
            this.lblMahasiswa.Text = "Data Mahasiswa";
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.AllowUserToAddRows = false;
            this.dgvMahasiswa.AllowUserToDeleteRows = false;
            this.dgvMahasiswa.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMahasiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.IDMahasiswa,
            this.NamaMahasiswa,
            this.KelasMahasiswa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMahasiswa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMahasiswa.Location = new System.Drawing.Point(134, 55);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMahasiswa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMahasiswa.Size = new System.Drawing.Size(546, 168);
            this.dgvMahasiswa.TabIndex = 1;
            this.dgvMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMahasiswa_CellClick);
            this.dgvMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMahasiswa_CellContentClick);
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
            // 
            // NamaMahasiswa
            // 
            this.NamaMahasiswa.HeaderText = "Nama Mahasiswa";
            this.NamaMahasiswa.Name = "NamaMahasiswa";
            this.NamaMahasiswa.ReadOnly = true;
            // 
            // KelasMahasiswa
            // 
            this.KelasMahasiswa.HeaderText = "Kelas Mahasiswa";
            this.KelasMahasiswa.Name = "KelasMahasiswa";
            this.KelasMahasiswa.ReadOnly = true;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Azure;
            this.btnTambah.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(134, 251);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(149, 53);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.Text = "Tambah Mahasiswa";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Azure;
            this.btnHapus.Enabled = false;
            this.btnHapus.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(328, 251);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(149, 56);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus Mahasiswa";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.Azure;
            this.btnKembali.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(531, 251);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(149, 56);
            this.btnKembali.TabIndex = 4;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // lblIDMahasiswa
            // 
            this.lblIDMahasiswa.AutoSize = true;
            this.lblIDMahasiswa.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMahasiswa.Location = new System.Drawing.Point(136, 337);
            this.lblIDMahasiswa.Name = "lblIDMahasiswa";
            this.lblIDMahasiswa.Size = new System.Drawing.Size(144, 24);
            this.lblIDMahasiswa.TabIndex = 5;
            this.lblIDMahasiswa.Text = "ID Mahasiswa:";
            this.lblIDMahasiswa.Visible = false;
            // 
            // lblNamaMahasiswa
            // 
            this.lblNamaMahasiswa.AutoSize = true;
            this.lblNamaMahasiswa.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaMahasiswa.Location = new System.Drawing.Point(105, 388);
            this.lblNamaMahasiswa.Name = "lblNamaMahasiswa";
            this.lblNamaMahasiswa.Size = new System.Drawing.Size(175, 24);
            this.lblNamaMahasiswa.TabIndex = 6;
            this.lblNamaMahasiswa.Text = "Nama Mahasiswa:";
            this.lblNamaMahasiswa.Visible = false;
            // 
            // lblKelasMahasiswa
            // 
            this.lblKelasMahasiswa.AutoSize = true;
            this.lblKelasMahasiswa.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelasMahasiswa.Location = new System.Drawing.Point(112, 442);
            this.lblKelasMahasiswa.Name = "lblKelasMahasiswa";
            this.lblKelasMahasiswa.Size = new System.Drawing.Size(168, 24);
            this.lblKelasMahasiswa.TabIndex = 7;
            this.lblKelasMahasiswa.Text = "Kelas Mahasiswa:";
            this.lblKelasMahasiswa.Visible = false;
            // 
            // txtIDMahasiswa
            // 
            this.txtIDMahasiswa.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMahasiswa.Location = new System.Drawing.Point(286, 334);
            this.txtIDMahasiswa.Name = "txtIDMahasiswa";
            this.txtIDMahasiswa.Size = new System.Drawing.Size(394, 31);
            this.txtIDMahasiswa.TabIndex = 8;
            this.txtIDMahasiswa.Visible = false;
            // 
            // txtNamaMahasiswa
            // 
            this.txtNamaMahasiswa.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaMahasiswa.Location = new System.Drawing.Point(286, 385);
            this.txtNamaMahasiswa.Name = "txtNamaMahasiswa";
            this.txtNamaMahasiswa.Size = new System.Drawing.Size(394, 31);
            this.txtNamaMahasiswa.TabIndex = 9;
            this.txtNamaMahasiswa.Visible = false;
            // 
            // txtKelasMahasiswa
            // 
            this.txtKelasMahasiswa.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelasMahasiswa.Location = new System.Drawing.Point(286, 442);
            this.txtKelasMahasiswa.Name = "txtKelasMahasiswa";
            this.txtKelasMahasiswa.Size = new System.Drawing.Size(394, 31);
            this.txtKelasMahasiswa.TabIndex = 10;
            this.txtKelasMahasiswa.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(531, 495);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(149, 53);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FormCekMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 661);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtKelasMahasiswa);
            this.Controls.Add(this.txtNamaMahasiswa);
            this.Controls.Add(this.txtIDMahasiswa);
            this.Controls.Add(this.lblKelasMahasiswa);
            this.Controls.Add(this.lblNamaMahasiswa);
            this.Controls.Add(this.lblIDMahasiswa);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.lblMahasiswa);
            this.Name = "FormCekMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.Load += new System.EventHandler(this.FormCekMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMahasiswa;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblIDMahasiswa;
        private System.Windows.Forms.Label lblNamaMahasiswa;
        private System.Windows.Forms.Label lblKelasMahasiswa;
        private System.Windows.Forms.TextBox txtIDMahasiswa;
        private System.Windows.Forms.TextBox txtNamaMahasiswa;
        private System.Windows.Forms.TextBox txtKelasMahasiswa;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMahasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMahasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KelasMahasiswa;
    }
}