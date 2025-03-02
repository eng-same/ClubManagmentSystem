namespace Club_UI
{
    partial class frmMemberships
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
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            grdMemberships = new DataGridView();
            panel1 = new Panel();
            labShowTime = new Label();
            labTime = new Label();
            labShowUser = new Label();
            labUser = new Label();
            groupBoxInputs = new GroupBox();
            label3 = new Label();
            combMembers = new ComboBox();
            label2 = new Label();
            combMembershipTypes = new ComboBox();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            btnClose = new Button();
            btnClear = new Button();
            labMembershipTypeBasebrice = new Label();
            labMembershipTypeDiscription = new Label();
            txtbPrice = new TextBox();
            labMembershipTypeName = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)grdMemberships).BeginInit();
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
            panelTop.Size = new Size(1221, 50);
            panelTop.TabIndex = 21;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(431, 183);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(554, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(674, 183);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grdMemberships
            // 
            grdMemberships.AllowUserToAddRows = false;
            grdMemberships.AllowUserToDeleteRows = false;
            grdMemberships.AllowUserToResizeRows = false;
            grdMemberships.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdMemberships.BackgroundColor = SystemColors.ButtonHighlight;
            grdMemberships.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMemberships.Location = new Point(0, 45);
            grdMemberships.MultiSelect = false;
            grdMemberships.Name = "grdMemberships";
            grdMemberships.ReadOnly = true;
            grdMemberships.RowHeadersWidth = 51;
            grdMemberships.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdMemberships.Size = new Size(774, 267);
            grdMemberships.TabIndex = 16;
            grdMemberships.CellClick += grdMemberships_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(labShowTime);
            panel1.Controls.Add(labTime);
            panel1.Controls.Add(labShowUser);
            panel1.Controls.Add(labUser);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 631);
            panel1.Name = "panel1";
            panel1.Size = new Size(1221, 37);
            panel1.TabIndex = 15;
            // 
            // labShowTime
            // 
            labShowTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labShowTime.AutoSize = true;
            labShowTime.Location = new Point(1101, 8);
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
            labTime.Location = new Point(1037, 8);
            labTime.Name = "labTime";
            labTime.Size = new Size(42, 20);
            labTime.TabIndex = 6;
            labTime.Text = "Time";
            // 
            // labShowUser
            // 
            labShowUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labShowUser.AutoSize = true;
            labShowUser.Location = new Point(128, 8);
            labShowUser.Name = "labShowUser";
            labShowUser.Size = new Size(27, 20);
            labShowUser.TabIndex = 5;
            labShowUser.Text = "---";
            // 
            // labUser
            // 
            labUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labUser.AutoSize = true;
            labUser.Location = new Point(28, 8);
            labUser.Name = "labUser";
            labUser.Size = new Size(85, 20);
            labUser.TabIndex = 4;
            labUser.Text = "User Name:";
            // 
            // groupBoxInputs
            // 
            groupBoxInputs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInputs.BackColor = Color.SteelBlue;
            groupBoxInputs.Controls.Add(label3);
            groupBoxInputs.Controls.Add(combMembers);
            groupBoxInputs.Controls.Add(label2);
            groupBoxInputs.Controls.Add(combMembershipTypes);
            groupBoxInputs.Controls.Add(btnDelete);
            groupBoxInputs.Controls.Add(btnUpdate);
            groupBoxInputs.Controls.Add(dtpEndDate);
            groupBoxInputs.Controls.Add(btnAdd);
            groupBoxInputs.Controls.Add(dtpStartDate);
            groupBoxInputs.Controls.Add(btnClose);
            groupBoxInputs.Controls.Add(btnClear);
            groupBoxInputs.Controls.Add(labMembershipTypeBasebrice);
            groupBoxInputs.Controls.Add(labMembershipTypeDiscription);
            groupBoxInputs.Controls.Add(txtbPrice);
            groupBoxInputs.Controls.Add(labMembershipTypeName);
            groupBoxInputs.Location = new Point(0, 318);
            groupBoxInputs.Name = "groupBoxInputs";
            groupBoxInputs.Size = new Size(774, 270);
            groupBoxInputs.TabIndex = 14;
            groupBoxInputs.TabStop = false;
            groupBoxInputs.Text = "Member Info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 52);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 22;
            label3.Text = "Member";
            // 
            // combMembers
            // 
            combMembers.DropDownStyle = ComboBoxStyle.DropDownList;
            combMembers.FormattingEnabled = true;
            combMembers.Location = new Point(485, 49);
            combMembers.Name = "combMembers";
            combMembers.Size = new Size(237, 28);
            combMembers.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 182);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 20;
            label2.Text = "Membership Type";
            // 
            // combMembershipTypes
            // 
            combMembershipTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            combMembershipTypes.FormattingEnabled = true;
            combMembershipTypes.Location = new Point(136, 179);
            combMembershipTypes.Name = "combMembershipTypes";
            combMembershipTypes.Size = new Size(237, 28);
            combMembershipTypes.TabIndex = 12;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(136, 131);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(237, 27);
            dtpEndDate.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(136, 89);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(237, 27);
            dtpStartDate.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(268, 227);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(136, 228);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // labMembershipTypeBasebrice
            // 
            labMembershipTypeBasebrice.AutoSize = true;
            labMembershipTypeBasebrice.Location = new Point(26, 136);
            labMembershipTypeBasebrice.Name = "labMembershipTypeBasebrice";
            labMembershipTypeBasebrice.Size = new Size(70, 20);
            labMembershipTypeBasebrice.TabIndex = 6;
            labMembershipTypeBasebrice.Text = "End Date";
            // 
            // labMembershipTypeDiscription
            // 
            labMembershipTypeDiscription.AutoSize = true;
            labMembershipTypeDiscription.Location = new Point(26, 94);
            labMembershipTypeDiscription.Name = "labMembershipTypeDiscription";
            labMembershipTypeDiscription.Size = new Size(76, 20);
            labMembershipTypeDiscription.TabIndex = 4;
            labMembershipTypeDiscription.Text = "Start Date";
            // 
            // txtbPrice
            // 
            txtbPrice.Location = new Point(136, 46);
            txtbPrice.Name = "txtbPrice";
            txtbPrice.Size = new Size(237, 27);
            txtbPrice.TabIndex = 3;
            // 
            // labMembershipTypeName
            // 
            labMembershipTypeName.AutoSize = true;
            labMembershipTypeName.Location = new Point(28, 49);
            labMembershipTypeName.Name = "labMembershipTypeName";
            labMembershipTypeName.Size = new Size(41, 20);
            labMembershipTypeName.TabIndex = 2;
            labMembershipTypeName.Text = "Price";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(940, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 532);
            panel2.TabIndex = 22;
            // 
            // frmMemberships
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 668);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Controls.Add(grdMemberships);
            Controls.Add(panel1);
            Controls.Add(groupBoxInputs);
            Name = "frmMemberships";
            Text = "frmMemberships";
            Load += frmMemberships_Load;
            ((System.ComponentModel.ISupportInitialize)grdMemberships).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxInputs.ResumeLayout(false);
            groupBoxInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView grdMemberships;
        private Panel panel1;
        private Label labShowTime;
        private Label labTime;
        private Label labShowUser;
        private Label labUser;
        private GroupBox groupBoxInputs;
        private DateTimePicker dtpStartDate;
        private Label label1;
        private DateTimePicker dtpBirthDate;
        private Button btnClose;
        private Button btnClear;
        private Label labMembershipTypeBasebrice;
        private Label labMembershipTypeDiscription;
        private TextBox txtbPrice;
        private TextBox txtbName;
        private Label labMembershipTypeName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox combMembershipTypes;
        private TextBox textBox1;
        private DateTimePicker dtpEndDate;
        private Label label2;
        private Label label3;
        private ComboBox combMembers;
        private Panel panel2;
    }
}