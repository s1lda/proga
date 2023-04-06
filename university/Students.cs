using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    internal class Students
    {
        string firstname;
        string lastname;
        string midllename;
        string data; 
        string group;
        Dictionary<string, int> marks;
        public Students(string firstname,
        string lastname,
        string midllename,
        string data,
        string group,
        Dictionary<string, int> marks)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.midllename = midllename;
            this.data = data;
            this.group = group;
            this.marks = marks;
        }
        public string Firstname { get { return firstname; } }
        public string Lastname { get { return lastname; } }
        public string Middlename { get { return midllename; } }
        public string Group { get { return group; } }
        public Dictionary<string, int> Marks()
        {
            return marks;
        }
    }
}
