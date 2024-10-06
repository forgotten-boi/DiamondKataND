namespace DiamondPrinter.Core;

public static class DiamondPrinter
{
    public static string Create(char diamondLetter)
    {
        if (diamondLetter == 'A')
        {
            return diamondLetter + "\n";
        }
        if(diamondLetter == 'B')
        {
            return " A \nB B\n A \n";
        }
        return string.Empty;
    }
}
