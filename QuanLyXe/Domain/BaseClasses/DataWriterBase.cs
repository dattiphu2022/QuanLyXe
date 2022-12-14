using QuanLyXe.Domain.Interfaces;

namespace QuanLyXe.Domain.BaseClasses
{
    public abstract class DataWriterBase : IDataWriter
    {
        public abstract bool Write(IEnumerable<IVehicle> datas);
        public abstract void Write(IEnumerable<IVehicle> datas, string message);
    }
}