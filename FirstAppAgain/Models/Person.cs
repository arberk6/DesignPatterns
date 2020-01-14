using System;
using System.Collections.Generic;

namespace FirstAppAgain.Models
{
    public partial class Person
    {
        public Person(string name, string lastname, int age)
        {
            Name = name;
            LastName = lastname;
            Age = age;
        }

        public Person() { }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int? Type { get; set; }

        public virtual UserType TypeNavigation { get; set; }
    }
}
