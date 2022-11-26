using Newtonsoft.Json;
using QuanLyXe.Domain.BaseClasses;
using QuanLyXe.Domain.Interfaces;

namespace QuanLyXe.Providers
{
    public class LocalStorageWriter : DataWriterBase
    {
        private readonly IAppConfig config;

        public LocalStorageWriter(IAppConfig config)
        {
            this.config = config;
        }

        public override bool Write(IEnumerable<IVehicle> datas)
        {
            try
            {
                string json = JsonConvert.SerializeObject(datas, config.JsonSerializerSettings);
                File.WriteAllText(config.DataFileName, json);
            }
            catch (Exception)
            {
                //TODO: log ex
                return false;
            }
            return true;
        }

        public override void Write(IEnumerable<IVehicle> datas, string message)
        {
            Write(datas);
        }
    }
}
