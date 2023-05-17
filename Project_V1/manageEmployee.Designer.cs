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
            btnRefresh = new PictureBox();
            btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            panelSearch = new Panel();
            btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            search = new TextBox();
            panelEmp.SuspendLayout();
            panelShow.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
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
            panelEmp.Margin = new Padding(3, 4, 3, 4);
            panelEmp.Name = "panelEmp";
            panelEmp.ShadowDecoration.CustomizableEdges = customizableEdges9;
            panelEmp.Size = new Size(1112, 845);
            panelEmp.TabIndex = 0;
            // 
            // panelShow
            // 
            panelShow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelShow.Controls.Add(panelDisplay);
            panelShow.Controls.Add(panelPos);
            panelShow.CustomizableEdges = customizableEdges3;
            panelShow.Location = new Point(0, 89);
            panelShow.Margin = new Padding(3, 4, 3, 4);
            panelShow.Name = "panelShow";
            panelShow.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelShow.Size = new Size(1112, 756);
            panelShow.TabIndex = 1;
            // 
            // panelDisplay
            // 
            panelDisplay.AutoScroll = true;
            panelDisplay.BackColor = SystemColors.Control;
            panelDisplay.Dock = DockStyle.Fill;
            panelDisplay.Location = new Point(0, 69);
            panelDisplay.Margin = new Padding(3, 4, 3, 4);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(1112, 687);
            panelDisplay.TabIndex = 0;
            // 
            // panelPos
            // 
            panelPos.CustomizableEdges = customizableEdges1;
            panelPos.Dock = DockStyle.Top;
            panelPos.Location = new Point(0, 0);
            panelPos.Margin = new Padding(3, 4, 3, 4);
            panelPos.Name = "panelPos";
            panelPos.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelPos.Size = new Size(1112, 69);
            panelPos.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(80, 149, 146);
            panelTop.Controls.Add(btnRefresh);
            panelTop.Controls.Add(btnAdd);
            panelTop.Controls.Add(panelSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1112, 89);
            panelTop.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.Image = Properties.Resources.refresh_button1;
            btnRefresh.Location = new Point(860, 27);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(32, 32);
            btnRefresh.SizeMode = PictureBoxSizeMode.AutoSize;
            btnRefresh.TabIndex = 63;
            btnRefresh.TabStop = false;
            btnRefresh.Click += btnRefresh_Click;
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
            btnAdd.FillColor = Color.FromArgb(182, 228, 226);
            btnAdd.FillColor2 = Color.FromArgb(3, 49, 90);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(898, 16);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAdd.Size = new Size(200, 55);
            btnAdd.TabIndex = 60;
            btnAdd.Text = "Thêm nhân viên";
            btnAdd.Click += btnAdd_Click;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.Azure;
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(search);
            panelSearch.Location = new Point(12, 19);
            panelSearch.Margin = new Padding(3, 4, 3, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.RightToLeft = RightToLeft.No;
            panelSearch.Size = new Size(406, 52);
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
            btnSearch.Location = new Point(371, 11);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.PressedState.Image = Properties.Resources.search;
            btnSearch.PressedState.ImageSize = new Size(64, 64);
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnSearch.Size = new Size(23, 27);
            btnSearch.TabIndex = 12;
            // 
            // search
            // 
            search.BackColor = Color.Azure;
            search.BorderStyle = BorderStyle.None;
            search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            search.ForeColor = Color.FromArgb(0, 0, 64);
            search.Location = new Point(16, 11);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.PlaceholderText = "Tìm kiếm theo tên/ID";
            search.Size = new Size(349, 27);
            search.TabIndex = 11;
            // 
            // manageEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 845);
            Controls.Add(panelEmp);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "manageEmployee";
            Load += manageEmployee_Load;
            panelEmp.ResumeLayout(false);
            panelShow.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
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
        private Guna.UI2.WinForms.Guna2Panel panelShow;
        private Guna.UI2.WinForms.Guna2Panel panelPos;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private FlowLayoutPanel panelDisplay;
        private PictureBox btnRefresh;
    }
}