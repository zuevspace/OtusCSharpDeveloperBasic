using System.Collections;
using ExceptionsAndTheirHandling;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("a * x^2 + b * x + c = 0");
        try
        {
            IDictionary dictionary = new Dictionary<string, string>(3);
            
            var separator = new string('-', 50);
            var message = "";
            var success = false;
            var a = 0;
            var b = 0;
            var c = 0;
            
            do
            {
                try
                {
                    Console.WriteLine("Введите значение a:");
                    dictionary.Add("a",Console.ReadLine());
                    Console.WriteLine("Введите значение b:");
                    dictionary.Add("b",Console.ReadLine());
                    Console.WriteLine("Введите значение c:");
                    dictionary.Add("c",Console.ReadLine());
                    
                    a = int.Parse((string) dictionary["a"]);
                    b = int.Parse((string) dictionary["b"]);
                    c = int.Parse((string) dictionary["c"]);
                    
                    success = true;
                }
                catch (FormatException)
                {
                    message = separator + $"\nНеверный формат параметра ?\n" + separator;
                    Format.FormatData(message, Severity.Error, dictionary);
                    dictionary.Clear();
                }
                catch (OverflowException)
                {
                    message = $"Значание должно быть в диапозоне: {int.MinValue}-{int.MaxValue}";
                    Format.FormatData(message, Severity.Info);
                    dictionary.Clear();
                }
                
            } while (!success);
            
            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Дискриминант = " + discriminant);

            switch (discriminant)
            {
                case > 0:
                    Console.WriteLine("> 0");
                    var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                    break;
                case 0:
                    Console.WriteLine("=0");
                    var x = (-b) / (2 * a);
                    Console.WriteLine($"x = {x}");
                    break;
                case < 0:
                    Console.WriteLine("< 0");
                    message = "Вещественных значений не найдено";
                    Format.FormatData(message, Severity.Warning);
                    throw new Exception("Вещественных значений не найдено");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}