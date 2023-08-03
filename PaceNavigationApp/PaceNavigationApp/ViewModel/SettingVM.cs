using PaceNavigationApp.Model;

namespace PaceNavigationApp.ViewModel
{
     class SettingVM :Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public bool Settings
        {
            get { return _pageModel.LocationStatus; }
            set { _pageModel.LocationStatus = value; OnPropertyChanged(); }
        }

        public SettingVM()
        {
            _pageModel = new PageModel();
            Settings = true;
        }

    }
}
