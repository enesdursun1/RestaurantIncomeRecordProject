using Business.Abstract;
using Business.Dtos.Requests.DailyIncomeRecord;
using Business.Dtos.Requests.Order;
using Business.Dtos.Requests.Product;
using Business.Dtos.Requests.Table;
using Business.Dtos.Responses.Category;
using Business.Dtos.Responses.Order;
using Business.Dtos.Responses.Product;
using Business.Dtos.Responses.Table;
using DataAccess.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Restaurant.CrossCuttingConcerns.Exceptions;
using Restaurant.SettingsForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Restaurant;

public partial class MainPage : Form
{

    private readonly ITableService _tableService;
    private readonly IOrderService _orderService;
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;
    private readonly IDailyIncomeRecordService _dailyIncomeRecordService;
    private readonly IMonthlyIncomeRecordService _monthlyIncomeRecordService;
    IList<GetListTableResponse> Tables;
    IList<GetListByCategoryProductResponse> ProductsByCategory;
    IList<GetListCategoryResponse> Categories;
    int SelectedCategoryId;
    Button SelectedTable;
    Button SelectedProduct;

    public MainPage(ITableService tableService, IOrderService orderService, IProductService productService, ICategoryService categoryService, IDailyIncomeRecordService dailyIncomeRecordService, IMonthlyIncomeRecordService monthlyIncomeRecordService)
    {
        _tableService = tableService;
        _orderService = orderService;
        _productService = productService;
        _categoryService = categoryService;
        _dailyIncomeRecordService = dailyIncomeRecordService;
        _monthlyIncomeRecordService = monthlyIncomeRecordService;
        InitializeComponent();
    }

    private async void MainPage_Load(object sender, EventArgs e)
    {
        flowLayoutPanelPay.Visible = false;
        flowLayoutPanelTables.Visible = false;
        flowLayoutPanelProducts.Visible = false;
        flowLayoutPanelAddOrder.Visible = false;
        await GetTables();
        ProductsByCategory = new List<GetListByCategoryProductResponse>();
        Categories = await GetCategories();


    }



    private void CreateProductButtons()
    {

        flowLayoutPanelProducts.Controls.Clear();
        CreateCategoryComboBox();
        foreach (var item in ProductsByCategory)
        {
            Button productButton = new()
            {
                Name = item.Id.ToString(),
                Text = item.Name,
                Height = 40,
                Width = 65,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Popup,
                BackColor = Color.DarkGray



            };


            flowLayoutPanelProducts.Controls.Add(productButton);
            productButton.Click += ProductButton_Click;
        }


    }




    private void CreateCategoryComboBox()
    {
        ComboBox comboBoxCategories = new()
        {
            DataSource = Categories,
            DisplayMember = "Name",
            ValueMember = "Id",
            DropDownStyle = ComboBoxStyle.DropDownList,
            Width = 150,



        };
        flowLayoutPanelProducts.Controls.Add(comboBoxCategories);
        comboBoxCategories.SelectedValueChanged += ComboBoxCategories_SelectedValueChanged;
    }


    private async void ComboBoxCategories_SelectedValueChanged(object sender, EventArgs e)
    {

        var selectedCategory = sender as ComboBox;
        SelectedCategoryId = Convert.ToInt32(selectedCategory.SelectedValue);
        await FindProductsByCategory(SelectedCategoryId);
        CreateProductButtons();
        txtQuantity.Text = txtQuantity.Text = "";
    }

    private async Task CreateTableButtons()
    {

        foreach (var item in Tables)
        {
            Button tablebutton = new()
            {
                Name = item.Id.ToString(),
                Text = item.Name,
                Height = 40,
                Width = 40,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Popup,
                BackColor = Color.DarkGray



            };
            if (item.IsActive)
            {
                tablebutton.BackColor = Color.Green;
            }

            flowLayoutPanelTables.Controls.Add(tablebutton);
            tablebutton.Click += Tablebutton_Click;
        }



    }

    private async void Tablebutton_Click(object? sender, EventArgs e)
    {
        SelectedTable = sender as Button;
        await FindOrdersForSelectedTable(Convert.ToInt32(SelectedTable.Name));
        labelSelectedTableName.Text = SelectedTable.Text;
        labelSelectedTable.Visible = true;
        labelSelectedTableName.Visible = true;

    }
    private async void ProductButton_Click(object? sender, EventArgs e)
    {
        if (SelectedTableControl())
        {

            SelectedProduct = sender as Button;
            int quantity = ProductQuantityControl();
            txtQuantity.Text = txtQuantity.Text = "";
            await ActivateTable();
            await AddOrder(quantity);
            await FindOrdersForSelectedTable(Convert.ToInt32(SelectedTable.Name));
        }

    }



    private async void btnTables_Click(object sender, EventArgs e)
    {
        await GetTables();
        flowLayoutPanelProducts.Visible = false;
        flowLayoutPanelAddOrder.Visible = false;
        flowLayoutPanelTables.Controls.Clear();
        CreateTableButtons();
        flowLayoutPanelTables.Visible = true;
        flowLayoutPanelPay.Visible = true;

    }
    private async void btnProducts_Click(object sender, EventArgs e)
    {


        Categories = await GetCategories();
        txtQuantity.Text = txtQuantity.Text = "";
        flowLayoutPanelTables.Visible = false;
        flowLayoutPanelPay.Visible = false;
        flowLayoutPanelProducts.Controls.Clear();
        CreateCategoryComboBox();
        flowLayoutPanelProducts.Visible = true;
        flowLayoutPanelAddOrder.Visible = true;
    }


    private async Task FindOrdersForSelectedTable(int id)
    {
        await ExceptionManager.HandleException(async () =>
        {

            IList<GetListByTableIdOrderResponse> getListByTableIdOrderResponse = await _orderService.GetListByTableIdAsync(id);
            dataGridViewOrders.DataSource = getListByTableIdOrderResponse;
            dataGridViewOrders.Columns["Id"].Visible = false;
            dataGridViewOrders.Columns["TableName"].Visible = false;
            dataGridViewOrders.Columns["ProductName"].HeaderText = "Ürün";
            dataGridViewOrders.Columns["Quantity"].HeaderText = "Adet";
            dataGridViewOrders.Columns["Price"].HeaderText = "Fiyat";
            CalculateTotalPrice(getListByTableIdOrderResponse);

        });


    }
    private async Task FindProductsByCategory(int id)
    {
        await ExceptionManager.HandleException(async () =>
        {


            ProductsByCategory = await _productService.GetListByCategoryIdAsync(id);

        });




    }




    private async Task GetTables()
    {
        await ExceptionManager.HandleException(async () =>
        {


            Tables = await _tableService.GetListAsync();

        });



    }

    private async Task<IList<GetListCategoryResponse>> GetCategories()
    {
        return await _categoryService.GetListAsync();
    }









    private async Task AddOrder(int quantity)
    {
        await ExceptionManager.HandleException(async () =>
        {


            GetByIdProductRequest getByIdProductRequest = new GetByIdProductRequest()
            {
                Id = Convert.ToInt32(SelectedProduct.Name)
            };
            var product = await _productService.GetByIdAsync(getByIdProductRequest);
            CreateOrderRequest createOrderRequest = new()
            {
                ProductId = Convert.ToInt32(SelectedProduct.Name),
                Quantity = quantity,
                TableId = Convert.ToInt32(SelectedTable.Name),
                Price = product.Price * quantity,


            };

            await _orderService.AddAsync(createOrderRequest);

        });





    }



    private async Task ActivateTable()
    {

        await ExceptionManager.HandleException(async () =>
        {

            GetByIdTableResponse getByIdTableResponse = await GetTableById();



            if (!getByIdTableResponse.IsActive)
            {
                getByIdTableResponse.IsActive = true;
                UpdateTableRequest updateTableRequest = new()
                {
                    Id = getByIdTableResponse.Id,
                    IsActive = getByIdTableResponse.IsActive,
                    Name = getByIdTableResponse.Name

                };

                await _tableService.UpdateAsync(updateTableRequest);

            }

        });


    }
    private async Task DeActivateTable()
    {
        await ExceptionManager.HandleException(async () =>
        {
            GetByIdTableResponse getByIdTableResponse = await GetTableById();
            if (getByIdTableResponse.IsActive)
            {
                getByIdTableResponse.IsActive = false;

                UpdateTableRequest updateTableRequest = new()
                {
                    Id = getByIdTableResponse.Id,
                    IsActive = getByIdTableResponse.IsActive,
                    Name = getByIdTableResponse.Name

                };

                await _tableService.UpdateAsync(updateTableRequest);

            }


        });

    }

    private async Task<GetByIdTableResponse> GetTableById()
    {




        GetByIdTableRequest request = new() { Id = Convert.ToInt32(SelectedTable.Name) };
        GetByIdTableResponse getByIdTableResponse = await _tableService.GetByIdAsync(request);
        return getByIdTableResponse;
    }


    private void btnClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void BtnMinimize_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void CalculateTotalPrice(IList<GetListByTableIdOrderResponse> data)
    {
        decimal totalPrice = 0;
        foreach (var item in data)
        {
            totalPrice += item.Price;

        }

        txtTotalPrice.Text = totalPrice.ToString();

    }

    private int ProductQuantityControl()
    {
        if (String.IsNullOrEmpty(txtQuantity.Text))
        {
            return 1;

        }
        else
        {
            return Convert.ToInt32(txtQuantity.Text);

        }

    }

    private async void btnDeleteOrder_Click(object sender, EventArgs e)
    {
        if (dataGridViewOrders.SelectedRows.Count == 0)
        {
            MessageBox.Show("Lütfen silinecek ürünü seçin !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        await ExceptionManager.HandleException(async () =>
        {
            int selectedOrder = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["Id"].Value);
            DeleteOrderRequest request = new() { Id = selectedOrder };

            await _orderService.DeleteAsync(request);
            await FindOrdersForSelectedTable(Convert.ToInt32(SelectedTable.Name));
            if (dataGridViewOrders.RowCount <= 0)
            {
                await DeActivateTable();
            }
            await GetTables();
            flowLayoutPanelTables.Controls.Clear();
            await CreateTableButtons();


        });




    }

    private async void btnPay_Click(object sender, EventArgs e)
    {
        if (SelectedTableControl())
        {
            if (txtTotalPrice.Text == "0")
            {
                MessageBox.Show("Bu masaya ait ürün bulunmuyor ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await ExceptionManager.HandleException(async () =>
            {

                DialogResult result = MessageBox.Show($"Masayı ({SelectedTable.Text}) kapatmak istediğinize emin misiniz? ", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    IList<GetListByTableIdOrderResponse> getListByTableIdOrderResponse = await _orderService.GetListByTableIdAsync(Convert.ToInt32(SelectedTable.Name));
                    IList<DeleteOrderRequest> deleteOrderRequests = new List<DeleteOrderRequest>();

                    foreach (var item in getListByTableIdOrderResponse)
                    {
                        deleteOrderRequests.Add(new DeleteOrderRequest()
                        {
                            Id = item.Id,

                        });

                    }
                    await _orderService.DeleteRangeAsync(deleteOrderRequests);
                    await FindOrdersForSelectedTable(Convert.ToInt32(SelectedTable.Name));
                    await DeActivateTable();
                    await GetTables();
                    flowLayoutPanelTables.Controls.Clear();
                    await CreateTableButtons();
                    await DailyIncomeRecordProductExistControl(getListByTableIdOrderResponse);
                }


            });



        }
    }



    private async Task DailyIncomeRecordProductExistControl(IList<GetListByTableIdOrderResponse> data)
    {
        await ExceptionManager.HandleException(async () =>
        {

            foreach (var item in data)
            {
                GetByProductNameDailyIncomeRecordRequest request = new() { ProductName = item.ProductName };
                var response = await _dailyIncomeRecordService.GetByProductNameAsync(request);
                if (response == null)
                {
                    CreateDailyIncomeRecordRequest createDailyIncomeRecordRequest = new() { ProductName = item.ProductName, Quantity = item.Quantity, Price = item.Price };

                    await _dailyIncomeRecordService.AddAsync(createDailyIncomeRecordRequest);
                }
                else
                {
                    UpdateDailyIncomeRecordRequest updateDailyIncomeRecordRequest = new() { Id = response.Id, ProductName = item.ProductName, Quantity = response.Quantity + item.Quantity, Price = response.Price + item.Price };
                    await _dailyIncomeRecordService.UpdateAsync(updateDailyIncomeRecordRequest);
                }

            }



        });





    }

    private bool SelectedTableControl()
    {
        if (SelectedTable == null)
        {
            MessageBox.Show("Lütfen masa seçiniz ! ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

    private void btnProductSettings_Click(object sender, EventArgs e)
    {

        ProductSettingsForm productSettingsForm = new(_categoryService, _productService);
        productSettingsForm.ShowDialog();
    }

    private void btnCategorySettings_Click(object sender, EventArgs e)
    {

        CategorySettingsForm categorySettingsForm = new(_categoryService);
        categorySettingsForm.ShowDialog();
    }

    private void btnTableSettings_Click(object sender, EventArgs e)
    {
        TableSettingsForm tableSettingsForm = new(_tableService);
        tableSettingsForm.ShowDialog();
    }
    private void btnIncomeRecords_Click(object sender, EventArgs e)
    {
        IncomeRecordsForm incomeRecordsForm = new(_dailyIncomeRecordService, _monthlyIncomeRecordService);
        incomeRecordsForm.ShowDialog();
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {

        btnCategorySettings.Visible = !btnCategorySettings.Visible;
        btnProductSettings.Visible = !btnProductSettings.Visible;
        btnTableSettings.Visible = !btnTableSettings.Visible;


    }


}
