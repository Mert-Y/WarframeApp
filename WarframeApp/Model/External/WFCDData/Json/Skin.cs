using WarframeApp.Model.External.WFCDData.Json.Subclasses;

namespace WarframeApp.Model.External.WFCDData.Json
{
    class Skin : ItemBuildable
    {
        public Hexcolour[] hexColours { get; set; }

        #region  Used for storing full webdata vs cutdown userdata
        public bool ShouldSerializehexColours()
        {
            return IsExternal;
        }
        #endregion
    }
}