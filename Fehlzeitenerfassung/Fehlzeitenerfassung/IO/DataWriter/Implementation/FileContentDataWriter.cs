using System;
using System.IO;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.DataWriter.Implementation
{
    internal class FileContentDataWriter : IDataWriter<string>
    {
        public void Write(string data, string[] args)
        {
            if (args.Length == 0)
                throw new ArgumentException("args[0] has to be the file path");

            using (StreamWriter writer = new StreamWriter(args[0]))
                writer.Write(data);
        }

        public async Task WriteAsync(string data, string[] args)
        {
            if (args.Length == 0)
                throw new ArgumentException("args[0] has to be the file path");

            using (StreamWriter writer = new StreamWriter(args[0]))
                await writer.WriteAsync(data);
        }
    }
}