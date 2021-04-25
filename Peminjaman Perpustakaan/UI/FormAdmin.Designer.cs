namespace Peminjaman_Perpustakaan
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnCekDataMahasiswa = new System.Windows.Forms.Button();
            this.btnCekDataPeminjamanPengembalian = new System.Windows.Forms.Button();
            this.gbPilihan = new System.Windows.Forms.GroupBox();
            this.btnCekDataBuku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPilihan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(67, 268);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(112, 55);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(354, 197);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 57);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(354, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(438, 26);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(238, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 25);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(354, 82);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(438, 26);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(238, 81);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(116, 25);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 216);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnKembali
            // 
            this.btnKembali.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(561, 197);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(156, 57);
            this.btnKembali.TabIndex = 13;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnCekDataMahasiswa
            // 
            this.btnCekDataMahasiswa.Enabled = false;
            this.btnCekDataMahasiswa.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCekDataMahasiswa.Location = new System.Drawing.Point(6, 27);
            this.btnCekDataMahasiswa.Name = "btnCekDataMahasiswa";
            this.btnCekDataMahasiswa.Size = new System.Drawing.Size(536, 36);
            this.btnCekDataMahasiswa.TabIndex = 14;
            this.btnCekDataMahasiswa.Text = "Cek Data Mahasiswa";
            this.btnCekDataMahasiswa.UseVisualStyleBackColor = true;
            this.btnCekDataMahasiswa.Click += new System.EventHandler(this.btnCekDataMahasiswa_Click);
            // 
            // btnCekDataPeminjamanPengembalian
            // 
            this.btnCekDataPeminjamanPengembalian.Enabled = false;
            this.btnCekDataPeminjamanPengembalian.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCekDataPeminjamanPengembalian.Location = new System.Drawing.Point(5, 131);
            this.btnCekDataPeminjamanPengembalian.Name = "btnCekDataPeminjamanPengembalian";
            this.btnCekDataPeminjamanPengembalian.Size = new System.Drawing.Size(537, 36);
            this.btnCekDataPeminjamanPengembalian.TabIndex = 15;
            this.btnCekDataPeminjamanPengembalian.Text = "Cek Data Peminjaman & Pengembalian";
            this.btnCekDataPeminjamanPengembalian.UseVisualStyleBackColor = true;
            this.btnCekDataPeminjamanPengembalian.Click += new System.EventHandler(this.btnCekDataPeminjamanPengembalian_Click);
            // 
            // gbPilihan
            // 
            this.gbPilihan.Controls.Add(this.btnCekDataBuku);
            this.gbPilihan.Controls.Add(this.btnCekDataMahasiswa);
            this.gbPilihan.Controls.Add(this.btnCekDataPeminjamanPengembalian);
            this.gbPilihan.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPilihan.Location = new System.Drawing.Point(243, 268);
            this.gbPilihan.Name = "gbPilihan";
            this.gbPilihan.Size = new System.Drawing.Size(548, 180);
            this.gbPilihan.TabIndex = 16;
            this.gbPilihan.TabStop = false;
            this.gbPilihan.Text = "Apa yang ingin anda lakukan?";
            // 
            // btnCekDataBuku
            // 
            this.btnCekDataBuku.Enabled = false;
            this.btnCekDataBuku.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCekDataBuku.Location = new System.Drawing.Point(6, 78);
            this.btnCekDataBuku.Name = "btnCekDataBuku";
            this.btnCekDataBuku.Size = new System.Drawing.Size(536, 36);
            this.btnCekDataBuku.TabIndex = 17;
            this.btnCekDataBuku.Text = "Cek Data Buku";
            this.btnCekDataBuku.UseVisualStyleBackColor = true;
            this.btnCekDataBuku.Click += new System.EventHandler(this.btnCekDataBuku_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(802, 465);
            this.Controls.Add(this.gbPilihan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblAdmin);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Admin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPilihan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnCekDataMahasiswa;
        private System.Windows.Forms.Button btnCekDataPeminjamanPengembalian;
        private System.Windows.Forms.GroupBox gbPilihan;
        private System.Windows.Forms.Button btnCekDataBuku;
    }
}

