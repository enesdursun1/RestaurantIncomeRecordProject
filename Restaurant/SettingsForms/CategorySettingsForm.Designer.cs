namespace Restaurant
{
    partial class CategorySettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorySettingsForm));
            flowLayoutPanelSettings = new FlowLayoutPanel();
            panel2 = new Panel();
            btnCategoryAdd = new Button();
            panel1 = new Panel();
            btnCategoryUpdate = new Button();
            panel7 = new Panel();
            btnCategoryDelete = new Button();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            btnMinimize = new Button();
            btnClose = new Button();
            label4 = new Label();
            CategorySettingsPage = new TabControl();
            UpdateCategoryPage = new TabPage();
            label1 = new Label();
            panel4 = new Panel();
            btnUpdateCategory = new Button();
            txtUpdateCategoryName = new TextBox();
            label7 = new Label();
            cmbUpdateCategories = new ComboBox();
            AddCategoryPage = new TabPage();
            label9 = new Label();
            panel5 = new Panel();
            btnAddCategory = new Button();
            txtAddCategoryName = new TextBox();
            DeleteCategoryPage = new TabPage();
            panel6 = new Panel();
            btnDeleteCategory = new Button();
            label5 = new Label();
            cmbDeleteCategories = new ComboBox();
            flowLayoutPanelSettings.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            CategorySettingsPage.SuspendLayout();
            UpdateCategoryPage.SuspendLayout();
            panel4.SuspendLayout();
            AddCategoryPage.SuspendLayout();
            panel5.SuspendLayout();
            DeleteCategoryPage.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelSettings
            // 
            flowLayoutPanelSettings.BackColor = Color.Black;
            flowLayoutPanelSettings.Controls.Add(panel2);
            flowLayoutPanelSettings.Controls.Add(panel1);
            flowLayoutPanelSettings.Controls.Add(panel7);
            flowLayoutPanelSettings.Location = new Point(0, 43);
            flowLayoutPanelSettings.Name = "flowLayoutPanelSettings";
            flowLayoutPanelSettings.Size = new Size(144, 297);
            flowLayoutPanelSettings.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCategoryAdd);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(141, 34);
            panel2.TabIndex = 4;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.BackColor = Color.Black;
            btnCategoryAdd.Cursor = Cursors.Hand;
            btnCategoryAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategoryAdd.ForeColor = Color.White;
            btnCategoryAdd.Location = new Point(-12, -11);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(162, 58);
            btnCategoryAdd.TabIndex = 3;
            btnCategoryAdd.Text = "  Kategori Ekle";
            btnCategoryAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnCategoryAdd.UseVisualStyleBackColor = false;
            btnCategoryAdd.Click += btnCategoryAdd_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCategoryUpdate);
            panel1.Location = new Point(3, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 34);
            panel1.TabIndex = 5;
            // 
            // btnCategoryUpdate
            // 
            btnCategoryUpdate.BackColor = Color.Black;
            btnCategoryUpdate.Cursor = Cursors.Hand;
            btnCategoryUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategoryUpdate.ForeColor = Color.White;
            btnCategoryUpdate.Location = new Point(-12, -11);
            btnCategoryUpdate.Name = "btnCategoryUpdate";
            btnCategoryUpdate.Size = new Size(162, 58);
            btnCategoryUpdate.TabIndex = 3;
            btnCategoryUpdate.Text = "  Kategori Güncelle";
            btnCategoryUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnCategoryUpdate.UseVisualStyleBackColor = false;
            btnCategoryUpdate.Click += btnCategoryUpdate_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnCategoryDelete);
            panel7.Location = new Point(3, 83);
            panel7.Name = "panel7";
            panel7.Size = new Size(141, 34);
            panel7.TabIndex = 20;
            // 
            // btnCategoryDelete
            // 
            btnCategoryDelete.BackColor = Color.Black;
            btnCategoryDelete.Cursor = Cursors.Hand;
            btnCategoryDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategoryDelete.ForeColor = Color.White;
            btnCategoryDelete.Location = new Point(-12, -11);
            btnCategoryDelete.Name = "btnCategoryDelete";
            btnCategoryDelete.Size = new Size(162, 58);
            btnCategoryDelete.TabIndex = 3;
            btnCategoryDelete.Text = "  Kategori Sil";
            btnCategoryDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnCategoryDelete.UseVisualStyleBackColor = false;
            btnCategoryDelete.Click += btnCategoryDelete_Click;
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
            panel3.TabIndex = 4;
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
            label4.Font = new Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(154, 2);
            label4.Name = "label4";
            label4.Size = new Size(274, 35);
            label4.TabIndex = 6;
            label4.Text = "KATEGORİ AYARLARI";
            // 
            // CategorySettingsPage
            // 
            CategorySettingsPage.Controls.Add(AddCategoryPage);
            CategorySettingsPage.Controls.Add(DeleteCategoryPage);
            CategorySettingsPage.Controls.Add(UpdateCategoryPage);
            CategorySettingsPage.Location = new Point(133, 12);
            CategorySettingsPage.Name = "CategorySettingsPage";
            CategorySettingsPage.SelectedIndex = 0;
            CategorySettingsPage.Size = new Size(412, 328);
            CategorySettingsPage.TabIndex = 5;
            // 
            // UpdateCategoryPage
            // 
            UpdateCategoryPage.Controls.Add(label1);
            UpdateCategoryPage.Controls.Add(panel4);
            UpdateCategoryPage.Controls.Add(txtUpdateCategoryName);
            UpdateCategoryPage.Controls.Add(label7);
            UpdateCategoryPage.Controls.Add(cmbUpdateCategories);
            UpdateCategoryPage.Location = new Point(4, 24);
            UpdateCategoryPage.Name = "UpdateCategoryPage";
            UpdateCategoryPage.Size = new Size(404, 300);
            UpdateCategoryPage.TabIndex = 1;
            UpdateCategoryPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 109);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 15;
            label1.Text = "Kategori Adı :";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnUpdateCategory);
            panel4.Location = new Point(147, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(176, 31);
            panel4.TabIndex = 14;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.BackColor = Color.Black;
            btnUpdateCategory.Cursor = Cursors.Hand;
            btnUpdateCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateCategory.ForeColor = Color.White;
            btnUpdateCategory.Location = new Point(-6, -15);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(191, 58);
            btnUpdateCategory.TabIndex = 8;
            btnUpdateCategory.Text = "Güncelle";
            btnUpdateCategory.UseVisualStyleBackColor = false;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // txtUpdateCategoryName
            // 
            txtUpdateCategoryName.Location = new Point(146, 106);
            txtUpdateCategoryName.Name = "txtUpdateCategoryName";
            txtUpdateCategoryName.Size = new Size(177, 23);
            txtUpdateCategoryName.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(76, 77);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 11;
            label7.Text = "Kategori :";
            // 
            // cmbUpdateCategories
            // 
            cmbUpdateCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateCategories.FormattingEnabled = true;
            cmbUpdateCategories.Location = new Point(146, 74);
            cmbUpdateCategories.Name = "cmbUpdateCategories";
            cmbUpdateCategories.Size = new Size(177, 23);
            cmbUpdateCategories.TabIndex = 10;
            cmbUpdateCategories.SelectedValueChanged += cmbUpdateCategories_SelectedValueChanged;
            // 
            // AddCategoryPage
            // 
            AddCategoryPage.Controls.Add(label9);
            AddCategoryPage.Controls.Add(panel5);
            AddCategoryPage.Controls.Add(txtAddCategoryName);
            AddCategoryPage.Location = new Point(4, 24);
            AddCategoryPage.Name = "AddCategoryPage";
            AddCategoryPage.Size = new Size(404, 300);
            AddCategoryPage.TabIndex = 0;
            AddCategoryPage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(40, 89);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 15;
            label9.Text = "Kategori Adı :";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnAddCategory);
            panel5.Location = new Point(129, 127);
            panel5.Name = "panel5";
            panel5.Size = new Size(176, 31);
            panel5.TabIndex = 14;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.Black;
            btnAddCategory.Cursor = Cursors.Hand;
            btnAddCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.Location = new Point(-6, -15);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(191, 58);
            btnAddCategory.TabIndex = 8;
            btnAddCategory.Text = "Ekle";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtAddCategoryName
            // 
            txtAddCategoryName.Location = new Point(128, 86);
            txtAddCategoryName.Name = "txtAddCategoryName";
            txtAddCategoryName.Size = new Size(177, 23);
            txtAddCategoryName.TabIndex = 12;
            // 
            // DeleteCategoryPage
            // 
            DeleteCategoryPage.Controls.Add(panel6);
            DeleteCategoryPage.Controls.Add(label5);
            DeleteCategoryPage.Controls.Add(cmbDeleteCategories);
            DeleteCategoryPage.Location = new Point(4, 24);
            DeleteCategoryPage.Name = "DeleteCategoryPage";
            DeleteCategoryPage.Size = new Size(404, 300);
            DeleteCategoryPage.TabIndex = 2;
            DeleteCategoryPage.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnDeleteCategory);
            panel6.Location = new Point(126, 139);
            panel6.Name = "panel6";
            panel6.Size = new Size(176, 31);
            panel6.TabIndex = 19;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.BackColor = Color.Black;
            btnDeleteCategory.Cursor = Cursors.Hand;
            btnDeleteCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteCategory.ForeColor = Color.White;
            btnDeleteCategory.Location = new Point(-6, -15);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(191, 58);
            btnDeleteCategory.TabIndex = 8;
            btnDeleteCategory.Text = "Sil";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(55, 93);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 17;
            label5.Text = "Kategori :";
            // 
            // cmbDeleteCategories
            // 
            cmbDeleteCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeleteCategories.FormattingEnabled = true;
            cmbDeleteCategories.Location = new Point(125, 90);
            cmbDeleteCategories.Name = "cmbDeleteCategories";
            cmbDeleteCategories.Size = new Size(177, 23);
            cmbDeleteCategories.TabIndex = 16;
            // 
            // CategorySettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 338);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanelSettings);
            Controls.Add(CategorySettingsPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategorySettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategorySettingsForm";
            Load += CategorySettingsForm_Load;
            flowLayoutPanelSettings.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            CategorySettingsPage.ResumeLayout(false);
            UpdateCategoryPage.ResumeLayout(false);
            UpdateCategoryPage.PerformLayout();
            panel4.ResumeLayout(false);
            AddCategoryPage.ResumeLayout(false);
            AddCategoryPage.PerformLayout();
            panel5.ResumeLayout(false);
            DeleteCategoryPage.ResumeLayout(false);
            DeleteCategoryPage.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelSettings;
        private Panel panel2;
        private Button btnCategoryAdd;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Button btnMinimize;
        private Button btnClose;
        private Panel panel1;
        private Button btnCategoryUpdate;
        private TabControl CategorySettingsPage;
        private TabPage AddCategoryPage;
        private TabPage UpdateCategoryPage;
        private Button btnCategoryDelete;
        private Label label9;
        private Panel panel5;
        private Button btnAddCategory;
        private TextBox txtAddCategoryName;
        private Label label1;
        private Panel panel4;
        private Button btnUpdateCategory;
        private TextBox txtUpdateCategoryName;
        private Label label7;
        private ComboBox cmbUpdateCategories;
        private TabPage DeleteCategoryPage;
        private Panel panel6;
        private Button btnDeleteCategory;
        private Label label5;
        private ComboBox cmbDeleteCategories;
        private Panel panel7;
    }
}