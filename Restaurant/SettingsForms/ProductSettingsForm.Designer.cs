namespace Restaurant
{
    partial class ProductSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSettingsForm));
            btnClose = new Button();
            BtnMinimize = new Button();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanelSettings = new FlowLayoutPanel();
            panel2 = new Panel();
            btnProductAdd = new Button();
            panel4 = new Panel();
            btnProductUpdate = new Button();
            panel7 = new Panel();
            btnProductDelete = new Button();
            ProductSettingsPage = new TabControl();
            AddProductPage = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            btnAddProduct = new Button();
            txtAddProductPrice = new TextBox();
            txtAddProductName = new TextBox();
            cmbAddProductCategories = new ComboBox();
            UpdateProductPage = new TabPage();
            label8 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            btnUpdateProduct = new Button();
            txtUpdateProductPrice = new TextBox();
            txtUpdateProductName = new TextBox();
            label7 = new Label();
            cmbUpdateProductCategories = new ComboBox();
            label6 = new Label();
            cmbUpdateProducts = new ComboBox();
            DeleteProductPage = new TabPage();
            label10 = new Label();
            cmbDeleteProductCategories = new ComboBox();
            label12 = new Label();
            panel6 = new Panel();
            btnDeleteProduct = new Button();
            cmbDeleteProducts = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanelSettings.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ProductSettingsPage.SuspendLayout();
            AddProductPage.SuspendLayout();
            panel3.SuspendLayout();
            UpdateProductPage.SuspendLayout();
            panel5.SuspendLayout();
            DeleteProductPage.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 4);
            label2.Name = "label2";
            label2.Size = new Size(221, 35);
            label2.TabIndex = 6;
            label2.Text = "ÜRÜN AYARLARI";
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
            panel1.TabIndex = 0;
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
            flowLayoutPanelSettings.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProductAdd);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(141, 34);
            panel2.TabIndex = 4;
            // 
            // btnProductAdd
            // 
            btnProductAdd.BackColor = Color.Black;
            btnProductAdd.Cursor = Cursors.Hand;
            btnProductAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductAdd.ForeColor = Color.White;
            btnProductAdd.Location = new Point(-12, -11);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(162, 58);
            btnProductAdd.TabIndex = 3;
            btnProductAdd.Text = "  Ürün Ekle";
            btnProductAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnProductAdd.UseVisualStyleBackColor = false;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnProductUpdate);
            panel4.Location = new Point(3, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(141, 34);
            panel4.TabIndex = 12;
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.BackColor = Color.Black;
            btnProductUpdate.Cursor = Cursors.Hand;
            btnProductUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductUpdate.ForeColor = Color.White;
            btnProductUpdate.Location = new Point(-12, -11);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(162, 58);
            btnProductUpdate.TabIndex = 3;
            btnProductUpdate.Text = "  Ürün Güncelle";
            btnProductUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnProductUpdate.UseVisualStyleBackColor = false;
            btnProductUpdate.Click += btnProductUpdate_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnProductDelete);
            panel7.Location = new Point(3, 83);
            panel7.Name = "panel7";
            panel7.Size = new Size(141, 34);
            panel7.TabIndex = 38;
            // 
            // btnProductDelete
            // 
            btnProductDelete.BackColor = Color.Black;
            btnProductDelete.Cursor = Cursors.Hand;
            btnProductDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductDelete.ForeColor = Color.White;
            btnProductDelete.Location = new Point(-12, -11);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(162, 58);
            btnProductDelete.TabIndex = 3;
            btnProductDelete.Text = "  Ürün Sil";
            btnProductDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnProductDelete.UseVisualStyleBackColor = false;
            btnProductDelete.Click += btnProductDelete_Click;
            // 
            // ProductSettingsPage
            // 
            ProductSettingsPage.Controls.Add(AddProductPage);
            ProductSettingsPage.Controls.Add(UpdateProductPage);
            ProductSettingsPage.Controls.Add(DeleteProductPage);
            ProductSettingsPage.Location = new Point(139, 12);
            ProductSettingsPage.Name = "ProductSettingsPage";
            ProductSettingsPage.SelectedIndex = 0;
            ProductSettingsPage.Size = new Size(406, 326);
            ProductSettingsPage.TabIndex = 2;
            // 
            // AddProductPage
            // 
            AddProductPage.Controls.Add(label5);
            AddProductPage.Controls.Add(label4);
            AddProductPage.Controls.Add(label3);
            AddProductPage.Controls.Add(panel3);
            AddProductPage.Controls.Add(txtAddProductPrice);
            AddProductPage.Controls.Add(txtAddProductName);
            AddProductPage.Controls.Add(cmbAddProductCategories);
            AddProductPage.Location = new Point(4, 24);
            AddProductPage.Name = "AddProductPage";
            AddProductPage.Padding = new Padding(3);
            AddProductPage.Size = new Size(398, 298);
            AddProductPage.TabIndex = 0;
            AddProductPage.UseVisualStyleBackColor = true;
        
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(71, 153);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 32;
            label5.Text = "Fiyat : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(49, 112);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 31;
            label4.Text = "Ürün Adı : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 73);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 30;
            label3.Text = "Kategori : ";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAddProduct);
            panel3.Location = new Point(120, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 29);
            panel3.TabIndex = 29;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Black;
            btnAddProduct.Cursor = Cursors.Hand;
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(-24, -12);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(231, 53);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Ekle";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtAddProductPrice
            // 
            txtAddProductPrice.Location = new Point(120, 153);
            txtAddProductPrice.Name = "txtAddProductPrice";
            txtAddProductPrice.Size = new Size(185, 23);
            txtAddProductPrice.TabIndex = 28;
            // 
            // txtAddProductName
            // 
            txtAddProductName.Location = new Point(120, 112);
            txtAddProductName.Name = "txtAddProductName";
            txtAddProductName.Size = new Size(185, 23);
            txtAddProductName.TabIndex = 27;
            // 
            // cmbAddProductCategories
            // 
            cmbAddProductCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddProductCategories.FormattingEnabled = true;
            cmbAddProductCategories.Location = new Point(120, 70);
            cmbAddProductCategories.Name = "cmbAddProductCategories";
            cmbAddProductCategories.Size = new Size(185, 23);
            cmbAddProductCategories.TabIndex = 26;
            // 
            // UpdateProductPage
            // 
            UpdateProductPage.Controls.Add(label8);
            UpdateProductPage.Controls.Add(label9);
            UpdateProductPage.Controls.Add(panel5);
            UpdateProductPage.Controls.Add(txtUpdateProductPrice);
            UpdateProductPage.Controls.Add(txtUpdateProductName);
            UpdateProductPage.Controls.Add(label7);
            UpdateProductPage.Controls.Add(cmbUpdateProductCategories);
            UpdateProductPage.Controls.Add(label6);
            UpdateProductPage.Controls.Add(cmbUpdateProducts);
            UpdateProductPage.Location = new Point(4, 24);
            UpdateProductPage.Name = "UpdateProductPage";
            UpdateProductPage.Padding = new Padding(3);
            UpdateProductPage.Size = new Size(398, 298);
            UpdateProductPage.TabIndex = 1;
            UpdateProductPage.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(68, 176);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 27;
            label8.Text = "Fiyat :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(46, 138);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 26;
            label9.Text = "Ürün Adı :";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnUpdateProduct);
            panel5.Location = new Point(117, 212);
            panel5.Name = "panel5";
            panel5.Size = new Size(176, 31);
            panel5.TabIndex = 25;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.Black;
            btnUpdateProduct.Cursor = Cursors.Hand;
            btnUpdateProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateProduct.ForeColor = Color.White;
            btnUpdateProduct.Location = new Point(-6, -15);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(191, 58);
            btnUpdateProduct.TabIndex = 8;
            btnUpdateProduct.Text = "Güncelle";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // txtUpdateProductPrice
            // 
            txtUpdateProductPrice.Location = new Point(116, 173);
            txtUpdateProductPrice.Name = "txtUpdateProductPrice";
            txtUpdateProductPrice.Size = new Size(177, 23);
            txtUpdateProductPrice.TabIndex = 24;
            // 
            // txtUpdateProductName
            // 
            txtUpdateProductName.Location = new Point(116, 135);
            txtUpdateProductName.Name = "txtUpdateProductName";
            txtUpdateProductName.Size = new Size(177, 23);
            txtUpdateProductName.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(46, 98);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 22;
            label7.Text = "Kategori :";
            // 
            // cmbUpdateProductCategories
            // 
            cmbUpdateProductCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateProductCategories.FormattingEnabled = true;
            cmbUpdateProductCategories.Location = new Point(116, 95);
            cmbUpdateProductCategories.Name = "cmbUpdateProductCategories";
            cmbUpdateProductCategories.Size = new Size(177, 23);
            cmbUpdateProductCategories.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(66, 63);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 20;
            label6.Text = "Ürün :";
            // 
            // cmbUpdateProducts
            // 
            cmbUpdateProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateProducts.FormattingEnabled = true;
            cmbUpdateProducts.Location = new Point(116, 60);
            cmbUpdateProducts.Name = "cmbUpdateProducts";
            cmbUpdateProducts.Size = new Size(177, 23);
            cmbUpdateProducts.TabIndex = 19;
            cmbUpdateProducts.SelectedValueChanged += cmbUpdateProducts_SelectedValueChanged;
            // 
            // DeleteProductPage
            // 
            DeleteProductPage.Controls.Add(label10);
            DeleteProductPage.Controls.Add(cmbDeleteProductCategories);
            DeleteProductPage.Controls.Add(label12);
            DeleteProductPage.Controls.Add(panel6);
            DeleteProductPage.Controls.Add(cmbDeleteProducts);
            DeleteProductPage.Location = new Point(4, 24);
            DeleteProductPage.Name = "DeleteProductPage";
            DeleteProductPage.Size = new Size(398, 298);
            DeleteProductPage.TabIndex = 2;
            DeleteProductPage.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(41, 97);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 39;
            label10.Text = "Kategori :";
            // 
            // cmbDeleteProductCategories
            // 
            cmbDeleteProductCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeleteProductCategories.FormattingEnabled = true;
            cmbDeleteProductCategories.Location = new Point(111, 94);
            cmbDeleteProductCategories.Name = "cmbDeleteProductCategories";
            cmbDeleteProductCategories.Size = new Size(185, 23);
            cmbDeleteProductCategories.TabIndex = 38;
            cmbDeleteProductCategories.SelectedValueChanged += cmbDeleteProductCategories_SelectedValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(61, 137);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 37;
            label12.Text = "Ürün : ";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnDeleteProduct);
            panel6.Location = new Point(111, 178);
            panel6.Name = "panel6";
            panel6.Size = new Size(185, 29);
            panel6.TabIndex = 36;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.Black;
            btnDeleteProduct.Cursor = Cursors.Hand;
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(-24, -12);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(231, 53);
            btnDeleteProduct.TabIndex = 6;
            btnDeleteProduct.Text = "Sil";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // cmbDeleteProducts
            // 
            cmbDeleteProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeleteProducts.FormattingEnabled = true;
            cmbDeleteProducts.Location = new Point(111, 134);
            cmbDeleteProducts.Name = "cmbDeleteProducts";
            cmbDeleteProducts.Size = new Size(185, 23);
            cmbDeleteProducts.TabIndex = 33;
            // 
            // ProductSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 338);
            Controls.Add(flowLayoutPanelSettings);
            Controls.Add(panel1);
            Controls.Add(ProductSettingsPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekle";
            Load += ProductSettingsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanelSettings.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ProductSettingsPage.ResumeLayout(false);
            AddProductPage.ResumeLayout(false);
            AddProductPage.PerformLayout();
            panel3.ResumeLayout(false);
            UpdateProductPage.ResumeLayout(false);
            UpdateProductPage.PerformLayout();
            panel5.ResumeLayout(false);
            DeleteProductPage.ResumeLayout(false);
            DeleteProductPage.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private Button BtnMinimize;
        private Label label2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanelSettings;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnProductAdd;
        private Panel panel2;
        private Panel panel4;
        private Button btnProductUpdate;
        private TabControl ProductSettingsPage;
        private TabPage AddProductPage;
        private TabPage UpdateProductPage;
        private TabPage DeleteProductPage;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Button btnAddProduct;
        private TextBox txtAddProductPrice;
        private TextBox txtAddProductName;
        private ComboBox cmbAddProductCategories;
        private Label label8;
        private Label label9;
        private Panel panel5;
        private Button btnUpdateProduct;
        private TextBox txtUpdateProductPrice;
        private TextBox txtUpdateProductName;
        private Label label7;
        private ComboBox cmbUpdateProductCategories;
        private Label label6;
        private ComboBox cmbUpdateProducts;
        private Panel panel7;
        private Button btnProductDelete;
        private Label label12;
        private Panel panel6;
        private Button btnDeleteProduct;
        private ComboBox cmbDeleteProducts;
        private Label label10;
        private ComboBox cmbDeleteProductCategories;
    }
}