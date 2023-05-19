namespace GUI
{
    partial class customerItem
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
            cusName = new Label();
            cusID = new Label();
            btnDetail = new Guna.UI2.WinForms.Guna2GradientButton();
            SuspendLayout();
            // 
            // cusName
            // 
            cusName.AutoSize = true;
            cusName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cusName.ForeColor = Color.FromArgb(3, 49, 90);
            cusName.Location = new Point(3, 0);
            cusName.Name = "cusName";
            cusName.Size = new Size(45, 28);
            cusName.TabIndex = 90;
            cusName.Text = "Tên";
            // 
            // cusID
            // 
            cusID.AutoSize = true;
            cusID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cusID.ForeColor = Color.FromArgb(3, 49, 90);
            cusID.Location = new Point(12, 37);
            cusID.Name = "cusID";
            cusID.Size = new Size(27, 23);
            cusID.TabIndex = 97;
            cusID.Text = "ID";
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
            btnDetail.Location = new Point(256, 0);
            btnDetail.Margin = new Padding(10, 5, 10, 5);
            btnDetail.Name = "btnDetail";
            btnDetail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDetail.Size = new Size(40, 68);
            btnDetail.TabIndex = 98;
            btnDetail.Click += btnDetail_Click;
            // 
            // cusItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 228, 226);
            Controls.Add(btnDetail);
            Controls.Add(cusID);
            Controls.Add(cusName);
            Margin = new Padding(10, 5, 10, 5);
            Name = "cusItem";
            Size = new Size(296, 68);
            Load += cusItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cusName;
        private Label cusID;
        private Guna.UI2.WinForms.Guna2GradientButton btnDetail;
    }
}
