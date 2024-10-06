namespace DiamondPrinter.Tests;

using DiamondPrinter.Core;

public class DiamondPrinterTests
{
    [Fact]
    public void TestDiamondsWithSingleLetter()
    {
        string result = DiamondPrinter.Create('A');
        Assert.Equal($"A\n", result);
    }

    [Fact]
    public void TestDiamonsWithLetterB()
    {
        var result = DiamondPrinter.Create('B');
        Assert.Equal(" A \nB B\n A \n", result);
    }
    [Fact]
    public void TestDiamondsWithLetterC()
    {
        var result = DiamondPrinter.Create('C');
        Assert.Equal("  A\n B B \nC   C\n B B \n  A  \n", result);
    }

}