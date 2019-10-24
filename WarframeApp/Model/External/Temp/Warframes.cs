using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeApp.Model.Json
{
    class Warframes
    {
        public string uniqueName { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int health { get; set; }
        public int shield { get; set; }
        public int armor { get; set; }
        public int stamina { get; set; }
        public int power { get; set; }
        public string passiveDescription { get; set; }
        public Ability[] abilities { get; set; }
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
        public string aura { get; set; }
        public bool conclave { get; set; }
        public int color { get; set; }
        public string introduced { get; set; }
        public int masteryReq { get; set; }
        public string[] polarities { get; set; }
        public string sex { get; set; }
        public float sprint { get; set; }
        public string wikiaThumbnail { get; set; }
        public string wikiaUrl { get; set; }
        public object vaulted { get; set; }
        public string releaseDate { get; set; }
        public string vaultDate { get; set; }
        public string estimatedVaultDate { get; set; }

        public class Ability
        {
            public string name { get; set; }
            public string description { get; set; }
        }

        public class Component
        {
            public string uniqueName { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public int itemCount { get; set; }
            public bool tradable { get; set; }
            public string imageName { get; set; }
            public Drop[] drops { get; set; }
            public int ducats { get; set; }
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
    }
}
