using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace LeesaUITests
{
    public static class Utilities
    {
        public static string Randomize()
        {
            return System.Guid.NewGuid().ToString().Substring(0, 6);
        }

        public static T CovertJsonToObject<T>(string jsonPath)
        {
            string json = File.ReadAllText(jsonPath);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static Dictionary<string, string> ToDictionary(this Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                for (int count = 0; count < row.Keys.Count; count++)
                {
                    dictionary.Add(row.Keys.ToList()[count], row.Values.ToList()[count]);
                }
            }
            return dictionary;
        }

        public static Tuple<string, string> ReplaceTextInFile(string path)
        {

            var tempFile = Path.GetTempFileName();
            var tempFileHtm = Path.ChangeExtension(tempFile, ".htm");
            var template = File.ReadAllText(path);
            var uniqueId = Guid.NewGuid().ToString();
            var newContent = template.Replace("{{REPLACE_ME_BLOCK}}", $"Run ID: {uniqueId}");
            File.WriteAllText(tempFileHtm, newContent);
            return new Tuple<string, string>(tempFileHtm, uniqueId);
        }

        public static string GetFileNameFromUrl(string hrefLink)
        {
            Uri uri = new Uri(hrefLink);
            return System.IO.Path.GetFileName(uri.LocalPath).Split('/').Last();
        }

        public static int RemoveDollarInCost(string text)
        {
            text = text.Replace("$", "").Replace(",","");
            return int.Parse(text);
        }
    }
}
