using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.CrossCuttingConcerns.Validation;

public static class ValidationManager
{

    public static void SelectedCategoryControl(object selectedCategory)
    {

        if (selectedCategory == null) {
            throw new ArgumentNullException("Kategori seçiniz !");
           
        };

    }


    public static void SelectedProductControl(object selectedProduct)
    {

        if (selectedProduct == null)
        {
            throw new ArgumentNullException("Ürün seçiniz !");

        };

    
    }
    public static void SelectedTableControl(object selectedTable)
    {

        if (selectedTable == null)
        {
            throw new ArgumentNullException("Masa seçiniz !");

        };


    }
}
