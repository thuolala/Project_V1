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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelEmp = new Guna.UI2.WinForms.Guna2Panel();
            panelShow = new Guna.UI2.WinForms.Guna2Panel();
            panelDisplay = new FlowLayoutPanel();
            panelTop = new Guna.UI2.WinForms.Guna2Panel();
            panelSearch = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            search = new Guna.UI2.WinForms.Guna2TextBox();
            empCount = new Label();
            btnRefresh = new PictureBox();
            btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            panelEmp.SuspendLayout();
            panelShow.SuspendLayout();
            panelTop.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            SuspendLayout();
            // 
            // panelEmp
            // 
            panelEmp.Controls.Add(panelShow);
            panelEmp.Controls.Add(panelTop);
            panelEmp.CustomizableEdges = customizableEdges27;
            panelEmp.Dock = DockStyle.Fill;
            panelEmp.Location = new Point(0, 0);
            panelEmp.Margin = new Padding(3, 4, 3, 4);
            panelEmp.Name = "panelEmp";
            panelEmp.ShadowDecoration.CustomizableEdges = customizableEdges28;
            panelEmp.Size = new Size(1112, 845);
            panelEmp.TabIndex = 0;
            // 
            // panelShow
            // 
            panelShow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelShow.Controls.Add(panelDisplay);
            panelShow.CustomizableEdges = customizableEdges15;
            panelShow.Location = new Point(0, 89);
            panelShow.Margin = new Padding(3, 4, 3, 4);
            panelShow.Name = "panelShow";
            panelShow.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelShow.Size = new Size(1112, 756);
            panelShow.TabIndex = 1;
            // 
            // panelDisplay
            // 
            panelDisplay.AutoScroll = true;
            panelDisplay.BackColor = SystemColors.Control;
            panelDisplay.Dock = DockStyle.Fill;
            panelDisplay.Location = new Point(0, 0);
            panelDisplay.Margin = new Padding(3, 4, 3, 4);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(1112, 756);
            panelDisplay.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BorderColor = Color.Transparent;
            panelTop.Controls.Add(panelSearch);
            panelTop.Controls.Add(btnRefresh);
            panelTop.Controls.Add(btnAdd);
            panelTop.CustomizableEdges = customizableEdges25;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.ShadowDecoration.CustomizableEdges = customizableEdges26;
            panelTop.Size = new Size(1112, 91);
            panelTop.TabIndex = 0;
            // 
            // panelSearch
            // 
            panelSearch.BorderColor = Color.FromArgb(3, 49, 90);
            panelSearch.BorderRadius = 5;
            panelSearch.BorderThickness = 1;
            panelSearch.Controls.Add(guna2PictureBox1);
            panelSearch.Controls.Add(search);
            panelSearch.Controls.Add(empCount);
            panelSearch.CustomizableEdges = customizableEdges21;
            panelSearch.FillColor = Color.Azure;
            panelSearch.FillColor2 = Color.Azure;
            panelSearch.Location = new Point(10, 13);
            panelSearch.Name = "panelSearch";
            panelSearch.ShadowDecoration.CustomizableEdges = customizableEdges22;
            panelSearch.Size = new Size(400, 62);
            panelSearch.TabIndex = 64;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges17;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.Image = Properties.Resources.magnifying_glass_search;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(4, 18);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2PictureBox1.Size = new Size(24, 24);
            guna2PictureBox1.TabIndex = 65;
            guna2PictureBox1.TabStop = false;
            // 
            // search
            // 
            search.Animated = true;
            search.BackColor = Color.Transparent;
            search.BorderThickness = 0;
            search.CustomizableEdges = customizableEdges19;
            search.DefaultText = "";
            search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search.FillColor = Color.Azure;
            search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            search.Location = new Point(23, 8);
            search.Margin = new Padding(6, 8, 6, 8);
            search.Name = "search";
            search.PasswordChar = '\0';
            search.PlaceholderText = "Tìm kiếm theo tên/ID";
            search.SelectedText = "";
            search.ShadowDecoration.CustomizableEdges = customizableEdges20;
            search.Size = new Size(371, 45);
            search.TabIndex = 67;
            // 
            // empCount
            // 
            empCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            empCount.AutoSize = true;
            empCount.BackColor = Color.Transparent;
            empCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            empCount.ForeColor = Color.White;
            empCount.Location = new Point(190, 80);
            empCount.Name = "empCount";
            empCount.Size = new Size(49, 38);
            empCount.TabIndex = 66;
            empCount.Text = "10";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.Image = Properties.Resources.refresh_button1;
            btnRefresh.Location = new Point(862, 34);
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
            btnAdd.CustomizableEdges = customizableEdges23;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(105, 175, 172);
            btnAdd.FillColor2 = Color.FromArgb(3, 49, 90);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(900, 20);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnAdd.Size = new Size(200, 55);
            btnAdd.TabIndex = 60;
            btnAdd.Text = "Thêm nhân viên";
            btnAdd.Click += btnAdd_Click;
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
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelEmp;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private Guna.UI2.WinForms.Guna2Panel panelShow;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private FlowLayoutPanel panelDisplay;
        private PictureBox btnRefresh;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelSearch;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private Label empCount;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}