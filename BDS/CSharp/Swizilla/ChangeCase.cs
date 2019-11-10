using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    public enum Case { Lower, Upper, Pascal, Camel };
    class ChangeCase
    {
        private static Dictionary<Case, Converter> Converters = new Dictionary<Case, Converter>()
            {
                { Case.Lower, LowerCaseConverter },
                { Case.Upper, UpperCaseConverter },
                { Case.Pascal, PascalCaseConverter }
            };

        public delegate string Converter(string[] w);
        public static string Convert(Case @case, string[] words)
        {
            return Converters.ContainsKey(@case) ? Converters[@case](words) : "error";
        }

        public static void AddConverter(Case caseType, Converter converter)
        {
            Converters.Add(caseType, converter);
        }

        static string LowerCaseConverter(string[] w)
        {
            var o = string.Empty;
            for (var i = 0; i < w.Length; i++)
                o += w[i].ToLower();
            return o;
        }
        static string UpperCaseConverter(string[] w)
        {
            var o = string.Empty;
            for (var i = 0; i < w.Length; i++)
            {
                o += Char.ToUpper(w[i][0]);
                o += w[i].Substring(1).ToLower();
            }
            return o;
        }

        static string PascalCaseConverter(string[] w)
        {
            var o = string.Empty;
            for (var i = 0; i < w.Length; i++)
            {
                o += Char.ToUpper(w[i][0]);
                o += w[i].Substring(1).ToLower();
            }
            return o;
        }
    }
}
