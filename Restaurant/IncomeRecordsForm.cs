using Business.Abstract;
using Business.Dtos.Requests.DailyIncomeRecord;
using Business.Dtos.Requests.MonthlyIncomeRecord;
using Business.Dtos.Responses.Category;
using Business.Dtos.Responses.DailyIncomeRecord;
using Business.Dtos.Responses.MonthlyIncomeRecord;
using DataAccess.Migrations;
using Entities.Concrete;
using Restaurant.CrossCuttingConcerns.Exceptions;
using Restaurant.Utilities.PdfCreator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Restaurant;

public partial class IncomeRecordsForm : Form
{

    private readonly IDailyIncomeRecordService _dailyIncomeRecordService;
    private readonly IMonthlyIncomeRecordService _monthlyIncomeRecordService;
    IList<GetListDailyIncomeRecordResponse> DailyIncomeRecords;
    IList<GetListMonthlyIncomeRecordResponse> MonthlyIncomeRecords;
    public decimal TotalPrice = 0;

    public IncomeRecordsForm(IDailyIncomeRecordService dailyIncomeRecordService, IMonthlyIncomeRecordService monthlyIncomeRecordService)
    {
        _dailyIncomeRecordService = dailyIncomeRecordService;
        _monthlyIncomeRecordService = monthlyIncomeRecordService;
        InitializeComponent();
    }

    private void IncomeRecordsForm_Load(object sender, EventArgs e)
    {
        IncomeRecordsPage.Visible = false;

    }





    private async void btnSaveDailyIncomeRecord_Click(object sender, EventArgs e)
    {
        CalculateTotalPriceForDailyIncomeRecord();
        await SaveDailyIncomeRecord(DailyIncomeRecords);
        await AddDailyIncomeRecordToMonthlyIncome();
        await ClearDailyIncomeRecord();
    }

    private async void btnSaveMonthlyIncomeRecord_Click(object sender, EventArgs e)
    {
        CalculateTotalPriceForMonthlyIncomeRecord();
        await SaveMonthlyIncomeRecord(MonthlyIncomeRecords);
        await ClearMonthlyIncomeRecord();
    }




    private async Task AddDailyIncomeRecordToMonthlyIncome()
    {
        await ExceptionManager.HandleException(async () =>
        {



            CreateMonthlyIncomeRecordRequest request = new() { Date = DateTime.Now.Date, Price = TotalPrice };
            await _monthlyIncomeRecordService.AddAsync(request);


        });

    }

    private async Task ClearDailyIncomeRecord()
    {
        await ExceptionManager.HandleException(async () =>
        {


            IList<GetListDailyIncomeRecordResponse> getListDailyIncomeRecordResponse = await _dailyIncomeRecordService.GetListAsync();


            IList<DeleteDailyIncomeRecordRequest> deleteDailyIncomeRecordRequest = new List<DeleteDailyIncomeRecordRequest>();
            foreach (var item in getListDailyIncomeRecordResponse)
            {
                deleteDailyIncomeRecordRequest.Add(new DeleteDailyIncomeRecordRequest { Id = item.Id });

            }
            await _dailyIncomeRecordService.DeleteRangeAsync(deleteDailyIncomeRecordRequest);


        });


    }
    private async Task ClearMonthlyIncomeRecord()
    {
        await ExceptionManager.HandleException(async () =>
        {

            IList<GetListMonthlyIncomeRecordResponse> getListMonthlyIncomeRecordResponse = await _monthlyIncomeRecordService.GetListAsync();


            IList<DeleteMonthlyIncomeRecordRequest> deleteMonthlyIncomeRecordRequest = new List<DeleteMonthlyIncomeRecordRequest>();
            foreach (var item in getListMonthlyIncomeRecordResponse)
            {
                deleteMonthlyIncomeRecordRequest.Add(new DeleteMonthlyIncomeRecordRequest { Id = item.Id });

            }
            await _monthlyIncomeRecordService.DeleteRangeAsync(deleteMonthlyIncomeRecordRequest);


        });

    }



    private async Task GetDailyIncomeRecords()
    {
        await ExceptionManager.HandleException(async () =>
        {


            DailyIncomeRecords = await _dailyIncomeRecordService.GetListAsync();


        });

    }
    private async Task GetMonthlyIncomeRecords()
    {
        await ExceptionManager.HandleException(async () =>
        {


            MonthlyIncomeRecords = await _monthlyIncomeRecordService.GetListAsync();


        });

    }







    private async Task SaveMonthlyIncomeRecord<T>(IList<T> data)
    {
        await ExceptionManager.HandleException(async () =>
        {



            DateTime currentDate = DateTime.Now.Date;
            string formattedDate = currentDate.ToString("MM.yyyy");

            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveDialog.FilterIndex = 1;
                saveDialog.RestoreDirectory = true;

                saveDialog.FileName = formattedDate + ".pdf";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = saveDialog.FileName;


                    await PdfExporter.MonthlyIncomeRecordExportToPdf(data, filePath, TotalPrice);
                }
            }

        });




    }
    private async Task SaveDailyIncomeRecord<T>(IList<T> data)
    {
        await ExceptionManager.HandleException(async () =>
        {

            DateTime currentDate = DateTime.Now.Date;
            string formattedDate = currentDate.ToString("dd.MM.yyyy");

            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveDialog.FilterIndex = 1;
                saveDialog.RestoreDirectory = true;

                saveDialog.FileName = formattedDate + ".pdf";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = saveDialog.FileName;


                    await PdfExporter.DailyIncomeRecordExportToPdf(data, filePath, TotalPrice);
                }
            }



        });




    }



    private async void dateTimePickerIncomeRecords_ValueChanged(object sender, EventArgs e)
    {
        await ExceptionManager.HandleException(async () =>
        {

            GetByDateMonthlyIncomeRecordRequest request = new() { Date = dateTimePickerIncomeRecords.Value.Date };

            List<GetByDateMonthlyIncomeRecordResponse> getByDateMonthlyIncomeRecordResponses = new();

            var response = await _monthlyIncomeRecordService.GetByDateAsync(request);

            getByDateMonthlyIncomeRecordResponses.Add(response);

            DataGridViewLoad(getByDateMonthlyIncomeRecordResponses);

        });

    }

    private async void DataGridViewLoad<T>(IList<T> data)
    {
        await ExceptionManager.HandleException(async () =>
        {

            if (data != null)
            {


                dtgDailyIncomeRecordControl.DataSource = data;
                dtgDailyIncomeRecordControl.Columns["Id"].Visible = false;
                dtgDailyIncomeRecordControl.Columns["Date"].HeaderText = "Tarih";
                dtgDailyIncomeRecordControl.Columns["Price"].HeaderText = "Gelir";


            }

        });






    }

    private void OpenPage(TabPage tabPage)
    {
        IncomeRecordsPage.Visible = true;
        IncomeRecordsPage.SelectedTab = tabPage;
    }

    private void CalculateTotalPriceForDailyIncomeRecord()
    {
        foreach (var item in DailyIncomeRecords)
        {
            TotalPrice += item.Price;
        }
    }
    private void CalculateTotalPriceForMonthlyIncomeRecord()
    {
        foreach (var item in MonthlyIncomeRecords)
        {
            TotalPrice += item.Price;
        }
    }


    private async void btnDailyIncomeRecord_Click(object sender, EventArgs e)
    {
        await GetDailyIncomeRecords();
        OpenPage(DailyIncomeRecordPage);
    }
    private async void btnMonthlyIncomeRecord_Click(object sender, EventArgs e)
    {
        await GetMonthlyIncomeRecords();
        OpenPage(MonthlyIncomeRecordPage);

    }
    private async void btnDailyIncomeRecordControl_Click(object sender, EventArgs e)
    {
        await GetMonthlyIncomeRecords();
        DataGridViewLoad(MonthlyIncomeRecords);
        OpenPage(DailyIncomeRecordControlPage);
        GetByDateMonthlyIncomeRecordRequest request = new() { Date = dateTimePickerIncomeRecords.Value.Date };

    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnMinimize_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void checkBoxFilterByDate_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxFilterByDate.Checked)
        {
            dateTimePickerIncomeRecords.Enabled = true;
        }
        else if (!checkBoxFilterByDate.Checked)
        {
            dateTimePickerIncomeRecords.Enabled = false;
            DataGridViewLoad(MonthlyIncomeRecords);
        }
    }
}
