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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelCus = new Guna.UI2.WinForms.Guna2Panel();
            btnRefresh = new PictureBox();
            btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            panelData = new Guna.UI2.WinForms.Guna2Panel();
            datagridviewCusList = new Guna.UI2.WinForms.Guna2DataGridView();
            gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
            panelCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridviewCusList).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelCus
            // 
            panelCus.Controls.Add(btnRefresh);
            panelCus.Controls.Add(btnAdd);
            panelCus.Controls.Add(panelData);
            panelCus.CustomizableEdges = customizableEdges5;
            panelCus.Dock = DockStyle.Fill;
            panelCus.Location = new Point(0, 0);
            panelCus.Name = "panelCus";
            panelCus.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelCus.Size = new Size(973, 648);
            panelCus.TabIndex = 0;
            panelCus.Paint += panelCus_Paint;
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
            btnRefresh.TabIndex = 62;
            btnRefresh.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Animated = true;
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
            btnAdd.TabIndex = 61;
            btnAdd.Text = "Thêm khách hàng";
            btnAdd.Click += btnAdd_Click;
            // 
            // panelData
            // 
            panelData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelData.AutoScroll = true;
            panelData.BorderColor = Color.FromArgb(94, 148, 255);
            panelData.BorderRadius = 10;
            panelData.BorderThickness = 1;
            panelData.Controls.Add(datagridviewCusList);
            panelData.CustomizableEdges = customizableEdges3;
            panelData.Location = new Point(10, 70);
            panelData.Name = "panelData";
            panelData.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelData.Size = new Size(952, 578);
            panelData.TabIndex = 0;
            // 
            // datagridviewCusList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(200, 218, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            datagridviewCusList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridviewCusList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(94, 148, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(94, 148, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            datagridviewCusList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            datagridviewCusList.ColumnHeadersHeight = 29;
            datagridviewCusList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 218, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            datagridviewCusList.DefaultCellStyle = dataGridViewCellStyle3;
            datagridviewCusList.GridColor = Color.FromArgb(231, 229, 255);
            datagridviewCusList.Location = new Point(3, 2);
            datagridviewCusList.Margin = new Padding(3, 2, 3, 2);
            datagridviewCusList.Name = "datagridviewCusList";
            datagridviewCusList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            datagridviewCusList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            datagridviewCusList.RowHeadersVisible = false;
            datagridviewCusList.RowHeadersWidth = 51;
            datagridviewCusList.RowTemplate.Height = 30;
            datagridviewCusList.Size = new Size(947, 778);
            datagridviewCusList.TabIndex = 16;
            datagridviewCusList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            datagridviewCusList.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datagridviewCusList.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            datagridviewCusList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(200, 218, 255);
            datagridviewCusList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            datagridviewCusList.ThemeStyle.BackColor = Color.White;
            datagridviewCusList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            datagridviewCusList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(94, 148, 255);
            datagridviewCusList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridviewCusList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            datagridviewCusList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            datagridviewCusList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagridviewCusList.ThemeStyle.HeaderStyle.Height = 29;
            datagridviewCusList.ThemeStyle.ReadOnly = false;
            datagridviewCusList.ThemeStyle.RowsStyle.BackColor = Color.White;
            datagridviewCusList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridviewCusList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datagridviewCusList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            datagridviewCusList.ThemeStyle.RowsStyle.Height = 30;
            datagridviewCusList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(200, 218, 255);
            datagridviewCusList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            datagridviewCusList.CellContentClick += datagridviewCusList_CellContentClick_1;
            // 
            // gunaAreaDataset1
            // 
            gunaAreaDataset1.BorderColor = Color.Empty;
            gunaAreaDataset1.FillColor = Color.Empty;
            gunaAreaDataset1.Label = "Area1";
            // 
            // manageCusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 648);
            Controls.Add(panelCus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "manageCusForm";
            Load += manageCusForm_Load;
            panelCus.ResumeLayout(false);
            panelCus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridviewCusList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panelCus;
        private Guna.UI2.WinForms.Guna2Panel panelData;
        private Guna.UI2.WinForms.Guna2DataGridView datagridviewCusList;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
        private PictureBox btnRefresh;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
    }
}