using Newtonsoft.Json;
using QuanLyXe.Domain.Interfaces;

internal class AppConfig : IAppConfig
{
    public string DataFileName { get; set; } = null!;

    public JsonSerializerSettings JsonSerializerSettings { get; set; } = null!;
}