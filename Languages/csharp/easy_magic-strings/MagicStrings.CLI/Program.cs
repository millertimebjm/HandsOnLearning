using System;

namespace MagicStrings.CLI;

public class Program
{
    public static void Main()
    {
        try
        {
            var symbol = CardService.GetSymbol("Jak");
            System.Console.WriteLine($"Jack symbol is {symbol}");
        }
        catch
        {
            System.Console.WriteLine($"Jack symbol was not found.");
        }

        try
        {
            var symbol = CardService.GetSymbol("Heart");
            System.Console.WriteLine($"Heart symbol is {symbol}");
        }
        catch
        {
            System.Console.WriteLine($"Heart symbol was not found.");
        }

        try
        {
            var symbol = CardService.GetSymbol("Clubb");
            System.Console.WriteLine($"Clubb symbol is {symbol}");
        }
        catch
        {
            System.Console.WriteLine($"Club symbol was not found.");
        }

        try
        {
            var symbol = CardService.GetSymbol("Jack");
            System.Console.WriteLine($"Spaide symbol is {symbol}");
        }
        catch
        {
            System.Console.WriteLine($"Spade symbol was not found.");
        }
    }
}