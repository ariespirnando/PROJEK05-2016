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
    public partial class formArsipMasuk : Form
    {
        Koneksi konek = new Koneksi();
        private SqlCommand cmd;
        String sql;
        SqlDataReader baca = null;
        String Nomorsurat;
        public formArsipMasuk()
        {
            InitializeComponent();
            isidata();
        }
        public void isidata()
        {

            listarsipsuratmasuk.Items.Clear();
            listarsipsuratmasuk.Columns.Clear();
            listarsipsuratmasuk.Columns.Add("Nomor Surat", 400, HorizontalAlignment.Left);

            listarsipsuratmasuk.GridLines = true;
            listarsipsuratmasuk.FullRowSelect = true;
            listarsipsuratmasuk.Activation = ItemActivation.TwoClick;
            listarsipsuratmasuk.View = View.Details;
            listarsipsuratmasuk.MultiSelect = false;

            SqlConnection kon = konek.isikoneksi();

            try
            {
                kon.Open();
                sql = "Select nomorSurat from ArsipSurat";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();

                baca = cmd.ExecuteReader();
                while (baca.Read())
                {
                    ListViewItem data1 = new ListViewItem(baca["nomorSurat"].ToString(), 0);
                    listarsipsuratmasuk.Items.Add(data1);
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
        public void caridata()
        {

            listarsipsuratmasuk.Items.Clear();
            listarsipsuratmasuk.Columns.Clear();
            listarsipsuratmasuk.Columns.Add("Nomor Surat", 400, HorizontalAlignment.Left);

            listarsipsuratmasuk.GridLines = true;
            listarsipsuratmasuk.FullRowSelect = true;
            listarsipsuratmasuk.Activation = ItemActivation.TwoClick;
            listarsipsuratmasuk.View = View.Details;
            listarsipsuratmasuk.MultiSelect = false;

            SqlConnection kon = konek.isikoneksi();

            try
            {
                kon.Open();
                sql = "Select nomorSurat from ArsipSurat where nomorSurat like '%"+nosurat.Text+"%'";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();

                baca = cmd.ExecuteReader();
                while (baca.Read())
                {
                    ListViewItem data1 = new ListViewItem(baca["nomorSurat"].ToString(), 0);
                    listarsipsuratmasuk.Items.Add(data1);
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            nosurat.Clear();
            pictureBox1.Image = null;
            isidata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void formArsip_Load(object sender, EventArgs e)
        {

        }

        private void nosurat_TextChanged(object sender, EventArgs e)
        {
            caridata();
        }

        private void listarsipsuratmasuk_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            try
            {
                Nomorsurat = Convert.ToString(this.listarsipsuratmasuk.SelectedItems[0].SubItems[0].Text);
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString());
            }

            SqlConnection kon = konek.isikoneksi();
            try
            {
                kon.Open();
                sql = "Select Gambar from ArsipSurat WHERE nomorSurat ='"+Nomorsurat+"'";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();

                baca = cmd.ExecuteReader();
                baca.Read();
                byte[] arrFoto = ((byte[])baca.GetValue(0));
                MemoryStream ms = new MemoryStream(arrFoto);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                baca.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());

            }
            finally
            {
                kon.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isidata();
        }
    }
}
