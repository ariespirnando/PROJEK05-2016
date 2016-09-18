using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_Aries
{
    public partial class formUtama : Form
    {
        public formUtama()
        {
            InitializeComponent();
        }

        formSurat fsu = new formSurat();
        formArsipMasuk fma = new formArsipMasuk();
        formLogin flo = new formLogin();
        formSuratMasuk fsm = new formSuratMasuk();
        formSuratKeluar fsk = new formSuratKeluar();
        formUser fmu = new formUser();
        formAbout fab = new formAbout();
        formArsipKeluar fmk = new formArsipKeluar();
        Laporan.LapSuratMasuk lsm = new Laporan.LapSuratMasuk();
        Laporan.LapSuratKeluar lsk = new Laporan.LapSuratKeluar();
        private void tipeSuratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fsu.MdiParent = this;
            fsu.Visible = true;
            fma.Visible = false;
            fsm.Visible = false;
            fsk.Visible = false;
            lsm.Visible = false;
            fmu.Visible = false;
            fab.Visible = false;
            fmk.Visible = false;
            lsk.Visible = false;
        }

        private void arsipSuratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fma.MdiParent = this;
            fma.Visible = true;
            fsu.Visible = false;
            fsm.Visible = false;
            lsk.Visible = false;
            fsk.Visible = false;
            fmu.Visible = false;
            lsm.Visible = false;
            fab.Visible = false;
            fmk.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            flo.Visible = true;
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flo.Visible = true;
            this.Close();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void suratMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fsm.MdiParent = this;
            fsm.Visible = true;
            fma.Visible = false;
            fsu.Visible = false;
            lsm.Visible = false;
            lsk.Visible = false;
            fsk.Visible = false;
            fmu.Visible = false;
            fab.Visible = false;
            fmk.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            fsm.MdiParent = this;
            fsm.Visible = true;
            fma.Visible = false;
            fsu.Visible = false;
            fsk.Visible = false;
            lsm.Visible = false;
            lsk.Visible = false;
            fmu.Visible = false;
            fab.Visible = false;
            fmk.Visible = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            fsk.MdiParent = this;
            fsk.Visible = true;
            fsm.Visible = false;
            fma.Visible = false;
            lsm.Visible = false;
            lsk.Visible = false;
            fsu.Visible = false;
            fmu.Visible = false;
            fab.Visible = false;
            fmk.Visible = false;
        }

        private void suratKeluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fsk.MdiParent = this;
            fsk.Visible = true;
            fsm.Visible = false;
            fma.Visible = false;
            lsm.Visible = false;
            lsk.Visible = false;
            fsu.Visible = false;
            fmu.Visible = false;
            fab.Visible = false;
            fmk.Visible = false;
        }

        private void formUtama_Load(object sender, EventArgs e)
        {

        }

        private void pengaturanUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmu.MdiParent = this;
            fmu.Visible = true;
            fsm.Visible = false;
            fma.Visible = false;
            lsk.Visible = false;
            fsu.Visible = false;
            fsk.Visible = false;
            lsm.Visible = false;
            fab.Visible = false;
            fmk.Visible = false;
        }

        private void tentangAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fab.MdiParent = this;
            fab.Visible = true;
            fsm.Visible = false;
            fma.Visible = false;
            lsk.Visible = false;
            fsu.Visible = false;
            fsk.Visible = false;
            fmu.Visible = false;
            fmk.Visible = false;
            lsm.Visible = false;
        }

        private void arsipSuratMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmk.MdiParent = this;
            fmk.Visible = true;
            fsm.Visible = false;
            lsk.Visible = false;
            fma.Visible = false;
            fsu.Visible = false;
            fsk.Visible = false;
            fmu.Visible = false;
            fab.Visible = false;
            lsm.Visible = false;
        }

        private void laporanSuratMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsm.MdiParent = this;
            lsm.Visible = true;
            fmk.Visible = false;
            fsm.Visible = false;
            fma.Visible = false;
            fsu.Visible = false;
            fsk.Visible = false;
            fmu.Visible = false;
            fab.Visible = false;
            lsk.Visible = false;
        }

        private void laporanSuratKeluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsk.MdiParent = this;
            lsk.Visible = true;
            lsm.Visible = false;
            fmk.Visible = false;
            fsm.Visible = false;
            fma.Visible = false;
            fsu.Visible = false;
            fsk.Visible = false;
            fmu.Visible = false;
            fab.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
