using System.Drawing;

public abstract class CarBase : IVehicle
{
    protected CarBase(
        string name, 
        int serialNumber, 
        int doorCount, 
        Color color)
    {
        VehicleName = name;
        SerialNumber = serialNumber;
        DoorCount = doorCount;
        Color = color;
    }

    public string VehicleName { get; set; } = null!;
    public int SerialNumber { get; set; }
    public int DoorCount { get; set; }
    public Color Color { get; set; }
}
