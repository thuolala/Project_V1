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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medItem));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            medPic = new Guna.UI2.WinForms.Guna2PictureBox();
            label9 = new Label();
            medPrice = new Label();
            orderQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddToCart = new Guna.UI2.WinForms.Guna2ImageButton();
            avalaibleQuantity = new Label();
            ((System.ComponentModel.ISupportInitialize)medPic).BeginInit();
            SuspendLayout();
            // 
            // medPic
            // 
            medPic.CustomizableEdges = customizableEdges1;
            medPic.ImageRotate = 0F;
            medPic.Location = new Point(3, 3);
            medPic.Name = "medPic";
            medPic.ShadowDecoration.CustomizableEdges = customizableEdges2;
            medPic.Size = new Size(127, 90);
            medPic.TabIndex = 0;
            medPic.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(170, 3);
            label9.Name = "label9";
            label9.Size = new Size(85, 21);
            label9.TabIndex = 80;
            label9.Text = "Tên thuốc";
            label9.Click += label9_Click;
            // 
            // medPrice
            // 
            medPrice.AutoSize = true;
            medPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            medPrice.ForeColor = Color.DarkGray;
            medPrice.Location = new Point(188, 37);
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
            orderQuantity.Location = new Point(171, 58);
            orderQuantity.Margin = new Padding(4);
            orderQuantity.Name = "orderQuantity";
            orderQuantity.PasswordChar = '\0';
            orderQuantity.PlaceholderText = "";
            orderQuantity.SelectedText = "";
            orderQuantity.ShadowDecoration.CustomizableEdges = customizableEdges4;
            orderQuantity.Size = new Size(76, 35);
            orderQuantity.TabIndex = 82;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = SystemColors.ControlDarkDark;
            btnAddToCart.CheckedState.ImageSize = new Size(64, 64);
            btnAddToCart.HoverState.ImageSize = new Size(64, 64);
            btnAddToCart.Image = (Image)resources.GetObject("btnAddToCart.Image");
            btnAddToCart.ImageOffset = new Point(0, 0);
            btnAddToCart.ImageRotate = 0F;
            btnAddToCart.Location = new Point(0, 116);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.PressedState.ImageSize = new Size(64, 64);
            btnAddToCart.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnAddToCart.Size = new Size(311, 39);
            btnAddToCart.TabIndex = 83;
            // 
            // avalaibleQuantity
            // 
            avalaibleQuantity.AutoSize = true;
            avalaibleQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            avalaibleQuantity.ForeColor = Color.DarkGray;
            avalaibleQuantity.Location = new Point(36, 96);
            avalaibleQuantity.Name = "avalaibleQuantity";
            avalaibleQuantity.Size = new Size(54, 17);
            avalaibleQuantity.TabIndex = 84;
            avalaibleQuantity.Text = "SL: hộp";
            // 
            // medItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(avalaibleQuantity);
            Controls.Add(btnAddToCart);
            Controls.Add(orderQuantity);
            Controls.Add(medPrice);
            Controls.Add(label9);
            Controls.Add(medPic);
            Name = "medItem";
            Size = new Size(311, 154);
            ((System.ComponentModel.ISupportInitialize)medPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox medPic;
        private Label label9;
        private Label medPrice;
        private Guna.UI2.WinForms.Guna2TextBox orderQuantity;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddToCart;
        private Label avalaibleQuantity;
    }
}
