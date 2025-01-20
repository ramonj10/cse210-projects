using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Declare and create a List
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
       
       // Loop to request user numbers
       int userNumber = 1;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = (int.Parse(userInput));
            
            // Condition to exclude the 0 from the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // List elemnts sum by itereting its elements
        int numbersSum = 0;
        foreach (int number in numbers)
        {
            numbersSum += number;
        }

        //Find the smallest ppositive
        int smallestPositive = numbers.Max();
        foreach(int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
        } 
        
        // Display values of the list
        Console.WriteLine($"The sum is: {numbersSum}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");

        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }   
}