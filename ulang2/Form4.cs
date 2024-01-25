using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulang2
{
    public partial class Form4 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        Koneksi konn = new Koneksi();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.getConn();
            conn.Open();
            cmd = new SqlCommand("select * from tblpegawai where username_pegawai='" + textBox1.Text + "' and password_pegawai='" + textBox2.Text + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Username dan password anda salah, coba lagi");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
