using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeApp.Model.Json
{
    class Archwing
    {
        public string name { get; set; }
        public string uniqueName { get; set; }
        public float secondsPerShot { get; set; }
        public float[] damagePerShot { get; set; }
        public int magazineSize { get; set; }
        public float reloadTime { get; set; }
        public int totalDamage { get; set; }
        public int damagePerSecond { get; set; }
        public string trigger { get; set; }
        public string description { get; set; }
        public float accuracy { get; set; }
        public float criticalChance { get; set; }
        public float criticalMultiplier { get; set; }
        public float procChance { get; set; }
        public float fireRate { get; set; }
        public int chargeAttack { get; set; }
        public int spinAttack { get; set; }
        public int leapAttack { get; set; }
        public int wallAttack { get; set; }
        public int slot { get; set; }
        public string noise { get; set; }
        public bool sentinel { get; set; }
        public int masteryReq { get; set; }
        public float omegaAttenuation { get; set; }
        public int buildPrice { get; set; }
        public int buildTime { get; set; }
        public int skipBuildTimePrice { get; set; }
        public int buildQuantity { get; set; }
        public bool consumeOnBuild { get; set; }
        public Component[] components { get; set; }
        public string imageName { get; set; }
        public string category { get; set; }
        public bool tradable { get; set; }
        public string damage { get; set; }
        public Damagetypes damageTypes { get; set; }
        public int marketCost { get; set; }
        public string[] polarities { get; set; }
        public string[] tags { get; set; }
        public bool vaulted { get; set; }
        public string wikiaThumbnail { get; set; }
        public string wikiaUrl { get; set; }
        public int disposition { get; set; }
        public int health { get; set; }
        public int shield { get; set; }
        public int armor { get; set; }
        public int stamina { get; set; }
        public int power { get; set; }
        public Ability[] abilities { get; set; }
        public string type { get; set; }
        public Patchlog[] patchlogs { get; set; }
        public string projectile { get; set; }
        public int statusChance { get; set; }
        public string releaseDate { get; set; }
        public string vaultDate { get; set; }
        public string estimatedVaultDate { get; set; }

        public class Damagetypes
        {
            public float impact { get; set; }
            public float slash { get; set; }
            public float puncture { get; set; }
            public int radiation { get; set; }
            public int magnetic { get; set; }
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
            public int secondsPerShot { get; set; }
            public float[] damagePerShot { get; set; }
            public int magazineSize { get; set; }
            public int reloadTime { get; set; }
            public int totalDamage { get; set; }
            public int damagePerSecond { get; set; }
            public string trigger { get; set; }
            public int accuracy { get; set; }
            public float criticalChance { get; set; }
            public int criticalMultiplier { get; set; }
            public float procChance { get; set; }
            public int fireRate { get; set; }
            public int chargeAttack { get; set; }
            public int spinAttack { get; set; }
            public int leapAttack { get; set; }
            public int wallAttack { get; set; }
            public int slot { get; set; }
            public string noise { get; set; }
            public bool sentinel { get; set; }
            public int masteryReq { get; set; }
            public float omegaAttenuation { get; set; }
            public int ducats { get; set; }
        }

        public class Drop
        {
            public string location { get; set; }
            public string type { get; set; }
            public string rarity { get; set; }
            public float chance { get; set; }
        }

        public class Ability
        {
            public string name { get; set; }
            public string description { get; set; }
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
