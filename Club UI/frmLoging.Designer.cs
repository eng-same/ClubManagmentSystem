namespace Club_UI
{
    partial class frmLoging
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtbPassword = new TextBox();
            txtbUserName = new TextBox();
            lblClear = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLog = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.user_svgrepo_com__4_;
            pictureBox1.Location = new Point(171, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(txtbPassword);
            groupBox1.Controls.Add(txtbUserName);
            groupBox1.Controls.Add(lblClear);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(49, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 213);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "User info";
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(81, 143);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.PasswordChar = '*';
            txtbPassword.Size = new Size(212, 27);
            txtbPassword.TabIndex = 6;
            // 
            // txtbUserName
            // 
            txtbUserName.Location = new Point(81, 62);
            txtbUserName.Name = "txtbUserName";
            txtbUserName.Size = new Size(212, 27);
            txtbUserName.TabIndex = 5;
            // 
            // lblClear
            // 
            lblClear.AutoSize = true;
            lblClear.Location = new Point(36, 184);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(50, 20);
            lblClear.TabIndex = 4;
            lblClear.Text = "Clear?";
            lblClear.Click += lblClear_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkTurquoise;
            panel2.Location = new Point(32, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 1);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Location = new Point(32, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 1);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.icons8_login_30__1_;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(32, 131);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 39);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.icons8_login_30;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(32, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 36);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLog.Location = new Point(85, 349);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(90, 45);
            btnLog.TabIndex = 2;
            btnLog.Text = "Login";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(272, 349);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 45);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmLoging
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(432, 403);
            Controls.Add(btnClose);
            Controls.Add(btnLog);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLoging";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmLoging";
            TopMost = true;
            Load += frmLoging_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnLog;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label lblClear;
        private Panel panel2;
        private TextBox txtbPassword;
        private TextBox txtbUserName;
        private Button btnClose;
    }
}