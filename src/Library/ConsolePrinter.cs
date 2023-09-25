using System;
using System.IO;
using Full_GRASP_And_SOLID.Library;

public class ConsolePrinter : IPrinter
{
    public void PrintTicket(Recipe recipe)
    {
        Console.WriteLine(recipe.GetTextToPrint());
    }
}