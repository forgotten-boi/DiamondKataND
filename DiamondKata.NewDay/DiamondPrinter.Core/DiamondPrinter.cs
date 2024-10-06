namespace DiamondPrinter.Core;

public static class DiamondPrinter
{
    public static string Create(char diamondLetter)
    {
        if (diamondLetter != null)
        {
            return diamondLetter + "\n";
        }
        return string.Empty;
    }
}
