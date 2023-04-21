namespace GUI
{
    partial class medItem
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
            orderQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            label10 = new Label();
            label1 = new Label();
            medQuantity = new Label();
            btnAddToCart = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)medPic).BeginInit();
            SuspendLayout();
            // 
            // medPic
            // 
            medPic.BorderRadius = 10;
            medPic.CustomizableEdges = customizableEdges1;
            medPic.ImageRotate = 0F;
            medPic.Location = new Point(3, 3);
            medPic.Name = "medPic";
            medPic.ShadowDecoration.CustomizableEdges = customizableEdges2;
            medPic.Size = new Size(127, 90);
            medPic.TabIndex = 0;
            medPic.TabStop = false;
            // 
            // medName
            // 
            medName.AutoSize = true;
            medName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            medName.ForeColor = Color.DimGray;
            medName.Location = new Point(178, 3);
            medName.Name = "medName";
            medName.Size = new Size(85, 21);
            medName.TabIndex = 80;
            medName.Text = "Tên thuốc";
            medName.Click += label9_Click;
            // 
            // medPrice
            // 
            medPrice.AutoSize = true;
            medPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            medPrice.ForeColor = Color.DarkGray;
            medPrice.Location = new Point(196, 37);
            medPrice.Name = "medPrice";
            medPrice.Size = new Size(51, 17);
            medPrice.TabIndex = 81;
            medPrice.Text = "0 đồng";
            // 
            // orderQuantity
            // 
            orderQuantity.BorderRadius = 10;
            orderQuantity.CustomizableEdges = customizableEdges3;
            orderQuantity.DefaultText = "";
            orderQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            orderQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            orderQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            orderQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            orderQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            orderQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            orderQuantity.Location = new Point(178, 58);
            orderQuantity.Margin = new Padding(4);
            orderQuantity.Name = "orderQuantity";
            orderQuantity.PasswordChar = '\0';
            orderQuantity.PlaceholderText = "";
            orderQuantity.SelectedText = "";
            orderQuantity.ShadowDecoration.CustomizableEdges = customizableEdges4;
            orderQuantity.Size = new Size(80, 35);
            orderQuantity.TabIndex = 82;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(3, 96);
            label10.Name = "label10";
            label10.Size = new Size(30, 17);
            label10.TabIndex = 84;
            label10.Text = "SL: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(98, 96);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 85;
            label1.Text = "hộp";
            // 
            // medQuantity
            // 
            medQuantity.AutoSize = true;
            medQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            medQuantity.ForeColor = Color.IndianRed;
            medQuantity.Location = new Point(60, 96);
            medQuantity.Name = "medQuantity";
            medQuantity.Size = new Size(32, 17);
            medQuantity.TabIndex = 86;
            medQuantity.Text = "hộp";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Animated = true;
            btnAddToCart.CustomizableEdges = customizableEdges5;
            btnAddToCart.DisabledState.BorderColor = Color.DarkGray;
            btnAddToCart.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddToCart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddToCart.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAddToCart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddToCart.Dock = DockStyle.Bottom;
            btnAddToCart.FillColor = Color.FromArgb(255, 192, 192);
            btnAddToCart.FillColor2 = Color.FromArgb(192, 255, 255);
            btnAddToCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Image = Properties.Resources.cart;
            btnAddToCart.ImageSize = new Size(32, 32);
            btnAddToCart.Location = new Point(0, 114);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddToCart.Size = new Size(309, 38);
            btnAddToCart.TabIndex = 87;
            // 
            // medItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnAddToCart);
            Controls.Add(medQuantity);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(orderQuantity);
            Controls.Add(medPrice);
            Controls.Add(medName);
            Controls.Add(medPic);
            Name = "medItem";
            Size = new Size(309, 152);
            Load += medItem_Load;
            Paint += medItem_Paint;
            ((System.ComponentModel.ISupportInitialize)medPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox medPic;
        private Label medName;
        private Label medPrice;
        private Guna.UI2.WinForms.Guna2TextBox orderQuantity;
        private Label label10;
        private Label label1;
        private Label medQuantity;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddToCart;
    }
}
