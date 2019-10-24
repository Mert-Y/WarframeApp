using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WarframeApp.Model.External.DigitalExtremes.Json;

namespace WarframeApp.Model.External.DigitalExtremes
{
    class Inventory : INotifyPropertyChanged
    {
        private ObservableCollection<Weapon> weapons;
        private ObservableCollection<Resource> resources;
        private ObservableCollection<Warframe> warframes;
        private ObservableCollection<Sentinel> pets;
        private ObservableCollection<Custom> skins;
        private ObservableCollection<Drone> extractors;
        private ObservableCollection<Flavour> animColourGlyphs;
        private ObservableCollection<Upgrade> mods;

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

        public ObservableCollection<Weapon> Weapons
        {
            get
            {
                return weapons;
            }
            set
            {
                if (weapons != value)
                {
                    weapons = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Sentinel> Pets
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

        public ObservableCollection<Upgrade> Mods
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
        
        public ObservableCollection<Custom> Skins
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

        public ObservableCollection<Drone> Extractors
        {
            get
            {
                return extractors;
            }
            set
            {
                if (extractors != value)
                {
                    extractors = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Flavour> AnimColourGlyphs
        {
            get
            {
                return animColourGlyphs;
            }
            set
            {
                if (animColourGlyphs != value)
                {
                    animColourGlyphs = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}