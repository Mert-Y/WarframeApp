﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeApp.Model.Json
{
    class Secondary
    {
        public string name { get; set; }
        public string uniqueName { get; set; }
        public float secondsPerShot { get; set; }
        public float[] damagePerShot { get; set; }
        public int magazineSize { get; set; }
        public float reloadTime { get; set; }
        public float totalDamage { get; set; }
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
        public int ammo { get; set; }
        public object damage { get; set; }
        public Damagetypes damageTypes { get; set; }
        public object flight { get; set; }
        public string[] polarities { get; set; }
        public string projectile { get; set; }
        public string[] tags { get; set; }
        public bool vaulted { get; set; }
        public string wikiaThumbnail { get; set; }
        public string wikiaUrl { get; set; }
        public int disposition { get; set; }
        public int marketCost { get; set; }
        public string releaseDate { get; set; }
        public string vaultDate { get; set; }
        public string estimatedVaultDate { get; set; }
        public SecondaryShot secondary { get; set; }
        public Secondaryarea secondaryArea { get; set; }
        public int statusChance { get; set; }

        public class Damagetypes
        {
            public int toxin { get; set; }
            public float impact { get; set; }
            public float slash { get; set; }
            public float puncture { get; set; }
            public int blast { get; set; }
            public int cold { get; set; }
            public int heat { get; set; }
            public int electricity { get; set; }
            public int radiation { get; set; }
            public int magnetic { get; set; }
            public int corrosive { get; set; }
        }

        public class SecondaryShot
        {
            public string name { get; set; }
            public Pellet pellet { get; set; }
            public int blast { get; set; }
            public string damage { get; set; }
            public float crit_chance { get; set; }
            public float status_chance { get; set; }
            public float speed { get; set; }
            public float crit_mult { get; set; }
            public string shot_type { get; set; }
            public int? shot_speed { get; set; }
            public float impact { get; set; }
            public float slash { get; set; }
            public float puncture { get; set; }
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
            public int radiation { get; set; }
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
            public string imgUrl { get; set; }
            public string additions { get; set; }
            public string changes { get; set; }
            public string fixes { get; set; }
        }
    }
}
