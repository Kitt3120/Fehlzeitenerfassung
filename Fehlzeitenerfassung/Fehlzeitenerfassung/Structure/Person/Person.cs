using System;

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
        public override string ToString() => $"{Name} {Vorname}";
    }
}
