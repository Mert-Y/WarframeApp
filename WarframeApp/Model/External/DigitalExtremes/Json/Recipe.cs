namespace WarframeApp.Model.External.DigitalExtremes.Json
{
    class Recipe
    {
        public string uniqueName { get; set; }
        public string resultType { get; set; }
        public int buildPrice { get; set; }
        public int buildTime { get; set; }
        public int skipBuildTimePrice { get; set; }
        public bool consumeOnUse { get; set; }
        public int num { get; set; }
        public bool codexSecret { get; set; }
        public Ingredient[] ingredients { get; set; }
        public Secretingredient[] secretIngredients { get; set; }
        public string visibility { get; set; }
        public bool alwaysAvailable { get; set; }

        public class Ingredient
        {
            public string ItemType { get; set; }
            public int ItemCount { get; set; }
            public string ProductCategory { get; set; }
        }

        public class Secretingredient
        {
            public string ItemType { get; set; }
            public int ItemCount { get; set; }
        }
    }
}
