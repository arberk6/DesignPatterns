using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class PersonFactory
    {
        static Dictionary<string, Person> person = new Dictionary<string, Person>() {
             { "Student",new Student()},
             { "Professor",new Professor()}
        };

        public PersonFactory()
        {
        }

        public static Person getPerson(string type)
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
