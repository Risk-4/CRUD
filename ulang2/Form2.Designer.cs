namespace ulang2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewButtonColumn();
            Column12 = new DataGridViewButtonColumn();
            button1 = new Button();
            button2 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 35);
            label1.Name = "label1";
            label1.Size = new Size(159, 48);
            label1.TabIndex = 0;
            label1.Text = "Pegawai";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employe;
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 168);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 228);
            label3.Name = "label3";
            label3.Size = new Size(152, 30);
            label3.TabIndex = 3;
            label3.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 287);
            label4.Name = "label4";
            label4.Size = new Size(153, 30);
            label4.TabIndex = 4;
            label4.Text = "Jenis Kelamin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(254, 288);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 31);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 343);
            label5.Name = "label5";
            label5.Size = new Size(80, 30);
            label5.TabIndex = 8;
            label5.Text = "No Hp";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(254, 344);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 31);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 405);
            label6.Name = "label6";
            label6.Size = new Size(87, 30);
            label6.TabIndex = 10;
            label6.Text = "Alamat";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(254, 406);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(155, 31);
            textBox5.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            dataGridView1.Location = new Point(484, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(771, 371);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Pegawai";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tanggal lahir";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "JK";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "No Hp";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Alamat";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Username";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.HeaderText = "Password";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 150;
            // 
            // Column9
            // 
            Column9.HeaderText = "Jabatan";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.Width = 150;
            // 
            // Column10
            // 
            Column10.HeaderText = "id";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.Visible = false;
            Column10.Width = 150;
            // 
            // Column11
            // 
            Column11.HeaderText = "Edit";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            Column11.Text = "Edit";
            Column11.UseColumnTextForButtonValue = true;
            Column11.Width = 150;
            // 
            // Column12
            // 
            Column12.HeaderText = "Hapus";
            Column12.MinimumWidth = 8;
            Column12.Name = "Column12";
            Column12.Text = "Hapus";
            Column12.UseColumnTextForButtonValue = true;
            Column12.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(711, 569);
            button1.Name = "button1";
            button1.Size = new Size(133, 73);
            button1.TabIndex = 13;
            button1.Text = "SIMPAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(916, 569);
            button2.Name = "button2";
            button2.Size = new Size(133, 73);
            button2.TabIndex = 14;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(252, 471);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(155, 31);
            textBox6.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 470);
            label7.Name = "label7";
            label7.Size = new Size(117, 30);
            label7.TabIndex = 17;
            label7.Text = "Username";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(254, 535);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(155, 31);
            textBox7.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 599);
            label8.Name = "label8";
            label8.Size = new Size(95, 30);
            label8.TabIndex = 21;
            label8.Text = "Jabatan";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(252, 600);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(155, 31);
            textBox8.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 534);
            label9.Name = "label9";
            label9.Size = new Size(112, 30);
            label9.TabIndex = 19;
            label9.Text = "Password";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(484, 600);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(37, 31);
            textBox9.TabIndex = 23;
            textBox9.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1267, 666);
            Controls.Add(textBox9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewButtonColumn Column11;
        private DataGridViewButtonColumn Column12;
    }
}