using System.Windows.Navigation;
using PaceNavigationApp.Model;

namespace PaceNavigationApp.ViewModel
{
     class TransactionVM :Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public decimal TransactionAmout
        {
            get { return _pageModel.TransactionValue; }
            set { _pageModel.TransactionValue = value; OnPropertyChanged(); }
        }

        public TransactionVM()
        {
            _pageModel = new PageModel();
             TransactionAmout = 5638;
        }
    }
}
