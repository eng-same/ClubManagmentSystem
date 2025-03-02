namespace Club_UI
{
    partial class frmStartup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            viewToolStripMenuItem = new ToolStripMenuItem();
            menuStripMembersInfo = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            themToolStripMenuItem = new ToolStripMenuItem();
            darkModeToolStripMenuItem = new ToolStripMenuItem();
            ligthModeToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            panelTop = new Panel();
            btnLogOut = new Button();
            labUser = new Label();
            labShowUser = new Label();
            panelBottom = new Panel();
            labShowTime = new Label();
            labTime = new Label();
            timerMain = new System.Windows.Forms.Timer(components);
            btnMemberships = new Button();
            btnMembers = new Button();
            btnPayments = new Button();
            btnMembershipstype = new Button();
            btnUsers = new Button();
            menuStrip1.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem, helpToolStripMenuItem, windowToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuStripMembersInfo });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // menuStripMembersInfo
            // 
            menuStripMembersInfo.Name = "menuStripMembersInfo";
            menuStripMembersInfo.Size = new Size(224, 26);
            menuStripMembersInfo.Text = "All members info";
            menuStripMembersInfo.Click += menuStripMembersInfo_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(144, 26);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // themToolStripMenuItem
            // 
            themToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkModeToolStripMenuItem, ligthModeToolStripMenuItem });
            themToolStripMenuItem.Name = "themToolStripMenuItem";
            themToolStripMenuItem.Size = new Size(137, 26);
            themToolStripMenuItem.Text = "Theme";
            // 
            // darkModeToolStripMenuItem
            // 
            darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            darkModeToolStripMenuItem.Size = new Size(168, 26);
            darkModeToolStripMenuItem.Text = "Dark Mode";
            // 
            // ligthModeToolStripMenuItem
            // 
            ligthModeToolStripMenuItem.Name = "ligthModeToolStripMenuItem";
            ligthModeToolStripMenuItem.Size = new Size(168, 26);
            ligthModeToolStripMenuItem.Text = "Light Mode";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(144, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(78, 24);
            windowToolStripMenuItem.Text = "Window";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(120, 26);
            addToolStripMenuItem.Text = "Add";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showToolStripMenuItem, manageToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(58, 24);
            usersToolStripMenuItem.Text = "Users";
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(146, 26);
            showToolStripMenuItem.Text = "Show";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(146, 26);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.SteelBlue;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 28);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(800, 50);
            panelTop.TabIndex = 1;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.BackgroundImage = Properties.Resources.exit;
            btnLogOut.BackgroundImageLayout = ImageLayout.Center;
            btnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ButtonHighlight;
            btnLogOut.Location = new Point(445, 240);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(160, 100);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Log out";
            btnLogOut.TextAlign = ContentAlignment.BottomCenter;
            btnLogOut.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // labUser
            // 
            labUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labUser.AutoSize = true;
            labUser.Location = new Point(12, 10);
            labUser.Name = "labUser";
            labUser.Size = new Size(85, 20);
            labUser.TabIndex = 0;
            labUser.Text = "User Name:";
            // 
            // labShowUser
            // 
            labShowUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labShowUser.AutoSize = true;
            labShowUser.Location = new Point(121, 10);
            labShowUser.Name = "labShowUser";
            labShowUser.Size = new Size(27, 20);
            labShowUser.TabIndex = 1;
            labShowUser.Text = "---";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.Gainsboro;
            panelBottom.Controls.Add(labUser);
            panelBottom.Controls.Add(labShowUser);
            panelBottom.Controls.Add(labShowTime);
            panelBottom.Controls.Add(labTime);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 410);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(800, 40);
            panelBottom.TabIndex = 3;
            // 
            // labShowTime
            // 
            labShowTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labShowTime.AutoSize = true;
            labShowTime.Location = new Point(684, 10);
            labShowTime.Name = "labShowTime";
            labShowTime.Size = new Size(36, 20);
            labShowTime.TabIndex = 3;
            labShowTime.Text = "--:--";
            // 
            // labTime
            // 
            labTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labTime.AutoSize = true;
            labTime.Location = new Point(628, 10);
            labTime.Name = "labTime";
            labTime.Size = new Size(42, 20);
            labTime.TabIndex = 2;
            labTime.Text = "Time";
            // 
            // timerMain
            // 
            timerMain.Enabled = true;
            timerMain.Interval = 1000;
            timerMain.Tick += timerMain_Tick;
            // 
            // btnMemberships
            // 
            btnMemberships.FlatStyle = FlatStyle.Flat;
            btnMemberships.Image = Properties.Resources.calendar_svgrepo_com__2___1_;
            btnMemberships.ImageAlign = ContentAlignment.TopCenter;
            btnMemberships.Location = new Point(50, 100);
            btnMemberships.Name = "btnMemberships";
            btnMemberships.Size = new Size(160, 100);
            btnMemberships.TabIndex = 4;
            btnMemberships.Text = "Memberships";
            btnMemberships.TextAlign = ContentAlignment.BottomCenter;
            btnMemberships.UseVisualStyleBackColor = true;
            btnMemberships.Click += btnMemberships_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackgroundImage = Properties.Resources.user_svgrepo_com__4_;
            btnMembers.BackgroundImageLayout = ImageLayout.Center;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.ImageAlign = ContentAlignment.TopCenter;
            btnMembers.Location = new Point(250, 100);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(160, 100);
            btnMembers.TabIndex = 5;
            btnMembers.Text = "Members";
            btnMembers.TextAlign = ContentAlignment.BottomCenter;
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnPayments
            // 
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Image = Properties.Resources.column_chart_svgrepo_com__1_;
            btnPayments.ImageAlign = ContentAlignment.TopCenter;
            btnPayments.Location = new Point(50, 240);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(160, 100);
            btnPayments.TabIndex = 6;
            btnPayments.Text = "Payments";
            btnPayments.TextAlign = ContentAlignment.BottomCenter;
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnMembershipstype
            // 
            btnMembershipstype.BackgroundImage = Properties.Resources.conversation_svgrepo_com__1_;
            btnMembershipstype.BackgroundImageLayout = ImageLayout.Center;
            btnMembershipstype.FlatStyle = FlatStyle.Flat;
            btnMembershipstype.ImageAlign = ContentAlignment.TopCenter;
            btnMembershipstype.Location = new Point(250, 240);
            btnMembershipstype.Name = "btnMembershipstype";
            btnMembershipstype.Size = new Size(160, 100);
            btnMembershipstype.TabIndex = 7;
            btnMembershipstype.Text = "Membership Types";
            btnMembershipstype.TextAlign = ContentAlignment.BottomCenter;
            btnMembershipstype.UseVisualStyleBackColor = true;
            btnMembershipstype.Click += btnMembershipstype_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackgroundImage = Properties.Resources.set_up_svgrepo_com__3_;
            btnUsers.BackgroundImageLayout = ImageLayout.Center;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.ImageAlign = ContentAlignment.TopCenter;
            btnUsers.Location = new Point(445, 100);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(160, 100);
            btnUsers.TabIndex = 8;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.BottomCenter;
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // frmStartup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogOut);
            Controls.Add(btnUsers);
            Controls.Add(btnMembershipstype);
            Controls.Add(btnPayments);
            Controls.Add(btnMembers);
            Controls.Add(btnMemberships);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmStartup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Management System";
            Load += frmStartup_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripMembersInfo;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligthModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labShowTime;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labShowUser;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button btnMemberships;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnMembershipstype;
        private Button btnUsers;
        private Button btnLogOut;
    }
}
