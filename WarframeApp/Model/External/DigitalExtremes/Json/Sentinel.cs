using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WarframeApp.Model.External.DigitalExtremes.Json
{
    class Sentinel : INotifyPropertyChanged
    {
        public string uniqueName { get; set; }
        private string name { get; set; }
        public string description { get; set; }
        public string longDescription { get; set; }
        public int health { get; set; }
        public int shield { get; set; }
        public int armor { get; set; }
        public int stamina { get; set; }
        public int power { get; set; }
        public bool codexSecret { get; set; }

        private int numOwned;
        private bool mastery;
        private bool foundryReady;

        private string category;
        public string Category
        {
            get
            {
                if (category == null)
                {
                    if (uniqueName.Contains("Sentinels"))
                    {
                        return "Sentinel";
                    }
                    else if (uniqueName.Contains("KubrowPet"))
                    {
                        return "Kubrow";
                    }
                    else if (uniqueName.Contains("CatbrowPet"))
                    {
                        return "Kavat";
                    }
                    return "Unknown";
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

        public bool Mastery
        {
            get
            {
                return mastery;
            }
            set
            {
                if (mastery != value)
                {
                    mastery = value;
                    NotifyPropertyChanged();
                }
            }
        }

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
                    foundryReady = value;
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

        public bool ShouldSerializeMastery()
        {
            return !IsExternal;
        }

        public bool ShouldSerializeFoundryReady()
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

        public bool ShouldSerializehealth()
        {
            return IsExternal;
        }

        public bool ShouldSerializeshield()
        {
            return IsExternal;
        }

        public bool ShouldSerializearmor()
        {
            return IsExternal;
        }

        public bool ShouldSerializestamina()
        {
            return IsExternal;
        }
        public bool ShouldSerializepower()
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
