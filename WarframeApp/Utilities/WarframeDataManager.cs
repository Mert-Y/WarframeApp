using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;
using WarframeApp.Model.External.WFCDData;
using WarframeApp.Model.External.WFCDData.Json;

namespace WarframeApp.Utilities
{
    static class WarframeDataManager
    {
        private static Type TypeOf<T>()
        {
            Type type = typeof(T);
            if (type.Name.Contains("List"))
            {
                type = type.GenericTypeArguments[0];
            }
            return type;
        }

        #region Set Inventory to local for Json parse should serialize
        private static void Localize(dynamic items)
        {
            if (items != null)
            {
                Type type = items.GetType();
                if (type.Name.Contains("List") || type.Name.Contains("ObservableCollection"))
                {
                    type = type.GenericTypeArguments[0];
                }
                var className = type.Name;
                var baseClassName = type.BaseType.Name;

                bool isComponent = className.Equals("ItemBuildable");

                if (className.Equals("ItemMasterable") || baseClassName.Equals("ItemMasterable")
                    || className.Equals("ItemBuildable") || baseClassName.Equals("ItemBuildable"))
                {
                    foreach (var item in items)
                    {
                        item.IsExternal = false;
                        item.IsComponent = isComponent;
                        Localize(item.components);
                    }
                }
                else if (className.Equals("Item") || baseClassName.Equals("Item"))
                {
                    foreach (var item in items)
                    {
                        item.IsExternal = false;
                    }
                }
            }
        }

        private static void LocalizeInventory(Inventory inventory)
        {
            Localize(inventory.Arcanes);
            Localize(inventory.Archwings);
            Localize(inventory.Fishes);
            Localize(inventory.Gear);
            Localize(inventory.Glyphs);
            Localize(inventory.Melees);
            Localize(inventory.Misc);
            Localize(inventory.Mods);
            Localize(inventory.Pets);
            Localize(inventory.Primaries);
            Localize(inventory.Quests);
            Localize(inventory.Relics);
            Localize(inventory.Resources);
            Localize(inventory.Secondaries);
            Localize(inventory.Sentinels);
            Localize(inventory.Sigils);
            Localize(inventory.Skins);
            Localize(inventory.Warframes);
        }
        #endregion

        //This looks bad, can't think of a better way right now.
        #region SyncComponentsWithWeapon
        private static ItemBuildable SearchArrayForComponent(dynamic array, string compUniqueNameToFind)
        {
            if (array != null)
            {
                foreach (var item in array)
                {
                    if (compUniqueNameToFind.Equals(item.uniqueName))
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        private static ItemBuildable SearchBuildablesForComponent(Inventory inv, string compUniqueNameToFind)
        {
            ItemBuildable item = null;
            if (inv != null)
            {
                item = SearchArrayForComponent(inv.Archwings, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Gear, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Melees, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Misc, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Pets, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Primaries, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Quests, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Relics, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Resources, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Secondaries, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Sentinels, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Skins, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
                item = SearchArrayForComponent(inv.Warframes, compUniqueNameToFind);
                if (item != null)
                {
                    return item;
                }
            }
            return item;
        }

        private static void SyncComponentsWithWeaponSub(Inventory inv, dynamic array)
        {
            if (inv != null && array != null)
            {
                foreach (var item in array)
                {
                    if (item.components != null)
                    {
                        for (int i = 0; i < item.components.Count; i++)
                        {
                            dynamic itemFound = SearchBuildablesForComponent(inv, item.components[i].uniqueName);
                            if (itemFound != null)
                            {
                                if (itemFound.subReference == null)
                                {
                                    itemFound.subReference = new List<ItemBuildable>();
                                }
                                if (item.components[i].baseReference == null)
                                {
                                    item.components[i].baseReference = new List<ItemBuildable>();
                                }
                                itemFound.subReference.Add(item.components[i]);
                                item.components[i].baseReference.Add(itemFound);
                            }
                        }
                    }
                }
            }
        }

        private static void SyncComponentsWithWeapon(Inventory inv)
        {
            if (inv != null)
            {
                SyncComponentsWithWeaponSub(inv, inv.Archwings);
                SyncComponentsWithWeaponSub(inv, inv.Gear);
                SyncComponentsWithWeaponSub(inv, inv.Melees);
                SyncComponentsWithWeaponSub(inv, inv.Misc);
                SyncComponentsWithWeaponSub(inv, inv.Pets);
                SyncComponentsWithWeaponSub(inv, inv.Primaries);
                SyncComponentsWithWeaponSub(inv, inv.Quests);
                SyncComponentsWithWeaponSub(inv, inv.Relics);
                SyncComponentsWithWeaponSub(inv, inv.Resources);
                SyncComponentsWithWeaponSub(inv, inv.Secondaries);
                SyncComponentsWithWeaponSub(inv, inv.Sentinels);
                SyncComponentsWithWeaponSub(inv, inv.Skins);
                SyncComponentsWithWeaponSub(inv, inv.Warframes);
            }
        }
        #endregion

        #region Combine userdata with the data retrieved from the net or cache.
        private static void CombineUserData<T>(dynamic userData, dynamic webData)
        {
            if (userData != null && webData != null)
            {
                var className = TypeOf<T>().Name;
                var baseClassName = TypeOf<T>().BaseType.Name;

                if (className.Equals("ItemMasterable") || baseClassName.Equals("ItemMasterable"))
                {
                    for (int i = userData.Count - 1; i >= 0; i--)
                    {
                        for (int j = webData.Count - 1; j >= 0; j--)
                        {
                            if (userData[i].uniqueName == webData[j].uniqueName)
                            {
                                webData[j].NumOwned = userData[i].NumOwned;
                                webData[j].Mastery = userData[i].Mastery;
                                webData[j].FoundryReady = userData[i].FoundryReady;
                                CombineUserData<ItemBuildable>(userData[i].components, webData[j].components);
                                userData.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
                else if (className.Equals("ItemBuildable") || baseClassName.Equals("ItemBuildable"))
                {
                    for (int i = userData.Count - 1; i >= 0; i--)
                    {
                        for (int j = webData.Count - 1; j >= 0; j--)
                        {
                            if (userData[i].uniqueName == webData[j].uniqueName)
                            {
                                webData[j].NumOwned = userData[i].NumOwned;
                                webData[j].FoundryReady = userData[i].FoundryReady;
                                CombineUserData<ItemBuildable>(userData[i].components, webData[j].components);
                                userData.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
                else if (className.Equals("Item") || baseClassName.Equals("Item"))
                {
                    for (int i = userData.Count - 1; i >= 0; i--)
                    {
                        for (int j = webData.Count - 1; j >= 0; j--)
                        {
                            if (userData[i].uniqueName == webData[j].uniqueName)
                            {
                                webData[j].NumOwned = userData[i].NumOwned;
                                userData.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        public static T LoadData<T>() where T : new()
        {
            var className = TypeOf<T>().Name;

            T data = default(T);
            if (className == "Inventory")
            {
                data = new T();
                ((Inventory)(object)data).Arcanes = new ObservableCollection<Arcane>(LoadData<List<Arcane>>());
                ((Inventory)(object)data).Archwings = new ObservableCollection<Archwing>(LoadData<List<Archwing>>());
                ((Inventory)(object)data).Fishes = new ObservableCollection<Fish>(LoadData<List<Fish>>());
                ((Inventory)(object)data).Gear = new ObservableCollection<Gear>(LoadData<List<Gear>>());
                ((Inventory)(object)data).Glyphs = new ObservableCollection<Glyph>(LoadData<List<Glyph>>());
                ((Inventory)(object)data).Melees = new ObservableCollection<Melee>(LoadData<List<Melee>>());
                ((Inventory)(object)data).Misc = new ObservableCollection<Misc>(LoadData<List<Misc>>());
                ((Inventory)(object)data).Mods = new ObservableCollection<Mod>(LoadData<List<Mod>>());
                ((Inventory)(object)data).Pets = new ObservableCollection<Pet>(LoadData<List<Pet>>());
                ((Inventory)(object)data).Primaries = new ObservableCollection<Primary>(LoadData<List<Primary>>());
                ((Inventory)(object)data).Quests = new ObservableCollection<Quest>(LoadData<List<Quest>>());
                ((Inventory)(object)data).Relics = new ObservableCollection<Relic>(LoadData<List<Relic>>());
                ((Inventory)(object)data).Resources = new ObservableCollection<Resource>(LoadData<List<Resource>>());
                ((Inventory)(object)data).Secondaries = new ObservableCollection<Secondary>(LoadData<List<Secondary>>());
                ((Inventory)(object)data).Sentinels = new ObservableCollection<Sentinel>(LoadData<List<Sentinel>>());
                ((Inventory)(object)data).Sigils = new ObservableCollection<Sigil>(LoadData<List<Sigil>>());
                ((Inventory)(object)data).Skins = new ObservableCollection<Skin>(LoadData<List<Skin>>());
                ((Inventory)(object)data).Warframes = new ObservableCollection<Warframe>(LoadData<List<Warframe>>());

                if (CheckCache(Paths.WFCDDataPaths["UserData"]))
                {
                    Inventory userData = (Inventory)(object)LoadFromCache<T>(Paths.WFCDDataPaths["UserData"]);
                    if (userData != null)
                    {
                        #region Combine userdata with the data retrieved from the net or cache.
                        CombineUserData<Arcane>(userData.Arcanes, ((Inventory)(object)data).Arcanes);
                        CombineUserData<Archwing>(userData.Archwings, ((Inventory)(object)data).Archwings);
                        CombineUserData<Fish>(userData.Fishes, ((Inventory)(object)data).Fishes);
                        CombineUserData<Gear>(userData.Gear, ((Inventory)(object)data).Gear);
                        CombineUserData<Glyph>(userData.Glyphs, ((Inventory)(object)data).Glyphs);
                        CombineUserData<Melee>(userData.Melees, ((Inventory)(object)data).Melees);
                        CombineUserData<Misc>(userData.Misc, ((Inventory)(object)data).Misc);
                        CombineUserData<Mod>(userData.Mods, ((Inventory)(object)data).Mods);
                        CombineUserData<Pet>(userData.Pets, ((Inventory)(object)data).Pets);
                        CombineUserData<Primary>(userData.Primaries, ((Inventory)(object)data).Primaries);
                        CombineUserData<Quest>(userData.Quests, ((Inventory)(object)data).Quests);
                        CombineUserData<Relic>(userData.Relics, ((Inventory)(object)data).Relics);
                        CombineUserData<Resource>(userData.Resources, ((Inventory)(object)data).Resources);
                        CombineUserData<Secondary>(userData.Secondaries, ((Inventory)(object)data).Secondaries);
                        CombineUserData<Sentinel>(userData.Sentinels, ((Inventory)(object)data).Sentinels);
                        CombineUserData<Sigil>(userData.Sigils, ((Inventory)(object)data).Sigils);
                        CombineUserData<Skin>(userData.Skins, ((Inventory)(object)data).Skins);
                        CombineUserData<Warframe>(userData.Warframes, ((Inventory)(object)data).Warframes);
                        #endregion
                    }
                }
                LocalizeInventory((Inventory)(object)data);
                SyncComponentsWithWeapon((Inventory)(object)data);
            }
            else if (className == "Arcane" || className == "Archwing" || className == "Fish" || className == "Gear"
                || className == "Glyph" || className == "Melee" || className == "Misc" || className == "Mod"
                || className == "Pet" || className == "Primary" || className == "Quest" || className == "Relic"
                || className == "Resource" || className == "Secondary" || className == "Sentinel" || className == "Sigil"
                || className == "Skin" || className == "Warframe" || className == "Pet")
            {
                data = RetrieveData<T>(className);
            }
            return data;
        }

        public static bool SaveInventory(Inventory inv)
        {
            return SaveToCache<Inventory>(Paths.WFCDDataPaths["UserData"], inv); ;
        }

        private static T RetrieveData<T>(string className)
        {
            if (CheckCache(Paths.WFCDDataPaths["Cache" + className]))
            {
                return LoadFromCache<T>(Paths.WFCDDataPaths["Cache" + className]);
            }
            else
            {
                return DownloadToCache<T>(Paths.WFCDDataPaths["Url" + className]);
            }
        }

        private static bool CheckCache(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            return false;
        }

        private static T LoadFromCache<T>(string path)
        {
            return ParseJson.LoadData<T>(path, 0);
        }

        private static T DownloadToCache<T>(string url)
        {
            string json = HttpClientHelper.GetSingleItemRequest(url, new CancellationToken()).Result;
            T result = ParseJson.Parse<T>(json, 0);
            SaveToCache(Paths.WFCDDataPaths["Cache" + TypeOf<T>().Name], result);
            return result;
        }

        private static bool SaveToCache<T>(string path, T obj)
        {
            return ParseJson.SaveData(path, obj);
        }
    }
}
