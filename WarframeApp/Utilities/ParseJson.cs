using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace WarframeApp.Utilities
{
    static class ParseJson
    {
        public static T LoadData<T>(string path, int skipRoot)
        {
            string json;
            using (StreamReader r = new StreamReader(path))
            {
                json = r.ReadToEnd();
            }
            if (IsValidJson(json))
            {
                return Parse<T>(json, skipRoot);
            }
            return default(T);
        }

        public static bool SaveData<T>(string path, T array)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }

                using (StreamWriter file = File.CreateText(@path))
                {
                    JsonSerializer serializer = new JsonSerializer
                    {
                        Formatting = Formatting.Indented
                    };
                    serializer.Serialize(file, array);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static T Parse<T>(string json, int skipRoot)
        {
            JToken parse;
            if (json.StartsWith("{"))
            {
                parse = JObject.Parse(json);
            }
            else
            {
                parse = JArray.Parse(json);
            }
            for (int i = 0; i < skipRoot; i++)
            {
                parse = parse.First;
            }
            return parse.ToObject<T>();
        }

        private static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) ||
                (strInput.StartsWith("[") && strInput.EndsWith("]")))
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


    }
}
