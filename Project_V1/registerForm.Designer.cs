namespace GUI
{
    partial class registerForm
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
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            loginLink = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            btnReset = new Button();
            btnRegis = new Button();
            label11 = new Label();
            checkBoxRemember = new CheckBox();
            groupBox2 = new GroupBox();
            dob = new DateTimePicker();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            phone = new TextBox();
            hometown = new TextBox();
            fullname = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            confirmPass = new TextBox();
            password = new TextBox();
            email = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            mini = new PictureBox();
            exit = new PictureBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(25, 19);
            label2.Name = "label2";
            label2.Size = new Size(257, 41);
            label2.TabIndex = 3;
            label2.Text = "Đăng ký tài khoản";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(274, 416);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(0, 23);
            linkLabel2.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(loginLink);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnRegis);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(checkBoxRemember);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(130, 39);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 763);
            panel1.TabIndex = 3;
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.Cursor = Cursors.Hand;
            loginLink.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            loginLink.LinkColor = Color.LimeGreen;
            loginLink.Location = new Point(336, 711);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(137, 23);
            loginLink.TabIndex = 29;
            loginLink.TabStop = true;
            loginLink.Text = "Đăng nhập ngay";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(417, 711);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 23);
            linkLabel1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(199, 711);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 27;
            label1.Text = "Đã có tài khoản?";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Gainsboro;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.FromArgb(0, 0, 64);
            btnReset.Location = new Point(311, 633);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(146, 55);
            btnReset.TabIndex = 26;
            btnReset.Text = "Hủy";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnRegis
            // 
            btnRegis.BackColor = Color.SteelBlue;
            btnRegis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegis.ForeColor = Color.White;
            btnRegis.Location = new Point(475, 633);
            btnRegis.Margin = new Padding(3, 4, 3, 4);
            btnRegis.Name = "btnRegis";
            btnRegis.Size = new Size(146, 55);
            btnRegis.TabIndex = 25;
            btnRegis.Text = "Đăng ký";
            btnRegis.UseVisualStyleBackColor = false;
            btnRegis.Click += btnRegis_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 0, 64);
            label11.Location = new Point(150, 592);
            label11.Name = "label11";
            label11.Size = new Size(189, 23);
            label11.TabIndex = 24;
            label11.Text = "Điều khoản và Dịch vụ";
            // 
            // checkBoxRemember
            // 
            checkBoxRemember.AutoSize = true;
            checkBoxRemember.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRemember.ForeColor = Color.FromArgb(0, 0, 64);
            checkBoxRemember.Location = new Point(27, 591);
            checkBoxRemember.Margin = new Padding(3, 4, 3, 4);
            checkBoxRemember.Name = "checkBoxRemember";
            checkBoxRemember.Size = new Size(138, 27);
            checkBoxRemember.TabIndex = 16;
            checkBoxRemember.Text = "Tôi đồng ý với";
            checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dob);
            groupBox2.Controls.Add(radioButtonFemale);
            groupBox2.Controls.Add(radioButtonMale);
            groupBox2.Controls.Add(phone);
            groupBox2.Controls.Add(hometown);
            groupBox2.Controls.Add(fullname);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(27, 299);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(594, 272);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // dob
            // 
            dob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dob.Location = new Point(194, 109);
            dob.Margin = new Padding(3, 4, 3, 4);
            dob.Name = "dob";
            dob.Size = new Size(375, 34);
            dob.TabIndex = 23;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFemale.ForeColor = Color.FromArgb(0, 0, 64);
            radioButtonFemale.Location = new Point(272, 72);
            radioButtonFemale.Margin = new Padding(3, 4, 3, 4);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(60, 32);
            radioButtonFemale.TabIndex = 22;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Nữ";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonMale.ForeColor = Color.FromArgb(0, 0, 64);
            radioButtonMale.Location = new Point(194, 72);
            radioButtonMale.Margin = new Padding(3, 4, 3, 4);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(75, 32);
            radioButtonMale.TabIndex = 21;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Nam";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            phone.BackColor = Color.White;
            phone.BorderStyle = BorderStyle.FixedSingle;
            phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(194, 203);
            phone.Margin = new Padding(3, 4, 3, 4);
            phone.Name = "phone";
            phone.Size = new Size(376, 34);
            phone.TabIndex = 20;
            // 
            // hometown
            // 
            hometown.BackColor = Color.White;
            hometown.BorderStyle = BorderStyle.FixedSingle;
            hometown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hometown.Location = new Point(194, 156);
            hometown.Margin = new Padding(3, 4, 3, 4);
            hometown.Name = "hometown";
            hometown.Size = new Size(376, 34);
            hometown.TabIndex = 19;
            // 
            // fullname
            // 
            fullname.BackColor = Color.White;
            fullname.BorderStyle = BorderStyle.FixedSingle;
            fullname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fullname.Location = new Point(194, 29);
            fullname.Margin = new Padding(3, 4, 3, 4);
            fullname.Name = "fullname";
            fullname.Size = new Size(376, 34);
            fullname.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 0, 64);
            label10.Location = new Point(25, 205);
            label10.Name = "label10";
            label10.Size = new Size(128, 28);
            label10.TabIndex = 17;
            label10.Text = "Số điện thoại";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(27, 167);
            label9.Name = "label9";
            label9.Size = new Size(97, 28);
            label9.TabIndex = 16;
            label9.Text = "Quê quán";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(27, 120);
            label8.Name = "label8";
            label8.Size = new Size(99, 28);
            label8.TabIndex = 15;
            label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(25, 75);
            label7.Name = "label7";
            label7.Size = new Size(87, 28);
            label7.TabIndex = 14;
            label7.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(27, 32);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 13;
            label6.Text = "Họ và tên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(confirmPass);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(27, 65);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(594, 211);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // confirmPass
            // 
            confirmPass.BackColor = Color.White;
            confirmPass.BorderStyle = BorderStyle.FixedSingle;
            confirmPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPass.Location = new Point(194, 149);
            confirmPass.Margin = new Padding(3, 4, 3, 4);
            confirmPass.Name = "confirmPass";
            confirmPass.Size = new Size(376, 34);
            confirmPass.TabIndex = 12;
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(194, 88);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Name = "password";
            password.Size = new Size(376, 34);
            password.TabIndex = 11;
            // 
            // email
            // 
            email.BackColor = Color.White;
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(194, 29);
            email.Margin = new Padding(3, 4, 3, 4);
            email.Name = "email";
            email.Size = new Size(376, 34);
            email.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(25, 149);
            label5.Name = "label5";
            label5.Size = new Size(177, 28);
            label5.TabIndex = 8;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(25, 88);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 7;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(25, 29);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.pmc_logo;
            pictureBox1.Location = new Point(5, 20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // mini
            // 
            mini.BackColor = Color.Transparent;
            mini.Image = Properties.Resources.mini;
            mini.Location = new Point(791, 16);
            mini.Margin = new Padding(3, 4, 3, 4);
            mini.Name = "mini";
            mini.Size = new Size(20, 20);
            mini.SizeMode = PictureBoxSizeMode.AutoSize;
            mini.TabIndex = 8;
            mini.TabStop = false;
            mini.Click += mini_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.Image = Properties.Resources.exit;
            exit.Location = new Point(821, 16);
            exit.Margin = new Padding(3, 4, 3, 4);
            exit.Name = "exit";
            exit.Size = new Size(20, 20);
            exit.SizeMode = PictureBoxSizeMode.AutoSize;
            exit.TabIndex = 7;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            BackgroundImage = Properties.Resources.bg__1_;
            ClientSize = new Size(857, 840);
            Controls.Add(mini);
            Controls.Add(exit);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "registerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += registerForm_Load;
            MouseDown += registerForm_MouseDown;
            MouseMove += registerForm_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mini).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private LinkLabel linkLabel2;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private DateTimePicker dob;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private TextBox phone;
        private TextBox hometown;
        private TextBox fullname;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox confirmPass;
        private TextBox password;
        private TextBox email;
        private Label label11;
        private CheckBox checkBoxRemember;
        private Button btnReset;
        private Button btnRegis;
        private PictureBox pictureBox1;
        private PictureBox mini;
        private PictureBox exit;
        private LinkLabel loginLink;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}