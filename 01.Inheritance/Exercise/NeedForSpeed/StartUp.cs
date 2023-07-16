namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car(100, 100);
            car.Drive(6);
            System.Console.WriteLine(car.Fuel);
        }
    }
}
