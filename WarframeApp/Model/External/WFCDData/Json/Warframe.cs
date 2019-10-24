using WarframeApp.Model.External.WFCDData.Json.Subclasses;

namespace WarframeApp.Model.External.WFCDData.Json
{
    class Warframe : ItemMasterable
    {
        public int health { get; set; }
        public int shield { get; set; }
        public int armor { get; set; }
        public int stamina { get; set; }
        public int power { get; set; }
        public string passiveDescription { get; set; }
        public Ability[] abilities { get; set; }
        public string aura { get; set; }
        public bool conclave { get; set; }
        public int color { get; set; }
        public string introduced { get; set; }
        public int masteryReq { get; set; }
        public string[] polarities { get; set; }
        public string sex { get; set; }
        public float sprint { get; set; }
        public string wikiaThumbnail { get; set; }
        public string wikiaUrl { get; set; }
        public object vaulted { get; set; }
        public string releaseDate { get; set; }
        public string vaultDate { get; set; }
        public string estimatedVaultDate { get; set; }

        #region  Used for storing full webdata vs cutdown userdata
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

        public bool ShouldSerializepassiveDescription()
        {
            return IsExternal;
        }

        public bool ShouldSerializeabilities()
        {
            return IsExternal;
        }

        public bool ShouldSerializeaura()
        {
            return IsExternal;
        }

        public bool ShouldSerializeconclave()
        {
            return IsExternal;
        }

        public bool ShouldSerializecolor()
        {
            return IsExternal;
        }

        public bool ShouldSerializeintroduced()
        {
            return IsExternal;
        }

        public bool ShouldSerializemasteryReq()
        {
            return IsExternal;
        }

        public bool ShouldSerializepolarities()
        {
            return IsExternal;
        }

        public bool ShouldSerializesex()
        {
            return IsExternal;
        }

        public bool ShouldSerializesprint()
        {
            return IsExternal;
        }

        public bool ShouldSerializewikiaThumbnail()
        {
            return IsExternal;
        }

        public bool ShouldSerializewikiaUrl()
        {
            return IsExternal;
        }

        public bool ShouldSerializevaulted()
        {
            return IsExternal;
        }

        public bool ShouldSerializereleaseDate()
        {
            return IsExternal;
        }

        public bool ShouldSerializevaultDate()
        {
            return IsExternal;
        }

        public bool ShouldSerializeestimatedVaultDate()
        {
            return IsExternal;
        }
        #endregion
    }
}