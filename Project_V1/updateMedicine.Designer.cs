namespace GUI
{
    partial class updateMedicine
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
            label9 = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(3, 49, 90);
            label9.Location = new Point(391, 9);
            label9.Name = "label9";
            label9.Size = new Size(348, 38);
            label9.TabIndex = 72;
            label9.Text = "Cập nhật thông tin thuốc";
            // 
            // updateMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 809);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "updateMedicine";
            Load += updateMedicine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
    }
}