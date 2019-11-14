using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.Structure.Person.Schueler
{
    class Fehlzeit
    {
        public DateTime Datum { get; set; }
        public int Fehlstunden { get; set; }
        public int EntschuldigteStunden { get; set; }
        public int UnentschuldigteStunden { get
            {
                return Fehlstunden - EntschuldigteStunden;
            } }
        public bool Entschuldigt { get
            {
                return Fehlstunden == EntschuldigteStunden;
            } }

        public Fehlzeit(DateTime datum, int fehlstunden, int entschuldigteStunden)
        {
            Datum = datum.Date; //Entfernt Zeit
            Fehlstunden = fehlstunden;
            EntschuldigteStunden = entschuldigteStunden;
        }

        public Fehlzeit(DateTime datum, int fehlstunden, bool entschuldigt)
        {
            Datum = datum.Date; //Entfernt Zeit
            Fehlstunden = fehlstunden;
            EntschuldigteStunden = (entschuldigt ? fehlstunden : 0);
        }

        public override string ToString()
        {
            return $"Am {Datum}, {Fehlstunden} Fehlstunden, davon Entschuldigt: {EntschuldigteStunden}";
        }
    }
}
