using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfassessment2
{
    internal class student
    {
        public int id;
        public string name;
        public int age;
        public string description;
        public student (int id, string name, int age ,string description) {
            this.id = id;
            this.name = name;
            this.age = age;
            this.description = description;
        }
    }

}
