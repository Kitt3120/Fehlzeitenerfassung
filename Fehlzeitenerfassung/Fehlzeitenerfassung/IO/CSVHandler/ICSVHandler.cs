using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.CSVHandler
{
    interface ICSVHandler<T>
    {
        List<T> Convert(string[][] parsedLines);
    }
}
