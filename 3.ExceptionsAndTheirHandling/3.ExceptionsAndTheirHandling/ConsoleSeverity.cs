namespace ExceptionsAndTheirHandling;

public class ConsoleSeverity
{
    public static void ConsoleColorEnum(Severity severity)
    {
        switch (severity)
        {
            case Severity.Warning:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            case Severity.Error:
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                break;
            default:
                Console.ResetColor();
                break;
        }
    }
}