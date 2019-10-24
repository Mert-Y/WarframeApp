using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WarframeApp.Model.External.DigitalExtremes.Json
{
    class Custom : INotifyPropertyChanged
    {
        public string uniqueName { get; set; }
        private string name { get; set; }
        public bool codexSecret { get; set; }
        public string description { get; set; }

        private int numOwned;
        private bool foundryReady;

        private string category;
        public string Category
        {
            get
            {
                if (category == null)
                {
                    var cat = "";
                    if (uniqueName.Contains("/SW") || uniqueName.Contains("/TennoGen"))
                    {
                        cat += "/TennoGen";
                    }
                    if (uniqueName.Contains("/TennoCon"))
                    {
                        cat += "/TennoCon";
                    }
                    if (uniqueName.Contains("/Halloween"))
                    {
                        cat += "/Halloween";
                    }
                    if (uniqueName.Contains("/VT") || uniqueName.Contains("/VoidTrader"))
                    {
                        cat += "/Baro";
                    }
                    if (uniqueName.Contains("/Ostron"))
                    {
                        cat += "/Ostron";
                    }
                    if (uniqueName.Contains("/Catbrows") || uniqueName.Contains("/CatbrowPet"))
                    {
                        cat += "/Pet/Kavat";
                    }
                    if (uniqueName.Contains("/Kubrows")|| uniqueName.Contains("/KubrowPet"))
                    {
                        cat += "/Pet/Kubrow";
                    }
                    if (uniqueName.Contains("/Sentinels"))
                    {
                        cat += "/Pet/Sentinel";
                    }
                    if (uniqueName.Contains("/Operator"))
                    {
                        int start = uniqueName.IndexOf("/Operator");
                        int end = uniqueName.IndexOf("/", start + 10);
                        string temp = uniqueName.Substring(start, end - start);
                        if (temp.Contains("Hair"))
                        {
                            start = uniqueName.IndexOf("/Hair") + 6;
                            name = uniqueName.Substring(start);
                        }
                        cat += temp;
                    }
                    if (uniqueName.Contains("/Armor"))
                    {
                        cat += "/Armor";
                    }
                    if (name.Contains("HELMET"))
                    {
                        cat += "/Helmet";
                    }
                    if (name.Contains("ARCANE"))
                    {
                        cat += "/Arcane";
                    }
                    if (uniqueName.Contains("/Sigils") || uniqueName.Contains("/Clan"))
                    {
                        cat += "/Sigil";
                    }
                    if (uniqueName.Contains("/Mustache"))
                    {
                        cat += "/Mustache";
                    }
                    if (uniqueName.Contains("/Effects"))
                    {
                        cat += "/Ephemera";
                    }
                    if (uniqueName.Contains("/Scarves") || name.Contains("SYANDANA"))
                    {
                        cat += "/Syandana";
                    }
                    if (uniqueName.Contains("/MeleeDangles"))
                    {
                        cat += "/Sugatra";
                    }
                    return cat == "" ? "Other" : cat;
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

        public bool ShouldSerializedescription()
        {
            return IsExternal;
        }

        public bool ShouldSerializeslot()
        {
            return IsExternal;
        }

        public bool ShouldSerializesentinel()
        {
            return IsExternal;
        }

        public bool ShouldSerializemasteryReq()
        {
            return IsExternal;
        }

        public bool ShouldSerializeomegaAttenuation()
        {
            return IsExternal;
        }
        #endregion
    }
}
