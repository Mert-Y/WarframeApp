using WarframeApp.Model.External.WFCDData.Json.Subclasses;

namespace WarframeApp.Model.External.WFCDData.Json
{
    class Archwing : ItemMasterable
    {
        public float secondsPerShot { get; set; }
        public float[] damagePerShot { get; set; }
        public int magazineSize { get; set; }
        public float reloadTime { get; set; }
        public int totalDamage { get; set; }
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

        #region  Used for storing full webdata vs cutdown userdata
        public bool ShouldSerializesecondsPerShot()
        {
            return IsExternal;
        }

        public bool ShouldSerializedamagePerShot()
        {
            return IsExternal;
        }

        public bool ShouldSerializemagazineSize()
        {
            return IsExternal;
        }

        public bool ShouldSerializereloadTime()
        {
            return IsExternal;
        }

        public bool ShouldSerializetotalDamage()
        {
            return IsExternal;
        }

        public bool ShouldSerializedamagePerSecond()
        {
            return IsExternal;
        }

        public bool ShouldSerializetrigger()
        {
            return IsExternal;
        }

        public bool ShouldSerializeaccuracy()
        {
            return IsExternal;
        }

        public bool ShouldSerializecriticalChance()
        {
            return IsExternal;
        }

        public bool ShouldSerializecriticalMultiplier()
        {
            return IsExternal;
        }

        public bool ShouldSerializeprocChance()
        {
            return IsExternal;
        }

        public bool ShouldSerializefireRate()
        {
            return IsExternal;
        }

        public bool ShouldSerializechargeAttack()
        {
            return IsExternal;
        }

        public bool ShouldSerializespinAttack()
        {
            return IsExternal;
        }

        public bool ShouldSerializeleapAttack()
        {
            return IsExternal;
        }

        public bool ShouldSerializewallAttack()
        {
            return IsExternal;
        }

        public bool ShouldSerializeslot()
        {
            return IsExternal;
        }

        public bool ShouldSerializenoise()
        {
            return IsExternal;
        }

        public bool ShouldSerializesentinel()
        {
            return IsExternal;
        }

        public bool ShouldSerializemasteryReq()
        {
            return IsExternal;
        }

        public bool ShouldSerializeomegaAttenuation()
        {
            return IsExternal;
        }

        public bool ShouldSerializedamage()
        {
            return IsExternal;
        }

        public bool ShouldSerializedamageTypes()
        {
            return IsExternal;
        }

        public bool ShouldSerializemarketCost()
        {
            return IsExternal;
        }

        public bool ShouldSerializepolarities()
        {
            return IsExternal;
        }

        public bool ShouldSerializetags()
        {
            return IsExternal;
        }

        public bool ShouldSerializevaulted()
        {
            return IsExternal;
        }

        public bool ShouldSerializewikiaThumbnail()
        {
            return IsExternal;
        }

        public bool ShouldSerializewikiaUrl()
        {
            return IsExternal;
        }

        public bool ShouldSerializedisposition()
        {
            return IsExternal;
        }

        public bool ShouldSerializehealth()
        {
            return IsExternal;
        }

        public bool ShouldSerializeshield()
        {
            return IsExternal;
        }

        public bool ShouldSerializearmor()
        {
            return IsExternal;
        }

        public bool ShouldSerializestamina()
        {
            return IsExternal;
        }

        public bool ShouldSerializepower()
        {
            return IsExternal;
        }

        public bool ShouldSerializeabilities()
        {
            return IsExternal;
        }

        public bool ShouldSerializeprojectile()
        {
            return IsExternal;
        }

        public bool ShouldSerializestatusChance()
        {
            return IsExternal;
        }

        public bool ShouldSerializereleaseDate()
        {
            return IsExternal;
        }

        public bool ShouldSerializevaultDate()
        {
            return IsExternal;
        }

        public bool ShouldSerializeestimatedVaultDate()
        {
            return IsExternal;
        }
        #endregion
    }
}