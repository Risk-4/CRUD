namespace ulang2
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel6 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(158, 468);
            panel1.MinimumSize = new Size(79, 468);
            panel1.Name = "panel1";
            panel1.Size = new Size(79, 468);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(10, 297);
            panel4.Name = "panel4";
            panel4.Size = new Size(205, 91);
            panel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-2, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 117, 214);
            button3.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-50, -38);
            button3.Name = "button3";
            button3.Size = new Size(290, 153);
            button3.TabIndex = 1;
            button3.Text = "User";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(203, 91);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, -9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 117, 214);
            button2.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-50, -47);
            button2.Name = "button2";
            button2.Size = new Size(306, 157);
            button2.TabIndex = 1;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(button4);
            panel5.Location = new Point(10, 200);
            panel5.Name = "panel5";
            panel5.Size = new Size(205, 91);
            panel5.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-2, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 117, 214);
            button4.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(-50, -38);
            button4.Name = "button4";
            button4.Size = new Size(290, 153);
            button4.TabIndex = 1;
            button4.Text = "Show";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(203, 91);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu_bar;
            pictureBox1.Location = new Point(9, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-50, -31);
            button1.Name = "button1";
            button1.Size = new Size(306, 141);
            button1.TabIndex = 1;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(79, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(762, 468);
            panel6.TabIndex = 1;
            panel6.Paint += panel6_Paint;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 468);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Button button3;
        private Panel panel5;
        private PictureBox pictureBox4;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
        private Panel panel6;
    }
}