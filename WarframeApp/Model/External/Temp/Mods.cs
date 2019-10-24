using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeApp.Model.Json
{
    class Mods
    {
            public string uniqueName { get; set; }
            public string name { get; set; }
            public string polarity { get; set; }
            public string rarity { get; set; }
            public int baseDrain { get; set; }
            public int fusionLimit { get; set; }
            public string description { get; set; }
            public string type { get; set; }
            public string imageName { get; set; }
            public string category { get; set; }
            public bool tradable { get; set; }
            public Drop[] drops { get; set; }
            public Patchlog[] patchlogs { get; set; }
            public Upgradeentry[] upgradeEntries { get; set; }
            public Availablechallenge[] availableChallenges { get; set; }

        public class Drop
        {
            public string location { get; set; }
            public string type { get; set; }
            public string rarity { get; set; }
            public float? chance { get; set; }
            public string rotation { get; set; }
        }

        public class Patchlog
        {
            public string name { get; set; }
            public DateTime date { get; set; }
            public string url { get; set; }
            public string imgUrl { get; set; }
            public string additions { get; set; }
            public string changes { get; set; }
            public string fixes { get; set; }
        }

        public class Upgradeentry
        {
            public string tag { get; set; }
            public string prefixTag { get; set; }
            public string suffixTag { get; set; }
            public Upgradevalue[] upgradeValues { get; set; }
        }

        public class Upgradevalue
        {
            public float value { get; set; }
            public string locTag { get; set; }
        }

        public class Availablechallenge
        {
            public string fullName { get; set; }
            public string description { get; set; }
            public Complication[] complications { get; set; }
        }

        public class Complication
        {
            public string fullName { get; set; }
            public string description { get; set; }
            public string overrideTag { get; set; }
        }
    }
}
