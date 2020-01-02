using System.Threading.Tasks;

namespace Fehlzeitenerfassung.IO.DataWriter
{
    interface IDataWriter<T>
    {
        public void Write(T data, string[] args);
        Task WriteAsync(T data, string[] args);
    }
}
