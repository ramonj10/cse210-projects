using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        
        string letter;

        string sign;

        // Logic conditions to get the letter
        if (percentage < 60)
        {
            letter = "F";
        }
        else if (percentage < 70)
        {
            letter = "D";
        }
        else if (percentage < 80)
        {
            letter = "C";
        }   
        else if (percentage < 90)
        {
            letter = "B";
        } 
        else 
        {
            letter = "A";
        }  
        
        // Logic conditions to get the sign
        int remainder = percentage % 10;
        if (remainder >= 7)
        {
            sign = "+";
        }        
        else if (remainder < 3)
        {
            sign = "-";
        }
        else
        {
            sign ="";
        }

        // Consider A+ does not exits.
        if (letter == "A" && sign == "+")
            sign ="";

        // Consider F has no sign.
        if (letter == "F")
            sign ="";

        // Display on screen the letter grade
        Console.WriteLine($"Your grade is {letter}{sign}");   

        if (percentage < 70 )
            Console.WriteLine("This time you percentage was not enought to pass the class. We are confident next time you will be able to do it.");   
        else
            Console.WriteLine("Congratulation you pass the course. ");
    }
}