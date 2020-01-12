using Fehlzeitenerfassung.IO.CSVHandler.Implementation;
using Fehlzeitenerfassung.Structure.Person.Lehrer;
using Fehlzeitenerfassung.Structure.Person.Schueler;
using System.Collections.Generic;
using System.Text;

namespace Fehlzeitenerfassung.IO.CSVHandler
{
    internal class CSVHandler
    {
        public static ICSVHandler<Schueler> SchuelerHandler { get; private set; }
        public static ICSVHandler<Lehrer> LehrerHandler { get; private set; }

        public static void Init()
        {
            SchuelerHandler = new SchuelerCSVHandler();
            LehrerHandler = new LehrerCSVHandler();
        }

        public static string[][] ParseLines(string[] lines, char splitCharacter)
        {
            List<string[]> csvEntries = new List<string[]>();
            foreach (string line in lines)
            {
                string lineModified = line;
                string splitCharacterString = splitCharacter.ToString();

                //In case line ends with splitCharacter, remove redundant char
                if (line.EndsWith(splitCharacterString))
                    lineModified = line.Substring(0, line.Length - 1);

                csvEntries.Add(lineModified.Split(splitCharacter));
            }

            return csvEntries.ToArray();
        }

        public static string[] ComposeLines(string[][] lines, char splitCharacter)
        {
            List<string> composedLines = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string[] parts in lines)
            {
                foreach (string part in parts)
                    stringBuilder.Append(part + splitCharacter);

                composedLines.Add(stringBuilder.ToString());
                stringBuilder.Clear();
            }

            return composedLines.ToArray();
        }
    }
}