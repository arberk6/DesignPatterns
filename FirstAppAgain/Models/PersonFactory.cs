using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAppAgain.Models
{
    public class PersonFactory
    {
        private static Dictionary<string, Person> lista = new Dictionary<string, Person>()
        {
            { "Student",new Student()}  ,
            { "Professor",new Professor()}

    };

        public PersonFactory()
        {
        }

        public static Person createPerson(string tipi)
        {
            //if (p.Type == 1)
            //{
            //    return new Student(p.Name, p.Lastname, p.Age);
            //    //obj = (Student)obj;
            //}
            //else if (p.Type == 2)
            //{
            //    return new Professor(p.Name, p.Lastname, p.Age);
            //    //obj = (Professor)obj;
            //}

            //rasti i perdorimit te RIP(replace ifs with polymophism)

            return lista[tipi];

        }
    }
}
