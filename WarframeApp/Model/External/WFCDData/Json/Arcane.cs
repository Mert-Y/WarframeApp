namespace WarframeApp.Model.External.WFCDData.Json
{
    class Arcane : Item
    {
        private int numOwnedlvl3;
        public int NumOwnedlvl3
        {
            get
            {
                return numOwnedlvl3;
            }
            set
            {
                if (numOwnedlvl3 != value)
                {
                    numOwnedlvl3 = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #region  Used for storing full webdata vs cutdown userdata
        public bool ShouldSerializeNumOwnedlvl3()
        {
            return !IsExternal;
        }
        #endregion
    }
}