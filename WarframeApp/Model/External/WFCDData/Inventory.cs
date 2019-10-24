using Prism.Events;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using WarframeApp.Model.External.WFCDData.Json;
using WarframeApp.Utilities;

namespace WarframeApp.Model.External.WFCDData
{
    class InventoryLoadedEvent : PubSubEvent<Inventory> { }

    class Inventory : INotifyPropertyChanged
    {
        private ObservableCollection<Arcane> arcanes;
        private ObservableCollection<Archwing> archwings;
        private ObservableCollection<Fish> fishes;
        private ObservableCollection<Gear> gear;
        private ObservableCollection<Glyph> glyphs;
        private ObservableCollection<Melee> melees;
        private ObservableCollection<Misc> misc;
        private ObservableCollection<Mod> mods;
        private ObservableCollection<Pet> pets;
        private ObservableCollection<Primary> primaries;
        private ObservableCollection<Quest> quests;
        private ObservableCollection<Relic> relics;
        private ObservableCollection<Resource> resources;
        private ObservableCollection<Secondary> secondaries;
        private ObservableCollection<Sentinel> sentinels;
        private ObservableCollection<Sigil> sigils;
        private ObservableCollection<Skin> skins;
        private ObservableCollection<Warframe> warframes;
        private ObservableCollection<PrimePart> primeParts;

        public ObservableCollection<Arcane> Arcanes
        {
            get
            {
                return arcanes;
            }
            set
            {
                if (arcanes != value)
                {
                    arcanes = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Archwing> Archwings
        {
            get
            {
                return archwings;
            }
            set
            {
                if (archwings != value)
                {
                    archwings = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Fish> Fishes
        {
            get
            {
                return fishes;
            }
            set
            {
                if (fishes != value)
                {
                    fishes = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Gear> Gear
        {
            get
            {
                return gear;
            }
            set
            {
                if (gear != value)
                {
                    gear = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Glyph> Glyphs
        {
            get
            {
                return glyphs;
            }
            set
            {
                if (glyphs != value)
                {
                    glyphs = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Melee> Melees
        {
            get
            {
                return melees;
            }
            set
            {
                if (melees != value)
                {
                    melees = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Misc> Misc
        {
            get
            {
                return misc;
            }
            set
            {
                if (misc != value)
                {
                    misc = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Mod> Mods
        {
            get
            {
                return mods;
            }
            set
            {
                if (mods != value)
                {
                    mods = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Pet> Pets
        {
            get
            {
                return pets;
            }
            set
            {
                if (pets != value)
                {
                    pets = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Primary> Primaries
        {
            get
            {
                return primaries;
            }
            set
            {
                if (primaries != value)
                {
                    primaries = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Quest> Quests
        {
            get
            {
                return quests;
            }
            set
            {
                if (quests != value)
                {
                    quests = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Relic> Relics
        {
            get
            {
                return relics;
            }
            set
            {
                if (relics != value)
                {
                    relics = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Resource> Resources
        {
            get
            {
                return resources;
            }
            set
            {
                if (resources != value)
                {
                    resources = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Secondary> Secondaries
        {
            get
            {
                return secondaries;
            }
            set
            {
                if (secondaries != value)
                {
                    secondaries = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Sentinel> Sentinels
        {
            get
            {
                return sentinels;
            }
            set
            {
                if (sentinels != value)
                {
                    sentinels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Sigil> Sigils
        {
            get
            {
                return sigils;
            }
            set
            {
                if (sigils != value)
                {
                    sigils = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Skin> Skins
        {
            get
            {
                return skins;
            }
            set
            {
                if (skins != value)
                {
                    skins = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Warframe> Warframes
        {
            get
            {
                return warframes;
            }
            set
            {
                if (warframes != value)
                {
                    warframes = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<PrimePart> PrimeParts
        {
            get
            {
                if (primeParts == null)
                {
                    primeParts = new ObservableCollection<PrimePart>(GetPrimeParts(Archwings));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Gear)));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Melees)));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Misc)));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Pets)));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Primaries)));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Quests)));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Relics)));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Resources)));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Secondaries)));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Sentinels)));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Skins)));
                    primeParts = new ObservableCollection<PrimePart>(primeParts.Concat(GetPrimeParts(Warframes)));
                    Extensions.SortObservableCollection(primeParts, x => x.name);
                }
                return primeParts;
            }
            set
            {
                if (primeParts != value)
                {
                    primeParts = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<PrimePart> GetPrimeParts(dynamic itemsArray)
        {
            var array = new ObservableCollection<PrimePart>();

            if (itemsArray == null)
            {
                return array;
            }

            foreach (var item in itemsArray)
            {
                if (item.name.Contains("Prime") && item.components != null)
                {
                    foreach (var component in item.components)
                    {
                        foreach (var name in Language.PartNames)
                        {
                            if (component.name != null && component.name.Contains(name))
                            {
                                array.Add(new PrimePart(item, component));
                                break;
                            }
                        }
                    }
                }
            }
            return array;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool ShouldSerializePrimeParts()
        {
            return false;
        }
    }
}
