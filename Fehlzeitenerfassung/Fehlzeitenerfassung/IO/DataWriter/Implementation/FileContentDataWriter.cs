using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.DataWriter.Implementation
{
    class FileContentDataWriter : IDataWriter
    {
        public void Write(IConvertible data, string[] args)
        {
            if (args.Length == 0)
                throw new NotImplementedException("args[0] has to be the file path");


            using(StreamWriter writer = new StreamWriter(args[0]))
                writer.Write((string) Convert.ChangeType(data, typeof(string)));
        }

        public async void WriteAsync(IConvertible data, string[] args)
        {
            if (args.Length == 0)
                throw new NotImplementedException("args[0] has to be the file path");

            using (StreamWriter writer = new StreamWriter(args[0]))
                await writer.WriteAsync((string)Convert.ChangeType(data, typeof(string)));
        }
    }
}
