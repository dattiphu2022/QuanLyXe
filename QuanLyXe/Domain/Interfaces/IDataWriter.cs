namespace QuanLyXe.Domain.Interfaces
{
    public interface IDataWriter
    {
        bool Write(IEnumerable<IVehicle> datas);
        void Write(IEnumerable<IVehicle> datas, string message);
    }
}