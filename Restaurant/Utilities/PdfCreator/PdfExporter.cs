using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Restaurant.CrossCuttingConcerns.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;


namespace Restaurant.Utilities.PdfCreator;

public static class PdfExporter
{
 

    public async static Task DailyIncomeRecordExportToPdf<T>(IList<T> data, string filePath,decimal totalPrice)
    {
        await ExceptionManager.HandleException(async () =>
        {


        using (var writer = new PdfWriter(filePath))
        {
            using (var pdf = new PdfDocument(writer))
            {
                var document = new Document(pdf);
                DateTime currentDate = DateTime.Now.Date;
                string formattedDate = currentDate.ToString("dd.MM.yyyy");

                document.Add(new Paragraph($"Tarih: {formattedDate} "));
                document.Add(new Paragraph(""));
                document.Add(new Paragraph(""));
            
                foreach (var item in data)
                {
                    var properties = typeof(T).GetProperties();

                    foreach (var prop in properties)
                    {
                       
                        var value = prop.GetValue(item);
                       
                        if (prop.Name == "ProductName") value = EditProductName(value.ToString());    
                        if (prop.Name == "Id") continue;
                       
                        string propName = PropertyNameConverter(prop.Name);
                       


                        document.Add(new Paragraph($"{propName}: {value}"));
                    }
                    document.Add(new Paragraph(""));
                    document.Add(new Paragraph(""));
                    document.Add(new Paragraph(""));
                }
                document.Add(new Paragraph($"Toplam Gelir: {totalPrice} TL"));
            }

        }
        });

    }





    public async static Task MonthlyIncomeRecordExportToPdf<T>(IList<T> data, string filePath, decimal totalPrice)
    {
        await ExceptionManager.HandleException(async () =>
        {
            using (var writer = new PdfWriter(filePath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);


                    foreach (var item in data)
                    {
                        var properties = typeof(T).GetProperties();

                        foreach (var prop in properties)
                        {

                            var value = prop.GetValue(item);

                            if (prop.Name == "Id") continue;
                            if (prop.Name == "Date") value = EditDate(value);

                            string propName = PropertyNameConverter(prop.Name);

                            document.Add(new Paragraph($"{propName}: {value}"));
                        }
                        document.Add(new Paragraph(""));
                        document.Add(new Paragraph(""));
                        document.Add(new Paragraph(""));
                    }
                    document.Add(new Paragraph($"Toplam Gelir: {totalPrice} TL"));
                }

            }



        });

     
    }





    internal static string EditDate(object date)
    {
        DateTime currentDate = (DateTime)date;
        string formattedDate = currentDate.ToString("dd.MM.yyyy");
        return formattedDate;
    }

    internal static string EditProductName(string name)
    {
        char[] chars = name.ToLower().ToCharArray();
        name = "";
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == 'ş')
            {
                chars[i] = 's';
            }
            if (chars[i] == 'ç')
            {
                chars[i] = 'c';
            }
            if (chars[i] == 'ğ')
            {
                chars[i] = 'g';
            }
            if (chars[i] == 'ö')
            {
                chars[i] = 'o';
            }
            if (chars[i] == 'ü')
            {
                chars[i] = 'u';
            }
          



            name += chars[i];
        }
       
        return name.ToUpper();

    }
   
    internal static string PropertyNameConverter(string name)
    {
        if (name == "ProductName")
        {
            return "Ürün";
        }
        else if (name == "Quantity")
        {
            return "Adet";
        }

        else if (name == "Price")
        {
            return "Fiyat";
        }
        else if (name == "TotalPrice")
        {
            return "Toplam Fiyat";
        }
        else if (name == "Date")
        {
            return "Tarih";
       
        }        
        else
        {
            return "";
        }
    }
   
}