using System;
using System.Collections.Generic;

namespace FirstAppAgain.Models
{
    public partial class UserType
    {
        public UserType()
        {
            Person = new HashSet<Person>();
        }

        public int Usertypeid { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
