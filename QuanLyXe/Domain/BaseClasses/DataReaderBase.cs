using QuanLyXe.Domain.Interfaces;

namespace QuanLyXe.Domain.BaseClasses
{
    public abstract class DataReaderBase : IDataReader
    {
        public abstract Task<IEnumerable<IVehicle>> GetAllAsync();
        public IEnumerable<IVehicle> GetAll()
        {
            return GetAllAsync().GetAwaiter().GetResult();
        }
    }
}