using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WarframeApp.Model.External.DigitalExtremes.Json
{
    class Drone : INotifyPropertyChanged
    {
        public string uniqueName { get; set; }
        private string name { get; set; }
        public string description { get; set; }
        public string longDescription { get; set; }
        public int binCount { get; set; }
        public int binCapacity { get; set; }
        public int fillRate { get; set; }
        public int durability { get; set; }
        public int repairRate { get; set; }
        public bool codexSecret { get; set; }
        public int[] capacityMultiplier { get; set; }
        public object[] specialities { get; set; }

        private int numOwned;

        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != value)
                {
                    name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int NumOwned
        {
            get
            {
                return numOwned;
            }
            set
            {
                if (numOwned != value)
                {
                    numOwned = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #region  Used for storing full webdata vs cutdown userdata
        public bool IsExternal { get; set; } = true;

        public bool ShouldSerializeIsExternal()
        {
            return false;
        }

        public bool ShouldSerializeNumOwned()
        {
            return !IsExternal;
        }

        public bool ShouldSerializedescription()
        {
            return IsExternal;
        }

        public bool ShouldSerializelongDescription()
        {
            return IsExternal;
        }

        public bool ShouldSerializebinCount()
        {
            return IsExternal;
        }

        public bool ShouldSerializebinCapacity()
        {
            return IsExternal;
        }

        public bool ShouldSerializefillRate()
        {
            return IsExternal;
        }
        public bool ShouldSerializedurability()
        {
            return IsExternal;
        }
        public bool ShouldSerializerepairRate()
        {
            return IsExternal;
        }
        public bool ShouldSerializecodexSecret()
        {
            return IsExternal;
        }
        public bool ShouldSerializecapacityMultiplier()
        {
            return IsExternal;
        }
        public bool ShouldSerializespecialities()
        {
            return IsExternal;
        }
        #endregion
    }
}
