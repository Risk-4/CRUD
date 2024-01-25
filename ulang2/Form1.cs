using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace ulang2
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        static Koneksi konn = new Koneksi();
        private SqlConnection conn = konn.getConn();

        public Form1()
        {
            InitializeComponent();
        }

        void Bersihkan()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            button1.Text = "SIMPAN";
        }

        void TampilBarang()
        {
            dataGridView1.Rows.Clear();

            try
            {
                cmd = new SqlCommand("select * from barang1", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int i = dataGridView1.Rows.Add();
                        int no = i + 1;
                        DataGridViewRow row = dataGridView1.Rows[i];
                        row.Cells[0].Value = no.ToString();
                        row.Cells[1].Value = dr["nama_barang"].ToString();
                        row.Cells[2].Value = dr["stok"].ToString();
                        row.Cells[3].Value = dr["harga_beli"].ToString();
                        row.Cells[4].Value = dr["harga_jual"].ToString();
                        row.Cells[5].Value = dr["satuan"].ToString();
                        row.Cells[8].Value = dr["id_barang"].ToString();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            TampilBarang();
            Bersihkan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap!!!");
            }
            else
            {
                if (button1.Text == "SIMPAN")
                {
                    //simpan
                    try
                    {
                        cmd = new SqlCommand("insert into barang1 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil!");
                        TampilBarang();
                        Bersihkan();
                    }
                    catch (Exception X)
                    {
                        MessageBox.Show(X.ToString());
                    }
                }
                else if (button1.Text == "UPDATE")
                //update
                {
                    try
                    {
                        cmd = new SqlCommand("update barang1 set nama_barang = '" + textBox1.Text + "',stok = '" + textBox2.Text + "',harga_beli = '" + textBox3.Text + "',harga_jual = '" + textBox4.Text + "',satuan = '" + textBox5.Text + "' where id_barang = '" + textBox6.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update Berhasil!!");
                        TampilBarang();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                //Show Edit
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    textBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                    textBox3.Text = row.Cells[3].Value.ToString();
                    textBox4.Text = row.Cells[4].Value.ToString();
                    textBox5.Text = row.Cells[5].Value.ToString();
                    textBox6.Text = row.Cells[8].Value.ToString();
                    button1.Text = "UPDATE";
                    button2.Visible = true;
                }
                else if (e.ColumnIndex == 7)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dialogResult = MessageBox.Show("Yakin dihapus: " + row.Cells[1].Value.ToString() + "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        //delete
                        {
                            cmd = new SqlCommand("delete from barang1 where id_barang = '" + row.Cells[8].Value.ToString() + "'", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Delete Berhasil!");
                            TampilBarang();
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

        void CariBarang()
        {
            dataGridView1.Rows.Clear();
            try
            {
                cmd = new SqlCommand("SELECT * FROM barang1 where id_barang like '%" + textBox7.Text + "%' or nama_barang like '%" + textBox7.Text + "%' ", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int i = dataGridView1.Rows.Add();
                        int no = i + 1;
                        DataGridViewRow row = dataGridView1.Rows[i];
                        row.Cells[0].Value = no.ToString();
                        row.Cells[1].Value = dr["nama_barang"].ToString();
                        row.Cells[2].Value = dr["stok"].ToString();
                        row.Cells[3].Value = dr["harga_beli"].ToString();
                        row.Cells[4].Value = dr["harga_jual"].ToString();
                        row.Cells[5].Value = dr["satuan"].ToString();
                        row.Cells[8].Value = dr["id_barang"].ToString();

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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CariBarang();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
