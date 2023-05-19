namespace GUI
{
    partial class medicineItem
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            medPic = new Guna.UI2.WinForms.Guna2PictureBox();
            medName = new Label();
            medPrice = new Label();
            labelUnit = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            label10 = new Label();
            avaiQuan = new Label();
            btnDetail = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)medPic).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // medPic
            // 
            medPic.BorderRadius = 10;
            medPic.CustomizableEdges = customizableEdges1;
            medPic.ImageRotate = 0F;
            medPic.Location = new Point(15, 4);
            medPic.Margin = new Padding(3, 4, 3, 4);
            medPic.Name = "medPic";
            medPic.ShadowDecoration.CustomizableEdges = customizableEdges2;
            medPic.Size = new Size(240, 190);
            medPic.TabIndex = 0;
            medPic.TabStop = false;
            // 
            // medName
            // 
            medName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            medName.AutoSize = true;
            medName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            medName.ForeColor = Color.FromArgb(3, 49, 90);
            medName.Location = new Point(3, 3);
            medName.Name = "medName";
            medName.Size = new Size(87, 23);
            medName.TabIndex = 80;
            medName.Text = "Tên thuốc";
            // 
            // medPrice
            // 
            medPrice.AutoSize = true;
            medPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            medPrice.ForeColor = Color.SteelBlue;
            medPrice.Location = new Point(14, 262);
            medPrice.Name = "medPrice";
            medPrice.Size = new Size(24, 28);
            medPrice.TabIndex = 81;
            medPrice.Text = "0";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelUnit.ForeColor = Color.DarkGray;
            labelUnit.Location = new Point(214, 267);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(41, 23);
            labelUnit.TabIndex = 85;
            labelUnit.Text = "hộp";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(medName);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(15, 218);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(240, 41);
            guna2Panel1.TabIndex = 88;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(148, 267);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 89;
            label1.Text = "đồng/";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(14, 198);
            label10.Name = "label10";
            label10.Size = new Size(36, 17);
            label10.TabIndex = 90;
            label10.Text = "Còn:";
            // 
            // avaiQuan
            // 
            avaiQuan.AutoSize = true;
            avaiQuan.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            avaiQuan.ForeColor = Color.IndianRed;
            avaiQuan.Location = new Point(57, 198);
            avaiQuan.Name = "avaiQuan";
            avaiQuan.Size = new Size(15, 17);
            avaiQuan.TabIndex = 91;
            avaiQuan.Text = "0";
            // 
            // btnDetail
            // 
            btnDetail.Animated = true;
            btnDetail.CustomizableEdges = customizableEdges5;
            btnDetail.DisabledState.BorderColor = Color.DarkGray;
            btnDetail.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDetail.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDetail.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnDetail.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDetail.Dock = DockStyle.Bottom;
            btnDetail.FillColor = Color.FromArgb(182, 228, 226);
            btnDetail.FillColor2 = Color.FromArgb(105, 175, 172);
            btnDetail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetail.ForeColor = Color.White;
            btnDetail.Image = Properties.Resources.file;
            btnDetail.ImageSize = new Size(32, 32);
            btnDetail.Location = new Point(0, 294);
            btnDetail.Margin = new Padding(10, 5, 10, 5);
            btnDetail.Name = "btnDetail";
            btnDetail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDetail.Size = new Size(272, 48);
            btnDetail.TabIndex = 99;
            // 
            // medicineItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 228, 226);
            Controls.Add(btnDetail);
            Controls.Add(avaiQuan);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            Controls.Add(labelUnit);
            Controls.Add(medPrice);
            Controls.Add(medPic);
            Margin = new Padding(10, 5, 10, 5);
            Name = "medicineItem";
            Size = new Size(272, 342);
            Load += medicineItem_Load;
            ((System.ComponentModel.ISupportInitialize)medPic).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox medPic;
        private Label medName;
        private Label medPrice;
        private Guna.UI2.WinForms.Guna2TextBox orderQuantity;
        private Label labelUnit;
        private Label medQuantity;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Label label10;
        private Label avaiQuan;
        private Guna.UI2.WinForms.Guna2GradientButton btnDetail;
    }
}
