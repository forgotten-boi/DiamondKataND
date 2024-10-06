namespace DiamondPrinter.Tests;

using DiamondPrinter.Core;

public class DiamondPrinterTests
{
    [Theory]
    [InlineData("A")]
    [InlineData("B")]
    [InlineData("C")]
    [InlineData("D")]
    [InlineData("E")]
    [InlineData("F")]
    public void TestDiamondsWithSingleLetter(string diamondLetter)
    {
        string result = DiamondPrinter.Create(diamondLetter);
        Assert.Equal($"{diamondLetter}\n", result);
    }
}