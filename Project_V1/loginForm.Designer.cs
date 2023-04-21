namespace GUI
{
    partial class loginForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(components);
            panelLogin = new Guna.UI2.WinForms.Guna2Panel();
            errorLogin = new Label();
            btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            panelPass = new Guna.UI2.WinForms.Guna2Panel();
            btnShowPass = new Guna.UI2.WinForms.Guna2ImageButton();
            password = new TextBox();
            pictureBox3 = new PictureBox();
            panelUname = new Guna.UI2.WinForms.Guna2Panel();
            username = new TextBox();
            pictureBox2 = new PictureBox();
            linkLabelForgotPass = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            mini = new PictureBox();
            exit = new PictureBox();
            pictureBox1 = new PictureBox();
            panelLogin.SuspendLayout();
            panelPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelUname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.None;
            panelLogin.BackColor = Color.White;
            panelLogin.BorderColor = Color.FromArgb(94, 148, 255);
            panelLogin.BorderRadius = 10;
            panelLogin.BorderThickness = 1;
            panelLogin.Controls.Add(errorLogin);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(panelPass);
            panelLogin.Controls.Add(panelUname);
            panelLogin.Controls.Add(linkLabelForgotPass);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.CustomizableEdges = customizableEdges8;
            panelLogin.Location = new Point(110, 144);
            panelLogin.Name = "panelLogin";
            panelLogin.ShadowDecoration.CustomizableEdges = customizableEdges9;
            panelLogin.Size = new Size(530, 379);
            panelLogin.TabIndex = 0;
            // 
            // errorLogin
            // 
            errorLogin.AutoSize = true;
            errorLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            errorLogin.ForeColor = Color.Red;
            errorLogin.Location = new Point(35, 236);
            errorLogin.Name = "errorLogin";
            errorLogin.Size = new Size(12, 17);
            errorLogin.TabIndex = 23;
            errorLogin.Text = " ";
            // 
            // btnLogin
            // 
            btnLogin.Animated = true;
            btnLogin.BorderRadius = 10;
            btnLogin.CustomizableEdges = customizableEdges1;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor2 = Color.FromArgb(128, 255, 128);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(34, 268);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogin.Size = new Size(460, 41);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // panelPass
            // 
            panelPass.BackColor = Color.White;
            panelPass.BorderColor = Color.FromArgb(94, 148, 255);
            panelPass.BorderRadius = 10;
            panelPass.BorderThickness = 1;
            panelPass.Controls.Add(btnShowPass);
            panelPass.Controls.Add(password);
            panelPass.Controls.Add(pictureBox3);
            panelPass.CustomizableEdges = customizableEdges4;
            panelPass.Location = new Point(35, 193);
            panelPass.Name = "panelPass";
            panelPass.ShadowDecoration.CustomizableEdges = customizableEdges5;
            panelPass.Size = new Size(460, 40);
            panelPass.TabIndex = 21;
            // 
            // btnShowPass
            // 
            btnShowPass.CheckedState.ImageSize = new Size(64, 64);
            btnShowPass.HoverState.Image = Properties.Resources.hide__1_1;
            btnShowPass.Image = Properties.Resources.hide__1_;
            btnShowPass.ImageOffset = new Point(0, 0);
            btnShowPass.ImageRotate = 0F;
            btnShowPass.ImageSize = new Size(20, 20);
            btnShowPass.Location = new Point(425, 9);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.PressedState.ImageSize = new Size(64, 64);
            btnShowPass.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnShowPass.Size = new Size(20, 20);
            btnShowPass.TabIndex = 5;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(42, 9);
            password.Name = "password";
            password.Size = new Size(377, 22);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.key;
            pictureBox3.Location = new Point(4, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panelUname
            // 
            panelUname.BackColor = Color.White;
            panelUname.BorderColor = Color.FromArgb(94, 148, 255);
            panelUname.BorderRadius = 10;
            panelUname.BorderThickness = 1;
            panelUname.Controls.Add(username);
            panelUname.Controls.Add(pictureBox2);
            panelUname.CustomizableEdges = customizableEdges6;
            panelUname.Location = new Point(35, 119);
            panelUname.Name = "panelUname";
            panelUname.ShadowDecoration.CustomizableEdges = customizableEdges7;
            panelUname.Size = new Size(460, 40);
            panelUname.TabIndex = 20;
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(42, 9);
            username.Name = "username";
            username.Size = new Size(414, 22);
            username.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(4, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // linkLabelForgotPass
            // 
            linkLabelForgotPass.AutoSize = true;
            linkLabelForgotPass.Cursor = Cursors.Hand;
            linkLabelForgotPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelForgotPass.LinkColor = Color.LimeGreen;
            linkLabelForgotPass.Location = new Point(393, 247);
            linkLabelForgotPass.Name = "linkLabelForgotPass";
            linkLabelForgotPass.Size = new Size(102, 17);
            linkLabelForgotPass.TabIndex = 19;
            linkLabelForgotPass.TabStop = true;
            linkLabelForgotPass.Text = "Quên mật khẩu?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(35, 169);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 17;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(35, 95);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 16;
            label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(123, 31);
            label2.Name = "label2";
            label2.Size = new Size(283, 32);
            label2.TabIndex = 15;
            label2.Text = "Đăng nhập vào tài khoản";
            // 
            // mini
            // 
            mini.BackColor = Color.Transparent;
            mini.Image = Properties.Resources.mini;
            mini.Location = new Point(693, 12);
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
            exit.Location = new Point(719, 12);
            exit.Name = "exit";
            exit.Size = new Size(20, 20);
            exit.SizeMode = PictureBoxSizeMode.AutoSize;
            exit.TabIndex = 5;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.pmc_logo;
            pictureBox1.Location = new Point(12, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg__1_;
            ClientSize = new Size(750, 630);
            Controls.Add(mini);
            Controls.Add(exit);
            Controls.Add(pictureBox1);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginForm";
            Text = "Pharmacity";
            Load += test_Load;
            MouseDown += loginF_MouseDown;
            MouseMove += loginF_MouseMove;
            MouseUp += loginF_MouseUp;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelPass.ResumeLayout(false);
            panelPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelUname.ResumeLayout(false);
            panelUname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mini).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2Panel panelLogin;
        private PictureBox mini;
        private PictureBox exit;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel panelUname;
        private LinkLabel linkLabelForgotPass;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel panelPass;
        private TextBox username;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private TextBox password;
        private PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowPass;
        private Label errorLogin;
    }
}