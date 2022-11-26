using System.Drawing;

public abstract class MotoBase : IVehicle
{
    protected MotoBase(
        string name, 
        int serialNumber, 
        Color color)
    {
        VehicleName = name;
        SerialNumber = serialNumber;
        DoorCount = 0;
        Color = color;
    }

    public string VehicleName { get; set; } = null!;
    public int SerialNumber { get; set; }
    public int DoorCount { get; set; }
    public Color Color { get; set; }
}
