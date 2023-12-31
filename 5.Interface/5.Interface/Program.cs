using _5.Interface;

class Program
{
    private static void Main()
    {
        var quadcopter = new Quadcopter();
        Console.WriteLine("-----Проверка метода GetComponents()-----");
        foreach (var copter in quadcopter.GetComponents())
        {
            Console.WriteLine(copter);
        }
        Console.WriteLine("-----Проверка метода Charge()-----");
        quadcopter.Charge();
        Console.WriteLine("-----Проверка метода GetInfo()-----");
        Console.WriteLine(quadcopter.GetInfo());
        Console.WriteLine("-----Проверка метода GetRobotType()-----");
        Console.WriteLine(quadcopter.GetRobotType());
    }
}