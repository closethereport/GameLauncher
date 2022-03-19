using GalaSoft.MvvmLight.Command;
using GameLauncher.View;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameLauncher.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private Page Wow = new WowPage();
        private Page HS = new HsPage();
        private Page OW = new OverwatchPage();
        private Page W3 = new W3Page();
        private Page D3 = new DiabloPage();
        private Page HOTS = new HotsPage();
        private Page SC2 = new Sc2Page();
        private Page SC = new ScPage();
        private Page _CurPage = new WowPage();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        public ICommand OpenHsPage
        {
            get
            {
                return new RelayCommand(() => CurPage = HS);
            }
        }
        public ICommand OpenWowPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Wow);
            }
        }
        public ICommand OpenOverWatchPage
        {
            get
            {
                return new RelayCommand(() => CurPage = OW);
            }
        }
        public ICommand OpenWow3Page
        {
            get
            {
                return new RelayCommand(() => CurPage = W3);
            }
        }
        public ICommand OpenHotsPage
        {
            get
            {
                return new RelayCommand(() => CurPage = HOTS);
            }
        }
        public ICommand OpenDiabloPage
        {
            get
            {
                return new RelayCommand(() => CurPage = D3);
            }
        }
        public ICommand OpenStarcraftPage
        {
            get
            {
                return new RelayCommand(() => CurPage = SC);
            }
        }
        public ICommand OpenStarcraft2Page
        {
            get
            {
                return new RelayCommand(() => CurPage = SC2);
            }
        }
    }
}
