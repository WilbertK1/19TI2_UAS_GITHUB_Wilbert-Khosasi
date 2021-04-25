namespace Peminjaman_Perpustakaan
{
    partial class FormUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnMhs = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.Silver;
            this.lblJudul.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblJudul.Location = new System.Drawing.Point(105, 120);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(555, 58);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Berbagi Ilmu Pengetahuan";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdmin.Location = new System.Drawing.Point(54, 215);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(193, 74);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnMhs
            // 
            this.btnMhs.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMhs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMhs.Location = new System.Drawing.Point(304, 215);
            this.btnMhs.Name = "btnMhs";
            this.btnMhs.Size = new System.Drawing.Size(193, 74);
            this.btnMhs.TabIndex = 2;
            this.btnMhs.Text = "Mahasiswa";
            this.btnMhs.UseVisualStyleBackColor = true;
            this.btnMhs.Click += new System.EventHandler(this.btnMhs_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnKeluar.Location = new System.Drawing.Point(551, 215);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(193, 74);
            this.btnKeluar.TabIndex = 3;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnMhs);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblJudul);
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Utama";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnMhs;
        private System.Windows.Forms.Button btnKeluar;
    }
}