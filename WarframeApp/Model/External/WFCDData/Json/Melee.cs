namespace WarframeApp.Model.External.WFCDData.Json
{
    class Melee : ItemMasterable
    {
        public float secondsPerShot { get; set; }
        public float[] damagePerShot { get; set; }
        public int magazineSize { get; set; }
        public int reloadTime { get; set; }
        public float totalDamage { get; set; }
        public int damagePerSecond { get; set; }
        public string trigger { get; set; }
        public int accuracy { get; set; }
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
        public string damage { get; set; }
        public Damagetypes damageTypes { get; set; }
        public string[] polarities { get; set; }
        public string stancePolarity { get; set; }
        public string[] tags { get; set; }
        public bool vaulted { get; set; }
        public string wikiaThumbnail { get; set; }
        public string wikiaUrl { get; set; }
        public int disposition { get; set; }
        public object marketCost { get; set; }
        public string releaseDate { get; set; }
        public string vaultDate { get; set; }
        public string estimatedVaultDate { get; set; }
        public string projectile { get; set; }
        public SecondaryShot secondary { get; set; }
        public Secondaryarea secondaryArea { get; set; }

        public class Damagetypes
        {
            public float impact { get; set; }
            public float slash { get; set; }
            public float puncture { get; set; }
            public int corrosive { get; set; }
            public int toxin { get; set; }
            public int radiation { get; set; }
            public int electricity { get; set; }
            public int heat { get; set; }
            public int viral { get; set; }
            public int cold { get; set; }
        }

        public class SecondaryShot
        {
            public string name { get; set; }
            public float speed { get; set; }
            public int impact { get; set; }
            public int slash { get; set; }
            public int puncture { get; set; }
        }

        public class Secondaryarea
        {
            public string name { get; set; }
            public int status_chance { get; set; }
            public int duration { get; set; }
            public int radius { get; set; }
            public float speed { get; set; }
            public int heat { get; set; }
            public string damage { get; set; }
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

        public bool ShouldSerializechanneling()
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

        public bool ShouldSerializepolarities()
        {
            return IsExternal;
        }

        public bool ShouldSerializestancePolarity()
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

        public bool ShouldSerializemarketCost()
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

        public bool ShouldSerializeprojectile()
        {
            return IsExternal;
        }

        public bool ShouldSerializesecondary()
        {
            return IsExternal;
        }

        public bool ShouldSerializesecondaryArea()
        {
            return IsExternal;
        }
        #endregion
    }
}