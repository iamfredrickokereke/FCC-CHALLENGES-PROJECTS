How do I check if a value is in an array in C#?

Like, I want to create an array with a list of printer names.

These will be fed to a method, which will look at each string in turn, and if the string is the same as a value in an array, do that action.

For example:

string[] printer = {"jupiter", "neptune", "pangea", "mercury", "sonic"};
foreach (p in printer)
{
   PrinterSetup(p);     
}
These are the names of the printers, they are being fed to the PrinterSetup method.

PrinterSetup will look sort of like this (some pseudocode):

public void PrinterSetup(printer)
{
   if (printer == "jupiter") 
   {
      Process.Start("BLAH BLAH CODE TO ADD PRINTER VIA WINDOWS EXEC");
   }
}
How do I format if (printer == "jupiter") in a way that C# can recognize?
