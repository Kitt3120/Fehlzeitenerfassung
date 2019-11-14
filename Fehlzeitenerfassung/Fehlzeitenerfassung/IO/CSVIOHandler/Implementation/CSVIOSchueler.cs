using Fehlzeitenerfassung.Structure.Person.Schueler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.CSVIOHandler.Implementation
{
    class CSVIOSchueler : ICSVIOHandler<Schueler>
    {

        public string[] ReadLines(string path)
        {
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                    lines.Add(sr.ReadLine());
            }
            return lines.ToArray();
        }

        public async Task<string[]> ReadLinesAsync(string path)
        {
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                    lines.Add(await sr.ReadLineAsync());
            }
            return lines.ToArray();
        }

        public string[][] ParseLines(string[] lines, char splitCharacter)
        {
            List<string[]> csvEntries = new List<string[]>();
            foreach(string line in lines)
            {
                string lineModified = line;
                string splitCharacterString = splitCharacter.ToString();

                //In case line ends with splitCharacter, remove redundant char
                if (line.EndsWith(splitCharacterString))
                    lineModified = line.Substring(0, line.Length - 1);

                csvEntries.Add(line.Split(splitCharacter));
            }

            return csvEntries.ToArray();
        }

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
    }
}
