namespace Club_UI
{
    partial class frmPayments
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
            grdPayments = new DataGridView();
            panelBottom = new Panel();
            labUser = new Label();
            labShowUser = new Label();
            labShowTime = new Label();
            labTime = new Label();
            btnAddPayment = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            label = new Label();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            btnClear = new Button();
            combMethod = new ComboBox();
            combMembership = new ComboBox();
            combMember = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtbAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grdPayments).BeginInit();
            panelBottom.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grdPayments
            // 
            grdPayments.BackgroundColor = Color.WhiteSmoke;
            grdPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPayments.Location = new Point(12, 216);
            grdPayments.Name = "grdPayments";
            grdPayments.RowHeadersWidth = 51;
            grdPayments.Size = new Size(641, 171);
            grdPayments.TabIndex = 0;
            grdPayments.CellClick += grdPayments_CellClick;
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
            panelBottom.TabIndex = 4;
            // 
            // labUser
            // 
            labUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labUser.AutoSize = true;
            labUser.Location = new Point(3, 11);
            labUser.Name = "labUser";
            labUser.Size = new Size(85, 20);
            labUser.TabIndex = 0;
            labUser.Text = "User Name:";
            // 
            // labShowUser
            // 
            labShowUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labShowUser.AutoSize = true;
            labShowUser.Location = new Point(117, 11);
            labShowUser.Name = "labShowUser";
            labShowUser.Size = new Size(27, 20);
            labShowUser.TabIndex = 1;
            labShowUser.Text = "---";
            // 
            // labShowTime
            // 
            labShowTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labShowTime.AutoSize = true;
            labShowTime.Location = new Point(677, 11);
            labShowTime.Name = "labShowTime";
            labShowTime.Size = new Size(36, 20);
            labShowTime.TabIndex = 3;
            labShowTime.Text = "--:--";
            // 
            // labTime
            // 
            labTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labTime.AutoSize = true;
            labTime.Location = new Point(611, 11);
            labTime.Name = "labTime";
            labTime.Size = new Size(42, 20);
            labTime.TabIndex = 2;
            labTime.Text = "Time";
            // 
            // btnAddPayment
            // 
            btnAddPayment.BackColor = Color.WhiteSmoke;
            btnAddPayment.Location = new Point(677, 240);
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Size = new Size(94, 29);
            btnAddPayment.TabIndex = 5;
            btnAddPayment.Text = "Add";
            btnAddPayment.UseVisualStyleBackColor = false;
            btnAddPayment.Click += btnAddPayment_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(677, 286);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.WhiteSmoke;
            btnUpdate.Location = new Point(677, 333);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 8;
            label1.Text = "Amount";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(314, 98);
            label.Name = "label";
            label.Size = new Size(61, 20);
            label.TabIndex = 9;
            label.Text = "Method";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(combMethod);
            groupBox1.Controls.Add(combMembership);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(combMember);
            groupBox1.Controls.Add(txtbAmount);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(153, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 176);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(297, 141);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 19;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(186, 141);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // combMethod
            // 
            combMethod.FormattingEnabled = true;
            combMethod.Location = new Point(377, 95);
            combMethod.Name = "combMethod";
            combMethod.Size = new Size(177, 28);
            combMethod.TabIndex = 18;
            // 
            // combMembership
            // 
            combMembership.FormattingEnabled = true;
            combMembership.Location = new Point(103, 95);
            combMembership.Name = "combMembership";
            combMembership.Size = new Size(177, 28);
            combMembership.TabIndex = 17;
            // 
            // combMember
            // 
            combMember.FormattingEnabled = true;
            combMember.Location = new Point(103, 40);
            combMember.Name = "combMember";
            combMember.Size = new Size(177, 28);
            combMember.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 98);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 13;
            label3.Text = "Membership";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 40);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 12;
            label4.Text = "Member";
            // 
            // txtbAmount
            // 
            txtbAmount.Location = new Point(377, 37);
            txtbAmount.Name = "txtbAmount";
            txtbAmount.Size = new Size(177, 27);
            txtbAmount.TabIndex = 10;
            // 
            // frmPayments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAddPayment);
            Controls.Add(panelBottom);
            Controls.Add(grdPayments);
            Name = "frmPayments";
            Text = "frmPayments";
            Load += frmPayments_Load;
            ((System.ComponentModel.ISupportInitialize)grdPayments).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdPayments;
        private Panel panelBottom;
        private Label labUser;
        private Label labShowUser;
        private Label labShowTime;
        private Label labTime;
        private Button btnAddPayment;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label1;
        private Label label;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox txtbAmount;
        private Label label3;
        private Label label4;
        private ComboBox combMembership;
        private ComboBox combMember;
        private ComboBox combMethod;
        private Button btnClose;
        private Button btnClear;
    }
}