namespace MagicStrings.CLI;

public static class CardService
{
    public static char GetSymbol(CardTypeEnum cardType)
    {
        if (cardType == CardTypeEnum.Spade) return '♠';
        if (cardType == CardTypeEnum.Heart) return '♥';
        if (cardType == CardTypeEnum.Club) return '♣';
        if (cardType == CardTypeEnum.Diamond) return '♦';
        throw new ArgumentException("Card Type not found.");
    }
}