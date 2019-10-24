namespace WarframeApp.Model.External.WFCDData.Json
{
    class Pet : ItemMasterable
    {
        public int health { get; set; }
        public int shield { get; set; }
        public int armor { get; set; }
        public int stamina { get; set; }
        public int power { get; set; }
        public bool alwaysAvailable { get; set; }
        public string visibility { get; set; }

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

        public bool ShouldSerializealwaysAvailable()
        {
            return IsExternal;
        }

        public bool ShouldSerializevisibility()
        {
            return IsExternal;
        }
        #endregion
    }
}