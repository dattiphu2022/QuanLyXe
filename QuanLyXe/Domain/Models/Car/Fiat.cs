using System.Drawing;

public sealed class Fiat : CarBase
{
    public Fiat(string name, int serialNumber, int doorCount, Color color)
        : base(name, serialNumber, doorCount, color)
    {
    }
}
