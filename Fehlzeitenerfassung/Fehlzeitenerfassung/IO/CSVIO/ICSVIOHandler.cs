using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.CSVIO
{
    interface ICSVIOHandler<T>
    {
        string[] ReadLines(string path);
        Task<string[]> ReadLinesAsync(string path);
        string[][] ParseLines(string[] lines, char splitCharacter);
        List<T> Convert(string[][] parsedLines);
    }
}
