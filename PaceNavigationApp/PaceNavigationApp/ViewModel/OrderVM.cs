using System;
using PaceNavigationApp.Model;

namespace PaceNavigationApp.ViewModel
{
     class OrderVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public DateOnly DisplayOrderDate
        {
            get { return _pageModel.OrderDate; }
            set { _pageModel.OrderDate = value; OnPropertyChanged(); }
        }

        public OrderVM()
        {
            _pageModel = new PageModel();
            DisplayOrderDate = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
