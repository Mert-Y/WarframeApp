using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeApp.Model.Json
{
    class Misc
    {
            public string uniqueName { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string type { get; set; }
            public int buildPrice { get; set; }
            public int buildTime { get; set; }
            public int skipBuildTimePrice { get; set; }
            public int buildQuantity { get; set; }
            public bool consumeOnBuild { get; set; }
            public Component[] components { get; set; }
            public string imageName { get; set; }
            public string category { get; set; }
            public bool tradable { get; set; }
            public Patchlog[] patchlogs { get; set; }
            public Drop1[] drops { get; set; }
            public int binCount { get; set; }
            public int binCapacity { get; set; }
            public int fillRate { get; set; }
            public int durability { get; set; }
            public int repairRate { get; set; }
            public int[] capacityMultiplier { get; set; }
            public object[] specialities { get; set; }

        public class Component
        {
            public string uniqueName { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public int itemCount { get; set; }
            public bool tradable { get; set; }
            public string imageName { get; set; }
            public Drop[] drops { get; set; }
        }

        public class Drop
        {
            public string location { get; set; }
            public string type { get; set; }
            public string rarity { get; set; }
            public float chance { get; set; }
            public string rotation { get; set; }
        }

        public class Patchlog
        {
            public string name { get; set; }
            public DateTime date { get; set; }
            public string url { get; set; }
            public string additions { get; set; }
            public string changes { get; set; }
            public string fixes { get; set; }
            public string imgUrl { get; set; }
        }

        public class Drop1
        {
            public string location { get; set; }
            public string type { get; set; }
            public string rarity { get; set; }
            public float chance { get; set; }
            public string rotation { get; set; }
        }
    }
}
