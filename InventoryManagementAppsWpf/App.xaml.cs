using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using InventoryManagementApplicationLayer.API;
using InventoryManagementApplicationLayer.Services;
using InventoryManagementAppsWpf.Views;
using InventoryManagementDataAccessLayer;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryManagementAppsWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<ICustomerServices, CustomerDataOperations>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var customerServices = _serviceProvider.GetService<ICustomerServices>();
            var customerView = new CustomerView(customerServices);
            customerView?.Show();
        }
    }
}
