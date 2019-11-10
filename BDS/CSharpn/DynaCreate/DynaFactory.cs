using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.XPath;

namespace DynaCreate
{
    class DynaFactory
    {
        private string repositry;

        public DynaFactory(string classRepository)
        {
            if (!File.Exists(classRepository))
                throw new Exception("class repository (" + classRepository + ") does not exits");

            this.repositry = classRepository;
        }

        public string getNodeValue(string name)
        {
            XPathDocument doc = new XPathDocument(repositry);
            XPathNavigator navigator = doc.CreateNavigator();
            XPathNodeIterator nodes = navigator.Select(name);

            if (nodes.Count == 0)
                throw new Exception(name + " not found");

            if (nodes.Count > 1)
                throw new Exception("multiple " + name + " found");

            nodes.MoveNext();
            return nodes.Current.Value;
        }
    }
}
