namespace GUI
{
    partial class test
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            gdV = new Guna.UI2.WinForms.Guna2DataGridView();
            btnPic = new Guna.UI2.WinForms.Guna2Button();
            pic = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)gdV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // gdV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            gdV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gdV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gdV.ColumnHeadersHeight = 4;
            gdV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gdV.DefaultCellStyle = dataGridViewCellStyle3;
            gdV.GridColor = Color.FromArgb(231, 229, 255);
            gdV.Location = new Point(139, 105);
            gdV.Name = "gdV";
            gdV.RowHeadersVisible = false;
            gdV.RowTemplate.Height = 25;
            gdV.Size = new Size(497, 251);
            gdV.TabIndex = 0;
            gdV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gdV.ThemeStyle.AlternatingRowsStyle.Font = null;
            gdV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gdV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gdV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gdV.ThemeStyle.BackColor = Color.White;
            gdV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            gdV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            gdV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gdV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gdV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gdV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gdV.ThemeStyle.HeaderStyle.Height = 4;
            gdV.ThemeStyle.ReadOnly = false;
            gdV.ThemeStyle.RowsStyle.BackColor = Color.White;
            gdV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gdV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gdV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gdV.ThemeStyle.RowsStyle.Height = 25;
            gdV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gdV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnPic
            // 
            btnPic.CustomizableEdges = customizableEdges3;
            btnPic.DisabledState.BorderColor = Color.DarkGray;
            btnPic.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPic.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPic.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPic.ForeColor = Color.White;
            btnPic.Location = new Point(139, 12);
            btnPic.Name = "btnPic";
            btnPic.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPic.Size = new Size(180, 45);
            btnPic.TabIndex = 1;
            btnPic.Text = "Add";
            btnPic.Click += btnPic_Click;
            // 
            // pic
            // 
            pic.CustomizableEdges = customizableEdges1;
            pic.ImageRotate = 0F;
            pic.Location = new Point(667, 49);
            pic.Name = "pic";
            pic.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pic.Size = new Size(184, 200);
            pic.TabIndex = 2;
            pic.TabStop = false;
            // 
            // test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 450);
            Controls.Add(pic);
            Controls.Add(btnPic);
            Controls.Add(gdV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "test";
            Text = "test";
            Load += test_Load;
            ((System.ComponentModel.ISupportInitialize)gdV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView gdV;
        private Guna.UI2.WinForms.Guna2PictureBox pic;
        private Guna.UI2.WinForms.Guna2Button btnPic;
    }
}