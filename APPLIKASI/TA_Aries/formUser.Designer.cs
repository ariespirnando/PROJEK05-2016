namespace TA_Aries
{
    partial class formUser
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
            this.panelogin = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpaswordlogin = new System.Windows.Forms.TextBox();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pane1 = new System.Windows.Forms.GroupBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtcariemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listdataUser = new System.Windows.Forms.ListView();
            this.panelogin.SuspendLayout();
            this.pane1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelogin
            // 
            this.panelogin.Controls.Add(this.button2);
            this.panelogin.Controls.Add(this.button1);
            this.panelogin.Controls.Add(this.txtpaswordlogin);
            this.panelogin.Controls.Add(this.txtUsernameLogin);
            this.panelogin.Controls.Add(this.label2);
            this.panelogin.Controls.Add(this.label1);
            this.panelogin.Location = new System.Drawing.Point(206, 48);
            this.panelogin.Name = "panelogin";
            this.panelogin.Size = new System.Drawing.Size(258, 134);
            this.panelogin.TabIndex = 0;
            this.panelogin.TabStop = false;
            this.panelogin.Text = "..:: Login ::..";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Keluar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpaswordlogin
            // 
            this.txtpaswordlogin.Location = new System.Drawing.Point(68, 62);
            this.txtpaswordlogin.Name = "txtpaswordlogin";
            this.txtpaswordlogin.PasswordChar = '*';
            this.txtpaswordlogin.Size = new System.Drawing.Size(184, 20);
            this.txtpaswordlogin.TabIndex = 4;
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Location = new System.Drawing.Point(68, 36);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(184, 20);
            this.txtUsernameLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // pane1
            // 
            this.pane1.Controls.Add(this.txtemail);
            this.pane1.Controls.Add(this.label5);
            this.pane1.Controls.Add(this.txtpassword);
            this.pane1.Controls.Add(this.label4);
            this.pane1.Controls.Add(this.txtUsername);
            this.pane1.Controls.Add(this.label3);
            this.pane1.Location = new System.Drawing.Point(12, 12);
            this.pane1.Name = "pane1";
            this.pane1.Size = new System.Drawing.Size(282, 140);
            this.pane1.TabIndex = 1;
            this.pane1.TabStop = false;
            this.pane1.Text = "..:: Input Data User ::..";
            this.pane1.Visible = false;
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(81, 97);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(184, 20);
            this.txtemail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // txtpassword
            // 
            this.txtpassword.Enabled = false;
            this.txtpassword.Location = new System.Drawing.Point(81, 65);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(184, 20);
            this.txtpassword.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(81, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Location = new System.Drawing.Point(12, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 100);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Enabled = false;
            this.btnSimpan.Location = new System.Drawing.Point(23, 18);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(62, 61);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnHapus);
            this.panel2.Controls.Add(this.btnBaru);
            this.panel2.Location = new System.Drawing.Point(126, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 100);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(91, 55);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(48, 23);
            this.btnKeluar.TabIndex = 3;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(91, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Enabled = false;
            this.btnHapus.Location = new System.Drawing.Point(26, 55);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(48, 23);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(26, 17);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(48, 23);
            this.btnBaru.TabIndex = 0;
            this.btnBaru.Text = "Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtcariemail);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.listdataUser);
            this.panel4.Location = new System.Drawing.Point(300, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 238);
            this.panel4.TabIndex = 5;
            this.panel4.Visible = false;
            // 
            // txtcariemail
            // 
            this.txtcariemail.Enabled = false;
            this.txtcariemail.Location = new System.Drawing.Point(71, 210);
            this.txtcariemail.Name = "txtcariemail";
            this.txtcariemail.Size = new System.Drawing.Size(263, 20);
            this.txtcariemail.TabIndex = 13;
            this.txtcariemail.TextChanged += new System.EventHandler(this.txtcariemail_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cari Email";
            // 
            // listdataUser
            // 
            this.listdataUser.Enabled = false;
            this.listdataUser.Location = new System.Drawing.Point(4, 4);
            this.listdataUser.Name = "listdataUser";
            this.listdataUser.Size = new System.Drawing.Size(330, 194);
            this.listdataUser.TabIndex = 0;
            this.listdataUser.UseCompatibleStateImageBehavior = false;
            this.listdataUser.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listdataUser_MouseDoubleClick);
            // 
            // formUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 265);
            this.ControlBox = false;
            this.Controls.Add(this.panelogin);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pane1);
            this.Name = "formUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: User ::..";
            this.Load += new System.EventHandler(this.formUser_Load);
            this.panelogin.ResumeLayout(false);
            this.panelogin.PerformLayout();
            this.pane1.ResumeLayout(false);
            this.pane1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panelogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpaswordlogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox pane1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.TextBox txtcariemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listdataUser;
    }
}