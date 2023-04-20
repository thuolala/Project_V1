namespace GUI
{
    partial class medicineListForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnAdd);
            panelTop.CustomizableEdges = customizableEdges3;
            panelTop.Dock = DockStyle.Top;
            panelTop.FillColor = Color.FromArgb(255, 192, 192);
            panelTop.FillColor2 = Color.FromArgb(192, 255, 255);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelTop.Size = new Size(973, 55);
            panelTop.TabIndex = 0;
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
            btnAdd.Location = new Point(786, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(175, 41);
            btnAdd.TabIndex = 60;
            btnAdd.Text = "Thêm thuốc";
            btnAdd.Click += btnAdd_Click;
            // 
            // medicineListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 567);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "medicineListForm";
            Text = "medicineList";
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelTop;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
    }
}