namespace Fehlzeitenerfassung.Storage
{
    interface IStorage
    {
        void Store(string key, object obj);
        T Restore<T>(string key);
        bool Exists(string key);
    }
}
