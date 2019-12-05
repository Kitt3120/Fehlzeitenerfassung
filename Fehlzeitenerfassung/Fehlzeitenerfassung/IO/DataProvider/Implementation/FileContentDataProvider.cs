using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.DataProvider.Implementation
{
    class FileContentDataProvider : IDataProvider
    {
        public T Provide<T>(string[] args) where T : IConvertible
        {
            if (args.Length == 0)
                throw new NotImplementedException("args[0] has to be the file path");

            string content = string.Empty;
            using (StreamReader sr = new StreamReader(args[0]))
            {
                while (!sr.EndOfStream)
                    content += $"{sr.ReadLine()}\n";
            }
            return (T)Convert.ChangeType(content, typeof(T));
        }

        public async Task<T> ProvideAsync<T>(string[] args) where T : IConvertible
        {
            if (args.Length == 0)
                throw new NotImplementedException("args[0] has to be the file path");

            string content = string.Empty;
            using (StreamReader sr = new StreamReader(args[0]))
            {
                while (!sr.EndOfStream)
                    content += $"{await sr.ReadLineAsync()}\n";
            }
            return (T)Convert.ChangeType(content, typeof(T));
        }
    }
}
