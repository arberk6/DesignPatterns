using System;
using System.Collections.Generic;

namespace FirstApp.Models
{
    public partial class Person : PersonFactory
    {
        protected Person(string name, string lastname, int age)
        {
            Name = name;
            Lastname = lastname;
            Age = age;
        }

        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int? Type { get; set; }

        public virtual UserType TypeNavigation { get; set; }
    }
}
