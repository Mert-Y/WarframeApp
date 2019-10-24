using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WarframeApp.Model.External.WFCDData.Json.Subclasses;

namespace WarframeApp.Model.External.WFCDData
{
    class Item : INotifyPropertyChanged
    {
        [JsonProperty(Order = 1)]
        public string uniqueName { get; set; }
        [JsonProperty(Order = 2)]
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string imageName { get; set; }
        public string category { get; set; }
        public bool tradable { get; set; }
        public Patchlog[] patchlogs { get; set; }

        protected int numOwned;
        public virtual int NumOwned
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

        public bool ShouldSerializeuniqueName()
        {
            return true;
        }

        public bool ShouldSerializename()
        {
            return IsExternal;
        }

        public bool ShouldSerializedescription()
        {
            return IsExternal;
        }

        public bool ShouldSerializetype()
        {
            return IsExternal;
        }

        public bool ShouldSerializeimageName()
        {
            return IsExternal;
        }

        public bool ShouldSerializecategory()
        {
            return IsExternal;
        }

        public bool ShouldSerializetradable()
        {
            return IsExternal;
        }

        public bool ShouldSerializepatchlogs()
        {
            return IsExternal;
        }
        #endregion
    }
}
