using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.Structure.Person.Lehrer
{
    class Fach
    {
        string Bezeichnung { get; set; }
        string Kürzel { get; set; }

        public Fach(string bezeichnung, string kürzel)
        {
            Bezeichnung = bezeichnung;
            Kürzel = kürzel;
        }
    }
}
