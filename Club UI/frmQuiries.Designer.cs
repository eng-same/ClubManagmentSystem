
namespace Club_UI
{
    partial class frmQuiries
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnApplyFilter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvResults = new DataGridView();
            btnApplyFilter = new Button();
            txtbPriceFrom = new TextBox();
            label1 = new Label();
            dtpStartDateFrom = new DateTimePicker();
            dtpStartDateTo = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtpEndDateTo = new DateTimePicker();
            label4 = new Label();
            dtpEndDateFrom = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtbPriceTo = new TextBox();
            label7 = new Label();
            rbPrice = new RadioButton();
            rbEndDate = new RadioButton();
            rbStartDate = new RadioButton();
            btnClose = new Button();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(12, 220);
            dgvResults.Margin = new Padding(3, 4, 3, 4);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(760, 293);
            dgvResults.TabIndex = 0;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Location = new Point(654, 170);
            btnApplyFilter.Margin = new Padding(3, 4, 3, 4);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(100, 31);
            btnApplyFilter.TabIndex = 3;
            btnApplyFilter.Text = "Filter";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // txtbPriceFrom
            // 
            txtbPriceFrom.Location = new Point(131, 142);
            txtbPriceFrom.Margin = new Padding(3, 4, 3, 4);
            txtbPriceFrom.Name = "txtbPriceFrom";
            txtbPriceFrom.Size = new Size(200, 27);
            txtbPriceFrom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 40);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 4;
            label1.Text = "Start Date from";
            // 
            // dtpStartDateFrom
            // 
            dtpStartDateFrom.Location = new Point(166, 35);
            dtpStartDateFrom.Name = "dtpStartDateFrom";
            dtpStartDateFrom.Size = new Size(202, 27);
            dtpStartDateFrom.TabIndex = 5;
            // 
            // dtpStartDateTo
            // 
            dtpStartDateTo.Location = new Point(428, 35);
            dtpStartDateTo.Name = "dtpStartDateTo";
            dtpStartDateTo.Size = new Size(202, 27);
            dtpStartDateTo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 40);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 6;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 142);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 8;
            label3.Text = "Price from";
            // 
            // dtpEndDateTo
            // 
            dtpEndDateTo.Location = new Point(428, 85);
            dtpEndDateTo.Name = "dtpEndDateTo";
            dtpEndDateTo.Size = new Size(202, 27);
            dtpEndDateTo.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(374, 90);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 11;
            label4.Text = "To";
            // 
            // dtpEndDateFrom
            // 
            dtpEndDateFrom.Location = new Point(166, 85);
            dtpEndDateFrom.Name = "dtpEndDateFrom";
            dtpEndDateFrom.Size = new Size(202, 27);
            dtpEndDateFrom.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 90);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 9;
            label5.Text = "End Date from";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(347, 142);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 14;
            label6.Text = "Price to";
            // 
            // txtbPriceTo
            // 
            txtbPriceTo.Location = new Point(430, 142);
            txtbPriceTo.Margin = new Padding(3, 4, 3, 4);
            txtbPriceTo.Name = "txtbPriceTo";
            txtbPriceTo.Size = new Size(200, 27);
            txtbPriceTo.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(661, 37);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 15;
            label7.Text = "filter by:";
            // 
            // rbPrice
            // 
            rbPrice.AutoSize = true;
            rbPrice.Checked = true;
            rbPrice.Location = new Point(661, 69);
            rbPrice.Name = "rbPrice";
            rbPrice.Size = new Size(62, 24);
            rbPrice.TabIndex = 16;
            rbPrice.TabStop = true;
            rbPrice.Text = "Price";
            rbPrice.UseVisualStyleBackColor = true;
            // 
            // rbEndDate
            // 
            rbEndDate.AutoSize = true;
            rbEndDate.Location = new Point(661, 129);
            rbEndDate.Name = "rbEndDate";
            rbEndDate.Size = new Size(87, 24);
            rbEndDate.TabIndex = 17;
            rbEndDate.Text = "EndDate";
            rbEndDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            rbStartDate.AutoSize = true;
            rbStartDate.Location = new Point(661, 99);
            rbStartDate.Name = "rbStartDate";
            rbStartDate.Size = new Size(93, 24);
            rbStartDate.TabIndex = 18;
            rbStartDate.Text = "StartDate";
            rbStartDate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(274, 184);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 19;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(25, 521);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(100, 31);
            btnPrint.TabIndex = 20;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // frmQuiries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(btnPrint);
            Controls.Add(btnClose);
            Controls.Add(rbStartDate);
            Controls.Add(rbEndDate);
            Controls.Add(rbPrice);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtbPriceTo);
            Controls.Add(dtpEndDateTo);
            Controls.Add(label4);
            Controls.Add(dtpEndDateFrom);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dtpStartDateTo);
            Controls.Add(label2);
            Controls.Add(dtpStartDateFrom);
            Controls.Add(label1);
            Controls.Add(btnApplyFilter);
            Controls.Add(txtbPriceFrom);
            Controls.Add(dgvResults);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmQuiries";
            Text = "Filter Queries";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtbPriceFrom;
        private Label label1;
        private DateTimePicker dtpStartDateFrom;
        private DateTimePicker dtpStartDateTo;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpEndDateTo;
        private Label label4;
        private DateTimePicker dtpEndDateFrom;
        private Label label5;
        private Label label6;
        private TextBox txtbPriceTo;
        private Label label7;
        private RadioButton rbPrice;
        private RadioButton rbEndDate;
        private RadioButton rbStartDate;
        private Button btnClose;
        private Button btnPrint;
    }
}
