namespace Restaurant.SettingsForms
{
    partial class TableSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableSettingsForm));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            BtnMinimize = new Button();
            btnClose = new Button();
            flowLayoutPanelSettings = new FlowLayoutPanel();
            panel2 = new Panel();
            btnTableAdd = new Button();
            panel4 = new Panel();
            btnTableUpdate = new Button();
            panel7 = new Panel();
            btnTableDelete = new Button();
            TableSettingsPage = new TabControl();
            AddTablePage = new TabPage();
            label9 = new Label();
            panel5 = new Panel();
            btnAddTable = new Button();
            txtAddTableName = new TextBox();
            DeleteTablePage = new TabPage();
            panel6 = new Panel();
            btnDeleteTable = new Button();
            label5 = new Label();
            cmbDeleteTables = new ComboBox();
            UpdateTablePage = new TabPage();
            label3 = new Label();
            panel3 = new Panel();
            btnUpdateTable = new Button();
            txtUpdateTableName = new TextBox();
            label7 = new Label();
            cmbUpdateTables = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanelSettings.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            TableSettingsPage.SuspendLayout();
            AddTablePage.SuspendLayout();
            panel5.SuspendLayout();
            DeleteTablePage.SuspendLayout();
            panel6.SuspendLayout();
            UpdateTablePage.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BtnMinimize);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 43);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 10;
            label1.Text = "AYARLAR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 4);
            label2.Name = "label2";
            label2.Size = new Size(217, 35);
            label2.TabIndex = 6;
            label2.Text = "MASA AYARLARI";
            // 
            // BtnMinimize
            // 
            BtnMinimize.Cursor = Cursors.Hand;
            BtnMinimize.FlatStyle = FlatStyle.Popup;
            BtnMinimize.Image = (Image)resources.GetObject("BtnMinimize.Image");
            BtnMinimize.Location = new Point(434, 4);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new Size(52, 33);
            BtnMinimize.TabIndex = 8;
            BtnMinimize.UseVisualStyleBackColor = true;
            BtnMinimize.Click += BtnMinimize_Click;
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
            // flowLayoutPanelSettings
            // 
            flowLayoutPanelSettings.BackColor = Color.Black;
            flowLayoutPanelSettings.Controls.Add(panel2);
            flowLayoutPanelSettings.Controls.Add(panel4);
            flowLayoutPanelSettings.Controls.Add(panel7);
            flowLayoutPanelSettings.Dock = DockStyle.Left;
            flowLayoutPanelSettings.Location = new Point(0, 43);
            flowLayoutPanelSettings.Name = "flowLayoutPanelSettings";
            flowLayoutPanelSettings.Size = new Size(144, 295);
            flowLayoutPanelSettings.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTableAdd);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(141, 34);
            panel2.TabIndex = 4;
            // 
            // btnTableAdd
            // 
            btnTableAdd.BackColor = Color.Black;
            btnTableAdd.Cursor = Cursors.Hand;
            btnTableAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTableAdd.ForeColor = Color.White;
            btnTableAdd.Location = new Point(-12, -11);
            btnTableAdd.Name = "btnTableAdd";
            btnTableAdd.Size = new Size(162, 58);
            btnTableAdd.TabIndex = 3;
            btnTableAdd.Text = "  Masa Ekle";
            btnTableAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnTableAdd.UseVisualStyleBackColor = false;
            btnTableAdd.Click += btnTableAdd_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTableUpdate);
            panel4.Location = new Point(3, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(141, 34);
            panel4.TabIndex = 12;
            // 
            // btnTableUpdate
            // 
            btnTableUpdate.BackColor = Color.Black;
            btnTableUpdate.Cursor = Cursors.Hand;
            btnTableUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTableUpdate.ForeColor = Color.White;
            btnTableUpdate.Location = new Point(-12, -11);
            btnTableUpdate.Name = "btnTableUpdate";
            btnTableUpdate.Size = new Size(162, 58);
            btnTableUpdate.TabIndex = 3;
            btnTableUpdate.Text = "  Masa Güncelle";
            btnTableUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnTableUpdate.UseVisualStyleBackColor = false;
            btnTableUpdate.Click += btnTableUpdate_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnTableDelete);
            panel7.Location = new Point(3, 83);
            panel7.Name = "panel7";
            panel7.Size = new Size(141, 34);
            panel7.TabIndex = 38;
            // 
            // btnTableDelete
            // 
            btnTableDelete.BackColor = Color.Black;
            btnTableDelete.Cursor = Cursors.Hand;
            btnTableDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTableDelete.ForeColor = Color.White;
            btnTableDelete.Location = new Point(-12, -11);
            btnTableDelete.Name = "btnTableDelete";
            btnTableDelete.Size = new Size(162, 58);
            btnTableDelete.TabIndex = 3;
            btnTableDelete.Text = "  Masa Sil";
            btnTableDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnTableDelete.UseVisualStyleBackColor = false;
            btnTableDelete.Click += btnTableDelete_Click;
            // 
            // TableSettingsPage
            // 
            TableSettingsPage.Controls.Add(AddTablePage);
            TableSettingsPage.Controls.Add(DeleteTablePage);
            TableSettingsPage.Controls.Add(UpdateTablePage);
            TableSettingsPage.Location = new Point(140, 12);
            TableSettingsPage.Name = "TableSettingsPage";
            TableSettingsPage.SelectedIndex = 0;
            TableSettingsPage.Size = new Size(405, 326);
            TableSettingsPage.TabIndex = 6;
            // 
            // AddTablePage
            // 
            AddTablePage.Controls.Add(label9);
            AddTablePage.Controls.Add(panel5);
            AddTablePage.Controls.Add(txtAddTableName);
            AddTablePage.Location = new Point(4, 24);
            AddTablePage.Name = "AddTablePage";
            AddTablePage.Size = new Size(397, 268);
            AddTablePage.TabIndex = 0;
            AddTablePage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(52, 105);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 15;
            label9.Text = "Masa Adı :";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnAddTable);
            panel5.Location = new Point(121, 143);
            panel5.Name = "panel5";
            panel5.Size = new Size(176, 31);
            panel5.TabIndex = 14;
            // 
            // btnAddTable
            // 
            btnAddTable.BackColor = Color.Black;
            btnAddTable.Cursor = Cursors.Hand;
            btnAddTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddTable.ForeColor = Color.White;
            btnAddTable.Location = new Point(-6, -15);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(191, 58);
            btnAddTable.TabIndex = 8;
            btnAddTable.Text = "Ekle";
            btnAddTable.UseVisualStyleBackColor = false;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // txtAddTableName
            // 
            txtAddTableName.Location = new Point(120, 102);
            txtAddTableName.Name = "txtAddTableName";
            txtAddTableName.Size = new Size(177, 23);
            txtAddTableName.TabIndex = 12;
            // 
            // DeleteTablePage
            // 
            DeleteTablePage.Controls.Add(panel6);
            DeleteTablePage.Controls.Add(label5);
            DeleteTablePage.Controls.Add(cmbDeleteTables);
            DeleteTablePage.Location = new Point(4, 24);
            DeleteTablePage.Name = "DeleteTablePage";
            DeleteTablePage.Size = new Size(397, 268);
            DeleteTablePage.TabIndex = 2;
            DeleteTablePage.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnDeleteTable);
            panel6.Location = new Point(122, 151);
            panel6.Name = "panel6";
            panel6.Size = new Size(176, 31);
            panel6.TabIndex = 19;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.BackColor = Color.Black;
            btnDeleteTable.Cursor = Cursors.Hand;
            btnDeleteTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteTable.ForeColor = Color.White;
            btnDeleteTable.Location = new Point(-6, -15);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(191, 58);
            btnDeleteTable.TabIndex = 8;
            btnDeleteTable.Text = "Sil";
            btnDeleteTable.UseVisualStyleBackColor = false;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(74, 105);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 17;
            label5.Text = "Masa :";
            // 
            // cmbDeleteTables
            // 
            cmbDeleteTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeleteTables.FormattingEnabled = true;
            cmbDeleteTables.Location = new Point(121, 102);
            cmbDeleteTables.Name = "cmbDeleteTables";
            cmbDeleteTables.Size = new Size(177, 23);
            cmbDeleteTables.TabIndex = 16;
            // 
            // UpdateTablePage
            // 
            UpdateTablePage.Controls.Add(label3);
            UpdateTablePage.Controls.Add(panel3);
            UpdateTablePage.Controls.Add(txtUpdateTableName);
            UpdateTablePage.Controls.Add(label7);
            UpdateTablePage.Controls.Add(cmbUpdateTables);
            UpdateTablePage.Location = new Point(4, 24);
            UpdateTablePage.Name = "UpdateTablePage";
            UpdateTablePage.Size = new Size(397, 298);
            UpdateTablePage.TabIndex = 1;
            UpdateTablePage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 130);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 15;
            label3.Text = "Masa Adı :";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnUpdateTable);
            panel3.Location = new Point(125, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(176, 31);
            panel3.TabIndex = 14;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.BackColor = Color.Black;
            btnUpdateTable.Cursor = Cursors.Hand;
            btnUpdateTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateTable.ForeColor = Color.White;
            btnUpdateTable.Location = new Point(-6, -15);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(191, 58);
            btnUpdateTable.TabIndex = 8;
            btnUpdateTable.Text = "Güncelle";
            btnUpdateTable.UseVisualStyleBackColor = false;
            btnUpdateTable.Click += btnUpdateTable_Click;
            // 
            // txtUpdateTableName
            // 
            txtUpdateTableName.Location = new Point(124, 127);
            txtUpdateTableName.Name = "txtUpdateTableName";
            txtUpdateTableName.Size = new Size(177, 23);
            txtUpdateTableName.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(74, 98);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 11;
            label7.Text = "Masa :";
            // 
            // cmbUpdateTables
            // 
            cmbUpdateTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateTables.FormattingEnabled = true;
            cmbUpdateTables.Location = new Point(124, 95);
            cmbUpdateTables.Name = "cmbUpdateTables";
            cmbUpdateTables.Size = new Size(177, 23);
            cmbUpdateTables.TabIndex = 10;
            cmbUpdateTables.SelectedValueChanged += cmbUpdateTables_SelectedValueChanged;
            // 
            // TableSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 338);
            Controls.Add(flowLayoutPanelSettings);
            Controls.Add(panel1);
            Controls.Add(TableSettingsPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TableSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableSettingsForm";
            Load += TableSettingsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanelSettings.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            TableSettingsPage.ResumeLayout(false);
            AddTablePage.ResumeLayout(false);
            AddTablePage.PerformLayout();
            panel5.ResumeLayout(false);
            DeleteTablePage.ResumeLayout(false);
            DeleteTablePage.PerformLayout();
            panel6.ResumeLayout(false);
            UpdateTablePage.ResumeLayout(false);
            UpdateTablePage.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button BtnMinimize;
        private Button btnClose;
        private FlowLayoutPanel flowLayoutPanelSettings;
        private Panel panel2;
        private Button btnTableAdd;
        private Panel panel4;
        private Button btnTableUpdate;
        private Panel panel7;
        private Button btnTableDelete;
        private TabControl TableSettingsPage;
        private TabPage AddTablePage;
        private Label label9;
        private Panel panel5;
        private Button btnAddTable;
        private TextBox txtAddTableName;
        private TabPage DeleteTablePage;
        private Panel panel6;
        private Button btnDeleteTable;
        private Label label5;
        private ComboBox cmbDeleteTables;
        private TabPage UpdateTablePage;
        private Label label3;
        private Panel panel3;
        private Button btnUpdateTable;
        private TextBox txtUpdateTableName;
        private Label label7;
        private ComboBox cmbUpdateTables;
    }
}