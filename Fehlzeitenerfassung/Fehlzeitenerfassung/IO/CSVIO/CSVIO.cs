using Fehlzeitenerfassung.IO.CSVIO.Implementation;
using Fehlzeitenerfassung.Structure.Person.Lehrer;
using Fehlzeitenerfassung.Structure.Person.Schueler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.CSVIO
{
    class CSVIO
    {
        public static ICSVIOHandler<Schueler> SchuelerHandler { get; private set; }
        public static ICSVIOHandler<Lehrer> LehrerHandler { get; private set; }

        public static void Init()
        {
            SchuelerHandler = new CSVIOSchueler();
            LehrerHandler = new CSVIOLehrer();
        }
    }
}
