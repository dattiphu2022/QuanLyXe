namespace QuanLyXe.Domain.Interfaces
{
    public interface IDataReader
    {
        IEnumerable<IVehicle> GetAll();
        Task<IEnumerable<IVehicle>> GetAllAsync();
    }
}