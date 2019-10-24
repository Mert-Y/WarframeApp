using System.Collections.Generic;
using WarframeApp.Model.External.WFCDData.Json.Subclasses;

namespace WarframeApp.Model.External.WFCDData
{
    class PrimePart
    {
        public PrimePart(ItemBuildable item, ItemBuildable component)
        {
            primePart = new KeyValuePair<ItemBuildable, ItemBuildable>(item, component);
        }

        public KeyValuePair<ItemBuildable, ItemBuildable> primePart;

        public string name
        {
            get
            {
                return primePart.Key.name + " " + primePart.Value.name;
            }
            set
            {
                if (primePart.Value.name != value)
                {
                    primePart.Value.name = value;
                    primePart.Value.NotifyPropertyChanged();
                }
            }
        }

        public string category
        {
            get
            {
                return primePart.Key.category;
            }
            set
            {
                if (primePart.Key.category != value)
                {
                    primePart.Key.category = value;
                    primePart.Key.NotifyPropertyChanged();
                }
            }
        }

        public Drop[] drops
        {
            get
            {
                return primePart.Value.drops;
            }
            set
            {
                if (primePart.Value.drops != value)
                {
                    primePart.Value.drops = value;
                    primePart.Value.NotifyPropertyChanged();
                }
            }
        }

        public int NumOwned
        {
            get
            {
                return primePart.Value.NumOwned;
            }
            set
            {
                primePart.Value.NumOwned = value;
            }
        }

        public bool FoundryReady
        {
            get
            {
                return primePart.Value.FoundryReady;
            }
            set
            {
                primePart.Value.FoundryReady = value;
            }
        }
    }
}
