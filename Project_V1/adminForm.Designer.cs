namespace GUI
{
    partial class adminForm
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
            this.components = new System.ComponentModel.Container();
            this.panelTask = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonIncome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.displayName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuShow = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEmp = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnMoney = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnEditI = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.mini = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.panelAction = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTask.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuShow)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask
            // 
            this.panelTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.panelTask.Controls.Add(this.panel2);
            this.panelTask.Controls.Add(this.panel5);
            this.panelTask.Controls.Add(this.panel4);
            this.panelTask.Controls.Add(this.panel1);
            this.panelTask.Controls.Add(this.panel3);
            this.panelTask.Controls.Add(this.panel8);
            this.panelTask.Controls.Add(this.panel9);
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTask.Location = new System.Drawing.Point(0, 0);
            this.panelTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(236, 697);
            this.panelTask.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 0);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.panel5.Controls.Add(this.btnEditInfo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 6);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 0);
            this.panel5.TabIndex = 3;
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.btnEditInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditInfo.ForeColor = System.Drawing.Color.White;
            this.btnEditInfo.Image = global::GUI.Properties.Resources.pencil;
            this.btnEditInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditInfo.Location = new System.Drawing.Point(-5, -7);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnEditInfo.Size = new System.Drawing.Size(272, 61);
            this.btnEditInfo.TabIndex = 18;
            this.btnEditInfo.Text = "Chỉnh sửa thông tin";
            this.btnEditInfo.UseVisualStyleBackColor = false;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.panel4.Controls.Add(this.buttonIncome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 0);
            this.panel4.TabIndex = 3;
            // 
            // buttonIncome
            // 
            this.buttonIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.buttonIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIncome.ForeColor = System.Drawing.Color.White;
            this.buttonIncome.Image = global::GUI.Properties.Resources.bar_chart;
            this.buttonIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIncome.Location = new System.Drawing.Point(-12, -12);
            this.buttonIncome.Name = "buttonIncome";
            this.buttonIncome.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.buttonIncome.Size = new System.Drawing.Size(272, 61);
            this.buttonIncome.TabIndex = 18;
            this.buttonIncome.Text = "Quản lý doanh thu";
            this.buttonIncome.UseVisualStyleBackColor = false;
            this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.panelPersonal);
            this.panel1.Controls.Add(this.menuShow);
            this.panel1.Location = new System.Drawing.Point(3, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 112);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::GUI.Properties.Resources.pmc_logo;
            this.pictureBox4.Location = new System.Drawing.Point(125, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(102, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.panelPersonal.Controls.Add(this.label1);
            this.panelPersonal.Controls.Add(this.displayName);
            this.panelPersonal.Controls.Add(this.pictureBox3);
            this.panelPersonal.Location = new System.Drawing.Point(0, 58);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelPersonal.Size = new System.Drawing.Size(236, 56);
            this.panelPersonal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quản lý cửa hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayName.ForeColor = System.Drawing.Color.White;
            this.displayName.Location = new System.Drawing.Point(48, 18);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(40, 17);
            this.displayName.TabIndex = 8;
            this.displayName.Text = "(Tên)";
            this.displayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displayName.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = global::GUI.Properties.Resources.user__1_;
            this.pictureBox3.Location = new System.Drawing.Point(10, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // menuShow
            // 
            this.menuShow.Image = global::GUI.Properties.Resources.menu;
            this.menuShow.Location = new System.Drawing.Point(10, 1);
            this.menuShow.Name = "menuShow";
            this.menuShow.Size = new System.Drawing.Size(32, 32);
            this.menuShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.menuShow.TabIndex = 3;
            this.menuShow.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.panel3.Controls.Add(this.btnEmp);
            this.panel3.Location = new System.Drawing.Point(3, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 55);
            this.panel3.TabIndex = 21;
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.btnEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.btnEmp.Image = global::GUI.Properties.Resources.management;
            this.btnEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmp.Location = new System.Drawing.Point(-12, -13);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEmp.Size = new System.Drawing.Size(299, 79);
            this.btnEmp.TabIndex = 22;
            this.btnEmp.Text = "       Quản lý nhân viên";
            this.btnEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.panel8.Controls.Add(this.btnMoney);
            this.panel8.Location = new System.Drawing.Point(3, 192);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 55);
            this.panel8.TabIndex = 23;
            // 
            // btnMoney
            // 
            this.btnMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.btnMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.btnMoney.Image = global::GUI.Properties.Resources.bar_chart;
            this.btnMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney.Location = new System.Drawing.Point(-12, -13);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMoney.Size = new System.Drawing.Size(299, 79);
            this.btnMoney.TabIndex = 22;
            this.btnMoney.Text = "       Quản lý doanh thu";
            this.btnMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney.UseVisualStyleBackColor = false;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.panel9.Controls.Add(this.btnInfo);
            this.panel9.Controls.Add(this.btnEditI);
            this.panel9.Location = new System.Drawing.Point(3, 253);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 55);
            this.panel9.TabIndex = 23;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.btnInfo.Image = global::GUI.Properties.Resources.pencil;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(-14, -12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(299, 79);
            this.btnInfo.TabIndex = 23;
            this.btnInfo.Text = "       Chỉnh sửa thông tin";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnEditI
            // 
            this.btnEditI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.btnEditI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.btnEditI.Image = global::GUI.Properties.Resources.pencil;
            this.btnEditI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditI.Location = new System.Drawing.Point(-12, -13);
            this.btnEditI.Name = "btnEditI";
            this.btnEditI.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnEditI.Size = new System.Drawing.Size(299, 79);
            this.btnEditI.TabIndex = 22;
            this.btnEditI.Text = "Chỉnh sửa thông tin";
            this.btnEditI.UseVisualStyleBackColor = false;
            this.btnEditI.Click += new System.EventHandler(this.btnEditI_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.panelTop.Controls.Add(this.logout);
            this.panelTop.Controls.Add(this.panel7);
            this.panelTop.Controls.Add(this.mini);
            this.panelTop.Controls.Add(this.exit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(236, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(725, 67);
            this.panelTop.TabIndex = 3;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Image = global::GUI.Properties.Resources.logout4;
            this.logout.Location = new System.Drawing.Point(9, 15);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(32, 32);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logout.TabIndex = 25;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Azure;
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.search);
            this.panel7.Location = new System.Drawing.Point(344, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(290, 39);
            this.panel7.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Image = global::GUI.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(262, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Azure;
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.search.Location = new System.Drawing.Point(4, 8);
            this.search.Name = "search";
            this.search.PlaceholderText = "Tìm kiếm";
            this.search.Size = new System.Drawing.Size(253, 22);
            this.search.TabIndex = 11;
            // 
            // mini
            // 
            this.mini.BackColor = System.Drawing.Color.Transparent;
            this.mini.Image = global::GUI.Properties.Resources.mini;
            this.mini.Location = new System.Drawing.Point(664, 10);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(20, 20);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mini.TabIndex = 13;
            this.mini.TabStop = false;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = global::GUI.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(694, 10);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 20);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exit.TabIndex = 12;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panelAction
            // 
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAction.Location = new System.Drawing.Point(236, 67);
            this.panelAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(725, 630);
            this.panelAction.TabIndex = 4;
            this.panelAction.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAction_Paint);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 697);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminForm";
            this.Text = "Pharmacity";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adminForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.adminForm_MouseMove);
            this.panelTask.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuShow)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel panelTask;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Button btnEditInfo;
        private Panel panel4;
        private Button buttonIncome;
        private PictureBox menuShow;
        private Panel panelTop;
        private Panel panel7;
        private PictureBox pictureBox1;
        private TextBox search;
        private PictureBox mini;
        private PictureBox exit;
        private Panel panelAction;
        private Panel panel3;
        private Button btnEmp;
        private Panel panel8;
        private Button btnMoney;
        private Panel panel9;
        private Button btnEditI;
        private Panel panelPersonal;
        private PictureBox pictureBox3;
        private Label displayName;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox logout;
        private Button btnInfo;
        private System.Windows.Forms.Timer timer1;
    }
}