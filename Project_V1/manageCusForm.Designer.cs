namespace GUI
{
    partial class manageCusForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelCus = new Guna.UI2.WinForms.Guna2Panel();
            panelDisplay = new FlowLayoutPanel();
            panelTop = new Guna.UI2.WinForms.Guna2Panel();
            panelSearch = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            search = new Guna.UI2.WinForms.Guna2TextBox();
            empCount = new Label();
            btnRefresh = new PictureBox();
            btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            panelCus.SuspendLayout();
            panelTop.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            SuspendLayout();
            // 
            // panelCus
            // 
            panelCus.Controls.Add(panelDisplay);
            panelCus.Controls.Add(panelTop);
            panelCus.CustomizableEdges = customizableEdges11;
            panelCus.Dock = DockStyle.Fill;
            panelCus.Location = new Point(0, 0);
            panelCus.Name = "panelCus";
            panelCus.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelCus.Size = new Size(1112, 845);
            panelCus.TabIndex = 0;
            // 
            // panelDisplay
            // 
            panelDisplay.AutoScroll = true;
            panelDisplay.BackColor = SystemColors.Control;
            panelDisplay.Dock = DockStyle.Fill;
            panelDisplay.Location = new Point(0, 91);
            panelDisplay.Margin = new Padding(3, 4, 3, 4);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(1112, 754);
            panelDisplay.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(panelSearch);
            panelTop.Controls.Add(btnRefresh);
            panelTop.Controls.Add(btnAdd);
            panelTop.CustomizableEdges = customizableEdges9;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.ShadowDecoration.CustomizableEdges = customizableEdges10;
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
            panelSearch.CustomizableEdges = customizableEdges5;
            panelSearch.FillColor = Color.Azure;
            panelSearch.FillColor2 = Color.Azure;
            panelSearch.Location = new Point(11, 14);
            panelSearch.Name = "panelSearch";
            panelSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelSearch.Size = new Size(400, 62);
            panelSearch.TabIndex = 67;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.Image = Properties.Resources.magnifying_glass_search;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(4, 18);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(24, 24);
            guna2PictureBox1.TabIndex = 65;
            guna2PictureBox1.TabStop = false;
            // 
            // search
            // 
            search.Animated = true;
            search.BackColor = Color.Transparent;
            search.BorderThickness = 0;
            search.CustomizableEdges = customizableEdges3;
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
            search.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            btnRefresh.Location = new Point(863, 35);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(32, 32);
            btnRefresh.SizeMode = PictureBoxSizeMode.AutoSize;
            btnRefresh.TabIndex = 66;
            btnRefresh.TabStop = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Animated = true;
            btnAdd.BorderRadius = 10;
            btnAdd.CustomizableEdges = customizableEdges7;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(105, 175, 172);
            btnAdd.FillColor2 = Color.FromArgb(3, 49, 90);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(901, 21);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAdd.Size = new Size(200, 55);
            btnAdd.TabIndex = 65;
            btnAdd.Text = "Thêm khách hàng";
            btnAdd.Click += btnAdd_Click;
            // 
            // manageCusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 845);
            Controls.Add(panelCus);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "manageCusForm";
            Load += manageCusForm_Load;
            panelCus.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelCus;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2GradientPanel panelSearch;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private Label empCount;
        private PictureBox btnRefresh;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private FlowLayoutPanel panelDisplay;
    }
}