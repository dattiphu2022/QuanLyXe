using Newtonsoft.Json;
using QuanLyXe.Domain.BaseClasses;
using QuanLyXe.Domain.Interfaces;

namespace QuanLyXe.Providers
{
    public class ConsoleWriter : DataWriterBase
    {
        public override bool Write(IEnumerable<IVehicle> datas)
        {
            try
            {
                foreach (IVehicle vehicle in datas)
                {
                    Console.WriteLine($"\t{vehicle.VehicleName}\t{vehicle.SerialNumber}\t{vehicle.DoorCount}\t{vehicle.Color.Name}");
                }
            }
            catch (Exception ex)
            {
                //TODO: log ex
                return false;
            }

            return true;
        }

        public override void Write(IEnumerable<IVehicle> datas, string message)
        {
            Console.WriteLine();
            Console.WriteLine($"<{message}>");

            Write(datas);

            Console.WriteLine($"</{message}>");

        }

    }
}
