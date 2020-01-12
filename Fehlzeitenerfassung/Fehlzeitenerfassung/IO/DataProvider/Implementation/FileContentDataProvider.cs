using System;
using System.IO;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.DataProvider.Implementation
{
    internal class FileContentDataProvider : IDataProvider<string>
    {
        public string Provide(string[] args)
        {
            if (args.Length == 0)
                throw new ArgumentException("args[0] has to be the file path");

            string content = string.Empty;
            using (StreamReader sr = new StreamReader(args[0]))
            {
                while (!sr.EndOfStream)
                    content += $"{sr.ReadLine()}\n";
            }
            return (string)Convert.ChangeType(content, typeof(string));
        }

        public async Task<string> ProvideAsync(string[] args)
        {
            if (args.Length == 0)
                throw new ArgumentException("args[0] has to be the file path");

            string content = string.Empty;
            using (StreamReader sr = new StreamReader(args[0]))
            {
                while (!sr.EndOfStream)
                    content += $"{await sr.ReadLineAsync()}\n";
            }
            content = content.Substring(0, content.Length - 1);
            return (string)Convert.ChangeType(content, typeof(string));
        }
    }
}