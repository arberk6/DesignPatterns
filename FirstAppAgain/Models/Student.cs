using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAppAgain.Models
{
    public class Student : Person
    {
        public Student(string name, string lastname, int age) : base(name, lastname, age)
        {

        }

        public Student() : base() { }
    }
}
