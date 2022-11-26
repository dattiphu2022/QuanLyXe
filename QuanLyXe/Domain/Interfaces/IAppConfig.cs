using Newtonsoft.Json;

namespace QuanLyXe.Domain.Interfaces
{
    public interface IAppConfig
    {
        string DataFileName { get; }
        JsonSerializerSettings JsonSerializerSettings { get; }
    }
}