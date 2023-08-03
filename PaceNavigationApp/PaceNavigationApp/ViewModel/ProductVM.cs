using PaceNavigationApp.Model;

namespace PaceNavigationApp.ViewModel
{
     class ProductVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public string ProductAvailability
        {
            get { return _pageModel.ProductStatus; }
            set { _pageModel.ProductStatus = value; OnPropertyChanged(); }
        }

        public ProductVM()
        {
            _pageModel = new PageModel();
            ProductAvailability = "out of Stock";
        }

    }
}
