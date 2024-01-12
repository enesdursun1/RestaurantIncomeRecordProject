using Business.Abstract;
using Business.Dtos.Requests.Category;
using Business.Dtos.Requests.Table;
using Business.Dtos.Responses.Category;
using Business.Dtos.Responses.Table;
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

namespace Restaurant.SettingsForms;

public partial class TableSettingsForm : Form
{
    private readonly ITableService _tableService;
    IList<GetListTableResponse> Tables;

    public TableSettingsForm(ITableService tableService)
    {
        _tableService = tableService;
        InitializeComponent();
    }

    private async void TableSettingsForm_Load(object sender, EventArgs e)
    {
        TableSettingsPage.Visible = false;
        Tables = await GetTables();
    }











    private async Task<IList<GetListTableResponse>> GetTables()
    {
        return await _tableService.GetListAsync();
    }



    private void ComboBoxTableLoad(ComboBox comboBox)
    {
        comboBox.DataSource = Tables;
        comboBox.DisplayMember = "Name";
        comboBox.ValueMember = "Id";
        comboBox.SelectedIndex = -1;
    }

    private void OpenPage(TabPage tabPage)
    {
        TableSettingsPage.Visible = true;
        TableSettingsPage.SelectedTab = tabPage;
    }


    private void btnTableAdd_Click(object sender, EventArgs e)
    {
        OpenPage(AddTablePage);
    }
    private void btnTableUpdate_Click(object sender, EventArgs e)
    {
        ComboBoxTableLoad(cmbUpdateTables);
        txtUpdateTableName.Text = string.Empty;
        OpenPage(UpdateTablePage);
    }
    private void btnTableDelete_Click(object sender, EventArgs e)
    {
        ComboBoxTableLoad(cmbDeleteTables);
        OpenPage(DeleteTablePage);
    }



    private async void btnAddTable_Click(object sender, EventArgs e)
    {
        await ExceptionManager.HandleException(async () =>
        {
            Business.Dtos.Requests.Table.CreateTableRequest request = new() { Name = txtAddTableName.Text };

            await _tableService.AddAsync(request);

            MessageBox.Show("Masa başarıyla eklendi !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAddTableName.Text = string.Empty;
            Tables = await GetTables();



        });
    }
    private async void btnUpdateTable_Click(object sender, EventArgs e)
    {
        await ExceptionManager.HandleException(async () =>
        {
            var selectedTable = (GetListTableResponse)cmbUpdateTables.SelectedItem;
            ValidationManager.SelectedTableControl(selectedTable);

            UpdateTableRequest request = new() { Id = selectedTable.Id, Name = txtUpdateTableName.Text };
            await _tableService.UpdateAsync(request);

            MessageBox.Show("Masa başarıyla güncellendi !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Tables = await GetTables();
            ComboBoxTableLoad(cmbUpdateTables);
            txtUpdateTableName.Text = string.Empty;



        });

    }

    private async void btnDeleteTable_Click(object sender, EventArgs e)
    {
        var dialogResult = MessageBox.Show("Masayı silmek istediğinize emin misiniz ? ", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (dialogResult == DialogResult.Yes)
        {
            await ExceptionManager.HandleException(async () =>
            {
                var selectedTable = (GetListTableResponse)cmbDeleteTables.SelectedItem;
                ValidationManager.SelectedTableControl(selectedTable);

                DeleteTableRequest request = new() { Id = selectedTable.Id };
                await _tableService.DeleteAsync(request);

                MessageBox.Show("Masa başarıyla silindi !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tables = await GetTables();
                ComboBoxTableLoad(cmbDeleteTables);

            });



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

    private void cmbUpdateTables_SelectedValueChanged(object sender, EventArgs e)
    {
        if (cmbUpdateTables.SelectedItem != null)
        {

            var selectedTable = (GetListTableResponse)cmbUpdateTables.SelectedItem;
            txtUpdateTableName.Text = selectedTable.Name;
        }
    }
}
