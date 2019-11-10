using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.Helpers
{
    public class FileHelper
    {
        public static string GetContent(string fileName)
        {
            var filePath = Directory.GetCurrentDirectory() + $"\\Files\\{fileName}";
            if (!File.Exists(filePath)) throw new Exception($"File {fileName} does not exist");
            var content = File.ReadAllText(filePath);
            return content;
        }

        public static IEnumerable<string> GetLines(string fileName)
        {
            var filePath = Directory.GetCurrentDirectory() + $"\\files\\{fileName}";
            if (!File.Exists(filePath)) throw new Exception($"File {fileName} does not exist");
            var lines = File.ReadLines(filePath);
            return lines;
        }

        public static T GetFileContentAs<T>(string fileName)
        {
            var content = GetContent(fileName);
            var instance = JsonConvert.DeserializeObject<T>(content);
            return instance;
        }
    }
}
