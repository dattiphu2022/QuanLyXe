using QuanLyXe.Domain.BaseClasses;

namespace QuanLyXe.Data.Manipulators
{
    public class DoubleDoorCountManipulator
        : ManipulatorBase<IVehicle>
    {
        public override IVehicle Manipulate(IVehicle data)
        {
            MultipleDoorCountBy(vehicle: data, by: 2);

            return data;
        }

        public override IEnumerable<IVehicle> Manipulate(IEnumerable<IVehicle> data)
        {
            foreach (IVehicle item in data)
            {
                MultipleDoorCountBy(vehicle: item, by: 2);
            }

            return data;
        }

        private void MultipleDoorCountBy(IVehicle vehicle, int by)
        {
            vehicle.DoorCount = vehicle.DoorCount * by;
        }
    }
}
