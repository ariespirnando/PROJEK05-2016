using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace TA_Aries
{
    public partial class formSuratKeluar : Form
    {
        Koneksi konek = new Koneksi();
        private SqlCommand cmd;
        String sql;
        private SqlCommand cmdGambar;
        String sqlGambar;
        SqlDataReader baca = null;

        public formSuratKeluar()
        {
            InitializeComponent();
            dataSuratMasuk();
            ListKodesurat();
            setingtanggal();
            bersih();
        }
        public void ListKodesurat()
        {

            listdataKodesurat.Items.Clear();
            listdataKodesurat.Columns.Clear();
            listdataKodesurat.Columns.Add("Kode Surat", 90, HorizontalAlignment.Left);
            listdataKodesurat.Columns.Add("Jenis Surat", 150, HorizontalAlignment.Left);

            listdataKodesurat.GridLines = true;
            listdataKodesurat.FullRowSelect = true;
            listdataKodesurat.Activation = ItemActivation.TwoClick;
            listdataKodesurat.View = View.Details;
            listdataKodesurat.MultiSelect = false;

            SqlConnection kon = konek.isikoneksi();

            try
            {
                kon.Open();
                sql = "Select * from TipeSurat";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();

                baca = cmd.ExecuteReader();
                while (baca.Read())
                {
                    ListViewItem data1 = new ListViewItem(baca["kodeSurat"].ToString(), 0);
                    data1.SubItems.Add(baca["jenisSurat"].ToString());
                    listdataKodesurat.Items.Add(data1);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                kon.Close();
            }
        }
        public void bersih()
        {
            txtnomrsurat.Clear();
            txttanggal.Value = DateTime.Now;
            txtalamat.Clear();
            txtpenerima.Clear();
            txtpengirim.Clear();
            txtprihal.Clear();
            txtkodesurat.Clear();
            txtpath.Text = "Upload Kembali File";
            txtnomrsurat.Focus();
        }
        public void ontombol()
        {
            listsuratmasuk.Enabled = true;
            textBox5.Enabled = true;
            txtnomrsurat.Enabled = true;
            txttanggal.Enabled = true;
            txtalamat.Enabled = true;
            txtpenerima.Enabled = true;
            txtpengirim.Enabled = true;
            txtprihal.Enabled = true;
            btnarsip.Enabled = true;
            btnedit.Enabled = true;
            btnhapus.Enabled = true;
            btnjenissurat.Enabled = true;
            btnsimpan.Enabled = true;
            bersih();
        }
        public void offtombol()
        {
            txtnomrsurat.Enabled = false;
            txttanggal.Enabled = false;
            txtalamat.Enabled = false;
            txtpenerima.Enabled = false;
            txtpengirim.Enabled = false;
            txtprihal.Enabled = false;
            btnarsip.Enabled = false;
            btnedit.Enabled = false;
            btnhapus.Enabled = false;
            btnjenissurat.Enabled = false;
            btnsimpan.Enabled = false;
            listsuratmasuk.Enabled = false;
            textBox5.Enabled = false;
            bersih();
        }
        public void setingtanggal()
        {
            txttanggal.Format = DateTimePickerFormat.Custom;
            txttanggal.CustomFormat = "dd-MMM-yyyy";
            txttanggal.Value = DateTime.Now;
        }
       
        public void simpan()
        {
            string tanggal = txttanggal.Value.ToString("yyyy-MM-dd");
            SqlConnection kon = konek.isikoneksi();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] arrImage = ms.GetBuffer();
            try
            {
                kon.Open();
                sql = "INSERT INTO SuratKeluar VALUES('" + txtnomrsurat.Text + "','" + txtprihal.Text + "','" + tanggal + "','" + txtpengirim.Text + "','" + txtalamat.Text + "','" + txtpenerima.Text + "','" + txtkodesurat.Text + "')";
                sqlGambar = "INSERT INTO ArsipSuratKel VALUES ('" + txtnomrsurat.Text + "',@img)";
                cmd = new SqlCommand(sql, kon);

                cmdGambar = new SqlCommand(sqlGambar, kon);
                cmdGambar.Parameters.Add(new SqlParameter("@img", SqlDbType.Image)).Value = arrImage;

                cmd.ExecuteNonQuery();
                cmdGambar.ExecuteNonQuery();

                MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataSuratMasuk();
                bersih();
                kon.Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Data gagal di simpan");
            }
        }
        public void setkode(string data)
        {
            SqlConnection kon = konek.isikoneksi();
            try
            {
                kon.Open();
                sql = "SELECT * FROM TipeSurat WHERE jenisSurat ='"+data+"' ";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();
                baca = cmd.ExecuteReader();
                baca.Read();
                txtkodesurat.Text = baca[0].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
            finally
            {
                kon.Close();

            }
        }
        
        public void Edit()
        {
            string tanggal = txttanggal.Value.ToString("yyyy-MM-dd");
            SqlConnection kon = konek.isikoneksi();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] arrImage = ms.GetBuffer();
            try
            {
                //, tanggalSM = '" + tanggal + "',
                kon.Open();
                sql = "UPDATE SuratKeluar SET prihalSK ='" + txtprihal.Text + "', PengirimSK = '" + txtpengirim.Text + "', tanggalSK = '" + tanggal + "', " +
                "alamatSK = '" + txtalamat.Text + "', penerimaSK = '" + txtpenerima.Text + "', kodeSurat = '" + txtkodesurat.Text + "'"+
                "WHERE nomorSurat = '"+txtnomrsurat.Text+"' ";
                cmd = new SqlCommand(sql, kon);

                sqlGambar = "UPDATE ArsipSuratKel SET GambarSk = @img WHERE nomorSurat ='" + txtnomrsurat.Text + "'";
                cmdGambar = new SqlCommand(sqlGambar, kon);
                cmdGambar.Parameters.Add(new SqlParameter("@img", SqlDbType.Image)).Value = arrImage;

                cmd.ExecuteNonQuery();
                cmdGambar.ExecuteNonQuery();

                kon.Close(); MessageBox.Show("Data berhasil diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataSuratMasuk();
                bersih();
            }
            catch (Exception)
            {
                MessageBox.Show("Data gagal di edit");
            }

        }
        public void hapus()
        {
            string tanggal = txttanggal.Value.ToString("yyyy-MM-dd");
            SqlConnection kon = konek.isikoneksi();
            try
            {
                kon.Open();
                sql = "DELETE SuratKeluar WHERE nomorSurat = '" + txtnomrsurat.Text + "' ";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();
                kon.Close();
                MessageBox.Show("Data berhasil dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataSuratMasuk();
                bersih();
            }
            catch (Exception)
            {
                MessageBox.Show("Data gagal di hapus");
            }
        }
        public void dataSuratMasuk()
        {

            listsuratmasuk.Items.Clear();
            listsuratmasuk.Columns.Clear();
            listsuratmasuk.Columns.Add("Nomor Surat", 90, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Jenis Surat", 90, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Prihal", 200, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Tanggal", 90, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Penerima", 100, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Alamat Penerima", 150, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Pengirim", 100, HorizontalAlignment.Left);

            listsuratmasuk.GridLines = true;
            listsuratmasuk.FullRowSelect = true;
            listsuratmasuk.Activation = ItemActivation.TwoClick;
            listsuratmasuk.View = View.Details;
            listsuratmasuk.MultiSelect = false;

            SqlConnection kon = konek.isikoneksi();
            
            try
            {
                kon.Open();
                sql = "Select sm.nomorSurat, ts.jenisSurat, sm.prihalSK, convert(varchar(20), sm.tanggalSK,106) as [tanggal], sm.penerimaSK, sm.alamatSK, sm.pengirimSK FROM TipeSurat as ts, SuratKeluar as sm WHERE ts.kodeSurat = sm.kodeSurat";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();

                baca = cmd.ExecuteReader();
                while (baca.Read())
                {
                    ListViewItem data1 = new ListViewItem(baca["nomorSurat"].ToString(), 0);
                    data1.SubItems.Add(baca["jenisSurat"].ToString());
                    data1.SubItems.Add(baca["prihalSK"].ToString());
                    data1.SubItems.Add(baca["tanggal"].ToString());
                    data1.SubItems.Add(baca["penerimaSK"].ToString());
                    data1.SubItems.Add(baca["alamatSK"].ToString());
                    data1.SubItems.Add(baca["pengirimSK"].ToString());
                    listsuratmasuk.Items.Add(data1);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                kon.Close();
            }
             
        }
        public void dataSuratMasukCari()
        {

            listsuratmasuk.Items.Clear();
            listsuratmasuk.Columns.Clear();
            listsuratmasuk.Columns.Add("Nomor Surat", 90, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Jenis Surat", 90, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Prihal", 200, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Tanggal", 90, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Penerima", 100, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Alamat Penerima", 150, HorizontalAlignment.Left);
            listsuratmasuk.Columns.Add("Pengirim", 100, HorizontalAlignment.Left);
            

            listsuratmasuk.GridLines = true;
            listsuratmasuk.FullRowSelect = true;
            listsuratmasuk.Activation = ItemActivation.TwoClick;
            listsuratmasuk.View = View.Details;
            listsuratmasuk.MultiSelect = false;

            SqlConnection kon = konek.isikoneksi();

            try
            {
                kon.Open();
                sql = "Select sm.nomorSurat, ts.jenisSurat, sm.prihalSK, convert(varchar(20), "+
                    "sm.tanggalSK,106) as [tanggal], sm.penerimaSK, sm.alamatSK, sm.pengirimSK "+
                    "FROM TipeSurat as ts, SuratKeluar as sm WHERE ts.kodeSurat = sm.kodeSurat and sm.nomorsurat like '%" + textBox5.Text + "%'";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();

                baca = cmd.ExecuteReader();
                while (baca.Read())
                {
                    ListViewItem data1 = new ListViewItem(baca["nomorSurat"].ToString(), 0);
                    data1.SubItems.Add(baca["jenisSurat"].ToString());
                    data1.SubItems.Add(baca["prihalSK"].ToString());
                    data1.SubItems.Add(baca["tanggal"].ToString());
                    data1.SubItems.Add(baca["penerimaSK"].ToString());
                    data1.SubItems.Add(baca["alamatSK"].ToString());
                    data1.SubItems.Add(baca["pengirimSK"].ToString());
                    listsuratmasuk.Items.Add(data1);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                kon.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtnomrsurat.Text.Trim() == "" || txtkodesurat.Text.Trim() == "" || txtprihal.Text.Trim() == "" || txtpengirim.Text.Trim() == "" || txtpenerima.Text.Trim() == "" || txtalamat.Text.Trim() == "")
            {
                MessageBox.Show("Terdapat data yang Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Edit();
            }
        }

        private void formSuratMasuk_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kodesurat.Visible = true;
            ListKodesurat();
        }

        private void listdataKodesurat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtkodesurat.Text = Convert.ToString(this.listdataKodesurat.SelectedItems[0].SubItems[0].Text);
                kodesurat.Visible = false;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString());
            }
        }
        
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            openFile.FileName = "";
            openFile.Title = "Pilih Gambar";
            openFile.Filter = "Image Files|*.bmp;*.jpg;*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                txtpath.Text = openFile.FileName;
                
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtnomrsurat.Text.Trim() == "" || txtkodesurat.Text.Trim() == "" || txtprihal.Text.Trim() == "" || txtpengirim.Text.Trim() == "" || txtpenerima.Text.Trim() == "" || txtalamat.Text.Trim() == "" || txtpath.Text.Trim() == "" || txtpath.Text.Trim() == "Upload Kembali File")
            {
                MessageBox.Show("Terdapat data yang Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                simpan();
            }
            
        }

        private void listsuratmasuk_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String kode;
            try
            {
                txtnomrsurat.Text = Convert.ToString(this.listsuratmasuk.SelectedItems[0].SubItems[0].Text);
                kode = Convert.ToString(this.listsuratmasuk.SelectedItems[0].SubItems[1].Text);
                txtprihal.Text = Convert.ToString(this.listsuratmasuk.SelectedItems[0].SubItems[2].Text);
                txttanggal.Value = Convert.ToDateTime(this.listsuratmasuk.SelectedItems[0].SubItems[3].Text);
                txtpengirim.Text = Convert.ToString(this.listsuratmasuk.SelectedItems[0].SubItems[4].Text);
                txtalamat.Text = Convert.ToString(this.listsuratmasuk.SelectedItems[0].SubItems[5].Text);
                txtpenerima.Text = Convert.ToString(this.listsuratmasuk.SelectedItems[0].SubItems[6].Text);
                txtpath.Text = "Upload Kembali File";
                setkode(kode);
                
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString());
            }
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtnomrsurat.Text.Trim() == "" || txtkodesurat.Text.Trim() == "" || txtprihal.Text.Trim() == "" || txtpengirim.Text.Trim() == "" || txtpenerima.Text.Trim() == "" || txtalamat.Text.Trim() == "")
            {
                MessageBox.Show("Terdapat data yang Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hapus();
            }
        }

        private void listdataKodesurat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataSuratMasukCari();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ontombol();
            bersih();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            offtombol();
            bersih(); 
            dataSuratMasuk();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
