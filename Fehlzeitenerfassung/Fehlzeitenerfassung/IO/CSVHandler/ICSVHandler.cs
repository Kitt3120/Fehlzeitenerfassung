using System.Collections.Generic;

namespace Fehlzeitenerfassung.IO.CSVHandler
{
    internal interface ICSVHandler<T>
    {
        List<T> Convert(string[][] parsedLines);

        string[][] Revert(List<T> data);
    }
}