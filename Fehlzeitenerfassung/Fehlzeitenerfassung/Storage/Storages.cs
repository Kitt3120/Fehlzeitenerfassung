using Fehlzeitenerfassung.Storage.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.Storage
{
    class Storages
    {
        public static IStorage InMemoryStorage { get; private set; }

        public static void Init()
        {
            InMemoryStorage = new InMemoryStorage();
        }
    }
}
