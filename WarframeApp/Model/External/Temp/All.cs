using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeApp.Model.Json
{
    class All
    {
        public string uniqueName { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string imageName { get; set; }
        public string category { get; set; }
        public bool tradable { get; set; }
        public int buildPrice { get; set; }
        public int buildTime { get; set; }
        public int skipBuildTimePrice { get; set; }
        public int buildQuantity { get; set; }
        public bool consumeOnBuild { get; set; }
        public Component[] components { get; set; }
        public string polarity { get; set; }
        public string rarity { get; set; }
        public int baseDrain { get; set; }
        public int fusionLimit { get; set; }
        public Patchlog[] patchlogs { get; set; }
        public Drop[] drops { get; set; }
        public float secondsPerShot { get; set; }
        public float[] damagePerShot { get; set; }
        public int magazineSize { get; set; }
        public float reloadTime { get; set; }
        public float totalDamage { get; set; }
        public int damagePerSecond { get; set; }
        public string trigger { get; set; }
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
        public float channeling { get; set; }
        public object damage { get; set; }
        public Damagetypes damageTypes { get; set; }
        public object marketCost { get; set; }
        public string[] polarities { get; set; }
        public string stancePolarity { get; set; }
        public string[] tags { get; set; }
        public object vaulted { get; set; }
        public string wikiaThumbnail { get; set; }
        public string wikiaUrl { get; set; }
        public int disposition { get; set; }
        public int ammo { get; set; }
        public object flight { get; set; }
        public string projectile { get; set; }
        public int health { get; set; }
        public int shield { get; set; }
        public int armor { get; set; }
        public int stamina { get; set; }
        public int power { get; set; }
        public bool alwaysAvailable { get; set; }
        public string releaseDate { get; set; }
        public string vaultDate { get; set; }
        public string estimatedVaultDate { get; set; }
        public Ability[] abilities { get; set; }
        public SecondaryShot secondary { get; set; }
        public Secondaryarea secondaryArea { get; set; }
        public int statusChance { get; set; }
        public string passiveDescription { get; set; }
        public string aura { get; set; }
        public bool conclave { get; set; }
        public int color { get; set; }
        public string introduced { get; set; }
        public string sex { get; set; }
        public float sprint { get; set; }
        public Hexcolour[] hexColours { get; set; }
        public int binCount { get; set; }
        public int binCapacity { get; set; }
        public int fillRate { get; set; }
        public int durability { get; set; }
        public int repairRate { get; set; }
        public int[] capacityMultiplier { get; set; }
        public object[] specialities { get; set; }
        public Upgradeentry[] upgradeEntries { get; set; }
        public Availablechallenge[] availableChallenges { get; set; }
        public string visibility { get; set; }

        public class Damagetypes
        {
            public float impact { get; set; }
            public float slash { get; set; }
            public float puncture { get; set; }
            public int toxin { get; set; }
            public int electricity { get; set; }
            public int blast { get; set; }
            public int radiation { get; set; }
            public int cold { get; set; }
            public int heat { get; set; }
            public int magnetic { get; set; }
            public int corrosive { get; set; }
            public int viral { get; set; }
        }

        public class SecondaryShot
        {
            public string name { get; set; }
            public Pellet pellet { get; set; }
            public int blast { get; set; }
            public string damage { get; set; }
            public float speed { get; set; }
            public float crit_chance { get; set; }
            public float crit_mult { get; set; }
            public float status_chance { get; set; }
            public string shot_type { get; set; }
            public float impact { get; set; }
            public float slash { get; set; }
            public float puncture { get; set; }
            public int? shot_speed { get; set; }
            public float charge_time { get; set; }
            public int radiation { get; set; }
            public int toxin { get; set; }
            public int corrosive { get; set; }
            public int electricity { get; set; }
        }

        public class Pellet
        {
            public string name { get; set; }
            public int count { get; set; }
        }

        public class Secondaryarea
        {
            public string name { get; set; }
            public float status_chance { get; set; }
            public Pellet1 pellet { get; set; }
            public int blast { get; set; }
            public string damage { get; set; }
            public int radius { get; set; }
            public int heat { get; set; }
            public float speed { get; set; }
            public int radiation { get; set; }
            public int duration { get; set; }
        }

        public class Pellet1
        {
            public string name { get; set; }
            public int count { get; set; }
        }

        public class Component
        {
            public string uniqueName { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public int itemCount { get; set; }
            public bool tradable { get; set; }
            public string imageName { get; set; }
            public float secondsPerShot { get; set; }
            public float[] damagePerShot { get; set; }
            public int magazineSize { get; set; }
            public float reloadTime { get; set; }
            public float totalDamage { get; set; }
            public int damagePerSecond { get; set; }
            public string trigger { get; set; }
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
            public int ducats { get; set; }
            public Drop[] drops { get; set; }
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

        public class Drop
        {
            public string location { get; set; }
            public string type { get; set; }
            public string rarity { get; set; }
            public float? chance { get; set; }
            public string rotation { get; set; }
        }

        public class Ability
        {
            public string name { get; set; }
            public string description { get; set; }
        }

        public class Hexcolour
        {
            public string value { get; set; }
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
