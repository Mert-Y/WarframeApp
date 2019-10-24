using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using WarframeApp.Model.External.WFCDData;
using WarframeApp.Utilities;
using WarframeApp.Views;

namespace WarframeApp.ViewModel
{
    class CalculationsViewModel : INotifyPropertyChanged
    {
        public CalculationsViewModel()
        {
            BtnCalculateCommand = new RelayCommand(o => CalculateButtonClick("BtnCalculate"));
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, new Action(() => { UserInventory = UserInventorySingleton.UserInventory; }));
        }

        private Inventory userInventory;
        public Inventory UserInventory
        {
            get
            {
                return userInventory;
            }
            set
            {
                if (userInventory != value)
                {
                    userInventory = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ICommand BtnCalculateCommand { get; set; }

        private void CalculateButtonClick(object sender)
        {
            RequiredResourcesPopupView popup = new RequiredResourcesPopupView();
            popup.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
