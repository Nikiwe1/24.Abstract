namespace _24.Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle car1 = new vehicle():
            corsa car2 = new corsa();
            Console.WriteLine(car2.wheels);

            Console.ReadLine();
        }
    }
}
abstract class vehicle
{
    public int wheels = 4;
}
class corsa: vehicle
{
    public int sparewheels = 1;
}