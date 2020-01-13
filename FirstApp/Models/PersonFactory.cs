using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class PersonFactory
    {
        private static Dictionary<string, Person> person = new Dictionary<string, Person>();

        public PersonFactory(string name, string lastname, int age)
        {
            person.Add("Student", new Student(name, lastname, age));
            person.Add("Professor", new Professor(name, lastname, age));
        }

        public static Person getPerson(string type, string name, string lastname, int age)
        {
            //if (type.Equals("Professor"))
            //{
            //    return new Professor(name, lastname, age);
            //}
            //else if (type.Equals("Student"))
            //{
            //    return new Student(name, lastname, age);
            //}
            //else
            //{
            //    return null;
            //}

            return person[type];
        }
    }
}
