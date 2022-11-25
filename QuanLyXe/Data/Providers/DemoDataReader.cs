using QuanLyXe.Domain.BaseClasses;
using System.Drawing;

namespace QuanLyXe.Providers
{
    internal class DemoDataReader : DataReaderBase
    {
        public override Task<IEnumerable<IVehicle>> GetAllAsync()
        {
            List<IVehicle> vehicleList = new List<IVehicle>();

            Toyota toyota = new Toyota(name: "Toyota", serialNumber: 111111, doorCount: 4, color: Color.RebeccaPurple);
            BMW bmw = new BMW(name: "BMW", serialNumber: 111112, doorCount: 2, color: Color.Red);
            Fiat fiat = new Fiat(name: "Fiat", serialNumber: 111113, doorCount: 4, color: Color.Blue);
            Dream dream = new Dream(name: "Dream", serialNumber: 222222, color: Color.Yellow);
            Spacy spacy = new Spacy(name: "Spacy", serialNumber: 222223, color: Color.Black);

            vehicleList.Add(toyota);
            vehicleList.Add(bmw);
            vehicleList.Add(fiat);
            vehicleList.Add(dream);
            vehicleList.Add(spacy);

            return Task.FromResult((IEnumerable<IVehicle>)vehicleList);
        }
    }
}
