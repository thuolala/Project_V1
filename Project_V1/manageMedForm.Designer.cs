namespace GUI
{
    partial class manageMedForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelMed = new Guna.UI2.WinForms.Guna2Panel();
            panelView = new Guna.UI2.WinForms.Guna2Panel();
            panelType = new FlowLayoutPanel();
            btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            panelSearch = new Panel();
            btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            search = new TextBox();
            panelData = new FlowLayoutPanel();
            panelMed.SuspendLayout();
            panelView.SuspendLayout();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelMed
            // 
            panelMed.Controls.Add(panelView);
            panelMed.Controls.Add(btnAdd);
            panelMed.Controls.Add(panelSearch);
            panelMed.CustomizableEdges = customizableEdges6;
            panelMed.Dock = DockStyle.Fill;
            panelMed.Location = new Point(0, 0);
            panelMed.Name = "panelMed";
            panelMed.ShadowDecoration.CustomizableEdges = customizableEdges7;
            panelMed.Size = new Size(973, 567);
            panelMed.TabIndex = 0;
            panelMed.Paint += panelMed_Paint;
            // 
            // panelView
            // 
            panelView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelView.Controls.Add(panelData);
            panelView.Controls.Add(panelType);
            panelView.CustomizableEdges = customizableEdges1;
            panelView.Location = new Point(12, 57);
            panelView.Name = "panelView";
            panelView.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelView.Size = new Size(949, 498);
            panelView.TabIndex = 62;
            // 
            // panelType
            // 
            panelType.Dock = DockStyle.Top;
            panelType.Location = new Point(0, 0);
            panelType.Name = "panelType";
            panelType.Size = new Size(949, 68);
            panelType.TabIndex = 64;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Animated = true;
            btnAdd.BorderRadius = 10;
            btnAdd.CustomizableEdges = customizableEdges3;
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
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.Size = new Size(175, 41);
            btnAdd.TabIndex = 61;
            btnAdd.Text = "Thêm thuốc";
            btnAdd.Click += btnAdd_Click;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.Azure;
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(search);
            panelSearch.Location = new Point(12, 12);
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
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges5;
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
            search.PlaceholderText = "Tìm kiếm";
            search.Size = new Size(287, 22);
            search.TabIndex = 11;
            // 
            // panelData
            // 
            panelData.AutoScroll = true;
            panelData.BorderStyle = BorderStyle.FixedSingle;
            panelData.Dock = DockStyle.Fill;
            panelData.Location = new Point(0, 68);
            panelData.Name = "panelData";
            panelData.Size = new Size(949, 430);
            panelData.TabIndex = 65;
            // 
            // manageMedForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 567);
            Controls.Add(panelMed);
            FormBorderStyle = FormBorderStyle.None;
            Name = "manageMedForm";
            Load += manageMedForm_Load;
            panelMed.ResumeLayout(false);
            panelView.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panelMed;
        private Panel panelSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private TextBox search;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2Panel panelView;
        private FlowLayoutPanel panelType;
        private FlowLayoutPanel panelData;
    }
}