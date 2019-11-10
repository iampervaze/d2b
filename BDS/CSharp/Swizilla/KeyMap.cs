using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Swizilla
{
    class KeyCode
    {
        public static string GetKeyMap(int keycode)
        {
            string code = "";
            switch (keycode)
            {
                case 37:
                    code = "{left}";
                    break;

                case 38:
                    code = "{up}";
                    break;

                case 39:
                    code = "{right}";
                    break;

                case 40:
                    code = "{down}";
                    break;
            }
            return code;
        }

        public static string GetKeyMapNew(int keycode)
        {
            var str = GetContent("keycodes.json");
            var dict = JsonConvert.DeserializeObject<Dictionary<int, string>>(str);
            return dict.ContainsKey(keycode) ? dict[keycode] : "Error";
        }

        public static IEnumerable<string> GetLines(string fileName)
        {
            var filePath = Directory.GetCurrentDirectory() + @"\Files\" + fileName;
            var lines = File.ReadLines(filePath);
            return lines;
        }

        public static string GetContent(string fileName)
        {
            var filePath = Directory.GetCurrentDirectory() + @"\Files\" + fileName;
            var content = File.ReadAllText(filePath);
            return content;
        }
    }
}
