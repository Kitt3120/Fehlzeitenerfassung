using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.DataProvider
{
    interface IDataProvider
    {
        T Provide<T>(string[] args) where T : IConvertible;
        Task<T> ProvideAsync<T>(string[] args) where T : IConvertible;
    }
}
