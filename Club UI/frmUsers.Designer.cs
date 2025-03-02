namespace Club_UI
{
    partial class frmUsers
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
            panelTop = new Panel();
            panel2 = new Panel();
            btnUpdateUser = new Button();
            btnDeleteUser = new Button();
            btnAddUser = new Button();
            grdMembers = new DataGridView();
            panel1 = new Panel();
            labShowTime = new Label();
            labTime = new Label();
            labShowUser = new Label();
            labUser = new Label();
            groupBoxInputs = new GroupBox();
            label2 = new Label();
            txtbEmail = new TextBox();
            label3 = new Label();
            txtbPassword = new TextBox();
            lblDateCreated = new Label();
            dtpCreatedDate = new DateTimePicker();
            btnClose = new Button();
            btnClear = new Button();
            txtbAddress = new TextBox();
            labMembershipTypeBasebrice = new Label();
            txtbPhone = new TextBox();
            labMembershipTypeDiscription = new Label();
            txtbName = new TextBox();
            labMembershipTypeName = new Label();
            combRole = new ComboBox();
            combStatus = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdMembers).BeginInit();
            panel1.SuspendLayout();
            groupBoxInputs.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.SteelBlue;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(916, 50);
            panelTop.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(916, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 555);
            panel2.TabIndex = 20;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(805, 431);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(94, 29);
            btnUpdateUser.TabIndex = 19;
            btnUpdateUser.Text = "Update";
            btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(805, 491);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(94, 29);
            btnDeleteUser.TabIndex = 18;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(805, 373);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(94, 29);
            btnAddUser.TabIndex = 17;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // grdMembers
            // 
            grdMembers.AllowUserToAddRows = false;
            grdMembers.AllowUserToDeleteRows = false;
            grdMembers.AllowUserToResizeRows = false;
            grdMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdMembers.BackgroundColor = SystemColors.ButtonHighlight;
            grdMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMembers.Location = new Point(0, -26);
            grdMembers.MultiSelect = false;
            grdMembers.Name = "grdMembers";
            grdMembers.ReadOnly = true;
            grdMembers.RowHeadersWidth = 51;
            grdMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdMembers.Size = new Size(774, 267);
            grdMembers.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(labShowTime);
            panel1.Controls.Add(labTime);
            panel1.Controls.Add(labShowUser);
            panel1.Controls.Add(labUser);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 555);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 37);
            panel1.TabIndex = 15;
            // 
            // labShowTime
            // 
            labShowTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labShowTime.AutoSize = true;
            labShowTime.Location = new Point(1755, -55);
            labShowTime.Name = "labShowTime";
            labShowTime.Size = new Size(36, 20);
            labShowTime.TabIndex = 7;
            labShowTime.Text = "--:--";
            // 
            // labTime
            // 
            labTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labTime.AutoSize = true;
            labTime.BackColor = SystemColors.ButtonHighlight;
            labTime.Location = new Point(1707, -55);
            labTime.Name = "labTime";
            labTime.Size = new Size(42, 20);
            labTime.TabIndex = 6;
            labTime.Text = "Time";
            // 
            // labShowUser
            // 
            labShowUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labShowUser.AutoSize = true;
            labShowUser.Location = new Point(120, -55);
            labShowUser.Name = "labShowUser";
            labShowUser.Size = new Size(27, 20);
            labShowUser.TabIndex = 5;
            labShowUser.Text = "---";
            // 
            // labUser
            // 
            labUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labUser.AutoSize = true;
            labUser.Location = new Point(29, -55);
            labUser.Name = "labUser";
            labUser.Size = new Size(85, 20);
            labUser.TabIndex = 4;
            labUser.Text = "User Name:";
            // 
            // groupBoxInputs
            // 
            groupBoxInputs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInputs.BackColor = Color.SteelBlue;
            groupBoxInputs.Controls.Add(label1);
            groupBoxInputs.Controls.Add(label4);
            groupBoxInputs.Controls.Add(combStatus);
            groupBoxInputs.Controls.Add(combRole);
            groupBoxInputs.Controls.Add(label2);
            groupBoxInputs.Controls.Add(txtbEmail);
            groupBoxInputs.Controls.Add(label3);
            groupBoxInputs.Controls.Add(txtbPassword);
            groupBoxInputs.Controls.Add(lblDateCreated);
            groupBoxInputs.Controls.Add(dtpCreatedDate);
            groupBoxInputs.Controls.Add(btnClose);
            groupBoxInputs.Controls.Add(btnClear);
            groupBoxInputs.Controls.Add(txtbAddress);
            groupBoxInputs.Controls.Add(labMembershipTypeBasebrice);
            groupBoxInputs.Controls.Add(txtbPhone);
            groupBoxInputs.Controls.Add(labMembershipTypeDiscription);
            groupBoxInputs.Controls.Add(txtbName);
            groupBoxInputs.Controls.Add(labMembershipTypeName);
            groupBoxInputs.Location = new Point(12, 266);
            groupBoxInputs.Name = "groupBoxInputs";
            groupBoxInputs.Size = new Size(762, 270);
            groupBoxInputs.TabIndex = 14;
            groupBoxInputs.TabStop = false;
            groupBoxInputs.Text = "Member Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 49);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 14;
            label2.Text = "Password";
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(493, 91);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(237, 27);
            txtbEmail.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 94);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(493, 46);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.Size = new Size(237, 27);
            txtbPassword.TabIndex = 11;
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(25, 183);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(97, 20);
            lblDateCreated.TabIndex = 9;
            lblDateCreated.Text = "Date Created";
            // 
            // dtpCreatedDate
            // 
            dtpCreatedDate.Location = new Point(136, 181);
            dtpCreatedDate.Name = "dtpCreatedDate";
            dtpCreatedDate.Size = new Size(237, 27);
            dtpCreatedDate.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(247, 229);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(136, 229);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtbAddress
            // 
            txtbAddress.Location = new Point(136, 136);
            txtbAddress.Name = "txtbAddress";
            txtbAddress.Size = new Size(237, 27);
            txtbAddress.TabIndex = 7;
            // 
            // labMembershipTypeBasebrice
            // 
            labMembershipTypeBasebrice.AutoSize = true;
            labMembershipTypeBasebrice.Location = new Point(26, 136);
            labMembershipTypeBasebrice.Name = "labMembershipTypeBasebrice";
            labMembershipTypeBasebrice.Size = new Size(62, 20);
            labMembershipTypeBasebrice.TabIndex = 6;
            labMembershipTypeBasebrice.Text = "Address";
            // 
            // txtbPhone
            // 
            txtbPhone.Location = new Point(136, 91);
            txtbPhone.Name = "txtbPhone";
            txtbPhone.Size = new Size(237, 27);
            txtbPhone.TabIndex = 5;
            // 
            // labMembershipTypeDiscription
            // 
            labMembershipTypeDiscription.AutoSize = true;
            labMembershipTypeDiscription.Location = new Point(26, 94);
            labMembershipTypeDiscription.Name = "labMembershipTypeDiscription";
            labMembershipTypeDiscription.Size = new Size(104, 20);
            labMembershipTypeDiscription.TabIndex = 4;
            labMembershipTypeDiscription.Text = "PhoneNumber";
            // 
            // txtbName
            // 
            txtbName.Location = new Point(136, 46);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(237, 27);
            txtbName.TabIndex = 3;
            // 
            // labMembershipTypeName
            // 
            labMembershipTypeName.AutoSize = true;
            labMembershipTypeName.Location = new Point(26, 46);
            labMembershipTypeName.Name = "labMembershipTypeName";
            labMembershipTypeName.Size = new Size(49, 20);
            labMembershipTypeName.TabIndex = 2;
            labMembershipTypeName.Text = "Name";
            // 
            // combRole
            // 
            combRole.FormattingEnabled = true;
            combRole.Location = new Point(493, 136);
            combRole.Name = "combRole";
            combRole.Size = new Size(151, 28);
            combRole.TabIndex = 15;
            // 
            // combStatus
            // 
            combStatus.FormattingEnabled = true;
            combStatus.Location = new Point(493, 180);
            combStatus.Name = "combStatus";
            combStatus.Size = new Size(151, 28);
            combStatus.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 139);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 18;
            label1.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 184);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 17;
            label4.Text = "Status";
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 592);
            Controls.Add(panelTop);
            Controls.Add(panel2);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnAddUser);
            Controls.Add(grdMembers);
            Controls.Add(panel1);
            Controls.Add(groupBoxInputs);
            Name = "frmUsers";
            Text = "frmUsers";
            ((System.ComponentModel.ISupportInitialize)grdMembers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxInputs.ResumeLayout(false);
            groupBoxInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panel2;
        private Button btnUpdateUser;
        private Button btnDeleteUser;
        private Button btnAddUser;
        private DataGridView grdMembers;
        private Panel panel1;
        private Label labShowTime;
        private Label labTime;
        private Label labShowUser;
        private Label labUser;
        private GroupBox groupBoxInputs;
        private Label lblDateCreated;
        private DateTimePicker dtpCreatedDate;
        private Button btnClose;
        private Button btnClear;
        private TextBox txtbAddress;
        private Label labMembershipTypeBasebrice;
        private TextBox txtbPhone;
        private Label labMembershipTypeDiscription;
        private TextBox txtbName;
        private Label labMembershipTypeName;
        private Label label2;
        private TextBox txtbEmail;
        private Label label3;
        private TextBox txtbPassword;
        private Label label1;
        private Label label4;
        private ComboBox combStatus;
        private ComboBox combRole;
    }
}