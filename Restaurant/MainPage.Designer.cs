using Business.Concrete;

namespace Restaurant
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            flowLayoutPanelMenu = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnTables = new Button();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            btnProducts = new Button();
            panel10 = new Panel();
            pictureBox5 = new PictureBox();
            btnIncomeRecords = new Button();
            panel8 = new Panel();
            pictureBox4 = new PictureBox();
            btnSettings = new Button();
            panel9 = new Panel();
            btnTableSettings = new Button();
            panel7 = new Panel();
            btnCategorySettings = new Button();
            panel6 = new Panel();
            btnProductSettings = new Button();
            panel2 = new Panel();
            labelSelectedTableName = new Label();
            labelSelectedTable = new Label();
            BtnMinimize = new Button();
            btnClose = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanelTables = new FlowLayoutPanel();
            dataGridViewOrders = new DataGridView();
            btnDeleteOrder = new Button();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            btnPay = new Button();
            txtTotalPrice = new TextBox();
            flowLayoutPanelPay = new FlowLayoutPanel();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            txtQuantity = new TextBox();
            flowLayoutPanelAddOrder = new FlowLayoutPanel();
            flowLayoutPanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanelPay.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanelAddOrder.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelMenu
            // 
            flowLayoutPanelMenu.BackColor = Color.Black;
            flowLayoutPanelMenu.Controls.Add(panel1);
            flowLayoutPanelMenu.Controls.Add(panel4);
            flowLayoutPanelMenu.Controls.Add(panel10);
            flowLayoutPanelMenu.Controls.Add(panel8);
            flowLayoutPanelMenu.Controls.Add(panel9);
            flowLayoutPanelMenu.Controls.Add(panel7);
            flowLayoutPanelMenu.Controls.Add(panel6);
            flowLayoutPanelMenu.Location = new Point(0, 37);
            flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            flowLayoutPanelMenu.Size = new Size(148, 546);
            flowLayoutPanelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnTables);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 33);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(111, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // btnTables
            // 
            btnTables.BackColor = Color.Black;
            btnTables.Cursor = Cursors.Hand;
            btnTables.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTables.ForeColor = Color.White;
            btnTables.ImageAlign = ContentAlignment.MiddleLeft;
            btnTables.Location = new Point(-21, -12);
            btnTables.Name = "btnTables";
            btnTables.Size = new Size(183, 59);
            btnTables.TabIndex = 2;
            btnTables.Text = "    Masalar";
            btnTables.TextAlign = ContentAlignment.MiddleLeft;
            btnTables.UseVisualStyleBackColor = false;
            btnTables.Click += btnTables_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(btnProducts);
            panel4.Location = new Point(3, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(144, 33);
            panel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(111, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.Black;
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(-22, -14);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(182, 59);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "    Ürünler";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(pictureBox5);
            panel10.Controls.Add(btnIncomeRecords);
            panel10.Location = new Point(3, 81);
            panel10.Name = "panel10";
            panel10.Size = new Size(144, 33);
            panel10.TabIndex = 17;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(111, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // btnIncomeRecords
            // 
            btnIncomeRecords.BackColor = Color.Black;
            btnIncomeRecords.Cursor = Cursors.Hand;
            btnIncomeRecords.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIncomeRecords.ForeColor = Color.White;
            btnIncomeRecords.Location = new Point(-22, -14);
            btnIncomeRecords.Name = "btnIncomeRecords";
            btnIncomeRecords.Size = new Size(182, 59);
            btnIncomeRecords.TabIndex = 2;
            btnIncomeRecords.Text = "    Raporlar";
            btnIncomeRecords.TextAlign = ContentAlignment.MiddleLeft;
            btnIncomeRecords.UseVisualStyleBackColor = false;
            btnIncomeRecords.Click += btnIncomeRecords_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox4);
            panel8.Controls.Add(btnSettings);
            panel8.Location = new Point(3, 120);
            panel8.Name = "panel8";
            panel8.Size = new Size(144, 33);
            panel8.TabIndex = 15;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(111, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Black;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(-22, -13);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(182, 59);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "    Ayarlar";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnTableSettings);
            panel9.Location = new Point(3, 159);
            panel9.Name = "panel9";
            panel9.Size = new Size(144, 33);
            panel9.TabIndex = 16;
            // 
            // btnTableSettings
            // 
            btnTableSettings.BackColor = Color.Black;
            btnTableSettings.Cursor = Cursors.Hand;
            btnTableSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTableSettings.ForeColor = Color.White;
            btnTableSettings.Location = new Point(-22, -14);
            btnTableSettings.Name = "btnTableSettings";
            btnTableSettings.Size = new Size(182, 59);
            btnTableSettings.TabIndex = 2;
            btnTableSettings.Text = "    Masa Ayarları";
            btnTableSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnTableSettings.UseVisualStyleBackColor = false;
            btnTableSettings.Visible = false;
            btnTableSettings.Click += btnTableSettings_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnCategorySettings);
            panel7.Location = new Point(3, 198);
            panel7.Name = "panel7";
            panel7.Size = new Size(144, 33);
            panel7.TabIndex = 14;
            // 
            // btnCategorySettings
            // 
            btnCategorySettings.BackColor = Color.Black;
            btnCategorySettings.Cursor = Cursors.Hand;
            btnCategorySettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategorySettings.ForeColor = Color.White;
            btnCategorySettings.Location = new Point(-22, -14);
            btnCategorySettings.Name = "btnCategorySettings";
            btnCategorySettings.Size = new Size(182, 59);
            btnCategorySettings.TabIndex = 2;
            btnCategorySettings.Text = "    Kategori Ayarları";
            btnCategorySettings.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorySettings.UseVisualStyleBackColor = false;
            btnCategorySettings.Visible = false;
            btnCategorySettings.Click += btnCategorySettings_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnProductSettings);
            panel6.Location = new Point(3, 237);
            panel6.Name = "panel6";
            panel6.Size = new Size(144, 33);
            panel6.TabIndex = 13;
            // 
            // btnProductSettings
            // 
            btnProductSettings.BackColor = Color.Black;
            btnProductSettings.Cursor = Cursors.Hand;
            btnProductSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductSettings.ForeColor = Color.White;
            btnProductSettings.Location = new Point(-22, -13);
            btnProductSettings.Name = "btnProductSettings";
            btnProductSettings.Size = new Size(182, 59);
            btnProductSettings.TabIndex = 2;
            btnProductSettings.Text = "    Ürün Ayarları";
            btnProductSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnProductSettings.UseVisualStyleBackColor = false;
            btnProductSettings.Visible = false;
            btnProductSettings.Click += btnProductSettings_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(labelSelectedTableName);
            panel2.Controls.Add(labelSelectedTable);
            panel2.Controls.Add(BtnMinimize);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1112, 40);
            panel2.TabIndex = 3;
            // 
            // labelSelectedTableName
            // 
            labelSelectedTableName.AutoSize = true;
            labelSelectedTableName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelSelectedTableName.Location = new Point(239, 15);
            labelSelectedTableName.Name = "labelSelectedTableName";
            labelSelectedTableName.Size = new Size(0, 19);
            labelSelectedTableName.TabIndex = 8;
            labelSelectedTableName.Visible = false;
            // 
            // labelSelectedTable
            // 
            labelSelectedTable.AutoSize = true;
            labelSelectedTable.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelSelectedTable.Location = new Point(153, 15);
            labelSelectedTable.Name = "labelSelectedTable";
            labelSelectedTable.Size = new Size(91, 19);
            labelSelectedTable.TabIndex = 7;
            labelSelectedTable.Text = "Seçili Masa: ";
            labelSelectedTable.Visible = false;
            // 
            // BtnMinimize
            // 
            BtnMinimize.Cursor = Cursors.Hand;
            BtnMinimize.FlatStyle = FlatStyle.Popup;
            BtnMinimize.Image = (Image)resources.GetObject("BtnMinimize.Image");
            BtnMinimize.Location = new Point(991, 3);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new Size(52, 33);
            BtnMinimize.TabIndex = 5;
            BtnMinimize.UseVisualStyleBackColor = true;
            BtnMinimize.Click += BtnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1040, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(52, 33);
            btnClose.TabIndex = 6;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "MENÜ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(503, 2);
            label1.Name = "label1";
            label1.Size = new Size(214, 35);
            label1.TabIndex = 5;
            label1.Text = "RESTORAN İSMİ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelTables
            // 
            flowLayoutPanelTables.Location = new Point(154, 40);
            flowLayoutPanelTables.Name = "flowLayoutPanelTables";
            flowLayoutPanelTables.Size = new Size(171, 428);
            flowLayoutPanelTables.TabIndex = 4;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.AllowUserToResizeColumns = false;
            dataGridViewOrders.AllowUserToResizeRows = false;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Cursor = Cursors.PanWest;
            dataGridViewOrders.Location = new Point(331, 40);
            dataGridViewOrders.MultiSelect = false;
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewOrders.RowTemplate.Height = 25;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(764, 489);
            dataGridViewOrders.TabIndex = 5;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.BackColor = Color.Black;
            btnDeleteOrder.Cursor = Cursors.Hand;
            btnDeleteOrder.ForeColor = Color.White;
            btnDeleteOrder.Location = new Point(-19, -6);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(190, 50);
            btnDeleteOrder.TabIndex = 6;
            btnDeleteOrder.Text = "Sil";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDeleteOrder);
            panel3.Location = new Point(938, 535);
            panel3.Name = "panel3";
            panel3.Size = new Size(157, 35);
            panel3.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(txtTotalPrice);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 94);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Toplam Fiyat";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnPay);
            panel5.Location = new Point(6, 58);
            panel5.Name = "panel5";
            panel5.Size = new Size(147, 29);
            panel5.TabIndex = 10;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Black;
            btnPay.Cursor = Cursors.Hand;
            btnPay.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(-17, -16);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(173, 60);
            btnPay.TabIndex = 9;
            btnPay.Text = "  Hesabı Öde";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(6, 22);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(147, 23);
            txtTotalPrice.TabIndex = 0;
            // 
            // flowLayoutPanelPay
            // 
            flowLayoutPanelPay.Controls.Add(groupBox1);
            flowLayoutPanelPay.Location = new Point(154, 474);
            flowLayoutPanelPay.Name = "flowLayoutPanelPay";
            flowLayoutPanelPay.Size = new Size(171, 106);
            flowLayoutPanelPay.TabIndex = 9;
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.Location = new Point(153, 40);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(172, 431);
            flowLayoutPanelProducts.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(172, 106);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün Adedi";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(6, 39);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(147, 23);
            txtQuantity.TabIndex = 0;
            // 
            // flowLayoutPanelAddOrder
            // 
            flowLayoutPanelAddOrder.Controls.Add(groupBox2);
            flowLayoutPanelAddOrder.Location = new Point(156, 473);
            flowLayoutPanelAddOrder.Name = "flowLayoutPanelAddOrder";
            flowLayoutPanelAddOrder.Size = new Size(169, 106);
            flowLayoutPanelAddOrder.TabIndex = 11;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 581);
            Controls.Add(flowLayoutPanelAddOrder);
            Controls.Add(flowLayoutPanelProducts);
            Controls.Add(flowLayoutPanelPay);
            Controls.Add(panel3);
            Controls.Add(dataGridViewOrders);
            Controls.Add(flowLayoutPanelTables);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            Load += MainPage_Load;
            flowLayoutPanelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel5.ResumeLayout(false);
            flowLayoutPanelPay.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanelAddOrder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelMenu;
        private Panel panel1;
        private Button btnTables;
        private Panel panel4;
        private Button btnProducts;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanelTables;
        private Label label2;
        private Button BtnMinimize;
        private Button btnClose;
        private DataGridView dataGridViewOrders;
        private Button btnDeleteOrder;
        private Panel panel3;
        private GroupBox groupBox1;
        private Panel panel5;
        private Button btnPay;
        private TextBox txtTotalPrice;
        private FlowLayoutPanel flowLayoutPanelPay;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private GroupBox groupBox2;
        private TextBox txtQuantity;
        private FlowLayoutPanel flowLayoutPanelAddOrder;
        private Panel panel6;
        private Button btnProductSettings;
        private Panel panel7;
        private Button btnCategorySettings;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel8;
        private Button btnSettings;
        private PictureBox pictureBox4;
        private Panel panel9;
        private Button btnTableSettings;
        private Panel panel10;
        private Button btnIncomeRecords;
        private PictureBox pictureBox5;
        private Label labelSelectedTable;
        private Label labelSelectedTableName;
    }
}