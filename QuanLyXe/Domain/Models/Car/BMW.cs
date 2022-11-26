using System.Drawing;

public sealed class BMW : CarBase
{
    public BMW(string name, int serialNumber, int doorCount, Color color) 
        : base(name, serialNumber, doorCount, color)
    {
    }
}
