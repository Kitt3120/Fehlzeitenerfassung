using Fehlzeitenerfassung.IO.DataWriter.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.DataWriter
{
    class DataWriter
    {
        public static IDataWriter FileContentDataWriter { get; private set; }

        public static void Init()
        {
            FileContentDataWriter = new FileContentDataWriter();
        }
    }
}
