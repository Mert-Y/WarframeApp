using System.Threading;
using WarframeApp.Model.External.WFCDData;
using WarframeApp.Utilities;

namespace WarframeApp.ViewModel
{
    class UserInventorySingleton
    {
        private UserInventorySingleton()
        {
            
        }
        private readonly static object balanceLock = new object();
        private static Inventory userInventory;
        public static Inventory UserInventory
        {
            get
            {
                if (userInventory == null)
                {
                    //Thread th = new Thread(WarframeDataManager.LoadData<Inventory>);
                    //private readonly object balanceLock = new object();
                    
                    userInventory = WarframeDataManager.LoadData<Inventory>();
                }
                return userInventory;
            }
            set
            {
                if (userInventory != value)
                {
                    userInventory = value;
                }
            }
        }
    }
}