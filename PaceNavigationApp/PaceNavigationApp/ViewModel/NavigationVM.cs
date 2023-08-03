using System.Windows.Input;
using PaceNavigationApp.Utilities;

namespace PaceNavigationApp.ViewModel
{
     class NavigationVM : Utilities.ViewModelBase
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; } 
            set { _currentView = value; OnPropertyChanged();}
        }

        public ICommand HomeCommand { get; set; }

        public ICommand CustomersCommand { get; set;}

        public ICommand ProductsCommand { get; set; }

        public ICommand  OrdersCommand { get; set; }

        public ICommand TransactionsCommand { get; set; }

        public  ICommand  ShipmentsCommand { get; set; }
        
        public ICommand SettingsCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Customer(object obj) => CurrentView = new CustomerVM();
        private void Product(object obj) => CurrentView = new ProductVM();
        private void Order(object obj) => CurrentView = new OrderVM();
        private void Transaction(object obj) => CurrentView = new TransactionVM();
        private void Shipment(object obj) => CurrentView = new ShipmentVM();
        private void Setting(object obj) => CurrentView = new SettingVM();

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            CustomersCommand = new RelayCommand(Customer);
            ProductsCommand = new RelayCommand(Product);
            OrdersCommand = new RelayCommand(Order);
            TransactionsCommand = new RelayCommand(Transaction);
            ShipmentsCommand = new RelayCommand(Shipment);
            SettingsCommand = new RelayCommand(Setting);

            // Startup Page
            CurrentView = new HomeVM();
        }

    }
}
