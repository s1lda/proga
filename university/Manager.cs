using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    internal class Manager
    {
        string firstname;
        string lastname;
        string midllename;
        string data;
        string levels;
        List<Laws> laws;
        public Manager(string firstname, string lastname, string midllename, string data, string levels, List<Laws> laws)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.midllename = midllename;
            this.data = data;
            this.levels = levels;
            this.laws = laws;
        }
        public string Firstname { get { return firstname; } }
        public string Lastname { get { return lastname; } }
        public string Midllename { get { return midllename; } }
        public List<Laws> Laws { get { return laws; } }
    }
}
