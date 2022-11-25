using QuanLyXe.Domain.Interfaces;

namespace QuanLyXe.Domain.BaseClasses
{
    internal abstract class ManipulatorBase<T>
        : IManipulator<T>
    {
        public abstract T Manipulate(T data);
        public abstract IEnumerable<T> Manipulate(IEnumerable<T> data);
    }
}