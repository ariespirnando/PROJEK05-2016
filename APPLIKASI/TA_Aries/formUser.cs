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
    public partial class formUser : Form
    {
        Koneksi konek = new Koneksi();
        private SqlCommand cmd;
        String sql;
        SqlDataReader baca = null;
        public formUser()
        {
            InitializeComponent();
            bersih();
            isidata();
        }
        public void simpan()
        {
            SqlConnection kon = konek.isikoneksi();
            try
            {
                kon.Open();
                sql = "INSERT INTO Pengguna VALUES('" + txtUsername.Text + "','" + txtpassword.Text + "','"+txtemail.Text+"')";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();
                kon.Close();
                MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isidata();
                bersih();
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
                sql = "UPDATE Pengguna SET Password ='" + txtpassword.Text + "',Email ='" + txtemail.Text + "'  WHERE Username ='" + txtUsername.Text + "'";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();
                kon.Close();
                MessageBox.Show("Data berhasil diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
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
                sql = "DELETE Pengguna WHERE Username ='" + txtUsername.Text + "'";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();
                kon.Close();
                MessageBox.Show("Data berhasil dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                isidata();
            }
            catch (Exception)
            {
                MessageBox.Show("Data gagal di hapus");
            }
        }
        public void isidata()
        {

            listdataUser.Items.Clear();
            listdataUser.Columns.Clear();
            listdataUser.Columns.Add("Username", 100, HorizontalAlignment.Left);
            listdataUser.Columns.Add("Password", 100, HorizontalAlignment.Left);
            listdataUser.Columns.Add("Email", 140, HorizontalAlignment.Left);

            listdataUser.GridLines = true;
            listdataUser.FullRowSelect = true;
            listdataUser.Activation = ItemActivation.TwoClick;
            listdataUser.View = View.Details;
            listdataUser.MultiSelect = false;

            SqlConnection kon = konek.isikoneksi();

            try
            {
                kon.Open();
                sql = "Select * from Pengguna";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();

                baca = cmd.ExecuteReader();
                while (baca.Read())
                {
                    ListViewItem data1 = new ListViewItem(baca["username"].ToString(), 0);
                    data1.SubItems.Add(baca["password"].ToString());
                    data1.SubItems.Add(baca["email"].ToString());
                    listdataUser.Items.Add(data1);
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
        public void Pencarian()
        {

            listdataUser.Items.Clear();
            listdataUser.Columns.Clear();
            listdataUser.Columns.Add("Username", 100, HorizontalAlignment.Left);
            listdataUser.Columns.Add("Password", 100, HorizontalAlignment.Left);
            listdataUser.Columns.Add("Email", 140, HorizontalAlignment.Left);

            listdataUser.GridLines = true;
            listdataUser.FullRowSelect = true;
            listdataUser.Activation = ItemActivation.TwoClick;
            listdataUser.View = View.Details;
            listdataUser.MultiSelect = false;

            SqlConnection kon = konek.isikoneksi();

            try
            {
                kon.Open();
                sql = "Select * from Pengguna WHERE email like '%"+txtcariemail.Text+"%'";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();

                baca = cmd.ExecuteReader();
                while (baca.Read())
                {
                    ListViewItem data1 = new ListViewItem(baca["username"].ToString(), 0);
                    data1.SubItems.Add(baca["password"].ToString());
                    data1.SubItems.Add(baca["email"].ToString());
                    listdataUser.Items.Add(data1);
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
            txtcariemail.Clear();
            txtemail.Clear();
            txtpassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
            txtpaswordlogin.Clear();
            txtUsernameLogin.Clear();
        }
        public void opentombol()
        {
            txtcariemail.Enabled = true;
            txtemail.Enabled = true;
            txtpassword.Enabled = true;
            txtUsername.Enabled = true;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
            btnSimpan.Enabled = true;
            listdataUser.Enabled = true;
            
        }
        public void offtombol()
        {
            listdataUser.Enabled = false;
            txtcariemail.Enabled = false;
            txtemail.Enabled = false;
            txtpassword.Enabled = false;
            txtUsername.Enabled = false;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            btnSimpan.Enabled = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsernameLogin.Text.Trim() == "" || txtpaswordlogin.Text.Trim() == "")
            {
                MessageBox.Show("Gagal Login", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else
            {
                SqlConnection kon = konek.isikoneksi();
                try
                {
                    kon.Open();
                    sql = "Select * from Pengguna WHERE username ='" + txtUsernameLogin.Text + "' and password ='" + txtpaswordlogin.Text + "'";
                    cmd = new SqlCommand(sql, kon);
                    cmd.ExecuteNonQuery();
                    baca = cmd.ExecuteReader();


                    if (baca.Read())
                    {
                        pane1.Visible = true;
                        panel1.Visible = true;
                        panel2.Visible = true;
                        panel4.Visible = true;
                        bersih();
                        offtombol();
                        panelogin.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Gagal Login", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Gagal Login", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bersih();
            this.Hide(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pane1.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panelogin.Visible = true;
            bersih();
            this.Hide(); 
            isidata();
        }

        private void formUser_Load(object sender, EventArgs e)
        {

        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            bersih();
            opentombol();
        }

        private void txtcariemail_TextChanged(object sender, EventArgs e)
        {
            Pencarian();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtpassword.Text.Trim() == "" || txtemail.Text.Trim() == "")
            {
                MessageBox.Show("Terdapat data yang Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                simpan();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtpassword.Text.Trim() == "" || txtemail.Text.Trim() == "")
            {
                MessageBox.Show("Terdapat data yang Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hapus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtpassword.Text.Trim() == "" || txtemail.Text.Trim() == "")
            {
                MessageBox.Show("Terdapat data yang Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                edit();
            }
        }

        private void listdataUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtUsername.Text = Convert.ToString(this.listdataUser.SelectedItems[0].SubItems[0].Text);
                txtpassword.Text = Convert.ToString(this.listdataUser.SelectedItems[0].SubItems[1].Text);
                txtemail.Text = Convert.ToString(this.listdataUser.SelectedItems[0].SubItems[2].Text);
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString());
            }
        }
    }
}
