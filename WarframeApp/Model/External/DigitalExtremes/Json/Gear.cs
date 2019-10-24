using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WarframeApp.Model.External.DigitalExtremes.Json
{
    class Gear : INotifyPropertyChanged
    {
        public string uniqueName { get; set; }
        private string name { get; set; }
        public string description { get; set; }
        public string longDescription { get; set; }
        public bool codexSecret { get; set; }
        public string parentName { get; set; }

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

        #region  Used for storing full webdata vs cutdown resourcedata
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

        public bool ShouldSerializecodexSecret()
        {
            return IsExternal;
        }
        #endregion
    }
}
