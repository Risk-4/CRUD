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
    public partial class Form2 : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        static Koneksi konn = new Koneksi();
        private SqlConnection conn = konn.getConn();

        void TampilPegawai()
        {
            dataGridView1.Rows.Clear();

            try
            {
                cmd = new SqlCommand("select * from tblpegawai", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int i = dataGridView1.Rows.Add();
                        int no = i + 1;
                        DataGridViewRow row = dataGridView1.Rows[i];
                        row.Cells[0].Value = no.ToString();
                        row.Cells[1].Value = dr["nama_pegawai"].ToString();
                        row.Cells[2].Value = dr["tanggal_lahir"].ToString();
                        row.Cells[3].Value = dr["jeniskelamin"].ToString();
                        row.Cells[4].Value = dr["nohp"].ToString();
                        row.Cells[5].Value = dr["alamat"].ToString();
                        row.Cells[6].Value = dr["username_pegawai"].ToString();
                        row.Cells[7].Value = dr["password_pegawai"].ToString();
                        row.Cells[8].Value = dr["jabatan"].ToString();
                    }
                    dr.Close();
                }
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {

            }
        }

        void Bersihkan()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            button1.Text = "Simpan";
        }

        public Form2()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 10)
                //Show Edit
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    textBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                    textBox3.Text = row.Cells[3].Value.ToString();
                    textBox4.Text = row.Cells[4].Value.ToString();
                    textBox5.Text = row.Cells[5].Value.ToString();
                    textBox6.Text = row.Cells[6].Value.ToString();
                    textBox7.Text = row.Cells[7].Value.ToString();
                    textBox8.Text = row.Cells[8].Value.ToString();
                    //textBox9.Text = row.Cells[9].Value.ToString();
                    button1.Text = "Update";
                    button2.Visible = true;
                }
                else if (e.ColumnIndex == 11)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dialogResult = MessageBox.Show("Yakin dihapus: " + row.Cells[1].Value.ToString() + "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        //delete
                        {
                            cmd = new SqlCommand("delete from tblpegawai where id_pegawai = '" + row.Cells[9].Value.ToString() + "'", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Delete Berhasil!");
                            TampilPegawai();
                            Bersihkan();
                        }
                        catch (Exception X)
                        {
                            MessageBox.Show(X.ToString());
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();
            TampilPegawai();
            Bersihkan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "" || textBox7.Text.Trim() == "" || textBox8.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap!!!");
            }
            else
            {
                if (button1.Text == "Simpan")
                {
                    //simpan
                    try
                    {
                        cmd = new SqlCommand("insert into tblpegawai values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil!");
                        TampilPegawai();
                        Bersihkan();
                    }
                    catch (Exception X)
                    {
                        MessageBox.Show(X.ToString());
                    }
                }
                else if (button1.Text == "Update")
                //update
                {
                    try
                    {
                        cmd = new SqlCommand("update tblpegawai set nama_pegawai = '" + textBox1.Text + "',tanggal_lahir = '" + textBox2.Text + "',jeniskelamin = '" + textBox3.Text + "',nohp = '" + textBox4.Text + "',alamat = '" + textBox5.Text + "',username_pegawai = '" + textBox6 + "',password_pegawai = '" + textBox7 + "',jabatan = '" + textBox8 + "' where id_pegawai = '" + textBox9.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update Berhasil!!");
                        TampilPegawai();
                        Bersihkan();
                    }
                    catch (Exception X)
                    {
                        MessageBox.Show(X.ToString());
                    }
                }
                else
                {

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
