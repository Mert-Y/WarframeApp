using System.Collections.Generic;
using WarframeApp.Model.External.WFCDData.Json.Subclasses;

namespace WarframeApp.Model.External.WFCDData
{
    class ItemBuildable : Item
    {
        public int buildPrice { get; set; }
        public int buildTime { get; set; }
        public int skipBuildTimePrice { get; set; }
        public int buildQuantity { get; set; }
        public bool consumeOnBuild { get; set; }
        public int itemCount { get; set; }
        public int ducats { get; set; }

        public Drop[] drops { get; set; }
        public List<ItemBuildable> components { get; set; }

        public List<ItemBuildable> baseReference;
        public List<ItemBuildable> subReference;
        
        private bool foundryReady;
        public bool FoundryReady
        {
            get
            {
                return foundryReady;
            }
            set
            {
                if (foundryReady != value)
                {
                    if (baseReference != null)
                    {
                        foreach (var item in baseReference)
                        {
                            item.FoundryReady = value;
                        }
                    }
                    if (subReference != null)
                    {
                        foreach (var item in subReference)
                        {
                            item.foundryReady = value;
                            item.NotifyPropertyChanged();
                        }
                    }
                    foundryReady = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public override int NumOwned
        {
            get
            {
                return numOwned;
            }
            set
            {
                if (numOwned != value)
                {
                    if (baseReference != null)
                    {
                        foreach (var item in baseReference)
                        {
                            item.NumOwned = value;
                        }
                    }
                    if (subReference != null)
                    {
                        foreach (var item in subReference)
                        {
                            item.numOwned = value;
                            item.NotifyPropertyChanged();
                        }
                    }
                    numOwned = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool IsComponent = false;

        public bool ShouldSerializeIsComponent()
        {
            return false;
        }

        public bool ShouldSerializecomponents()
        {
            return !IsComponent;
        }

        public bool ShouldSerializebaseReference()
        {
            return false;
        }

        public bool ShouldSerializesubReference()
        {
            return false;
        }

        #region  Used for storing full webdata vs cutdown userdata
        public bool ShouldSerializeFoundryReady()
        {
            return !IsExternal;
        }

        public bool ShouldSerializebuildPrice()
        {
            return IsExternal;
        }

        public bool ShouldSerializebuildTime()
        {
            return IsExternal;
        }

        public bool ShouldSerializeskipBuildTimePrice()
        {
            return IsExternal;
        }

        public bool ShouldSerializebuildQuantity()
        {
            return IsExternal;
        }

        public bool ShouldSerializeconsumeOnBuild()
        {
            return IsExternal;
        }

        public bool ShouldSerializeitemCount()
        {
            return IsExternal;
        }

        public bool ShouldSerializeducats()
        {
            return IsExternal;
        }

        public bool ShouldSerializedrops()
        {
            return IsExternal;
        }
        #endregion
    }
}
