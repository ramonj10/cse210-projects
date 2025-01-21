using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PrompUserName(), PrompUserNumber());
    }

    // Define the DisplayWelcome funtion
    static void DisplayWelcome()
    {
        Console.WriteLine("Wellcome to the program!");
    }

    //Define a function to ask an return a user name
    static string PrompUserName()
    {
        Console.Write("Please enter your name:");
        string UserName = Console.ReadLine();
        return UserName;
    }

    // Define a function to ask for and return the user favorite number
    static string PrompUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string FavoriteNumber = Console.ReadLine();
        return FavoriteNumber;
    }

    // Define a function with an int as parameter and return its squared number
    static int SquareNumber(string aNumber)
    {
        int squared = int.Parse(aNumber) * int.Parse(aNumber);
        return squared;
    }

    // Define a function to Accept the users name and the square number to display them
    static void DisplayResult(string PrompUserName, string PrompUserNumber)
    {
        int square = SquareNumber(PrompUserNumber);
        Console.WriteLine($"{PrompUserName}, the square of your number is {square}");
    }

}