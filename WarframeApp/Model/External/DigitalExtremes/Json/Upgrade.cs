using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WarframeApp.Model.External.DigitalExtremes.Json
{
    class Upgrade
    {
        public string uniqueName { get; set; }
        private string name { get; set; }
        public string polarity { get; set; }
        public string rarity { get; set; }
        public bool codexSecret { get; set; }
        public int baseDrain { get; set; }
        public int fusionLimit { get; set; }
        public string[] description { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public Upgradeentry[] upgradeEntries { get; set; }
        public Availablechallenge[] availableChallenges { get; set; }

        public class Upgradeentry
        {
            public string tag { get; set; }
            public string prefixTag { get; set; }
            public string suffixTag { get; set; }
            public Upgradevalue[] upgradeValues { get; set; }
        }

        public class Upgradevalue
        {
            public float value { get; set; }
            public string locTag { get; set; }
        }

        public class Availablechallenge
        {
            public string fullName { get; set; }
            public string description { get; set; }
            public Complication[] complications { get; set; }
        }

        public class Complication
        {
            public string fullName { get; set; }
            public string description { get; set; }
            public string overrideTag { get; set; }
        }

        private int numOwned;
        private string category;

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

        public string Category
        {
            get
            {
                if (category == null)
                {
                    string rareOrder = "";
                    if (rarity.Contains("UNCOMMON"))
                    {
                        rareOrder = "4/";
                    }
                    else if (rarity.Contains("COMMON"))
                    {
                        rareOrder = "3/";
                    }
                    else if (rarity.Contains("RARE"))
                    {
                        rareOrder = "2/";
                    }
                    else if (rarity.Contains("LEGENDARY"))
                    {
                        rareOrder = "1/";
                    }
                    return type == null ? "/Riven" : "/" + type + "/" + rareOrder + rarity;
                }
                else
                {
                    return category;
                }
            }
            set
            {
                if (category != value)
                {
                    category = value;
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

        public bool ShouldSerializeCategory()
        {
            return !IsExternal;
        }

        public bool ShouldSerializeNumOwned()
        {
            return !IsExternal;
        }

        public bool ShouldSerializecodexSecret()
        {
            return IsExternal;
        }

        public bool ShouldSerializebaseDrain()
        {
            return IsExternal;
        }

        public bool ShouldSerializefusionLimit()
        {
            return IsExternal;
        }

        public bool ShouldSerializedescription()
        {
            return IsExternal;
        }

        public bool ShouldSerializetype()
        {
            return true;
        }

        public bool ShouldSerializesubtype()
        {
            return true;
        }

        public bool ShouldSerializeupgradeEntries()
        {
            return IsExternal;
        }

        public bool ShouldSerializeavailableChallenges()
        {
            return IsExternal;
        }
        #endregion
    }
}
