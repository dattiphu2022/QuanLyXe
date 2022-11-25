namespace QuanLyXe.Domain.Interfaces
{
    internal interface IDataReader
    {
        IEnumerable<IVehicle> GetAll();
        Task<IEnumerable<IVehicle>> GetAllAsync();
    }
}