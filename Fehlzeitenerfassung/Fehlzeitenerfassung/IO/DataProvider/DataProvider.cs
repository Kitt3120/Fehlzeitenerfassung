using Fehlzeitenerfassung.IO.DataProvider.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.DataProvider
{
    class DataProvider
    {
        public static IDataProvider FileContentDataProvider { get; private set; }

        public static void Init()
        {
            FileContentDataProvider = new FileContentDataProvider();
        }
    }
}
