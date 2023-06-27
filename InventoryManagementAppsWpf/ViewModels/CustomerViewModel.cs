using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementApplicationLayer;
using InventoryManagementApplicationLayer.Services;
using System.Data.SqlClient;
using InventoryManagementApplicationLayer.API;
using InventoryManagementAppsWpf.MVVM;

namespace InventoryManagementAppsWpf.ViewModels
{
    internal class CustomerViewModel:ViewModelBase
    {
        public ObservableCollection<CustomerDTO> Customers { get; set; }

        //public RelayCommand AddCommand => new RelayCommand(execute => AddCustomer());
        //public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteCustomer(), canExecute => SelectedItem != null);
        //public RelayCommand SaveCommand => new RelayCommand(execute => SaveCustomer(), canExecute => SelectedItem != null);

        public CustomerViewModel(ICustomerServices customerServices)
        {
            Customers = new ObservableCollection<CustomerDTO>();
            List<CustomerDTO> list = customerServices.GetAllCustomers();
            foreach (var customer in list)
            {
                Customers.Add(customer);
            }
        }

        private CustomerDTO selectedItem;

        public CustomerDTO SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        public void AddCustomer()
        {

        }

        public void DeleteCustomer()
        {

        }

        public void SaveCustomer()
        {

        }
    }
}
