using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    internal class Laws
    {
        string prefix;
        string number;
        string name;
        string content;
        public Laws(string prefix, string number, string name, string content)
        {
            this.prefix = prefix;
            this.number = number;
            this.name = name;
            this.content = content;
        }
        public string Prefix { get { return prefix; } }
        public string Number { get { return number; } }
        public string Name { get { return name; } }
    }
}
