namespace GUI
{
    partial class medType
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelPic = new Guna.UI2.WinForms.Guna2Panel();
            typeName = new Label();
            panelName = new Guna.UI2.WinForms.Guna2Panel();
            typePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panelPic.SuspendLayout();
            panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)typePic).BeginInit();
            SuspendLayout();
            // 
            // panelPic
            // 
            panelPic.Controls.Add(typePic);
            panelPic.CustomizableEdges = customizableEdges2;
            panelPic.Dock = DockStyle.Fill;
            panelPic.Location = new Point(0, 0);
            panelPic.Name = "panelPic";
            panelPic.ShadowDecoration.CustomizableEdges = customizableEdges3;
            panelPic.Size = new Size(206, 39);
            panelPic.TabIndex = 2;
            panelPic.Paint += panelPic_Paint;
            // 
            // typeName
            // 
            typeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            typeName.AutoSize = true;
            typeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            typeName.ForeColor = Color.FromArgb(0, 0, 64);
            typeName.Location = new Point(28, 3);
            typeName.Name = "typeName";
            typeName.Size = new Size(49, 21);
            typeName.TabIndex = 24;
            typeName.Text = "(Tên)";
            typeName.TextAlign = ContentAlignment.MiddleCenter;
            typeName.Click += typeName_Click;
            // 
            // panelName
            // 
            panelName.Controls.Add(typeName);
            panelName.CustomizableEdges = customizableEdges4;
            panelName.Dock = DockStyle.Bottom;
            panelName.Location = new Point(0, 39);
            panelName.Name = "panelName";
            panelName.ShadowDecoration.CustomizableEdges = customizableEdges5;
            panelName.Size = new Size(206, 27);
            panelName.TabIndex = 1;
            panelName.Paint += panelName_Paint;
            // 
            // typePic
            // 
            typePic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            typePic.ImageRotate = 0F;
            typePic.Location = new Point(83, -1);
            typePic.Name = "typePic";
            typePic.ShadowDecoration.CustomizableEdges = customizableEdges1;
            typePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            typePic.Size = new Size(40, 40);
            typePic.TabIndex = 2;
            typePic.TabStop = false;
            // 
            // medType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panelPic);
            Controls.Add(panelName);
            Name = "medType";
            Size = new Size(206, 66);
            Load += medType_Load;
            Click += medType_Click;
            panelPic.ResumeLayout(false);
            panelName.ResumeLayout(false);
            panelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)typePic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelPic;
        private Label typeName;
        private Guna.UI2.WinForms.Guna2Panel panelName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox typePic;
    }
}
