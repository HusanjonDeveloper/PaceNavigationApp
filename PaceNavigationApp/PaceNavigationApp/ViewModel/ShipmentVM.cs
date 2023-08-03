using System;
using PaceNavigationApp.Model;

namespace PaceNavigationApp.ViewModel
{
     class ShipmentVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public TimeOnly ShipmentTracking
        {
            get { return _pageModel.ShipmentDelivery; }
            set { _pageModel.ShipmentDelivery = value; OnPropertyChanged(); }
        }
        public ShipmentVM()
        {
            _pageModel = new PageModel();
            TimeOnly  time = TimeOnly.FromDateTime(DateTime.Now);
            ShipmentTracking = time;
        }
    }
}
