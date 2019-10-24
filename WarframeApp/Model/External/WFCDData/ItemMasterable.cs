namespace WarframeApp.Model.External.WFCDData
{
    class ItemMasterable : ItemBuildable
    {
        private bool mastery;
        public bool Mastery
        {
            get
            {
                return mastery;
            }
            set
            {
                if (mastery != value)
                {
                    mastery = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #region  Used for storing full webdata vs cutdown userdata
        public bool ShouldSerializeMastery()
        {
            return !IsExternal;
        }
        #endregion
    }
}
