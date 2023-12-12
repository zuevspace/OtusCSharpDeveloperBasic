using System.Collections;

namespace ExceptionsAndTheirHandling;

public class Format
{
    public static void FormatData(Severity severity)
    {
        ConsoleSeverity.ConsoleColorEnum(severity);
    }
    public static void FormatData(string message, Severity severity)
    {
        ConsoleSeverity.ConsoleColorEnum(severity);
        Console.WriteLine(message);
        Console.ResetColor();
    }
    public static void FormatData(string message, Severity severity, IDictionary data)
    {
        IDictionary dictionaryDouble = new Dictionary<string, int>(3);
        var listErrorParse = new List<string>();
        var valueDict = "";
        ConsoleSeverity.ConsoleColorEnum(severity);
        
        foreach (DictionaryEntry pair in data)
        {
            valueDict += $"\n{pair.Key} = {pair.Value}";
            
            if (int.TryParse((string?) pair.Value, out var number))
            {
                dictionaryDouble.Add(pair.Key,number);
            }
            else
            {
                listErrorParse.Add((string)pair.Key);
            }
        }
        
        Console.WriteLine(message.Replace("?",$"{string.Join(',',listErrorParse)}" + valueDict));
        Console.ResetColor();
    }
}