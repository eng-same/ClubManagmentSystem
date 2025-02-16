namespace Club_UI
{
    partial class frmStartup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            viewToolStripMenuItem = new ToolStripMenuItem();
            allMembersInfoToolStripMenuItem = new ToolStripMenuItem();
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
            panel1 = new Panel();
            btnPayments = new Button();
            btnMembershipstype = new Button();
            btnMembers = new Button();
            btnMemberships = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            labShowTime = new Label();
            labTime = new Label();
            labShowUser = new Label();
            labUser = new Label();
            timerMain = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allMembersInfoToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // allMembersInfoToolStripMenuItem
            // 
            allMembersInfoToolStripMenuItem.Name = "allMembersInfoToolStripMenuItem";
            allMembersInfoToolStripMenuItem.Size = new Size(206, 26);
            allMembersInfoToolStripMenuItem.Text = "All members info";
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
            optionsToolStripMenuItem.Size = new Size(142, 26);
            optionsToolStripMenuItem.Text = "options";
            // 
            // themToolStripMenuItem
            // 
            themToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkModeToolStripMenuItem, ligthModeToolStripMenuItem });
            themToolStripMenuItem.Name = "themToolStripMenuItem";
            themToolStripMenuItem.Size = new Size(129, 26);
            themToolStripMenuItem.Text = "Them";
            // 
            // darkModeToolStripMenuItem
            // 
            darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            darkModeToolStripMenuItem.Size = new Size(168, 26);
            darkModeToolStripMenuItem.Text = "Dark mode";
            // 
            // ligthModeToolStripMenuItem
            // 
            ligthModeToolStripMenuItem.Name = "ligthModeToolStripMenuItem";
            ligthModeToolStripMenuItem.Size = new Size(168, 26);
            ligthModeToolStripMenuItem.Text = "Ligth mode";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(142, 26);
            aboutToolStripMenuItem.Text = "About ";
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(btnPayments);
            panel1.Controls.Add(btnMembershipstype);
            panel1.Controls.Add(btnMembers);
            panel1.Controls.Add(btnMemberships);
            panel1.Location = new Point(575, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 431);
            panel1.TabIndex = 1;
            // 
            // btnPayments
            // 
            btnPayments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPayments.Location = new Point(20, 286);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(181, 52);
            btnPayments.TabIndex = 3;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnMembershipstype
            // 
            btnMembershipstype.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMembershipstype.Location = new Point(20, 216);
            btnMembershipstype.Name = "btnMembershipstype";
            btnMembershipstype.Size = new Size(181, 52);
            btnMembershipstype.TabIndex = 2;
            btnMembershipstype.Text = "MembershipsType";
            btnMembershipstype.UseVisualStyleBackColor = true;
            btnMembershipstype.Click += btnMembershipstype_Click;
            // 
            // btnMembers
            // 
            btnMembers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMembers.Location = new Point(20, 146);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(181, 52);
            btnMembers.TabIndex = 1;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = true;
            // 
            // btnMemberships
            // 
            btnMemberships.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMemberships.Location = new Point(20, 76);
            btnMemberships.Name = "btnMemberships";
            btnMemberships.Size = new Size(181, 52);
            btnMemberships.TabIndex = 0;
            btnMemberships.Text = "Memberships";
            btnMemberships.UseVisualStyleBackColor = true;
            btnMemberships.Click += btnMemberships_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(6, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 57);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(labShowTime);
            panel3.Controls.Add(labTime);
            panel3.Controls.Add(labShowUser);
            panel3.Controls.Add(labUser);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 407);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 43);
            panel3.TabIndex = 3;
            // 
            // labShowTime
            // 
            labShowTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labShowTime.AutoSize = true;
            labShowTime.Location = new Point(684, 7);
            labShowTime.Name = "labShowTime";
            labShowTime.Size = new Size(36, 20);
            labShowTime.TabIndex = 3;
            labShowTime.Text = "--:--";
            // 
            // labTime
            // 
            labTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labTime.AutoSize = true;
            labTime.Location = new Point(628, 7);
            labTime.Name = "labTime";
            labTime.Size = new Size(42, 20);
            labTime.TabIndex = 2;
            labTime.Text = "Time";
            // 
            // labShowUser
            // 
            labShowUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labShowUser.AutoSize = true;
            labShowUser.Location = new Point(129, 7);
            labShowUser.Name = "labShowUser";
            labShowUser.Size = new Size(27, 20);
            labShowUser.TabIndex = 1;
            labShowUser.Text = "---";
            // 
            // labUser
            // 
            labUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labUser.AutoSize = true;
            labUser.Location = new Point(20, 7);
            labUser.Name = "labUser";
            labUser.Size = new Size(85, 20);
            labUser.TabIndex = 0;
            labUser.Text = "User Name:";
            // 
            // timerMain
            // 
            timerMain.Enabled = true;
            timerMain.Interval = 1000;
            timerMain.Tick += timerMain_Tick;
            // 
            // frmStartup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmStartup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Mangment System";
            Load += frmStartup_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem themToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem darkModeToolStripMenuItem;
        private ToolStripMenuItem ligthModeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnPayments;
        private Button btnMembershipstype;
        private Button btnMembers;
        private Button btnMemberships;
        private Label labUser;
        private Label labShowTime;
        private Label labTime;
        private Label labShowUser;
        private System.Windows.Forms.Timer timerMain;
        private ToolStripMenuItem allMembersInfoToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
    }
}
