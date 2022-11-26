using QuanLyXe.Domain.BaseClasses;

namespace QuanLyXe.Data.Manipulators
{
    public class ResetDefaultDoorCountManipulator
        : ManipulatorBase<IVehicle>
    {
        public override IVehicle Manipulate(IVehicle data)
        {
            ResetDoorCount(data);

            return data;
        }

        public override IEnumerable<IVehicle> Manipulate(IEnumerable<IVehicle> data)
        {
            foreach (IVehicle item in data)
            {
                ResetDoorCount(item);
            }

            return data;
        }

        private void ResetDoorCount(IVehicle vehicle)
        {
            if (vehicle is CarBase car)
            {
                vehicle.DoorCount = 4;
            }
        }
    }
}
