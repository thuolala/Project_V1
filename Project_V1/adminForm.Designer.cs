namespace GUI
{
    partial class adminForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(components);
            panelTop = new Panel();
            logout = new PictureBox();
            panelSearch = new Panel();
            btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            search = new TextBox();
            panelShow = new Guna.UI2.WinForms.Guna2Panel();
            timerMenu = new System.Windows.Forms.Timer(components);
            pictureBox4 = new PictureBox();
            btnMenu = new Guna.UI2.WinForms.Guna2Button();
            displayName = new Label();
            label1 = new Label();
            btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            btnMoney = new Guna.UI2.WinForms.Guna2Button();
            btnInfo = new Guna.UI2.WinForms.Guna2Button();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(182, 228, 226);
            panelTop.Controls.Add(logout);
            panelTop.Controls.Add(panelSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(270, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1112, 89);
            panelTop.TabIndex = 1;
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.Image = Properties.Resources.logout4;
            logout.Location = new Point(6, 28);
            logout.Margin = new Padding(3, 4, 3, 4);
            logout.Name = "logout";
            logout.Size = new Size(32, 32);
            logout.SizeMode = PictureBoxSizeMode.AutoSize;
            logout.TabIndex = 27;
            logout.TabStop = false;
            logout.Click += logout_Click;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelSearch.BackColor = Color.Azure;
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(search);
            panelSearch.Location = new Point(726, 20);
            panelSearch.Margin = new Padding(3, 4, 3, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.RightToLeft = RightToLeft.No;
            panelSearch.Size = new Size(374, 52);
            panelSearch.TabIndex = 26;
            // 
            // btnSearch
            // 
            btnSearch.CheckedState.ImageSize = new Size(64, 64);
            btnSearch.HoverState.Image = Properties.Resources.search;
            btnSearch.Image = Properties.Resources.search;
            btnSearch.ImageOffset = new Point(0, 0);
            btnSearch.ImageRotate = 0F;
            btnSearch.ImageSize = new Size(20, 20);
            btnSearch.Location = new Point(339, 11);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.PressedState.Image = Properties.Resources.search;
            btnSearch.PressedState.ImageSize = new Size(64, 64);
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnSearch.Size = new Size(23, 27);
            btnSearch.TabIndex = 12;
            btnSearch.Click += btnSearch_Click;
            // 
            // search
            // 
            search.BackColor = Color.Azure;
            search.BorderStyle = BorderStyle.None;
            search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            search.ForeColor = Color.FromArgb(0, 0, 64);
            search.Location = new Point(5, 11);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.PlaceholderText = "Tìm kiếm";
            search.Size = new Size(328, 27);
            search.TabIndex = 11;
            // 
            // panelShow
            // 
            panelShow.BackColor = Color.Transparent;
            panelShow.CustomizableEdges = customizableEdges2;
            panelShow.Dock = DockStyle.Fill;
            panelShow.Location = new Point(270, 89);
            panelShow.Margin = new Padding(3, 4, 3, 4);
            panelShow.Name = "panelShow";
            panelShow.ShadowDecoration.CustomizableEdges = customizableEdges3;
            panelShow.Size = new Size(1112, 864);
            panelShow.TabIndex = 2;
            // 
            // timerMenu
            // 
            timerMenu.Interval = 10;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.pmc_logo;
            pictureBox4.Location = new Point(127, 20);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(117, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.CustomizableEdges = customizableEdges4;
            btnMenu.DisabledState.BorderColor = Color.DarkGray;
            btnMenu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenu.FillColor = Color.Transparent;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.White;
            btnMenu.HoverState.FillColor = Color.Transparent;
            btnMenu.Image = Properties.Resources.menu;
            btnMenu.Location = new Point(12, 20);
            btnMenu.Name = "btnMenu";
            btnMenu.PressedColor = Color.Transparent;
            btnMenu.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnMenu.Size = new Size(109, 56);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "  Menu";
            btnMenu.Click += btnMenu_Click;
            // 
            // displayName
            // 
            displayName.AutoSize = true;
            displayName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            displayName.ForeColor = Color.White;
            displayName.Location = new Point(55, 105);
            displayName.Name = "displayName";
            displayName.Size = new Size(49, 23);
            displayName.TabIndex = 11;
            displayName.Text = "(Tên)";
            displayName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSteelBlue;
            label1.Location = new Point(55, 133);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 12;
            label1.Text = "Quản lý cửa hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.Transparent;
            btnEmployee.CustomizableEdges = customizableEdges6;
            btnEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEmployee.FillColor = Color.Transparent;
            btnEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.ForeColor = Color.FromArgb(182, 228, 226);
            btnEmployee.Image = Properties.Resources.management;
            btnEmployee.ImageAlign = HorizontalAlignment.Left;
            btnEmployee.ImageOffset = new Point(4, 0);
            btnEmployee.Location = new Point(0, 186);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.RightToLeft = RightToLeft.No;
            btnEmployee.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnEmployee.Size = new Size(270, 56);
            btnEmployee.TabIndex = 13;
            btnEmployee.Text = "  Quản lý nhân viên";
            btnEmployee.TextAlign = HorizontalAlignment.Left;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Transparent;
            btnCustomer.CustomizableEdges = customizableEdges8;
            btnCustomer.DisabledState.BorderColor = Color.DarkGray;
            btnCustomer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomer.FillColor = Color.Transparent;
            btnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomer.ForeColor = Color.FromArgb(182, 228, 226);
            btnCustomer.Image = Properties.Resources.value;
            btnCustomer.ImageAlign = HorizontalAlignment.Left;
            btnCustomer.ImageOffset = new Point(4, 0);
            btnCustomer.Location = new Point(0, 242);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.RightToLeft = RightToLeft.No;
            btnCustomer.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnCustomer.Size = new Size(270, 56);
            btnCustomer.TabIndex = 14;
            btnCustomer.Text = "  Quản lý khách hàng";
            btnCustomer.TextAlign = HorizontalAlignment.Left;
            // 
            // btnMoney
            // 
            btnMoney.BackColor = Color.Transparent;
            btnMoney.CustomizableEdges = customizableEdges10;
            btnMoney.DisabledState.BorderColor = Color.DarkGray;
            btnMoney.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMoney.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMoney.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMoney.FillColor = Color.Transparent;
            btnMoney.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMoney.ForeColor = Color.FromArgb(182, 228, 226);
            btnMoney.Image = Properties.Resources.bar_chart;
            btnMoney.ImageAlign = HorizontalAlignment.Left;
            btnMoney.ImageOffset = new Point(4, 0);
            btnMoney.Location = new Point(0, 298);
            btnMoney.Name = "btnMoney";
            btnMoney.RightToLeft = RightToLeft.No;
            btnMoney.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnMoney.Size = new Size(270, 56);
            btnMoney.TabIndex = 16;
            btnMoney.Text = "  Xem doanh thu";
            btnMoney.TextAlign = HorizontalAlignment.Left;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Transparent;
            btnInfo.CustomizableEdges = customizableEdges12;
            btnInfo.DisabledState.BorderColor = Color.DarkGray;
            btnInfo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInfo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInfo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInfo.FillColor = Color.Transparent;
            btnInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInfo.ForeColor = Color.FromArgb(182, 228, 226);
            btnInfo.Image = Properties.Resources.pencil;
            btnInfo.ImageAlign = HorizontalAlignment.Left;
            btnInfo.ImageOffset = new Point(4, 0);
            btnInfo.Location = new Point(0, 354);
            btnInfo.Name = "btnInfo";
            btnInfo.RightToLeft = RightToLeft.No;
            btnInfo.ShadowDecoration.CustomizableEdges = customizableEdges13;
            btnInfo.Size = new Size(270, 56);
            btnInfo.TabIndex = 16;
            btnInfo.Text = "  Chỉnh sửa thông tin";
            btnInfo.TextAlign = HorizontalAlignment.Left;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.FillColor = Color.Transparent;
            guna2CirclePictureBox1.Image = Properties.Resources.user__1_;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(12, 116);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(32, 32);
            guna2CirclePictureBox1.TabIndex = 17;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.FromArgb(182, 228, 226);
            guna2Separator1.Location = new Point(0, 79);
            guna2Separator1.MaximumSize = new Size(270, 0);
            guna2Separator1.MinimumSize = new Size(42, 0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(270, 20);
            guna2Separator1.TabIndex = 18;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(3, 49, 90);
            panelMenu.Controls.Add(guna2Separator1);
            panelMenu.Controls.Add(guna2CirclePictureBox1);
            panelMenu.Controls.Add(btnInfo);
            panelMenu.Controls.Add(btnMoney);
            panelMenu.Controls.Add(btnCustomer);
            panelMenu.Controls.Add(btnEmployee);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(displayName);
            panelMenu.Controls.Add(btnMenu);
            panelMenu.Controls.Add(pictureBox4);
            panelMenu.CustomizableEdges = customizableEdges15;
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.MaximumSize = new Size(270, 0);
            panelMenu.MinimumSize = new Size(53, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelMenu.Size = new Size(270, 953);
            panelMenu.TabIndex = 0;
            // 
            // adminF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 953);
            Controls.Add(panelShow);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "adminF";
            Text = "Pharmacity";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Panel panelTop;
        private Guna.UI2.WinForms.Guna2Panel panelShow;
        private PictureBox logout;
        private Panel panelSearch;
        private TextBox search;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private System.Windows.Forms.Timer timerMenu;
        private PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Label displayName;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnMoney;
        private Guna.UI2.WinForms.Guna2Button btnInfo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel panelMenu;
    }
}