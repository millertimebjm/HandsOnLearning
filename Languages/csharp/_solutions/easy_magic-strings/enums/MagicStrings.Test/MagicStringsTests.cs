using MagicStrings.CLI;

namespace MagicStrings.Test;

public class CardTests
{
    [Fact]
    public void SpadeTest_Equal()
    {
        var symbol = CardService.GetSymbol(CardTypeEnum.Spade);
        Assert.Equal('♠', symbol);
    }

    [Fact]
    public void HeartTest_Equal()
    {
        var symbol = CardService.GetSymbol(CardTypeEnum.Heart);
        Assert.Equal('♥', symbol);
    }

    [Fact]
    public void ClubTest_Equal()
    {
        var symbol = CardService.GetSymbol(CardTypeEnum.Club);
        Assert.Equal('♣', symbol);
    }

    [Fact]
    public void DiamondTest_Equal()
    {
        var symbol = CardService.GetSymbol(CardTypeEnum.Diamond);
        Assert.Equal('♦', symbol);
    }
}
