using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_Aries.Laporan
{
    public partial class LapSuratMasuk : Form
    {
        public LapSuratMasuk()
        {
            InitializeComponent();
            setingtanggal();
        }

        private void LapSuratMasuk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1,tanggalAwal.Text,tanggalAkhir.Text);

            this.reportViewer1.RefreshReport();
        }
        public void setingtanggal()
        {
            tanggalAwal.Format = DateTimePickerFormat.Custom;
            tanggalAwal.CustomFormat = "dd-MMM-yyyy";
            tanggalAwal.Value = DateTime.Now;

            tanggalAkhir.Format = DateTimePickerFormat.Custom;
            tanggalAkhir.CustomFormat = "dd-MMM-yyyy";
            tanggalAkhir.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tanggal = tanggalAwal.Value.ToString("yyyy-MM-dd"); 
            string tanggal2 = tanggalAkhir.Value.ToString("yyyy-MM-dd");

            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1, tanggal, tanggal2);
            this.reportViewer1.RefreshReport();
        }
    }
}
