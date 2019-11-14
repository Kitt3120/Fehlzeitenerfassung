using Fehlzeitenerfassung.IO.CSVHandler;
using Fehlzeitenerfassung.Structure.Person.Lehrer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.CSVHandler.Implementation
{
    class LehrerCSVHandler : ICSVHandler<Lehrer>
    {
        public List<Lehrer> Convert(string[][] parsedLines)
        {
            List<Lehrer> lehrerListe = new List<Lehrer>();

            foreach (string[] parts in parsedLines)
            {
                string name = parts[0];
                string vorname = parts[1];
                DateTime geburtstag = System.Convert.ToDateTime(parts[2]);

                List<Fach> fächer = new List<Fach>();

                for (int i = 3; i < parts.Length; i += 2)
                {
                    string bezeichnung = parts[i];
                    string kürzel = parts[i + 1];
                    fächer.Add(new Fach(bezeichnung, kürzel));
                }

                lehrerListe.Add(new Lehrer(name, vorname, geburtstag, fächer.ToArray()));
            }

            return lehrerListe;
        }
    }
}
