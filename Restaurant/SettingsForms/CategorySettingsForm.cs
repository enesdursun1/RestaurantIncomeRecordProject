using Business.Abstract;
using Business.Dtos.Requests.Category;
using Business.Dtos.Responses.Category;
using Entities.Concrete;
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

public partial class CategorySettingsForm : Form
{
    private readonly ICategoryService _categoryService;
    IList<GetListCategoryResponse> Categories;

    public CategorySettingsForm(ICategoryService categoryService)
    {
        _categoryService = categoryService;
        InitializeComponent();
    }

    private async void CategorySettingsForm_Load(object sender, EventArgs e)
    {
        CategorySettingsPage.Visible = false;
        Categories = await GetCategories();

    }







    private void ComboBoxCategoryLoad(ComboBox comboBox)
    {
        comboBox.DataSource = Categories;
        comboBox.DisplayMember = "Name";
        comboBox.ValueMember = "Id";
        comboBox.SelectedIndex = -1;
    }
    private async Task<IList<GetListCategoryResponse>> GetCategories()
    {
        return await _categoryService.GetListAsync();
    }


    private void OpenPage(TabPage tabPage)
    {
        CategorySettingsPage.Visible = true;
        CategorySettingsPage.SelectedTab = tabPage;
    }








    private void btnCategoryAdd_Click(object sender, EventArgs e)
    {
        OpenPage(AddCategoryPage);
    }
    private void btnCategoryUpdate_Click(object sender, EventArgs e)
    {
        ComboBoxCategoryLoad(cmbUpdateCategories);
        txtUpdateCategoryName.Text = string.Empty;
        OpenPage(UpdateCategoryPage);
    }
    private void btnCategoryDelete_Click(object sender, EventArgs e)
    {
        ComboBoxCategoryLoad(cmbDeleteCategories);
        OpenPage(DeleteCategoryPage);
    }



    private async void btnAddCategory_Click(object sender, EventArgs e)
    {
        await ExceptionManager.HandleException(async () =>
        {
            CreateCategoryRequest request = new() { Name = txtAddCategoryName.Text };
          
            await _categoryService.AddAsync(request);
           
            MessageBox.Show("Kategori başarıyla eklendi !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAddCategoryName.Text = string.Empty;
            Categories = await GetCategories();


        });


    }

    private async void btnUpdateCategory_Click(object sender, EventArgs e)
    {


        await ExceptionManager.HandleException(async () =>
        {
            var selectedCategory = (GetListCategoryResponse)cmbUpdateCategories.SelectedItem;
            ValidationManager.SelectedCategoryControl(selectedCategory);

            UpdateCategoryRequest request = new() { Id = selectedCategory.Id, Name = txtUpdateCategoryName.Text };
            await _categoryService.UpdateAsync(request);
            MessageBox.Show("Kategori başarıyla güncellendi !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Categories = await GetCategories();
            ComboBoxCategoryLoad(cmbUpdateCategories);
            txtUpdateCategoryName.Text = string.Empty;

        });






    }
    private async void btnDeleteCategory_Click(object sender, EventArgs e)
    {


        var dialogResult = MessageBox.Show("Kategoriyi silmek istediğinize emin misiniz ? ", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (dialogResult == DialogResult.Yes)
        {
            await ExceptionManager.HandleException(async () =>
        {
            var selectedCategory = (GetListCategoryResponse)cmbDeleteCategories.SelectedItem;
            ValidationManager.SelectedCategoryControl(selectedCategory);

            DeleteCategoryRequest request = new() { Id = selectedCategory.Id };
            await _categoryService.DeleteAsync(request);
            MessageBox.Show("Kategori başarıyla silindi !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Categories = await GetCategories();
            ComboBoxCategoryLoad(cmbDeleteCategories);

        });



        }



    }





    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void btnMinimize_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }


    private void cmbUpdateCategories_SelectedValueChanged(object sender, EventArgs e)
    {
        if (cmbUpdateCategories.SelectedItem != null)
        {

            var selectedCategory = (GetListCategoryResponse)cmbUpdateCategories.SelectedItem;
            txtUpdateCategoryName.Text = selectedCategory.Name;
        }
    }
}







