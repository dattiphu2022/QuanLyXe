using Newtonsoft.Json;
using QuanLyXe.Domain.BaseClasses;
using QuanLyXe.Domain.Interfaces;

namespace QuanLyXe.Providers
{
    internal class LocalStorageReader : DataReaderBase
    {
        public override async Task<IEnumerable<IVehicle>> GetAllAsync()
        {
            IEnumerable<IVehicle> xes = new List<IVehicle>();
        
            return xes;
        }
    }
}
