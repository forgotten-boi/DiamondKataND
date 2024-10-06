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
}