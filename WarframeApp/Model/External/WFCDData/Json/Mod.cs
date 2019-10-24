using WarframeApp.Model.External.WFCDData.Json.Subclasses;

namespace WarframeApp.Model.External.WFCDData.Json
{
    class Mod : Item
    {
        public string polarity { get; set; }
        public string rarity { get; set; }
        public int baseDrain { get; set; }
        public int fusionLimit { get; set; }
        public Drop[] drops { get; set; }
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

        #region  Used for storing full webdata vs cutdown userdata
        public bool ShouldSerializepolarity()
        {
            return IsExternal;
        }

        public bool ShouldSerializerarity()
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

        public bool ShouldSerializedrops()
        {
            return IsExternal;
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