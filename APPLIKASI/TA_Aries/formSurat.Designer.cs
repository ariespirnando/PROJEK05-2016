namespace TA_Aries
{
    partial class formSurat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipeSurat = new System.Windows.Forms.TextBox();
            this.txtKodeSurat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.listTipeSurat = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTipeSurat);
            this.groupBox1.Controls.Add(this.txtKodeSurat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "..:: Input ::..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode";
            // 
            // txtTipeSurat
            // 
            this.txtTipeSurat.Enabled = false;
            this.txtTipeSurat.Location = new System.Drawing.Point(75, 57);
            this.txtTipeSurat.Name = "txtTipeSurat";
            this.txtTipeSurat.Size = new System.Drawing.Size(228, 20);
            this.txtTipeSurat.TabIndex = 2;
            // 
            // txtKodeSurat
            // 
            this.txtKodeSurat.Enabled = false;
            this.txtKodeSurat.Location = new System.Drawing.Point(75, 31);
            this.txtKodeSurat.Name = "txtKodeSurat";
            this.txtKodeSurat.Size = new System.Drawing.Size(128, 20);
            this.txtKodeSurat.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnKeluar);
            this.panel1.Controls.Add(this.btnHapus);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnBaru);
            this.panel1.Location = new System.Drawing.Point(127, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(112, 58);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 3;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Enabled = false;
            this.btnHapus.Location = new System.Drawing.Point(112, 21);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(15, 58);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(15, 21);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(75, 23);
            this.btnBaru.TabIndex = 0;
            this.btnBaru.Text = "Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Location = new System.Drawing.Point(15, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 100);
            this.panel2.TabIndex = 2;
            // 
            // btnSimpan
            // 
            this.btnSimpan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSimpan.Enabled = false;
            this.btnSimpan.Location = new System.Drawing.Point(15, 21);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 60);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // listTipeSurat
            // 
            this.listTipeSurat.Enabled = false;
            this.listTipeSurat.Location = new System.Drawing.Point(333, 19);
            this.listTipeSurat.Name = "listTipeSurat";
            this.listTipeSurat.Size = new System.Drawing.Size(271, 194);
            this.listTipeSurat.TabIndex = 3;
            this.listTipeSurat.UseCompatibleStateImageBehavior = false;
            this.listTipeSurat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listTipeSurat_MouseDoubleClick);
            // 
            // formSurat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 224);
            this.ControlBox = false;
            this.Controls.Add(this.listTipeSurat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "formSurat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Tipe Surat ::..";
            this.Load += new System.EventHandler(this.formSurat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipeSurat;
        private System.Windows.Forms.TextBox txtKodeSurat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listTipeSurat;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBaru;
    }
}