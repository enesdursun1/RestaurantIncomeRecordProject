using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using DataAccess;
using Business;
using Core.DependencyResolvers;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;


namespace Restaurant
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
    
            var serviceProvider = ConfigureServices();

           
            
                var mainForm = serviceProvider.GetRequiredService<MainPage>();
                Application.Run(mainForm);
            
        }
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();


            services.AddDataAccessServices();
            services.AddBusinessServices();
            services.AddDependencyResolvers();
        


            services.AddScoped<MainPage>();

            return services.BuildServiceProvider();
        }




    }
}