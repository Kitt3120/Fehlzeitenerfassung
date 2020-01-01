using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.DataProvider
{
    interface IDataProvider<T> where T : IConvertible
    {
        T Provide(string[] args);
        Task<T> ProvideAsync(string[] args);
    }
}
