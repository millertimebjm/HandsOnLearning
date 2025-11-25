using System;

namespace MagicStrings.CLI;

public class Program
{
    public static void Main()
    {
        foreach (var cardType in (CardTypeEnum[])Enum.GetValues(typeof(CardTypeEnum)))
        {
            try
            {
                var symbol = CardService.GetSymbol(cardType);
                Console.WriteLine($"{cardType} symbol is {symbol}");
            }
            catch
            {
                System.Console.WriteLine($"{cardType} symbol was not found.");
            }
        }

        // Or this solution if you didn't put it into a loop:
        // {
        //     var cardType = CardTypeEnum.Club;
        //     try
        //     {
        //         var symbol = CardService.GetSymbol(cardType);
        //         Console.WriteLine($"{cardType} symbol is {symbol}");
        //     }
        //     catch
        //     {
        //         System.Console.WriteLine($"{cardType} symbol was not found.");
        //     }
        // }

        // {
        //     var cardType = CardTypeEnum.Diamond;
        //     try
        //     {
        //         var symbol = CardService.GetSymbol(cardType);
        //         Console.WriteLine($"{cardType} symbol is {symbol}");
        //     }
        //     catch
        //     {
        //         System.Console.WriteLine($"{cardType} symbol was not found.");
        //     }
        // }

        // {
        //     var cardType = CardTypeEnum.Spade;
        //     try
        //     {
        //         var symbol = CardService.GetSymbol(cardType);
        //         Console.WriteLine($"{cardType} symbol is {symbol}");
        //     }
        //     catch
        //     {
        //         System.Console.WriteLine($"{cardType} symbol was not found.");
        //     }
        // }

        // {
        //     var cardType = CardTypeEnum.Heart;
        //     try
        //     {
        //         var symbol = CardService.GetSymbol(cardType);
        //         Console.WriteLine($"{cardType} symbol is {symbol}");
        //     }
        //     catch
        //     {
        //         System.Console.WriteLine($"{cardType} symbol was not found.");
        //     }
        // }
    }
}