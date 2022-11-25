using Newtonsoft.Json;

namespace QuanLyXe.Domain.Interfaces
{
    internal interface IAppConfig
    {
        string DataFileName { get; }
        JsonSerializerSettings JsonSerializerSettings { get; }
    }
}