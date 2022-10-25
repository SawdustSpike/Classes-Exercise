using System.Runtime.InteropServices;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Fit";
            myCar.Year = 2016;
            var carList = new List<Car>();
            carList.Add(myCar);
            Console.WriteLine($"I am currently driving a {myCar.Make} {myCar.Model} that was manufactured in {myCar.Year}");
            foreach (var thing in carList)
            {
                Console.WriteLine(thing.Make);
                Console.WriteLine(thing.Model);
                Console.WriteLine(thing.Year);
            }

        }
    }
}
