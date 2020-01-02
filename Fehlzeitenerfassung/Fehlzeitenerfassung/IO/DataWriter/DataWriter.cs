using Fehlzeitenerfassung.IO.DataWriter.Implementation;

namespace Fehlzeitenerfassung.IO.DataWriter
{
    class DataWriter
    {
        public static IDataWriter<string> FileContentDataWriter { get; private set; }

        public static void Init()
        {
            FileContentDataWriter = new FileContentDataWriter();
        }
    }
}
