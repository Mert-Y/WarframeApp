using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Threading;
using WarframeApp.Model.External.WFCDData;

namespace WarframeApp.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            //Load inventory after window loads
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, new Action(() => { LoadInventory(); }));
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

        public void LoadInventory()
        {
            UserInventory = UserInventorySingleton.UserInventory;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
