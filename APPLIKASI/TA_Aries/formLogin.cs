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
    public partial class formLogin : Form
    {
        Koneksi konek = new Koneksi();
        private SqlCommand cmd;
        String sql;
        SqlDataReader baca = null;

        public formLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection kon = konek.isikoneksi();
            try
            {
                kon.Open();
                sql = "Select * from Pengguna WHERE username ='"+textBox1.Text+"' and password ='"+textBox2.Text+"'";
                cmd = new SqlCommand(sql, kon);
                cmd.ExecuteNonQuery();
                baca = cmd.ExecuteReader();


                if (baca.Read())
                {
                    formUtama fu = new formUtama();
                    fu.Show();
                    this.Hide();
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();

                    MessageBox.Show("Gagal Login","Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception){
                MessageBox.Show("Gagal Login","Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
