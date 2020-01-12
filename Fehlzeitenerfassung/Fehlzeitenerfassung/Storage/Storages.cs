using Fehlzeitenerfassung.Storage.Implementation;

namespace Fehlzeitenerfassung.Storage
{
    internal class Storages
    {
        public static IStorage InMemoryStorage { get; private set; }

        public static void Init()
        {
            InMemoryStorage = new InMemoryStorage();
        }
    }
}