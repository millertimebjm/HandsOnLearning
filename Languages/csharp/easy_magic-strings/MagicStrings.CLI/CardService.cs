namespace MagicStrings.CLI;

public static class CardService
{
    public static char GetSymbol(string cardType)
    {
        if (cardType == "Spade") return '♠';
        if (cardType == "Hart") return '♥';
        if (cardType == "Club") return '♣';
        if (cardType == "Dimond") return '♦';
        throw new ArgumentException("Card Type not found.");
    }
}