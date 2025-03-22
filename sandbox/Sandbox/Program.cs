using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("This is in C#");

        Console.WriteLine("What is you favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine(color);

        Console.Write("What is you favorite animal? ");  // It prevents a new line
        string animal = Console.ReadLine();
        Console.WriteLine(animal);
        Console.WriteLine("This is my favor animal " + animal);  // Concatenating strings with +
        Console.WriteLine($"And remember this is my favor color {color}");  // String interpolation strings with +

    // CONVERTING TYPES -----------------------------------------------------------------
        Console.Write("Enter a number: ");
        string valueFromuser = Console.ReadLine();
        int a = int.Parse(valueFromuser);
        

    // CONDITIONALS ----------------------------------------------------------------------
        int x =5;
        int y = 2;

        if (x > y)
        {
            Console.WriteLine("Greater");
        }
        else if ( x < y)
        {
            Console.WriteLine("Less");
        }
        else
        {
            Console.WriteLine("Equal");
        }

    }
}