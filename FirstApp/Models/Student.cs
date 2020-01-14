using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class Student : Person
    {
        // public override UserType TypeNavigation { get => base.TypeNavigation; set => base.TypeNavigation = value; }

        public Student(string name, string lastname, int age) : base(name, lastname, age)
        {

        }
    }
}
