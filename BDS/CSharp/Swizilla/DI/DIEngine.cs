using Swizilla.Helpers;
using Swizilla.RuleEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla.DI
{
    public class DIEngine
    {
        private Dictionary<string, TypeInformation> types;
        public DIEngine() => types = new Dictionary<string, TypeInformation>();
        public void Init()
        {
            types = FileHelper.GetFileContentAs<Dictionary<string, TypeInformation>>("di.json");
        }

        public T GetInstance<T>(List<object> parameters)
        {
            var typeStr = typeof(T).ToString();
            if (!types.ContainsKey(typeStr)) throw new Exception("Type not registered");
            var instance = (T)Activator.CreateInstance(typeof(T), parameters);
            return instance;
        }

        public List<IRule> GetRules(string fileName= "ruledi.txt", string namesp="Swizilla.RuleEngine.DiscountRules.")
        {
            var rules = new List<IRule>();
            var ruleList = FileHelper.GetLines(fileName);
            ruleList.ToList().ForEach(ruleName =>
            {
                var instance = (IRule)Activator.CreateInstance(Type.GetType($"{namesp}{ruleName}"));
                rules.Add(instance);
            });
            return rules;
        }
    }


    public class TypeInformation
    {
        public List<Parameter> parameters { get; set; }
        public TypeInformation() => parameters = new List<Parameter>();
    }
    public class Parameter
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
