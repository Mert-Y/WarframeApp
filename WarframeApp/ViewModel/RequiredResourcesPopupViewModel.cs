using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WarframeApp.Model.External.WFCDData;
using WarframeApp.Model.External.WFCDData.Json.Subclasses;
using WarframeApp.Utilities;

namespace WarframeApp.ViewModel
{
    class RequiredResourcesPopupViewModel : INotifyPropertyChanged
    {
        public RequiredResourcesPopupViewModel()
        {
            UserInventory = UserInventorySingleton.UserInventory;
            CalculateRequiredResources();
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

        private ObservableCollection<ItemBuildable> resourceList;
        public ObservableCollection<ItemBuildable> ResourceList
        {
            get
            {
                return resourceList;
            }
            set
            {
                if (resourceList != value)
                {
                    resourceList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private void CalculateRequiredResources()
        {
            if (UserInventory != null)
            {
                List<ItemBuildable> list = new List<ItemBuildable>();
                getRequestedItems(UserInventory.Archwings, list);
                getRequestedItems(UserInventory.Melees, list);
                getRequestedItems(UserInventory.Primaries, list);
                getRequestedItems(UserInventory.Secondaries, list);
                getRequestedItems(UserInventory.Sentinels, list);
                getRequestedItems(UserInventory.Warframes, list);

                ResourceList = CalculateTotalResources(list);
                //SubtractOwnedFromTotalResources(ResourceList);
            }
        }

        private ObservableCollection<ItemBuildable> SubtractOwnedFromTotalResources(ObservableCollection<ItemBuildable> resources)
        {
            foreach (var resource in resources)
            {
                resource.itemCount -= resource.NumOwned;
            }
            return resources;
        }

            private ObservableCollection<ItemBuildable> CalculateTotalResources(List<ItemBuildable> items)
        {
            ObservableCollection<ItemBuildable> resources = new ObservableCollection<ItemBuildable>();

            foreach (var item in items)
            {
                if (item.components != null)
                {
                    foreach (var component in item.components)
                    {
                        bool found = false;
                        foreach (var partName in Language.PartNames)
                        {
                            if (component.name.Contains(partName)) { found = true; break; }
                        }
                        if (!found)
                        {
                            foreach (var resource in resources)
                            {
                                if (resource.name.Equals(component.name))
                                {
                                    found = true;
                                    resource.itemCount += component.itemCount;
                                }
                            }
                            if (!found)
                            {
                                resources.Add(component);
                            }
                        }
                    }
                }
            }
            return resources;
        }
        private void getRequestedItems(dynamic items, List<ItemBuildable> list)
        {
            bool substractMastered = true;
            bool substractInInventory = true;

            foreach (var item in items)
            {
                if (((substractMastered && !item.Mastery)
                    && (substractInInventory && !(item.NumOwned > 0)))
                    || (!substractMastered && !substractInInventory))
                {
                    list.Add(item);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
