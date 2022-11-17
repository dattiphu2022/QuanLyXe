using System.Drawing;

sealed class Toyota : CarBase
{
    public Toyota(string name, int serialNumber, int doorCount, Color color)
        : base(name, serialNumber, doorCount, color)
    {
    }
}
