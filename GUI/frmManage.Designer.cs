namespace QuanLyTiemBanh.GUI
{
    partial class frmManage
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
            this.lbUserName = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panelFunction = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnXXX = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbNameButton = new System.Windows.Forms.Label();
            this.lbvien = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFunction.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(477, 18);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(105, 20);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên tài khoản";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Controls.Add(this.panelFunction);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(255, 649);
            this.panelLeft.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.btnHelp);
            this.panelLogo.Controls.Add(this.btnMin);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(255, 186);
            this.panelLogo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyTiemBanh.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(68, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 113);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(3, 54);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(48, 33);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(3, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(48, 33);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "=";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panelFunction
            // 
            this.panelFunction.Controls.Add(this.button6);
            this.panelFunction.Controls.Add(this.groupBox2);
            this.panelFunction.Controls.Add(this.groupBox1);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFunction.Location = new System.Drawing.Point(0, 186);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(255, 463);
            this.panelFunction.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 423);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(255, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "&Đăng xuất";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân viên";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(249, 40);
            this.button5.TabIndex = 6;
            this.button5.Text = "&Chi tiết hóa đơn";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnNhanVien);
            this.groupBox1.Controls.Add(this.btnXXX);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(249, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "&Hóa đơn";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "&Loại Sản Phẩm";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Sản Phẩm";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.AutoSize = true;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 62);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(249, 40);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "&Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.UseWaitCursor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnXXX
            // 
            this.btnXXX.AutoSize = true;
            this.btnXXX.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXXX.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.btnXXX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXXX.Location = new System.Drawing.Point(3, 22);
            this.btnXXX.Name = "btnXXX";
            this.btnXXX.Size = new System.Drawing.Size(249, 40);
            this.btnXXX.TabIndex = 5;
            this.btnXXX.Text = "&Tài khoản";
            this.btnXXX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXXX.UseVisualStyleBackColor = true;
            this.btnXXX.UseWaitCursor = true;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lbNameButton);
            this.panelTop.Controls.Add(this.lbvien);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.lbUserName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(255, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(691, 58);
            this.panelTop.TabIndex = 3;
            // 
            // lbNameButton
            // 
            this.lbNameButton.AutoSize = true;
            this.lbNameButton.Location = new System.Drawing.Point(24, 18);
            this.lbNameButton.Name = "lbNameButton";
            this.lbNameButton.Size = new System.Drawing.Size(86, 20);
            this.lbNameButton.TabIndex = 5;
            this.lbNameButton.Text = "Tên button";
            // 
            // lbvien
            // 
            this.lbvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbvien.Location = new System.Drawing.Point(0, 54);
            this.lbvien.Name = "lbvien";
            this.lbvien.Size = new System.Drawing.Size(691, 4);
            this.lbvien.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(631, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 649);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManage";
            this.panelLeft.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFunction.ResumeLayout(false);
            this.panelFunction.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.Button btnXXX;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label lbvien;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Label lbNameButton;
    }
}