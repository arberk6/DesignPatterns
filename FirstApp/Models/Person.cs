using System;
using System.Collections.Generic;

namespace FirstApp.Models
{
    public partial class Person
    {
        public Person(string name, string lastname, int age)
        {
            Name = name;
            Lastname = lastname;
            Age = age;
        }

        private int PersonId { get; set; }
        private string Name { get; set; }
        private string Lastname { get; set; }
        private int Age { get; set; }
        private int? Type { get; set; }

        public void setPersonId(int id)
        {
            this.PersonId = id;
        }

        public int getPersonId()
        {
            return this.PersonId;
        }

        //public virtual UserType TypeNavigation { get; set; }
    }
}
