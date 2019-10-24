using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeApp.Model.Json
{
    class Glyphs
    {
            public string uniqueName { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string type { get; set; }
            public string imageName { get; set; }
            public string category { get; set; }
            public bool tradable { get; set; }
            public Patchlog[] patchlogs { get; set; }

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
