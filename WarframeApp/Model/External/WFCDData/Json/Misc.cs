namespace WarframeApp.Model.External.WFCDData.Json
{
    class Misc : ItemMasterable
    {
        public int binCount { get; set; }
        public int binCapacity { get; set; }
        public int fillRate { get; set; }
        public int durability { get; set; }
        public int repairRate { get; set; }
        public int[] capacityMultiplier { get; set; }
        public object[] specialities { get; set; }

        #region  Used for storing full webdata vs cutdown userdata
        public bool ShouldSerializebinCount()
        {
            return IsExternal;
        }

        public bool ShouldSerializebinCapacity()
        {
            return IsExternal;
        }

        public bool ShouldSerializefillRate()
        {
            return IsExternal;
        }

        public bool ShouldSerializedurability()
        {
            return IsExternal;
        }

        public bool ShouldSerializerepairRate()
        {
            return IsExternal;
        }

        public bool ShouldSerializecapacityMultiplier()
        {
            return IsExternal;
        }

        public bool ShouldSerializespecialities()
        {
            return IsExternal;
        }
        #endregion
    }
}