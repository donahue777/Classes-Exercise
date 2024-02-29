using System.Xml.Schema;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Subaru";
            myCar.Model = "wrx";
            myCar.Year = 2020;

            var ferrari = new Car()
            {
                Make = "ferrari",
                Model = "SF90",
                Year = 2019
            };

            var ford = new Car("ford", "gt500", 1967);

            var carList = new List<Car>() { myCar, ferrari, ford };

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
