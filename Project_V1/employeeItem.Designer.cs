namespace GUI
{
    partial class employeeItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnDetail = new Guna.UI2.WinForms.Guna2GradientButton();
            empPos = new Label();
            empName = new Label();
            empPic = new Guna.UI2.WinForms.Guna2PictureBox();
            empID = new Label();
            ((System.ComponentModel.ISupportInitialize)empPic).BeginInit();
            SuspendLayout();
            // 
            // btnDetail
            // 
            btnDetail.Animated = true;
            btnDetail.CustomizableEdges = customizableEdges1;
            btnDetail.DisabledState.BorderColor = Color.DarkGray;
            btnDetail.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDetail.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDetail.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnDetail.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDetail.Dock = DockStyle.Right;
            btnDetail.FillColor = Color.FromArgb(182, 228, 226);
            btnDetail.FillColor2 = Color.FromArgb(105, 175, 172);
            btnDetail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetail.ForeColor = Color.White;
            btnDetail.Image = Properties.Resources.file;
            btnDetail.ImageSize = new Size(32, 32);
            btnDetail.Location = new Point(375, 0);
            btnDetail.Margin = new Padding(3, 4, 3, 4);
            btnDetail.Name = "btnDetail";
            btnDetail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDetail.Size = new Size(51, 121);
            btnDetail.TabIndex = 95;
            btnDetail.Click += btnDetail_Click;
            // 
            // empPos
            // 
            empPos.AutoSize = true;
            empPos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            empPos.ForeColor = Color.FromArgb(3, 49, 90);
            empPos.Location = new Point(102, 88);
            empPos.Name = "empPos";
            empPos.Size = new Size(46, 23);
            empPos.TabIndex = 90;
            empPos.Text = "Vị trí";
            // 
            // empName
            // 
            empName.AutoSize = true;
            empName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            empName.ForeColor = Color.FromArgb(3, 49, 90);
            empName.Location = new Point(102, 4);
            empName.Name = "empName";
            empName.Size = new Size(45, 28);
            empName.TabIndex = 89;
            empName.Text = "Tên";
            // 
            // empPic
            // 
            empPic.BorderRadius = 10;
            empPic.CustomizableEdges = customizableEdges3;
            empPic.ImageRotate = 0F;
            empPic.Location = new Point(3, 11);
            empPic.Margin = new Padding(3, 4, 3, 4);
            empPic.Name = "empPic";
            empPic.ShadowDecoration.CustomizableEdges = customizableEdges4;
            empPic.Size = new Size(90, 100);
            empPic.SizeMode = PictureBoxSizeMode.StretchImage;
            empPic.TabIndex = 88;
            empPic.TabStop = false;
            empPic.Click += empPic_Click;
            // 
            // empID
            // 
            empID.AutoSize = true;
            empID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            empID.ForeColor = Color.FromArgb(3, 49, 90);
            empID.Location = new Point(102, 49);
            empID.Name = "empID";
            empID.Size = new Size(27, 23);
            empID.TabIndex = 96;
            empID.Text = "ID";
            // 
            // empItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 228, 226);
            Controls.Add(empID);
            Controls.Add(btnDetail);
            Controls.Add(empPos);
            Controls.Add(empName);
            Controls.Add(empPic);
            Margin = new Padding(10, 5, 10, 5);
            Name = "empItem";
            Size = new Size(426, 121);
            Load += empItem_Load;
            Paint += empItem_Paint;
            ((System.ComponentModel.ISupportInitialize)empPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnDetail;
        private Label empPos;
        private Label empName;
        private Guna.UI2.WinForms.Guna2PictureBox empPic;
        private Label empID;
    }
}
