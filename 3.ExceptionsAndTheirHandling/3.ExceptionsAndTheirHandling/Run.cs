using System.Collections;

namespace ExceptionsAndTheirHandling;

public class Run
{
    public static void Discriminant()
    {
        IDictionary dicAbcString = new Dictionary<string, string>(3);
        //IDictionary formatDataInt = new Dictionary<string, double>(3);
        
        string message = null;
                
        Console.WriteLine("Введите значение a:");
        dicAbcString.Add("a",Console.ReadLine());
        Console.WriteLine("Введите значение b:");
        dicAbcString.Add("b",Console.ReadLine());
        Console.WriteLine("Введите значение c:");
        dicAbcString.Add("c",Console.ReadLine());

        foreach (DictionaryEntry pair in dicAbcString)
        {
            message += $"\n{pair.Key} = {pair.Value}";
            
            if (double.TryParse((string)pair.Value!, out var number))
            {
                dicAbcString[pair.Key] = number;
            }
            else
            {
                Format.FormatData(message, Severity.Error, dicAbcString);
                //listErrorParse.Add((string)pair.Key);
            }
        }
        
        foreach (DictionaryEntry pair in dicAbcString)
        {
            try
            {
                dicAbcString[pair.Key] = double.Parse((string)pair.Value);
            }
            catch (FormatException e)
            {
                Format.FormatData(message, Severity.Error, dicAbcString);
                throw;
            }
        }
        
        //formatDataInt = Format.FormatData(message, Severity.Error, dicAbcString);
        
        var a = (double)dicAbcString["a"];
        var b = (double)dicAbcString["b"];
        var c = (double)dicAbcString["c"];

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
                //Format.FormatData(message, Severity.Warning, dicAbcString);
                throw new Exception("Вещественных значений не найдено");
        }
    }
}