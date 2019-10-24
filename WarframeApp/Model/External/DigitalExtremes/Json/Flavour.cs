using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WarframeApp.Model.External.DigitalExtremes.Json
{
    class Flavour : INotifyPropertyChanged
    {
        public string uniqueName { get; set; }
        private string name { get; set; }
        public string description { get; set; }
        public string longDescription { get; set; }
        public bool codexSecret { get; set; }
        public Hexcolour[] hexColours { get; set; }

        public class Hexcolour
        {
            public string value { get; set; }
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
        
        public string Category
        {
            get
            {
                if (category == null)
                {
                    string cat = "";
                    if (uniqueName.Contains("/Unlock"))
                    {
                        cat += "/Animation";
                    }
                    if (uniqueName.Contains("SW"))
                    {
                        cat += "/TennoGen";
                    }
                    if (uniqueName.Contains("/Liset"))
                    {
                        cat += "/Liset";
                    }
                    if (uniqueName.Contains("/SuitCustomizations"))
                    {
                        cat += "/Colour";
                    }
                    if (uniqueName.Contains("/AvatarImages"))
                    {
                        cat += "/Glyph";
                    }
                    if (uniqueName.Contains("/Emotes"))
                    {
                        cat += "/Emote";
                    }
                    if (uniqueName.Contains("/Arcade"))
                    {
                        cat += "/Glyph";
                    }
                    if (uniqueName.Contains("/KubrowPet"))
                    {
                        cat += "/Kubrow/Gene";
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

        public bool ShouldSerializecodexSecret()
        {
            return IsExternal;
        }

        public bool ShouldSerializehexColours()
        {
            return IsExternal;
        }
        #endregion
    }
}
