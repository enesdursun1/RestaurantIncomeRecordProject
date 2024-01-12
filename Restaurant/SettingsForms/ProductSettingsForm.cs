using Business.Abstract;
using Business.Dtos.Requests.Product;
using Business.Dtos.Responses.Category;
using Business.Dtos.Responses.Product;
using Restaurant.CrossCuttingConcerns.Exceptions;
using Restaurant.CrossCuttingConcerns.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant;

public partial class ProductSettingsForm : Form
{
    private readonly ICategoryService _categoryService;
    private readonly IProductService _productService;
    IList<GetListCategoryResponse> Categories;
    IList<GetListProductResponse> Products;
    IList<GetListByCategoryProductResponse> ProductsByCategory;
    private bool suppressUpdate = false;

    public ProductSettingsForm(ICategoryService categoryService, IProductService productService)
    {
        _categoryService = categoryService;
        _productService = productService;
        InitializeComponent();
    }

    private async void ProductSettingsForm_Load(object sender, EventArgs e)
    {
        ProductSettingsPage.Visible = false;
        Categories = await GetCategories();
        Products = await GetProducts();

    }






























    private async Task<IList<GetListCategoryResponse>> GetCategories()
    {
        return await _categoryService.GetListAsync();
    }
    private async Task<IList<GetListProductResponse>> GetProducts()
    {
        return await _productService.GetListAsync();
    }
    private async Task<GetByIdProductResponse> GetProductById(int id)
    {
        GetByIdProductRequest request = new() { Id = id };

        return await _productService.GetByIdAsync(request);
    }
    private void ComboBoxCategoryLoad(ComboBox comboBox)
    {
        suppressUpdate = true;
        comboBox.DataSource = Categories;
        comboBox.DisplayMember = "Name";
        comboBox.ValueMember = "Id";
        comboBox.SelectedIndex = -1;
        suppressUpdate = false;
    }
    private void ComboBoxProductLoad(ComboBox comboBox)
    {
        comboBox.DataSource = Products;
        comboBox.DisplayMember = "Name";
        comboBox.ValueMember = "Id";
        comboBox.SelectedIndex = -1;
    }
    private void ComboBoxProductLoadForUpdated(ComboBox comboBox)
    {
        comboBox.DataSource = Products;
        comboBox.DisplayMember = "Name";
        comboBox.ValueMember = "Id";

    }
    private async Task FindProductsByCategory(int id)
    {

        ProductsByCategory = await _productService.GetListByCategoryIdAsync(id);


    }


    private void OpenPage(TabPage tabPage)
    {
        ProductSettingsPage.Visible = true;
        ProductSettingsPage.SelectedTab = tabPage;
    }



    private void btnProductAdd_Click(object sender, EventArgs e)
    {
        ComboBoxCategoryLoad(cmbAddProductCategories);
        OpenPage(AddProductPage);
    }

    private void btnProductUpdate_Click(object sender, EventArgs e)
    {
        ComboBoxProductLoad(cmbUpdateProducts);
        ComboBoxCategoryLoad(cmbUpdateProductCategories);
        txtUpdateProductName.Text = string.Empty;
        txtUpdateProductPrice.Text = string.Empty;
        OpenPage(UpdateProductPage);

    }

    private void btnProductDelete_Click(object sender, EventArgs e)
    {

        ComboBoxCategoryLoad(cmbDeleteProductCategories);
        OpenPage(DeleteProductPage);

    }






    private async void btnAddProduct_Click(object sender, EventArgs e)
    {

        await ExceptionManager.HandleException(async () =>
          {
              CreateProductRequest request = new()
              {
                  CategoryId = Convert.ToInt32(cmbAddProductCategories.SelectedValue),
                  Name = txtAddProductName.Text,
                  Price = Convert.ToDecimal(txtAddProductPrice.Text)
              };


              await _productService.AddAsync(request);
              MessageBox.Show("Ürün başarıyla eklendi !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
              txtAddProductName.Text = "";
              txtAddProductPrice.Text = "";
              cmbAddProductCategories.SelectedIndex = -1;
              Products = await GetProducts();
          });



    }

    private async void btnUpdateProduct_Click(object sender, EventArgs e)
    {

        await ExceptionManager.HandleException(async () =>
        {
            ValidationManager.SelectedProductControl(cmbUpdateProducts.SelectedItem);


            UpdateProductRequest request = new()
            {
                Id = Convert.ToInt32(cmbUpdateProducts.SelectedValue),
                CategoryId = Convert.ToInt32(cmbUpdateProductCategories.SelectedValue),
                Name = txtUpdateProductName.Text,
                Price = Convert.ToDecimal(txtUpdateProductPrice.Text)
            };


            await _productService.UpdateAsync(request);
            MessageBox.Show("Ürün başarıyla güncellendi !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Products = await GetProducts();
            ComboBoxProductLoadForUpdated(cmbUpdateProducts);
            cmbUpdateProductCategories.SelectedIndex = -1;
            cmbUpdateProducts.SelectedIndex = -1;
            txtUpdateProductName.Text = "";
            txtUpdateProductPrice.Text = "";
        });



    }

    private async void btnDeleteProduct_Click(object sender, EventArgs e)
    {

        await ExceptionManager.HandleException(async () =>
        {

            ValidationManager.SelectedProductControl(cmbDeleteProducts.SelectedItem);

            DeleteProductRequest request = new()
            {
                Id = Convert.ToInt32(cmbDeleteProducts.SelectedValue),

            };


            await _productService.DeleteAsync(request);
            MessageBox.Show("Ürün başarıyla silindi !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Products = await GetProducts();
            cmbDeleteProducts.SelectedIndex = -1;
            cmbDeleteProductCategories.SelectedIndex = -1;
        });


    }





    private void cmbUpdateProducts_SelectedValueChanged(object sender, EventArgs e)
    {
        if (cmbUpdateProducts.SelectedItem != null)
        {
            var selectedProduct = (GetListProductResponse)cmbUpdateProducts.SelectedItem;
            txtUpdateProductName.Text = selectedProduct.Name;
            txtUpdateProductPrice.Text = selectedProduct.Price.ToString();

            var categoryOfSelectedProduct = Categories.FirstOrDefault(c => c.Id == selectedProduct.CategoryId);


            if (categoryOfSelectedProduct != null)
            {
                cmbUpdateProductCategories.SelectedItem = categoryOfSelectedProduct;
            }


        }
    }

    private async void cmbDeleteProductCategories_SelectedValueChanged(object sender, EventArgs e)
    {

        if (suppressUpdate) return;
        if (cmbDeleteProductCategories.SelectedItem != null)
        {
            var selectedCategory = (GetListCategoryResponse)cmbDeleteProductCategories.SelectedItem;

            await FindProductsByCategory(selectedCategory.Id);

            cmbDeleteProducts.DataSource = ProductsByCategory;
            cmbDeleteProducts.DisplayMember = "Name";
            cmbDeleteProducts.ValueMember = "Id";
            cmbDeleteProducts.SelectedIndex = -1;


        }

    }





    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void BtnMinimize_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    
}
