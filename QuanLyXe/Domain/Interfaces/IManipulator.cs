namespace QuanLyXe.Domain.Interfaces
{
    public interface IManipulator<T>
    {
        T Manipulate(T data);
        IEnumerable<T> Manipulate(IEnumerable<T> datas);
    }
}