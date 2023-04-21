namespace GUI
{
    partial class manageEmpForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelEmp = new Guna.UI2.WinForms.Guna2Panel();
            btnRefresh = new PictureBox();
            btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            panelView = new Guna.UI2.WinForms.Guna2Panel();
            datagridviewEmpList = new Guna.UI2.WinForms.Guna2DataGridView();
            label7 = new Label();
            positionDisplay = new Guna.UI2.WinForms.Guna2ComboBox();
            gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
            panelEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridviewEmpList).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelEmp
            // 
            panelEmp.Controls.Add(btnRefresh);
            panelEmp.Controls.Add(btnAdd);
            panelEmp.Controls.Add(panelView);
            panelEmp.Controls.Add(label7);
            panelEmp.Controls.Add(positionDisplay);
            panelEmp.CustomizableEdges = customizableEdges7;
            panelEmp.Dock = DockStyle.Fill;
            panelEmp.Location = new Point(0, 0);
            panelEmp.Margin = new Padding(3, 2, 3, 2);
            panelEmp.Name = "panelEmp";
            panelEmp.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelEmp.Size = new Size(973, 648);
            panelEmp.TabIndex = 0;
            panelEmp.Paint += panelEmp_Paint;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.Image = Properties.Resources.refresh_button;
            btnRefresh.Location = new Point(731, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(32, 32);
            btnRefresh.SizeMode = PictureBoxSizeMode.AutoSize;
            btnRefresh.TabIndex = 60;
            btnRefresh.TabStop = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BorderRadius = 10;
            btnAdd.CustomizableEdges = customizableEdges1;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor2 = Color.FromArgb(128, 255, 128);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(788, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(175, 41);
            btnAdd.TabIndex = 59;
            btnAdd.Text = "Thêm nhân viên";
            btnAdd.Click += btnAdd_Click;
            // 
            // panelView
            // 
            panelView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelView.BorderColor = Color.FromArgb(94, 148, 255);
            panelView.BorderRadius = 10;
            panelView.BorderThickness = 1;
            panelView.Controls.Add(datagridviewEmpList);
            panelView.CustomizableEdges = customizableEdges3;
            panelView.Location = new Point(10, 70);
            panelView.Margin = new Padding(3, 2, 3, 2);
            panelView.Name = "panelView";
            panelView.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelView.Size = new Size(952, 578);
            panelView.TabIndex = 15;
            panelView.Paint += panelView_Paint;
            // 
            // datagridviewEmpList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(200, 218, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            datagridviewEmpList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridviewEmpList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(94, 148, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(94, 148, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            datagridviewEmpList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            datagridviewEmpList.ColumnHeadersHeight = 29;
            datagridviewEmpList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 218, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            datagridviewEmpList.DefaultCellStyle = dataGridViewCellStyle3;
            datagridviewEmpList.GridColor = Color.FromArgb(231, 229, 255);
            datagridviewEmpList.Location = new Point(3, 2);
            datagridviewEmpList.Margin = new Padding(3, 2, 3, 2);
            datagridviewEmpList.Name = "datagridviewEmpList";
            datagridviewEmpList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            datagridviewEmpList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            datagridviewEmpList.RowHeadersVisible = false;
            datagridviewEmpList.RowHeadersWidth = 51;
            datagridviewEmpList.RowTemplate.Height = 30;
            datagridviewEmpList.Size = new Size(947, 778);
            datagridviewEmpList.TabIndex = 15;
            datagridviewEmpList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            datagridviewEmpList.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datagridviewEmpList.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            datagridviewEmpList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(200, 218, 255);
            datagridviewEmpList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            datagridviewEmpList.ThemeStyle.BackColor = Color.White;
            datagridviewEmpList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            datagridviewEmpList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(94, 148, 255);
            datagridviewEmpList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridviewEmpList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            datagridviewEmpList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            datagridviewEmpList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagridviewEmpList.ThemeStyle.HeaderStyle.Height = 29;
            datagridviewEmpList.ThemeStyle.ReadOnly = false;
            datagridviewEmpList.ThemeStyle.RowsStyle.BackColor = Color.White;
            datagridviewEmpList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridviewEmpList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datagridviewEmpList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            datagridviewEmpList.ThemeStyle.RowsStyle.Height = 30;
            datagridviewEmpList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(200, 218, 255);
            datagridviewEmpList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            datagridviewEmpList.CellContentClick += datagridviewEmpList_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(13, 27);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 13;
            label7.Text = "Chọn vị trí";
            label7.Click += label7_Click;
            // 
            // positionDisplay
            // 
            positionDisplay.BackColor = Color.Transparent;
            positionDisplay.CustomizableEdges = customizableEdges5;
            positionDisplay.DrawMode = DrawMode.OwnerDrawFixed;
            positionDisplay.DropDownStyle = ComboBoxStyle.DropDownList;
            positionDisplay.FocusedColor = Color.FromArgb(94, 148, 255);
            positionDisplay.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            positionDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            positionDisplay.ForeColor = Color.FromArgb(68, 88, 112);
            positionDisplay.ItemHeight = 30;
            positionDisplay.Location = new Point(108, 27);
            positionDisplay.Margin = new Padding(3, 2, 3, 2);
            positionDisplay.Name = "positionDisplay";
            positionDisplay.ShadowDecoration.CustomizableEdges = customizableEdges6;
            positionDisplay.Size = new Size(283, 36);
            positionDisplay.TabIndex = 0;
            positionDisplay.SelectedIndexChanged += positionDisplay_SelectedIndexChanged;
            // 
            // gunaAreaDataset1
            // 
            gunaAreaDataset1.BorderColor = Color.Empty;
            gunaAreaDataset1.FillColor = Color.Empty;
            gunaAreaDataset1.Label = "Area1";
            // 
            // manageEmpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(973, 648);
            Controls.Add(panelEmp);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "manageEmpForm";
            Load += manageEmpForm_Load;
            panelEmp.ResumeLayout(false);
            panelEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridviewEmpList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panelEmp;
        private Guna.UI2.WinForms.Guna2ComboBox positionDisplay;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Panel panelView;
        private Guna.UI2.WinForms.Guna2DataGridView datagridviewEmpList;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
        private PictureBox btnRefresh;
    }
}