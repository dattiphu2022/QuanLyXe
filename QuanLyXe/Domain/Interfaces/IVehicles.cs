using System.Drawing;

interface IVehicle
{
    string VehicleName { get; set; }
    int SerialNumber { get; set; }
    int DoorCount { get; set; }
    Color Color { get; set; }
}
