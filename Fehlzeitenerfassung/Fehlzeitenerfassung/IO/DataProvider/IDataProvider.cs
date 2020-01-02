using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.DataProvider
{
    interface IDataProvider<T>
    {
        T Provide(string[] args);
        Task<T> ProvideAsync(string[] args);
    }
}
