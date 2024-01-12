namespace Restaurant
{
    partial class IncomeRecordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeRecordsForm));
            panel3 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            btnMinimize = new Button();
            btnClose = new Button();
            label4 = new Label();
            flowLayoutPanelRecords = new FlowLayoutPanel();
            panel2 = new Panel();
            btnDailyIncomeRecord = new Button();
            panel1 = new Panel();
            btnMonthlyIncomeRecord = new Button();
            panel6 = new Panel();
            btnDailyIncomeRecordControl = new Button();
            IncomeRecordsPage = new TabControl();
            DailyIncomeRecordPage = new TabPage();
            panel5 = new Panel();
            btnSaveDailyIncomeRecord = new Button();
            MonthlyIncomeRecordPage = new TabPage();
            panel4 = new Panel();
            btnSaveMonthlyIncomeRecord = new Button();
            DailyIncomeRecordControlPage = new TabPage();
            checkBoxFilterByDate = new CheckBox();
            dtgDailyIncomeRecordControl = new DataGridView();
            dateTimePickerIncomeRecords = new DateTimePicker();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanelRecords.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            IncomeRecordsPage.SuspendLayout();
            DailyIncomeRecordPage.SuspendLayout();
            panel5.SuspendLayout();
            MonthlyIncomeRecordPage.SuspendLayout();
            panel4.SuspendLayout();
            DailyIncomeRecordControlPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDailyIncomeRecordControl).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btnMinimize);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(545, 43);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 12);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 10;
            label3.Text = "AYARLAR";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatStyle = FlatStyle.Popup;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(434, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(52, 33);
            btnMinimize.TabIndex = 8;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(483, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(52, 33);
            btnClose.TabIndex = 7;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(148, 4);
            label4.Name = "label4";
            label4.Size = new Size(280, 34);
            label4.TabIndex = 6;
            label4.Text = "GÜNLÜK-AYLIK RAPOR";
            // 
            // flowLayoutPanelRecords
            // 
            flowLayoutPanelRecords.BackColor = Color.Black;
            flowLayoutPanelRecords.Controls.Add(panel2);
            flowLayoutPanelRecords.Controls.Add(panel1);
            flowLayoutPanelRecords.Controls.Add(panel6);
            flowLayoutPanelRecords.Location = new Point(0, 43);
            flowLayoutPanelRecords.Name = "flowLayoutPanelRecords";
            flowLayoutPanelRecords.Size = new Size(144, 297);
            flowLayoutPanelRecords.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDailyIncomeRecord);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(141, 34);
            panel2.TabIndex = 4;
            // 
            // btnDailyIncomeRecord
            // 
            btnDailyIncomeRecord.BackColor = Color.Black;
            btnDailyIncomeRecord.Cursor = Cursors.Hand;
            btnDailyIncomeRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDailyIncomeRecord.ForeColor = Color.White;
            btnDailyIncomeRecord.Location = new Point(-12, -11);
            btnDailyIncomeRecord.Name = "btnDailyIncomeRecord";
            btnDailyIncomeRecord.Size = new Size(162, 58);
            btnDailyIncomeRecord.TabIndex = 3;
            btnDailyIncomeRecord.Text = "  Günlük Rapor";
            btnDailyIncomeRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnDailyIncomeRecord.UseVisualStyleBackColor = false;
            btnDailyIncomeRecord.Click += btnDailyIncomeRecord_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMonthlyIncomeRecord);
            panel1.Location = new Point(3, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 34);
            panel1.TabIndex = 5;
            // 
            // btnMonthlyIncomeRecord
            // 
            btnMonthlyIncomeRecord.BackColor = Color.Black;
            btnMonthlyIncomeRecord.Cursor = Cursors.Hand;
            btnMonthlyIncomeRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMonthlyIncomeRecord.ForeColor = Color.White;
            btnMonthlyIncomeRecord.Location = new Point(-12, -11);
            btnMonthlyIncomeRecord.Name = "btnMonthlyIncomeRecord";
            btnMonthlyIncomeRecord.Size = new Size(162, 58);
            btnMonthlyIncomeRecord.TabIndex = 3;
            btnMonthlyIncomeRecord.Text = "  Aylık Rapor";
            btnMonthlyIncomeRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnMonthlyIncomeRecord.UseVisualStyleBackColor = false;
            btnMonthlyIncomeRecord.Click += btnMonthlyIncomeRecord_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnDailyIncomeRecordControl);
            panel6.Location = new Point(3, 83);
            panel6.Name = "panel6";
            panel6.Size = new Size(141, 34);
            panel6.TabIndex = 6;
            // 
            // btnDailyIncomeRecordControl
            // 
            btnDailyIncomeRecordControl.BackColor = Color.Black;
            btnDailyIncomeRecordControl.Cursor = Cursors.Hand;
            btnDailyIncomeRecordControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDailyIncomeRecordControl.ForeColor = Color.White;
            btnDailyIncomeRecordControl.ImageAlign = ContentAlignment.BottomCenter;
            btnDailyIncomeRecordControl.Location = new Point(-12, -11);
            btnDailyIncomeRecordControl.Name = "btnDailyIncomeRecordControl";
            btnDailyIncomeRecordControl.Size = new Size(162, 58);
            btnDailyIncomeRecordControl.TabIndex = 3;
            btnDailyIncomeRecordControl.Text = "  Rapor Kontrol";
            btnDailyIncomeRecordControl.TextAlign = ContentAlignment.MiddleLeft;
            btnDailyIncomeRecordControl.UseVisualStyleBackColor = false;
            btnDailyIncomeRecordControl.Click += btnDailyIncomeRecordControl_Click;
            // 
            // IncomeRecordsPage
            // 
            IncomeRecordsPage.Controls.Add(DailyIncomeRecordPage);
            IncomeRecordsPage.Controls.Add(MonthlyIncomeRecordPage);
            IncomeRecordsPage.Controls.Add(DailyIncomeRecordControlPage);
            IncomeRecordsPage.Location = new Point(141, 12);
            IncomeRecordsPage.Name = "IncomeRecordsPage";
            IncomeRecordsPage.SelectedIndex = 0;
            IncomeRecordsPage.Size = new Size(404, 328);
            IncomeRecordsPage.TabIndex = 7;
            // 
            // DailyIncomeRecordPage
            // 
            DailyIncomeRecordPage.Controls.Add(panel5);
            DailyIncomeRecordPage.Location = new Point(4, 24);
            DailyIncomeRecordPage.Name = "DailyIncomeRecordPage";
            DailyIncomeRecordPage.Padding = new Padding(3);
            DailyIncomeRecordPage.Size = new Size(396, 300);
            DailyIncomeRecordPage.TabIndex = 0;
            DailyIncomeRecordPage.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSaveDailyIncomeRecord);
            panel5.Location = new Point(81, 117);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 34);
            panel5.TabIndex = 7;
            // 
            // btnSaveDailyIncomeRecord
            // 
            btnSaveDailyIncomeRecord.BackColor = Color.Black;
            btnSaveDailyIncomeRecord.Cursor = Cursors.Hand;
            btnSaveDailyIncomeRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveDailyIncomeRecord.ForeColor = Color.White;
            btnSaveDailyIncomeRecord.Location = new Point(-12, -15);
            btnSaveDailyIncomeRecord.Name = "btnSaveDailyIncomeRecord";
            btnSaveDailyIncomeRecord.Size = new Size(257, 62);
            btnSaveDailyIncomeRecord.TabIndex = 3;
            btnSaveDailyIncomeRecord.Text = "Günlük Rapor Çıkart";
            btnSaveDailyIncomeRecord.UseVisualStyleBackColor = false;
            btnSaveDailyIncomeRecord.Click += btnSaveDailyIncomeRecord_Click;
            // 
            // MonthlyIncomeRecordPage
            // 
            MonthlyIncomeRecordPage.Controls.Add(panel4);
            MonthlyIncomeRecordPage.Location = new Point(4, 24);
            MonthlyIncomeRecordPage.Name = "MonthlyIncomeRecordPage";
            MonthlyIncomeRecordPage.Padding = new Padding(3);
            MonthlyIncomeRecordPage.Size = new Size(396, 300);
            MonthlyIncomeRecordPage.TabIndex = 1;
            MonthlyIncomeRecordPage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSaveMonthlyIncomeRecord);
            panel4.Location = new Point(81, 117);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 34);
            panel4.TabIndex = 8;
            // 
            // btnSaveMonthlyIncomeRecord
            // 
            btnSaveMonthlyIncomeRecord.BackColor = Color.Black;
            btnSaveMonthlyIncomeRecord.Cursor = Cursors.Hand;
            btnSaveMonthlyIncomeRecord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveMonthlyIncomeRecord.ForeColor = Color.White;
            btnSaveMonthlyIncomeRecord.Location = new Point(-12, -15);
            btnSaveMonthlyIncomeRecord.Name = "btnSaveMonthlyIncomeRecord";
            btnSaveMonthlyIncomeRecord.Size = new Size(257, 62);
            btnSaveMonthlyIncomeRecord.TabIndex = 3;
            btnSaveMonthlyIncomeRecord.Text = "Aylık Rapor Çıkart";
            btnSaveMonthlyIncomeRecord.UseVisualStyleBackColor = false;
            btnSaveMonthlyIncomeRecord.Click += btnSaveMonthlyIncomeRecord_Click;
            // 
            // DailyIncomeRecordControlPage
            // 
            DailyIncomeRecordControlPage.Controls.Add(checkBoxFilterByDate);
            DailyIncomeRecordControlPage.Controls.Add(dtgDailyIncomeRecordControl);
            DailyIncomeRecordControlPage.Controls.Add(dateTimePickerIncomeRecords);
            DailyIncomeRecordControlPage.Location = new Point(4, 24);
            DailyIncomeRecordControlPage.Name = "DailyIncomeRecordControlPage";
            DailyIncomeRecordControlPage.Size = new Size(396, 300);
            DailyIncomeRecordControlPage.TabIndex = 2;
            DailyIncomeRecordControlPage.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilterByDate
            // 
            checkBoxFilterByDate.AutoSize = true;
            checkBoxFilterByDate.Location = new Point(3, 50);
            checkBoxFilterByDate.Name = "checkBoxFilterByDate";
            checkBoxFilterByDate.Size = new Size(123, 19);
            checkBoxFilterByDate.TabIndex = 3;
            checkBoxFilterByDate.Text = "Tarihe Göre Filtrele";
            checkBoxFilterByDate.UseVisualStyleBackColor = true;
            checkBoxFilterByDate.CheckedChanged += checkBoxFilterByDate_CheckedChanged;
            // 
            // dtgDailyIncomeRecordControl
            // 
            dtgDailyIncomeRecordControl.AllowUserToAddRows = false;
            dtgDailyIncomeRecordControl.AllowUserToDeleteRows = false;
            dtgDailyIncomeRecordControl.AllowUserToResizeColumns = false;
            dtgDailyIncomeRecordControl.AllowUserToResizeRows = false;
            dtgDailyIncomeRecordControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDailyIncomeRecordControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDailyIncomeRecordControl.Cursor = Cursors.PanWest;
            dtgDailyIncomeRecordControl.Location = new Point(5, 90);
            dtgDailyIncomeRecordControl.MultiSelect = false;
            dtgDailyIncomeRecordControl.Name = "dtgDailyIncomeRecordControl";
            dtgDailyIncomeRecordControl.ReadOnly = true;
            dtgDailyIncomeRecordControl.RowHeadersVisible = false;
            dtgDailyIncomeRecordControl.RowTemplate.Height = 25;
            dtgDailyIncomeRecordControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDailyIncomeRecordControl.Size = new Size(385, 207);
            dtgDailyIncomeRecordControl.TabIndex = 2;
            // 
            // dateTimePickerIncomeRecords
            // 
            dateTimePickerIncomeRecords.Enabled = false;
            dateTimePickerIncomeRecords.Format = DateTimePickerFormat.Short;
            dateTimePickerIncomeRecords.Location = new Point(3, 21);
            dateTimePickerIncomeRecords.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dateTimePickerIncomeRecords.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePickerIncomeRecords.Name = "dateTimePickerIncomeRecords";
            dateTimePickerIncomeRecords.Size = new Size(211, 23);
            dateTimePickerIncomeRecords.TabIndex = 1;
            dateTimePickerIncomeRecords.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePickerIncomeRecords.ValueChanged += dateTimePickerIncomeRecords_ValueChanged;
            // 
            // IncomeRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 338);
            Controls.Add(flowLayoutPanelRecords);
            Controls.Add(panel3);
            Controls.Add(IncomeRecordsPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IncomeRecordsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IncomeRecordsForm";
            Load += IncomeRecordsForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanelRecords.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            IncomeRecordsPage.ResumeLayout(false);
            DailyIncomeRecordPage.ResumeLayout(false);
            panel5.ResumeLayout(false);
            MonthlyIncomeRecordPage.ResumeLayout(false);
            panel4.ResumeLayout(false);
            DailyIncomeRecordControlPage.ResumeLayout(false);
            DailyIncomeRecordControlPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDailyIncomeRecordControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnMinimize;
        private Button btnClose;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanelRecords;
        private Panel panel2;
        private Button btnDailyIncomeRecord;
        private Panel panel1;
        private Button btnMonthlyIncomeRecord;
        private TabControl IncomeRecordsPage;
        private TabPage DailyIncomeRecordPage;
        private Panel panel5;
        private Button btnSaveDailyIncomeRecord;
        private TabPage MonthlyIncomeRecordPage;
        private Panel panel4;
        private Button btnSaveMonthlyIncomeRecord;
        private Panel panel6;
        private Button btnDailyIncomeRecordControl;
        private TabPage DailyIncomeRecordControlPage;
        private DateTimePicker dateTimePickerIncomeRecords;
        private DataGridView dtgDailyIncomeRecordControl;
        private CheckBox checkBoxFilterByDate;
    }
}