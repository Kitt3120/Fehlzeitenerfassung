using System;

namespace Fehlzeitenerfassung.Structure.Person.Lehrer
{
    class Lehrer : Person
    {
        public Fach[] Fächer { get; set; }

        public Lehrer(string name, string vorname, DateTime geburtstag, Fach[] fächer) : base(name, vorname, geburtstag)
        {
            Fächer = fächer;
        }
    }
}
