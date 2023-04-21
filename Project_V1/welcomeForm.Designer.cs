namespace GUI
{
    partial class welcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mini = new PictureBox();
            exit = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(216, 163);
            label1.Name = "label1";
            label1.Size = new Size(314, 80);
            label1.TabIndex = 3;
            label1.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.aaaa__1_1;
            pictureBox1.Location = new Point(90, 226);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // mini
            // 
            mini.BackColor = Color.Transparent;
            mini.Image = Properties.Resources.mini;
            mini.Location = new Point(692, 12);
            mini.Name = "mini";
            mini.Size = new Size(20, 20);
            mini.SizeMode = PictureBoxSizeMode.AutoSize;
            mini.TabIndex = 7;
            mini.TabStop = false;
            mini.Click += mini_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.Image = Properties.Resources.exit;
            exit.Location = new Point(718, 12);
            exit.Name = "exit";
            exit.Size = new Size(20, 20);
            exit.SizeMode = PictureBoxSizeMode.AutoSize;
            exit.TabIndex = 6;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 614);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 19);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 19);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(78, 572);
            label3.Name = "label3";
            label3.Size = new Size(194, 21);
            label3.TabIndex = 9;
            label3.Text = "Phát triển bởi Extract Team";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(544, 572);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 10;
            label2.Text = "@Copyright 2023";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.pmc_logo;
            pictureBox2.Location = new Point(562, 520);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.logo_color_transparent1;
            pictureBox3.Location = new Point(127, 489);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // welcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            BackgroundImage = Properties.Resources.bg__1_;
            ClientSize = new Size(750, 630);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(mini);
            Controls.Add(exit);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "welcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pharmacity";
            Load += welcomeForm_Load;
            MouseDown += welcomeForm_MouseDown;
            MouseMove += welcomeForm_MouseMove;
            MouseUp += welcomeForm_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mini).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox mini;
        private PictureBox exit;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}