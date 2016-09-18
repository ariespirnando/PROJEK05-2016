namespace TA_Aries.Laporan
{
    partial class LapSuratKeluar
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new TA_Aries.DataSet2();
            this.dataTable1TableAdapter = new TA_Aries.DataSet2TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TA_Aries.Laporan.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(872, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // tanggalAwal
            // 
            this.tanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tanggalAwal.Location = new System.Drawing.Point(12, 12);
            this.tanggalAwal.Name = "tanggalAwal";
            this.tanggalAwal.Size = new System.Drawing.Size(200, 20);
            this.tanggalAwal.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Keluar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sampai";
            // 
            // tanggalAkhir
            // 
            this.tanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tanggalAkhir.Location = new System.Drawing.Point(268, 12);
            this.tanggalAkhir.Name = "tanggalAkhir";
            this.tanggalAkhir.Size = new System.Drawing.Size(200, 20);
            this.tanggalAkhir.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Prosess";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // LapSuratKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 502);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tanggalAkhir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tanggalAwal);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LapSuratKeluar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Laporan Surat Keluar ::..";
            this.Load += new System.EventHandler(this.LapSuratKeluar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker tanggalAwal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tanggalAkhir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}