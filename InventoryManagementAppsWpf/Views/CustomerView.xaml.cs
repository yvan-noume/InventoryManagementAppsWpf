using InventoryManagementApplicationLayer.API;
using InventoryManagementAppsWpf.ViewModels;
using System.Windows;
using InventoryManagementPresentationLayer.ViewModels;

namespace InventoryManagementAppsWpf.Views
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : Window
    {
        public CustomerView(ICustomerServices customerServices)
        {
            InitializeComponent();
            CustomersViewModel viewModel = new CustomersViewModel(customerServices);
            DataContext = viewModel;
        }
    }
}
