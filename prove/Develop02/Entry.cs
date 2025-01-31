using System.Runtime.InteropServices;

public class Entry
{
    // Declare the needed attributes
    public string _date;
    public string _prompt;
    public string _entry;

    // Display the Entry attributes in the needed format
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt} ");
        Console.WriteLine(_entry);
        Console.WriteLine();
    }
}