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

namespace TA_Aries
{
    
    public partial class formSurat : Form
    {
        Koneksi konek = new Koneksi();
        private SqlCommand cmd;
        String sql;
        SqlDataReader baca = null;
        public formSurat()
        {
            InitializeComponent();
            isidata();
        }
        public void simpan()
        {
            SqlConnection kon = konek.isikoneksi();
            try
            {
                kon.Open();
                sql = "INSERT INTO TipeSurat VALUES('"+txtKodeSurat.Text+"','"+txtTipeSurat.Text+"')";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();
                kon.Close();
                kodeOtomatis();
                MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openButon();
                isidata();
            }
            catch (Exception)
            {
                MessageBox.Show("Data gagal di simpan");
            }
        }
        public void edit()
        {
            SqlConnection kon = konek.isikoneksi();
            try
            {
                kon.Open();
                sql = "UPDATE TipeSurat SET jenisSurat ='" + txtTipeSurat.Text + "' WHERE kodeSurat ='"+txtKodeSurat.Text+"'";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();
                kon.Close();
                kodeOtomatis();
                MessageBox.Show("Data berhasil diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openButon();
                isidata();
            }
            catch (Exception)
            {
                MessageBox.Show("Data gagal di edit");
            }
        }
        public void hapus()
        {
            SqlConnection kon = konek.isikoneksi();
            try
            {
                kon.Open();
                sql = "DELETE TipeSurat WHERE kodeSurat ='" + txtKodeSurat.Text + "'";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();
                kon.Close();
                kodeOtomatis();
                MessageBox.Show("Data berhasil dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openButon();
                isidata();
            }
            catch (Exception)
            {
                MessageBox.Show("Data gagal di hapus");
            }
        }
        public void kodeOtomatis()
        {
            SqlConnection kon = konek.isikoneksi();
            try
            {
                string Otomatis ="";
                kon.Open();
                sql = "SELECT MAX(right(kodeSurat,2)) FROM TipeSurat";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();

                baca = cmd.ExecuteReader();
                baca.Read();
                
                if(baca[0].ToString() !=""){
                    Otomatis = "Kod"+(int.Parse(baca[0].ToString())+1).ToString("00");
                }
                baca.Close();
                txtKodeSurat.Text = Otomatis;


            }catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }finally
            {
                kon.Close();

            }
        }
        public void openButon()
        {
            btnSimpan.Enabled = true;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
            listTipeSurat.Enabled = true;
            txtTipeSurat.Text = "";
            txtTipeSurat.Enabled = true;
        }
        public void isidata()
        {
            
            listTipeSurat.Items.Clear();
            listTipeSurat.Columns.Clear();
            listTipeSurat.Columns.Add("Kode Surat", 90, HorizontalAlignment.Left);
            listTipeSurat.Columns.Add("Jenis Surat", 175, HorizontalAlignment.Left);

            listTipeSurat.GridLines = true;
            listTipeSurat.FullRowSelect = true;
            listTipeSurat.Activation = ItemActivation.TwoClick;
            listTipeSurat.View = View.Details;
            listTipeSurat.MultiSelect = false;

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
                    listTipeSurat.Items.Add(data1);
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
        private void button5_Click(object sender, EventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            listTipeSurat.Enabled = false;
            txtTipeSurat.Clear();
            txtKodeSurat.Clear();
            txtTipeSurat.Enabled = false;
            this.Hide(); 
            isidata();
        }

        private void formSurat_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kodeOtomatis();
            openButon();
            txtTipeSurat.Focus();
        }

        private void btnSimpan_Click(object sender, System.EventArgs e)
        {
            if (txtTipeSurat.Text.Trim() == "")
            {
                MessageBox.Show("Terdapat data yang Kosong","Peringatan",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                simpan();
            }
        }

        private void listTipeSurat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtKodeSurat.Text = Convert.ToString(this.listTipeSurat.SelectedItems[0].SubItems[0].Text);
                txtTipeSurat.Text = Convert.ToString(this.listTipeSurat.SelectedItems[0].SubItems[1].Text);
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTipeSurat.Text.Trim() == "")
            {
                MessageBox.Show("Terdapat data yang Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                edit();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtTipeSurat.Text.Trim() == "")
            {
                MessageBox.Show("Terdapat data yang Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hapus();
            }
        }
    }
}
