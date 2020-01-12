using Fehlzeitenerfassung.IO.DataProvider.Implementation;

namespace Fehlzeitenerfassung.IO.DataProvider
{
    internal class DataProvider
    {
        public static IDataProvider<string> FileContentDataProvider { get; private set; }

        public static void Init()
        {
            FileContentDataProvider = new FileContentDataProvider();
        }
    }
}