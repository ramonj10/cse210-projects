using System;

class Program
{
    static void Main(string[] args)
    {
        // Get a random number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
         
        // Loop tries with a do while as it will always take place at least once
        int guess;
        int counter = 0;

            do
            {
                counter += 1;
                
                Console.Write("What is your guess number? ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);
            
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                    Console.WriteLine($"You guessed it! just with {counter} tries. ");
            } while (guess != magicNumber);      
        }
    }