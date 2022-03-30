using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_03_2022_Classwork_Again.Models
{
    internal abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract int Age { get; set; }
        public abstract void GetInfo();
    }
}
