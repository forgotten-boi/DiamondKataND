namespace DiamondPrinter.Tests;

using DiamondPrinter.Core;

public class DiamondPrinterTests
{
    [Fact]
    public void TestDiamondsWithSingleLetter()
    {
        string result = DiamondPrinter.Create('A');
        Assert.Equal($"A", result);
    }

    [Fact]
    public void TestDiamonsWithLetterB()
    {
        var result = DiamondPrinter.Create('B');
        Assert.Equal(" A \nB B\n A ", result);
    }
    [Fact]
    public void TestDiamondsWithLetterC()
    {
        var result = DiamondPrinter.Create('C');
        Assert.Equal("  A  \n B B \nC   C\n B B \n  A  ", result);
    }

    [Fact]
    public void TestArgumentExceptionForInvalidCharacter()
    {
        Assert.Throws<ArgumentException>(() => DiamondPrinter.Create('1'));
    }
    [Fact]
    public void TestDiamondsWithLargeLetterZ()
    {
        var result = DiamondPrinter.Create('Z');
        //Performance check
        Assert.NotNull(result);
    }

    [Fact]
    public void TestBuildLineWithC()
    {
        var result = DiamondPrinter.BuildLine('C', 2, '_');
        Assert.Equal("__C___C__", result);
    }





}