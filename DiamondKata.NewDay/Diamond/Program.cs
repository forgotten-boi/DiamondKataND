// Test project to run from Command

using System.Xml.Linq;

var errorMsg = "The letter should be between A and Z";
try
{
    string input = Environment.GetCommandLineArgs()[1];
    if (string.IsNullOrEmpty(input) || input.Length != 1)
    {
        Console.WriteLine(errorMsg);
        return;
    }
    var diamondStructure = DiamondPrinter.Core.DiamondPrinter.Create(input[0]);

    Console.WriteLine(diamondStructure);
}
catch (ArgumentException ex)
{
    Console.WriteLine(errorMsg);
}
catch (Exception ex)
{

	throw;
}

