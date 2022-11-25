namespace QuanLyXe.Domain.Interfaces
{
    internal interface IDataWriter
    {
        bool Write(IEnumerable<IVehicle> datas);
        void Write(IEnumerable<IVehicle> datas, string message);
    }
}