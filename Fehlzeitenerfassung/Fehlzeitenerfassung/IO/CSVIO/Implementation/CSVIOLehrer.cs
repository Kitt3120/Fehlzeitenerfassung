using Fehlzeitenerfassung.Structure.Person.Lehrer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.CSVIO.Implementation
{
    class CSVIOLehrer : ICSVIOHandler<Lehrer>
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
