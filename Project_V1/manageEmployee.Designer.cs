namespace GUI
{
    partial class manageEmployee
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelEmp = new Guna.UI2.WinForms.Guna2Panel();
            panelShow = new Guna.UI2.WinForms.Guna2Panel();
            panelDisplay = new FlowLayoutPanel();
            panelPos = new Guna.UI2.WinForms.Guna2Panel();
            panelTop = new Panel();
            btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            logout = new PictureBox();
            panelSearch = new Panel();
            btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            search = new TextBox();
            panelEmp.SuspendLayout();
            panelShow.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // panelEmp
            // 
            panelEmp.Controls.Add(panelShow);
            panelEmp.Controls.Add(panelTop);
            panelEmp.CustomizableEdges = customizableEdges8;
            panelEmp.Dock = DockStyle.Fill;
            panelEmp.Location = new Point(0, 0);
            panelEmp.Name = "panelEmp";
            panelEmp.ShadowDecoration.CustomizableEdges = customizableEdges9;
            panelEmp.Size = new Size(973, 634);
            panelEmp.TabIndex = 0;
            // 
            // panelShow
            // 
            panelShow.Controls.Add(panelDisplay);
            panelShow.Controls.Add(panelPos);
            panelShow.CustomizableEdges = customizableEdges3;
            panelShow.Location = new Point(0, 67);
            panelShow.Name = "panelShow";
            panelShow.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelShow.Size = new Size(973, 567);
            panelShow.TabIndex = 1;
            // 
            // panelDisplay
            // 
            panelDisplay.AutoScroll = true;
            panelDisplay.Dock = DockStyle.Fill;
            panelDisplay.Location = new Point(0, 52);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(973, 515);
            panelDisplay.TabIndex = 1;
            // 
            // panelPos
            // 
            panelPos.CustomizableEdges = customizableEdges1;
            panelPos.Dock = DockStyle.Top;
            panelPos.Location = new Point(0, 0);
            panelPos.Name = "panelPos";
            panelPos.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelPos.Size = new Size(973, 52);
            panelPos.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(182, 228, 226);
            panelTop.Controls.Add(btnAdd);
            panelTop.Controls.Add(logout);
            panelTop.Controls.Add(panelSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(973, 67);
            panelTop.TabIndex = 0;
            panelTop.Paint += panelTop_Paint;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Animated = true;
            btnAdd.BorderRadius = 10;
            btnAdd.CustomizableEdges = customizableEdges5;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor2 = Color.FromArgb(128, 255, 128);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(786, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAdd.Size = new Size(175, 41);
            btnAdd.TabIndex = 60;
            btnAdd.Text = "Thêm nhân viên";
            btnAdd.Click += btnAdd_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.Image = Properties.Resources.logout4;
            logout.Location = new Point(3, 12);
            logout.Name = "logout";
            logout.Size = new Size(32, 32);
            logout.SizeMode = PictureBoxSizeMode.AutoSize;
            logout.TabIndex = 28;
            logout.TabStop = false;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.Azure;
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(search);
            panelSearch.Location = new Point(41, 12);
            panelSearch.Name = "panelSearch";
            panelSearch.RightToLeft = RightToLeft.No;
            panelSearch.Size = new Size(327, 39);
            panelSearch.TabIndex = 27;
            // 
            // btnSearch
            // 
            btnSearch.CheckedState.ImageSize = new Size(64, 64);
            btnSearch.HoverState.Image = Properties.Resources.search;
            btnSearch.Image = Properties.Resources.search;
            btnSearch.ImageOffset = new Point(0, 0);
            btnSearch.ImageRotate = 0F;
            btnSearch.ImageSize = new Size(20, 20);
            btnSearch.Location = new Point(297, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.PressedState.Image = Properties.Resources.search;
            btnSearch.PressedState.ImageSize = new Size(64, 64);
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnSearch.Size = new Size(20, 20);
            btnSearch.TabIndex = 12;
            // 
            // search
            // 
            search.BackColor = Color.Azure;
            search.BorderStyle = BorderStyle.None;
            search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            search.ForeColor = Color.FromArgb(0, 0, 64);
            search.Location = new Point(4, 8);
            search.Name = "search";
            search.PlaceholderText = "Tìm kiếm theo tên/ID";
            search.Size = new Size(287, 22);
            search.TabIndex = 11;
            // 
            // manageEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 634);
            Controls.Add(panelEmp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "manageEmployee";
            Load += manageEmployee_Load;
            panelEmp.ResumeLayout(false);
            panelShow.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelEmp;
        private Panel panelTop;
        private Panel panelSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private TextBox search;
        private PictureBox logout;
        private Guna.UI2.WinForms.Guna2Panel panelShow;
        private Guna.UI2.WinForms.Guna2Panel panelPos;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private FlowLayoutPanel panelDisplay;
    }
}