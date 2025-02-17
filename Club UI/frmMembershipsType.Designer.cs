namespace Club_UI
{
    partial class frmMembershipsType
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
            groupBoxInputs = new GroupBox();
            btnClose = new Button();
            btnClear = new Button();
            txtbBasebrice = new TextBox();
            labMembershipTypeBasebrice = new Label();
            txtbDiscription = new TextBox();
            labMembershipTypeDiscription = new Label();
            txtbName = new TextBox();
            labMembershipTypeName = new Label();
            panel1 = new Panel();
            labShowTime = new Label();
            labTime = new Label();
            labShowUser = new Label();
            labUser = new Label();
            grdmembershipTypes = new DataGridView();
            membershipTypeRepositoryBindingSource = new BindingSource(components);
            btnAddMembershipType = new Button();
            btnDeleteMembershipType = new Button();
            btnUpdateMembershipType = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBoxInputs.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdmembershipTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)membershipTypeRepositoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInputs
            // 
            groupBoxInputs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInputs.BackColor = SystemColors.ActiveCaption;
            groupBoxInputs.Controls.Add(btnClose);
            groupBoxInputs.Controls.Add(btnClear);
            groupBoxInputs.Controls.Add(txtbBasebrice);
            groupBoxInputs.Controls.Add(labMembershipTypeBasebrice);
            groupBoxInputs.Controls.Add(txtbDiscription);
            groupBoxInputs.Controls.Add(labMembershipTypeDiscription);
            groupBoxInputs.Controls.Add(txtbName);
            groupBoxInputs.Controls.Add(labMembershipTypeName);
            groupBoxInputs.Location = new Point(545, 25);
            groupBoxInputs.Name = "groupBoxInputs";
            groupBoxInputs.Size = new Size(351, 205);
            groupBoxInputs.TabIndex = 0;
            groupBoxInputs.TabStop = false;
            groupBoxInputs.Text = "Membership Type Info";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(218, 170);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(108, 170);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtbBasebrice
            // 
            txtbBasebrice.Location = new Point(108, 135);
            txtbBasebrice.Name = "txtbBasebrice";
            txtbBasebrice.Size = new Size(237, 27);
            txtbBasebrice.TabIndex = 7;
            // 
            // labMembershipTypeBasebrice
            // 
            labMembershipTypeBasebrice.AutoSize = true;
            labMembershipTypeBasebrice.Location = new Point(26, 138);
            labMembershipTypeBasebrice.Name = "labMembershipTypeBasebrice";
            labMembershipTypeBasebrice.Size = new Size(77, 20);
            labMembershipTypeBasebrice.TabIndex = 6;
            labMembershipTypeBasebrice.Text = "Base brice";
            // 
            // txtbDiscription
            // 
            txtbDiscription.Location = new Point(108, 92);
            txtbDiscription.Name = "txtbDiscription";
            txtbDiscription.Size = new Size(237, 27);
            txtbDiscription.TabIndex = 5;
            // 
            // labMembershipTypeDiscription
            // 
            labMembershipTypeDiscription.AutoSize = true;
            labMembershipTypeDiscription.Location = new Point(26, 95);
            labMembershipTypeDiscription.Name = "labMembershipTypeDiscription";
            labMembershipTypeDiscription.Size = new Size(81, 20);
            labMembershipTypeDiscription.TabIndex = 4;
            labMembershipTypeDiscription.Text = "Discription";
            // 
            // txtbName
            // 
            txtbName.Location = new Point(108, 43);
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(labShowTime);
            panel1.Controls.Add(labTime);
            panel1.Controls.Add(labShowUser);
            panel1.Controls.Add(labUser);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 448);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 37);
            panel1.TabIndex = 1;
            // 
            // labShowTime
            // 
            labShowTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labShowTime.AutoSize = true;
            labShowTime.Location = new Point(860, 8);
            labShowTime.Name = "labShowTime";
            labShowTime.Size = new Size(36, 20);
            labShowTime.TabIndex = 7;
            labShowTime.Text = "--:--";
            // 
            // labTime
            // 
            labTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labTime.AutoSize = true;
            labTime.Location = new Point(804, 8);
            labTime.Name = "labTime";
            labTime.Size = new Size(42, 20);
            labTime.TabIndex = 6;
            labTime.Text = "Time";
            // 
            // labShowUser
            // 
            labShowUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labShowUser.AutoSize = true;
            labShowUser.Location = new Point(159, 8);
            labShowUser.Name = "labShowUser";
            labShowUser.Size = new Size(27, 20);
            labShowUser.TabIndex = 5;
            labShowUser.Text = "---";
            // 
            // labUser
            // 
            labUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labUser.AutoSize = true;
            labUser.Location = new Point(50, 8);
            labUser.Name = "labUser";
            labUser.Size = new Size(85, 20);
            labUser.TabIndex = 4;
            labUser.Text = "User Name:";
            // 
            // grdmembershipTypes
            // 
            grdmembershipTypes.AllowUserToAddRows = false;
            grdmembershipTypes.AllowUserToDeleteRows = false;
            grdmembershipTypes.AllowUserToResizeRows = false;
            grdmembershipTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grdmembershipTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdmembershipTypes.BackgroundColor = SystemColors.ButtonHighlight;
            grdmembershipTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdmembershipTypes.Location = new Point(22, 25);
            grdmembershipTypes.MultiSelect = false;
            grdmembershipTypes.Name = "grdmembershipTypes";
            grdmembershipTypes.ReadOnly = true;
            grdmembershipTypes.RowHeadersWidth = 51;
            grdmembershipTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdmembershipTypes.Size = new Size(517, 382);
            grdmembershipTypes.TabIndex = 2;
            grdmembershipTypes.CellClick += grdmembershipTypes_CellClick;
            // 
            // membershipTypeRepositoryBindingSource
            // 
            membershipTypeRepositoryBindingSource.DataSource = typeof(ClubClassLibrary.Repository.MembershipTypeRepository);
            // 
            // btnAddMembershipType
            // 
            btnAddMembershipType.Location = new Point(571, 266);
            btnAddMembershipType.Name = "btnAddMembershipType";
            btnAddMembershipType.Size = new Size(94, 29);
            btnAddMembershipType.TabIndex = 3;
            btnAddMembershipType.Text = "Add";
            btnAddMembershipType.UseVisualStyleBackColor = true;
            btnAddMembershipType.Click += btnAddMembershipType_Click;
            // 
            // btnDeleteMembershipType
            // 
            btnDeleteMembershipType.Location = new Point(571, 315);
            btnDeleteMembershipType.Name = "btnDeleteMembershipType";
            btnDeleteMembershipType.Size = new Size(94, 29);
            btnDeleteMembershipType.TabIndex = 4;
            btnDeleteMembershipType.Text = "Delete";
            btnDeleteMembershipType.UseVisualStyleBackColor = true;
            btnDeleteMembershipType.Click += btnDeleteMembershipType_Click;
            // 
            // btnUpdateMembershipType
            // 
            btnUpdateMembershipType.Location = new Point(571, 362);
            btnUpdateMembershipType.Name = "btnUpdateMembershipType";
            btnUpdateMembershipType.Size = new Size(94, 29);
            btnUpdateMembershipType.TabIndex = 5;
            btnUpdateMembershipType.Text = "Update";
            btnUpdateMembershipType.UseVisualStyleBackColor = true;
            btnUpdateMembershipType.Click += btnUpdateMembershipType_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmMembershipsType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(946, 485);
            Controls.Add(btnUpdateMembershipType);
            Controls.Add(btnDeleteMembershipType);
            Controls.Add(btnAddMembershipType);
            Controls.Add(grdmembershipTypes);
            Controls.Add(panel1);
            Controls.Add(groupBoxInputs);
            Name = "frmMembershipsType";
            Text = "frmMembershipsType";
            Load += frmMembershipsType_Load;
            groupBoxInputs.ResumeLayout(false);
            groupBoxInputs.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdmembershipTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)membershipTypeRepositoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInputs;
        private Panel panel1;
        private Label labShowTime;
        private Label labTime;
        private Label labShowUser;
        private Label labUser;
        private TextBox txtbBasebrice;
        private Label labMembershipTypeBasebrice;
        private TextBox txtbDiscription;
        private Label labMembershipTypeDiscription;
        private TextBox txtbName;
        private Label labMembershipTypeName;
        private DataGridView grdmembershipTypes;
        private Button btnAddMembershipType;
        private Button btnDeleteMembershipType;
        private Button btnUpdateMembershipType;
        private BindingSource membershipTypeRepositoryBindingSource;
        private System.Windows.Forms.Timer timer1;
        private Button btnClear;
        private Button btnClose;
    }
}