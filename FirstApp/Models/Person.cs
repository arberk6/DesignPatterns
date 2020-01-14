﻿using System;
using System.Collections.Generic;

namespace FirstApp.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int? Type { get; set; }

        public virtual UserType TypeNavigation { get; set; }
    }
}
