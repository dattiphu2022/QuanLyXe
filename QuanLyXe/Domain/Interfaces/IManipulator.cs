namespace QuanLyXe.Domain.Interfaces
{
    internal interface IManipulator<T>
    {
        T Manipulate(T data);
        IEnumerable<T> Manipulate(IEnumerable<T> datas);
    }
}