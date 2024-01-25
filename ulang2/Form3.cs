using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulang2
{
    public partial class Form3 : Form
    {
        bool sidebarxp;

        public Form3()
        {
            InitializeComponent();
        }

        void time()
        {
            if (sidebarxp)
            {
                panel1.Width -= 10;
                if (panel1.Width == panel1.MinimumSize.Width)
                {
                    sidebarxp = false;
                    timer1.Stop();
                }
            }
            else
            {
                panel1.Width += 10;
                if (panel1.Width == panel1.MaximumSize.Width)
                {
                    sidebarxp = true;
                    timer1.Stop();
                }
            }
        }

        public void loadform(object Form)
        {
            if (this.panel6.Controls.Count > 0)
                this.panel6.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel6.Controls.Add(f);
            this.panel6.Tag = f;
            f.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Form1());
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
