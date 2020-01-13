using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class Professor : Person
    {
        public Professor(string name, string lastname, int age) : base(name, lastname, age)
        {

        }

        public Professor() : base(null, null, -1) { }
    }
}
