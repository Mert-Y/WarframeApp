using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using WarframeApp.Model.External.WFCDData;
using WarframeApp.Utilities;

namespace WarframeApp.ViewModel
{
    class InventoryViewModel : INotifyPropertyChanged
    {
        public InventoryViewModel()
        {
            BtnSaveCommand = new RelayCommand(o => SaveButtonClick("BtnSave"));
            //Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, new Action(() => { UserInventory = UserInventorySingleton.UserInventory; }));
            UserInventory = UserInventorySingleton.UserInventory;
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

        public bool SaveItems()
        {
            return WarframeDataManager.SaveInventory(UserInventory);
        }

        public ICommand BtnSaveCommand { get; set; }

        private void SaveButtonClick(object sender)
        {
            SaveItems();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
