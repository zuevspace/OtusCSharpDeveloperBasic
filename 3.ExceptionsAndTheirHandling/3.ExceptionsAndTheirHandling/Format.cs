using System.Collections;

namespace ExceptionsAndTheirHandling;

public class Format
{
    public static void FormatData(string message, Severity severity, IDictionary data)
    {
        var separator = new string('-', 50);
        
        foreach (DictionaryEntry pair in data)
        {
            try
            {
                var num = double.Parse((string) pair.Value);
            }
            catch (FormatException e)
            {
                ConsoleSeverity.ConsoleColorEnum(severity);
                var formatError = separator + $"\nНеверный формат параметра {(string) pair.Value}\n" + separator + message;
                
                throw new FormatException(formatError + e);
            }
            finally
            {
                Console.ResetColor();
            }
        }
    }
    // public static IDictionary FormatData(string message, Severity severity, IDictionary data)
    // {
    //     IDictionary dicAbcInt = new Dictionary<string, double>();
    //     var listErrorParse = new List<string>();
    //     
    //     foreach (DictionaryEntry pair in data)
    //     {
    //         if (double.TryParse((string)pair.Value!, out var number))
    //         {
    //             dicAbcInt.Add(pair.Key, number);
    //         }
    //         else
    //         {
    //             listErrorParse.Add((string)pair.Key);
    //         }
    //     }
    //
    //     if (listErrorParse.Count == 0) return dicAbcInt;
    //     
    //     ConsoleSeverity.ConsoleColorEnum(severity);
    //     
    //     Console.WriteLine(new string('-',50) +
    //                       $"\nНеверный формат параметра {string.Join(',',listErrorParse)}\n" +
    //                       new string('-',50) +
    //                       message);
    //     data.Clear();
    //     dicAbcInt.Clear();
    //     Console.ResetColor();
    //     Run.Discriminant();
    //     return dicAbcInt;
    //     //throw new FormatException();
    // }
}