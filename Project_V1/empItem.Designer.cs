namespace GUI
{
    partial class empItem
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
            btnDetail.Dock = DockStyle.Bottom;
            btnDetail.FillColor = Color.FromArgb(255, 192, 192);
            btnDetail.FillColor2 = Color.FromArgb(192, 255, 255);
            btnDetail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetail.ForeColor = Color.White;
            btnDetail.Image = Properties.Resources.file;
            btnDetail.ImageSize = new Size(32, 32);
            btnDetail.Location = new Point(0, 85);
            btnDetail.Name = "btnDetail";
            btnDetail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDetail.Size = new Size(371, 38);
            btnDetail.TabIndex = 95;
            // 
            // empPos
            // 
            empPos.AutoSize = true;
            empPos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            empPos.ForeColor = Color.DarkGray;
            empPos.Location = new Point(89, 66);
            empPos.Name = "empPos";
            empPos.Size = new Size(35, 17);
            empPos.TabIndex = 90;
            empPos.Text = "Vị trí";
            // 
            // empName
            // 
            empName.AutoSize = true;
            empName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            empName.ForeColor = Color.DimGray;
            empName.Location = new Point(89, 3);
            empName.Name = "empName";
            empName.Size = new Size(37, 21);
            empName.TabIndex = 89;
            empName.Text = "Tên";
            // 
            // empPic
            // 
            empPic.BorderRadius = 10;
            empPic.CustomizableEdges = customizableEdges3;
            empPic.ImageRotate = 0F;
            empPic.Location = new Point(3, 3);
            empPic.Name = "empPic";
            empPic.ShadowDecoration.CustomizableEdges = customizableEdges4;
            empPic.Size = new Size(80, 80);
            empPic.TabIndex = 88;
            empPic.TabStop = false;
            // 
            // empID
            // 
            empID.AutoSize = true;
            empID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            empID.ForeColor = Color.DarkGray;
            empID.Location = new Point(89, 37);
            empID.Name = "empID";
            empID.Size = new Size(20, 17);
            empID.TabIndex = 96;
            empID.Text = "ID";
            // 
            // empItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(empID);
            Controls.Add(btnDetail);
            Controls.Add(empPos);
            Controls.Add(empName);
            Controls.Add(empPic);
            Name = "empItem";
            Size = new Size(371, 123);
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
