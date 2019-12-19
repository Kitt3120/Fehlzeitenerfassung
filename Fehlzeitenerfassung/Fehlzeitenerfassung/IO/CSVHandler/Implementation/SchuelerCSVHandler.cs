using Fehlzeitenerfassung.IO.CSVHandler;
using Fehlzeitenerfassung.Structure.Person.Schueler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.CSVHandler.Implementation
{
    class SchuelerCSVHandler : ICSVHandler<Schueler>
    {
        public List<Schueler> Convert(string[][] parsedLines)
        {
            List<Schueler> schuelerListe = new List<Schueler>();

            foreach (string[] parts in parsedLines)
            {
                string name = parts[0];
                string vorname = parts[1];
                DateTime geburtstag = System.Convert.ToDateTime(parts[2]);
                double anfahrtsweg = double.Parse(parts[3]);
                bool buskarte = parts[4] == "1";
                Schueler schueler = new Schueler(name, vorname, geburtstag, anfahrtsweg, buskarte);

                for (int i = 5; i < parts.Length; i += 3)
                {
                    DateTime datum = System.Convert.ToDateTime(parts[i]);
                    int fehlstunden = int.Parse(parts[i + 1]);
                    int entschuldigteStunden = int.Parse(parts[i + 2]);
                    schueler.RegistriereFehlstunde(datum, fehlstunden, entschuldigteStunden);
                }

                schuelerListe.Add(schueler);
            }

            return schuelerListe;
        }

        public string[][] Revert(List<Schueler> data)
        {
            List<string[]> entityList = new List<string[]>();
            foreach (Schueler schueler in data)
            {
                List<string> entityParts = new List<string>();
                entityParts.Add(schueler.Name);
                entityParts.Add(schueler.Vorname);
                entityParts.Add(schueler.Geburtstag.ToString());
                entityParts.Add(schueler.Anfahrtsweg.ToString());
                entityParts.Add(schueler.Buskarte ? "true" : "false");
                foreach (Fehlzeit fehlzeit in schueler.Fehlzeiten)
                {
                    entityParts.Add(fehlzeit.Datum.ToString());
                    entityParts.Add(fehlzeit.Fehlstunden.ToString());
                    entityParts.Add(fehlzeit.EntschuldigteStunden.ToString());
                }

                entityList.Add(entityParts.ToArray());
            }

            return entityList.ToArray();
        }
    }
}
