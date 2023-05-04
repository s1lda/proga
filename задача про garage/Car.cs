using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage
{
    class Car
    {
        string name;
        int id;
        public Car(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public string Name {get{ return name;}  }
        public int Id { get { return id; } }
    }
}
