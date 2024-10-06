using System.Diagnostics.Metrics;

namespace DiamondPrinter.Core;

public static class DiamondPrinter
{
    public static string Create(char diamondLetter)
    {
        if(diamondLetter > 'A' || diamondLetter < 'Z')
        {
            throw new ArgumentException();
        }
        //char cannot be null, thus null check is not required.
        if (diamondLetter == 'A') //for only one letter, it is diamond in itself
        {
            return diamondLetter.ToString();
        }

        int size = diamondLetter - 'A' + 1;
        var diamond = new List<string>();
        //form the top half of the diamond
        for (int i = 0; i< size; i++)
        {
            var currentLetter = (char)('A' + i);
            var line = BuildLine(currentLetter, size - i-1, ' ');
            diamond.Add(line);
        }

        //form the bottom half, without middle
        var lowerHalf = diamond.Take(diamond.Count - 1).Reverse().ToList();
        diamond.AddRange(lowerHalf);


        return string.Join("\n",diamond);
    }

    public static string BuildLine(char letter, int padding, char separatingChar)
    {
        var paddingSpace = new string(separatingChar, padding);
        if (letter == 'A')
            return paddingSpace + "A" + paddingSpace;
        var spaceBetten = new string(separatingChar, (letter - 'A') * 2 - 1);

        return paddingSpace + letter + spaceBetten + letter + paddingSpace;
    }
}
