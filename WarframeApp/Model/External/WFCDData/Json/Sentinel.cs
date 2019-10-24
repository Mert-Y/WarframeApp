namespace WarframeApp.Model.External.WFCDData.Json
{
    class Sentinel : ItemMasterable
    {
        public int health { get; set; }
        public int shield { get; set; }
        public int armor { get; set; }
        public int stamina { get; set; }
        public int power { get; set; }
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