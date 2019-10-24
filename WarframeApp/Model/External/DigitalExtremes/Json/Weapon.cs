using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WarframeApp.Model.External.DigitalExtremes.Json
{
    class Weapon : INotifyPropertyChanged
    {
        private string name;
        public string uniqueName { get; set; }
        public bool codexSecret { get; set; }
        public float secondsPerShot { get; set; }
        public float[] damagePerShot { get; set; }
        public int magazineSize { get; set; }
        public float reloadTime { get; set; }
        public float totalDamage { get; set; }
        public int damagePerSecond { get; set; }
        public string trigger { get; set; }
        public string description { get; set; }
        public float accuracy { get; set; }
        public float criticalChance { get; set; }
        public float criticalMultiplier { get; set; }
        public float procChance { get; set; }
        public float fireRate { get; set; }
        public int chargeAttack { get; set; }
        public int spinAttack { get; set; }
        public int leapAttack { get; set; }
        public int wallAttack { get; set; }
        public int slot { get; set; }
        public string noise { get; set; }
        public bool sentinel { get; set; }
        public int masteryReq { get; set; }
        public float omegaAttenuation { get; set; }

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
                    string cat = "";
                    if (sentinel)
                    {
                        cat += "/Sentinel";
                    }
                    if (slot == 1)
                    {
                        cat += "/1/Primary";
                    }
                    else if (slot == 0)
                    {
                        cat += "/2/Secondary";
                    }
                    else if (slot == 5)
                    {
                        cat += "/3/Melee";
                    }

                    return cat == "" ? "Unknown" : cat;
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

        public bool ShouldSerializecodexSecret()
        {
            return IsExternal;
        }

        public bool ShouldSerializesecondsPerShot()
        {
            return IsExternal;
        }

        public bool ShouldSerializedamagePerShot()
        {
            return IsExternal;
        }

        public bool ShouldSerializemagazineSize()
        {
            return IsExternal;
        }

        public bool ShouldSerializereloadTime()
        {
            return IsExternal;
        }

        public bool ShouldSerializetotalDamage()
        {
            return IsExternal;
        }

        public bool ShouldSerializedamagePerSecond()
        {
            return IsExternal;
        }

        public bool ShouldSerializetrigger()
        {
            return IsExternal;
        }

        public bool ShouldSerializedescription()
        {
            return true;
        }

        public bool ShouldSerializeaccuracy()
        {
            return IsExternal;
        }

        public bool ShouldSerializecriticalChance()
        {
            return IsExternal;
        }

        public bool ShouldSerializecriticalMultiplier()
        {
            return IsExternal;
        }

        public bool ShouldSerializeprocChance()
        {
            return IsExternal;
        }

        public bool ShouldSerializefireRate()
        {
            return IsExternal;
        }

        public bool ShouldSerializechargeAttack()
        {
            return IsExternal;
        }

        public bool ShouldSerializespinAttack()
        {
            return IsExternal;
        }

        public bool ShouldSerializeleapAttack()
        {
            return IsExternal;
        }

        public bool ShouldSerializewallAttack()
        {
            return IsExternal;
        }

        public bool ShouldSerializeslot()
        {
            return true;
        }

        public bool ShouldSerializenoise()
        {
            return IsExternal;
        }

        public bool ShouldSerializesentinel()
        {
            return true;
        }

        public bool ShouldSerializemasteryReq()
        {
            return true;
        }

        public bool ShouldSerializeomegaAttenuation()
        {
            return true;
        }
        #endregion
    }
}
