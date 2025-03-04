﻿namespace Club_UI
{
    partial class frmMembers
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
            btnUpdateMembers = new Button();
            btnDeleteMember = new Button();
            btnAddMembers = new Button();
            grdMembers = new DataGridView();
            panel1 = new Panel();
            labShowTime = new Label();
            labTime = new Label();
            labShowUser = new Label();
            labUser = new Label();
            groupBoxInputs = new GroupBox();
            label1 = new Label();
            dtpBirthDate = new DateTimePicker();
            btnClose = new Button();
            btnClear = new Button();
            txtbAddress = new TextBox();
            labMembershipTypeBasebrice = new Label();
            txtbPhoneNumber = new TextBox();
            labMembershipTypeDiscription = new Label();
            txtbName = new TextBox();
            labMembershipTypeName = new Label();
            panel2 = new Panel();
            panelTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)grdMembers).BeginInit();
            panel1.SuspendLayout();
            groupBoxInputs.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdateMembers
            // 
            btnUpdateMembers.Location = new Point(620, 513);
            btnUpdateMembers.Name = "btnUpdateMembers";
            btnUpdateMembers.Size = new Size(94, 29);
            btnUpdateMembers.TabIndex = 11;
            btnUpdateMembers.Text = "Update";
            btnUpdateMembers.UseVisualStyleBackColor = true;
            btnUpdateMembers.Click += btnUpdateMembers_Click;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.Location = new Point(620, 573);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new Size(94, 29);
            btnDeleteMember.TabIndex = 10;
            btnDeleteMember.Text = "Delete";
            btnDeleteMember.UseVisualStyleBackColor = true;
            btnDeleteMember.Click += btnDeleteMember_Click;
            // 
            // btnAddMembers
            // 
            btnAddMembers.Location = new Point(620, 455);
            btnAddMembers.Name = "btnAddMembers";
            btnAddMembers.Size = new Size(94, 29);
            btnAddMembers.TabIndex = 9;
            btnAddMembers.Text = "Add";
            btnAddMembers.UseVisualStyleBackColor = true;
            btnAddMembers.Click += btnAddMembers_Click;
            // 
            // grdMembers
            // 
            grdMembers.AllowUserToAddRows = false;
            grdMembers.AllowUserToDeleteRows = false;
            grdMembers.AllowUserToResizeRows = false;
            grdMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdMembers.BackgroundColor = SystemColors.ButtonHighlight;
            grdMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMembers.Location = new Point(0, 59);
            grdMembers.MultiSelect = false;
            grdMembers.Name = "grdMembers";
            grdMembers.ReadOnly = true;
            grdMembers.RowHeadersWidth = 51;
            grdMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdMembers.Size = new Size(774, 267);
            grdMembers.TabIndex = 8;
            grdMembers.CellClick += grdMembers_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(labShowTime);
            panel1.Controls.Add(labTime);
            panel1.Controls.Add(labShowUser);
            panel1.Controls.Add(labUser);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 638);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 37);
            panel1.TabIndex = 7;
            // 
            // labShowTime
            // 
            labShowTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labShowTime.AutoSize = true;
            labShowTime.Location = new Point(815, 8);
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
            labTime.Location = new Point(767, 8);
            labTime.Name = "labTime";
            labTime.Size = new Size(42, 20);
            labTime.TabIndex = 6;
            labTime.Text = "Time";
            // 
            // labShowUser
            // 
            labShowUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labShowUser.AutoSize = true;
            labShowUser.Location = new Point(120, 8);
            labShowUser.Name = "labShowUser";
            labShowUser.Size = new Size(27, 20);
            labShowUser.TabIndex = 5;
            labShowUser.Text = "---";
            // 
            // labUser
            // 
            labUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labUser.AutoSize = true;
            labUser.Location = new Point(29, 8);
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
            groupBoxInputs.Controls.Add(dtpBirthDate);
            groupBoxInputs.Controls.Add(btnClose);
            groupBoxInputs.Controls.Add(btnClear);
            groupBoxInputs.Controls.Add(txtbAddress);
            groupBoxInputs.Controls.Add(labMembershipTypeBasebrice);
            groupBoxInputs.Controls.Add(txtbPhoneNumber);
            groupBoxInputs.Controls.Add(labMembershipTypeDiscription);
            groupBoxInputs.Controls.Add(txtbName);
            groupBoxInputs.Controls.Add(labMembershipTypeName);
            groupBoxInputs.Location = new Point(12, 351);
            groupBoxInputs.Name = "groupBoxInputs";
            groupBoxInputs.Size = new Size(511, 270);
            groupBoxInputs.TabIndex = 6;
            groupBoxInputs.TabStop = false;
            groupBoxInputs.Text = "Member Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 183);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 9;
            label1.Text = "Birth Date";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(136, 183);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(237, 27);
            dtpBirthDate.TabIndex = 8;
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
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(136, 229);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
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
            // txtbPhoneNumber
            // 
            txtbPhoneNumber.Location = new Point(136, 91);
            txtbPhoneNumber.Name = "txtbPhoneNumber";
            txtbPhoneNumber.Size = new Size(237, 27);
            txtbPhoneNumber.TabIndex = 5;
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
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(767, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 638);
            panel2.TabIndex = 12;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.SteelBlue;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(767, 50);
            panelTop.TabIndex = 13;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(991, 675);
            Controls.Add(panelTop);
            Controls.Add(panel2);
            Controls.Add(btnUpdateMembers);
            Controls.Add(btnDeleteMember);
            Controls.Add(btnAddMembers);
            Controls.Add(grdMembers);
            Controls.Add(panel1);
            Controls.Add(groupBoxInputs);
            Name = "frmMembers";
            Text = "frmMembers";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)grdMembers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxInputs.ResumeLayout(false);
            groupBoxInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdateMembers;
        private Button btnDeleteMember;
        private Button btnAddMembers;
        private DataGridView grdMembers;
        private Panel panel1;
        private Label labShowTime;
        private Label labTime;
        private Label labShowUser;
        private Label labUser;
        private GroupBox groupBoxInputs;
        private Button btnClose;
        private Button btnClear;
        private TextBox txtbAddress;
        private Label labMembershipTypeBasebrice;
        private TextBox txtbPhoneNumber;
        private Label labMembershipTypeDiscription;
        private TextBox txtbName;
        private Label labMembershipTypeName;
        private Panel panel2;
        private DateTimePicker dtpBirthDate;
        private Panel panelTop;
        private Label label1;
    }
}