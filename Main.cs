using AlgoUni_Tasks;
using System.Diagnostics.Metrics;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        car.StartEngine();
        car.ActivateTurbo();
        car.StopEngine();
        Bike bike = new Bike();
        bike.StartEngine();
        bike.ActivateTurbo();
        bike.StopEngine();

    }
}