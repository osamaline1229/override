using Encapsulation;
namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Corolla", "2018", "red");
            car.;
            car.moveCar();
            Car car2 = new Car("civic", null, "Green");

            car = car2;
            car.color = "Blue";
            //Console.WriteLine(car.model);

            //int[] someNumbers = new int[10];

            //someNumbers.Length = 5;

        }
    }
}







