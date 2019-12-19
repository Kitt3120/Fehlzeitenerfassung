using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.DataWriter
{
    interface IDataWriter
    {
        public void Write(IConvertible data, string[] args);
        void WriteAsync(IConvertible data, string[] args);
    }
}
