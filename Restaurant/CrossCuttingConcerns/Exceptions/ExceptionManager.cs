using Core.CrossCuttingConcerns.Exceptions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.CrossCuttingConcerns.Exceptions;

public static class ExceptionManager
{
    public static async Task HandleException(Func<Task> action)
    {
        try
        {
         await action();
        }
      
        catch (Exception exception)
        {
          await HandleExceptionAsync(exception);
        }
    }

   

    private static async Task HandleExceptionAsync(Exception exception)
    {
        MessageBox.Show("HATA: " + exception.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}