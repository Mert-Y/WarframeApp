namespace WarframeApp.Model.External.WFCDData.Json
{
    class Gear : ItemBuildable
    {
        public bool alwaysAvailable { get; set; }

        #region  Used for storing full webdata vs cutdown userdata
        public bool ShouldSerializealwaysAvailable()
        {
            return IsExternal;
        }
        #endregion
    }
}