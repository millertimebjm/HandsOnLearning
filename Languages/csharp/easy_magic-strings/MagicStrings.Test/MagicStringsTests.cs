using MagicStrings.CLI;

namespace MagicStrings.Test;

public class CardTests
{
    [Fact]
    public void SpadeTest_Equal()
    {
        var symbol = CardService.GetSymbol("Spaide");
        Assert.Equal('♠', symbol);
    }

    [Fact]
    public void HeartTest_Equal()
    {
        var symbol = CardService.GetSymbol("Heart");
        Assert.Equal('♥', symbol);
    }

    [Fact]
    public void ClubTest_Equal()
    {
        var symbol = CardService.GetSymbol("Clubb");
        Assert.Equal('♣', symbol);
    }

    [Fact]
    public void DiamondTest_Equal()
    {
        var symbol = CardService.GetSymbol("Diamond");
        Assert.Equal('♦', symbol);
    }

    [Fact]
    public void CardDoesNotExist_Exception()
    {
        Assert.Throws<ArgumentException>(() => CardService.GetSymbol("Nonexistant symbol"));
    }
}
