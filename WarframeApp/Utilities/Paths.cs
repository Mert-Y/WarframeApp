using System.Collections.Generic;
using System.IO;

namespace WarframeApp.Utilities
{
    static class Paths
    {
        public static string appPath = Directory.GetCurrentDirectory();
        public static string externalDataPath = Path.Combine(appPath, "ExternalData");

        public static string baseUrl = @"http://content.warframe.com/MobileExport/Manifest/";
        public static string WFCDBaseUrl = @"https://raw.githubusercontent.com/WFCD/warframe-items/development/data/json/";
        public static string extension = ".json";

        public static Dictionary<string, string> WFCDDataPaths = new Dictionary<string, string>()
        {
            { "UserData", Path.Combine(appPath, "UserData.json") },
            
            //Prefix Cache for local, Url for external. Used in Datamanager generic method
            { "CacheArcane", Path.Combine(externalDataPath, "Arcanes" + extension)},
            { "CacheArchwing", Path.Combine(externalDataPath, "Archwing" + extension)},
            { "CacheFish", Path.Combine(externalDataPath, "Fish" + extension)},
            { "CacheGear", Path.Combine(externalDataPath, "Gear" + extension)},
            { "CacheGlyph", Path.Combine(externalDataPath, "Glyphs" + extension)},
            { "CacheMelee", Path.Combine(externalDataPath, "Melee" + extension)},
            { "CacheMisc", Path.Combine(externalDataPath, "Misc" + extension)},
            { "CacheMod", Path.Combine(externalDataPath, "Mods" + extension)},
            { "CachePet", Path.Combine(externalDataPath, "Pets" + extension)},
            { "CachePrimary", Path.Combine(externalDataPath, "Primary" + extension)},
            { "CacheQuest", Path.Combine(externalDataPath, "Quests" + extension)},
            { "CacheRelic", Path.Combine(externalDataPath, "Relics" + extension)},
            { "CacheResource", Path.Combine(externalDataPath, "Resources" + extension)},
            { "CacheSecondary", Path.Combine(externalDataPath, "Secondary" + extension)},
            { "CacheSentinel", Path.Combine(externalDataPath, "Sentinels" + extension)},
            { "CacheSigil", Path.Combine(externalDataPath, "Sigils" + extension)},
            { "CacheSkin", Path.Combine(externalDataPath, "Skins" + extension)},
            { "CacheWarframe", Path.Combine(externalDataPath, "Warframes" + extension)},
            { "UrlArcane", WFCDBaseUrl  + "Arcanes"  + extension},
            { "UrlArchwing", WFCDBaseUrl  + "Archwing"  + extension},
            { "UrlFish", WFCDBaseUrl  + "Fish"  + extension},
            { "UrlGear", WFCDBaseUrl  + "Gear"  + extension},
            { "UrlGlyph", WFCDBaseUrl  + "Glyphs"  + extension},
            { "UrlMelee", WFCDBaseUrl  + "Melee"  + extension},
            { "UrlMisc", WFCDBaseUrl  + "Misc"  + extension},
            { "UrlMod", WFCDBaseUrl  + "Mods"  + extension},
            { "UrlPet", WFCDBaseUrl  + "Pets"  + extension},
            { "UrlPrimary", WFCDBaseUrl  + "Primary"  + extension},
            { "UrlQuest", WFCDBaseUrl  + "Quests"  + extension},
            { "UrlRelic", WFCDBaseUrl  + "Relics"  + extension},
            { "UrlResource", WFCDBaseUrl  + "Resources"  + extension},
            { "UrlSecondary", WFCDBaseUrl  + "Secondary"  + extension},
            { "UrlSentinel", WFCDBaseUrl  + "Sentinels"  + extension},
            { "UrlSigil", WFCDBaseUrl  + "Sigils"  + extension},
            { "UrlSkin", WFCDBaseUrl  + "Skins"  + extension},
            { "UrlWarframe", WFCDBaseUrl  + "Warframes"  + extension}
        };

        public static Dictionary<string, string> DEDataPaths = new Dictionary<string, string>()
        {
            { "UserData", Path.Combine(appPath, "UserData.json") },

            //Prefix Cache for local, Url for external. Used in Datamanager generic method
            { "CacheWeapon", Path.Combine(externalDataPath, "Weapons" + extension)},
            { "CacheUpgrade", Path.Combine(externalDataPath, "Upgrades" + extension)},
            { "CacheSentinel", Path.Combine(externalDataPath, "Sentinels" + extension)},
            { "CacheResource", Path.Combine(externalDataPath, "Resources" + extension)},
            { "CacheDrone", Path.Combine(externalDataPath, "Drones" + extension)},
            { "CacheCustom", Path.Combine(externalDataPath, "Customs" + extension)},
            { "CacheFlavour", Path.Combine(externalDataPath, "Flavour" + extension)},
            { "CacheKey", Path.Combine(externalDataPath, "Keys" + extension)},
            { "CacheGear", Path.Combine(externalDataPath, "Gear" + extension)},
            { "CacheRelicArcane", Path.Combine(externalDataPath, "RelicArcane" + extension)},
            { "CacheWarframe", Path.Combine(externalDataPath, "Warframes" + extension)},
            { "CacheRecipe", Path.Combine(externalDataPath, "Recipes" + extension)},
            { "CacheManifest", Path.Combine(externalDataPath, "Manifest" + extension)},
            { "UrlWeapon", baseUrl  + "ExportWeapons"  + extension},
            { "UrlUpgrade", baseUrl  + "ExportUpgrades"  + extension},
            { "UrlSentinel", baseUrl  + "ExportSentinels"  + extension},
            { "UrlResource", baseUrl  + "ExportResources"  + extension},
            { "UrlDrone", baseUrl  + "ExportDrones"  + extension},
            { "UrlCustom", baseUrl  + "ExportCustoms"  + extension},
            { "UrlFlavour", baseUrl  + "ExportFlavour"  + extension},
            { "UrlKey", baseUrl  + "ExportKeys"  + extension},
            { "UrlGear", baseUrl  + "ExportGear"  + extension},
            { "UrlRelicArcane", baseUrl  + "ExportRelicArcane"  + extension},
            { "UrlWarframe", baseUrl  + "ExportWarframes"  + extension},
            { "UrlRecipe", baseUrl  + "ExportRecipes"  + extension},
            { "UrlManifest", baseUrl  + "ExportManifest"  + extension},
            //Implement later
            { "UrlDrops", "https://n8k6e2y6.ssl.hwcdn.net/repos/hnfvc0o3jnfvc873njb03enrf56.html"}
        };
    }
}
