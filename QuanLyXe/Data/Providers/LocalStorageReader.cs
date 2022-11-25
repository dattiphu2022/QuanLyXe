using Newtonsoft.Json;
using QuanLyXe.Domain.BaseClasses;
using QuanLyXe.Domain.Interfaces;

namespace QuanLyXe.Providers
{
    internal class LocalStorageReader : DataReaderBase
    {
        private readonly IAppConfig config;

        public LocalStorageReader(IAppConfig config)
        {
            this.config = config;
        }
        public override async Task<IEnumerable<IVehicle>> GetAllAsync()
        {
            IEnumerable<IVehicle> xes = new List<IVehicle>();

            if (File.Exists(config.DataFileName))
            {
                var jsonText = await File.ReadAllTextAsync(config.DataFileName);
                if (jsonText is not null)
                {
                    try
                    {
                        xes = JsonConvert.DeserializeObject<IEnumerable<IVehicle>>(jsonText, config.JsonSerializerSettings) ?? new List<IVehicle>();
                    }
                    catch (Exception ex)
                    {
                        //TODO: log Ex
                    }
                }
            }

            return xes;
        }
    }
}
