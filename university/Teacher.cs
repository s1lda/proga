using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    internal class Teacher
    {
        string firstname;
        string lastname;
        string midllename;
        string data;
        string kafedra;
        List<string> lessons;
        public Teacher(string firstname, string lastname, string midllename, string data, string kafedra, List<string> lessons)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.midllename = midllename;
            this.data = data;
            this.kafedra = kafedra;
            this.lessons = lessons;
        }
        public string Firstname { get { return firstname; } }
        public string Lastname { get { return lastname; } }
        public string Midllename { get { return midllename; } }
        public List<string> Lessons { get { return lessons; } }


    }
}
