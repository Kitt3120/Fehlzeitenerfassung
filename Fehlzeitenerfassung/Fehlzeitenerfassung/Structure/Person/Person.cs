using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.Structure.Person
{
    class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public DateTime Geburtstag { get; set; }

        public Person(string name, string vorname, DateTime geburtstag)
        {
            Name = name;
            Vorname = vorname;
            Geburtstag = geburtstag;
        }
    }
}
