using QuanLyXe.Domain.BaseClasses;

namespace QuanLyXe.Data.Manipulators
{
    internal class HalfDoorCountManipulator
        : ManipulatorBase<IVehicle>
    {
        public override IVehicle Manipulate(IVehicle data)
        {
            DevideDoorCountBy(vehicle: data, by: 2);
            
            return data;
        }

        public override IEnumerable<IVehicle> Manipulate(IEnumerable<IVehicle> data)
        {
            foreach (IVehicle item in data)
            {
                DevideDoorCountBy(vehicle: item, by: 2);
            }

            return data;
        }

        private void DevideDoorCountBy(IVehicle vehicle, int by)
        {
            if (by == 0)
            {
                throw new DivideByZeroException();
            }
            vehicle.DoorCount = vehicle.DoorCount / by;
        }
    }
}
