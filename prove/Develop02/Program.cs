using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        // Declare the needed variables.
        string userInput;
        DateTime actualDate = DateTime.Today;
        string actualDateText = actualDate.ToShortDateString();
        string clearScreen = "no";
        
        // Create the needed objects
        Journal myJournal = new Journal();  // creates a Jounal object
        PromptGenerator prompt = new PromptGenerator();   // creates a PromptGenerator object
        prompt.Load("prompt.txt"); // Upload all prompts in the file to the empty promt object
        
        // Start with a Wellcome message
        Console.Clear();
        Console.WriteLine("Wellcome to your Journal Program!");
        Console.WriteLine();
        
        // While loop to display the menu over again
        string replay = "yes";
        while (replay == "yes")
        {
            Entry entry1 = new Entry();    // Must be WITHIN the loop to creates a different Entry object every time
            
            if (clearScreen == "yes")   // To clear the terminal display whenever convinient.
            {
                Console.Clear();
            }

            // Display the main menu
            Console.WriteLine("Please select one of te following choices:");
            Console.WriteLine("0. Add new prompts");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What whould you like to do? ");
            userInput = Console.ReadLine();

            // Analize user reply
            if (userInput == "1")
            {
                Console.Clear();
                string sugestion = prompt.Generator();
                Console.WriteLine(sugestion);
                Console.Write("> ");
                userInput = Console.ReadLine();
                
                // Fillout entry1 object with its attributes values
                entry1._date = actualDateText;
                entry1._prompt = sugestion;
                entry1._entry = userInput;

                // Add entry1 object to myJournal oject
                myJournal.AddingEntry(entry1);
                clearScreen = "yes";
            }

            else if (userInput == "2")
            {
                Console.WriteLine();
                myJournal.DisplayAllEntries();
                Console.WriteLine();
                clearScreen = "no";
            }

            else if (userInput == "3")
            {
                Console.WriteLine("What is the file name?");
                userInput = Console.ReadLine();
                myJournal.Load(userInput);
                Console.WriteLine("Loading data from memory file...");
                clearScreen = "yes";
            }

            else if (userInput == "4")
            {
                Console.WriteLine("What is the file name?");
                userInput = Console.ReadLine();
                myJournal.SaveFile(userInput);
                clearScreen = "yes";
            }

            else if (userInput == "5")
            {
                Console.Clear();
                Console.WriteLine("Thank you for writting in your journal again.");
                Console.WriteLine("See you tomorrow.");
                Console.WriteLine();
                replay = "No";
            }

            else if (userInput == "0")
            {
                Console.Clear();
                prompt.Display();
                Console.WriteLine();
                Console.WriteLine("Type the new prompt you want to add to the existing ones above:");
                string newPromp = Console.ReadLine();
                Console.WriteLine($"Do you want to add this new prompt? {newPromp} Type (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    prompt.AddPrompts(newPromp);  // Add newPromp to the promt in RAM
                    prompt.Save("prompt.txt");  // Directly save it to the file for future uses.
                    Console.Clear();
                    prompt.Display();
                    Console.WriteLine();
                    Console.WriteLine("Your new prompt was added above.");
                    Console.WriteLine();
                    clearScreen = "no";
                }
                else
                {
                    clearScreen = "yes";
                }
            }
            
            else
            {
                // To manage any entry different from the menu options numbers.
                Console.WriteLine();
                Console.WriteLine("You have selected an invalid option. please enter a value 0 through 5");
                Console.WriteLine();
                clearScreen = "no";
            }
        }
    }
}