using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Bulding all needed list of prompts and questions 
        List<string> reflectingPrompts = new List<string>();
        reflectingPrompts.Add("Think of a time when you stood up for someone else. ");
        reflectingPrompts.Add("Think of a time when you did something really difficult. ");
        reflectingPrompts.Add("Think of a time when you helped someone in need. ");
        reflectingPrompts.Add("Think of a time when you did something truly selfless. ");

        List<string> questions = new List<string>();
        questions.Add("> Why was this experience meaningful to you? ");
        questions.Add("> Have you ever done anything like this before? ");
        questions.Add("> How did you get started? ");
        questions.Add("> How did you feel when it was complete? ");
        questions.Add("> What made this time different than other times when you were not as successful? ");
        questions.Add("> What is your favorite thing about this experience? ");
        questions.Add("> What could you learn from this experience that applies to other situations? ");
        questions.Add("> What did you learn about yourself through this experience? ");
        questions.Add("> How can you keep this experience in mind in the future? ");

        //Create a List object with all the propmts
        List<string> listingPropmpts = new List<string>();
        listingPropmpts.Add("Who are people that you appreciate? ");
        listingPropmpts.Add("What are personal strengths of yours? ");
        listingPropmpts.Add("Who are people that you have helped this week? ");
        listingPropmpts.Add("When have you felt the Holy Ghost this month? ");
        listingPropmpts.Add("Who are some of your personal heroes? ");
        
        // Create a new object for every Activity
        Breathing breath = new Breathing("Breathing", 60, "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.",
                                         "Great Job", 6);

        Reflecting reflection = new Reflecting("Reflecting", 30, 
        "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.",
        "Well done.", reflectingPrompts, questions);
        
        Listing list = new Listing("Listing", 30, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                 "Well done.", 60, listingPropmpts);
        
        // Display a recurent Menu with a while loop
        bool replay = true;
        bool hint = false;
        while (replay == true){
            //Menu Display
            Console.Clear();
            Console.CursorVisible = true;  //Display the cursor on the terminal again
            Console.WriteLine(
                "Menu Options: \n"+
                "   1. Start breathing activity \n"+
                "   2. Start reflecting activity \n"+
                "   3. Start listing activity \n"+
                "   4. Quit");
            // Ask and get user option
            if (hint == false){
                Console.Write("Select an option from the menu: ");
            }
            else{
                Console.Write("\nYou selected an invalid option. \nThis time, please type a number from 1 to 4. ");
                hint = false;
            }
            string option = Console.ReadLine();

            // Analice user option
            if (option == "1"){
                breath.RunBreathing(); // Call the Breath running method
            }
            else if (option == "2"){
                reflection.RunReflecting(); // Call the Reflection running method
            } 
            else if (option == "3"){
                list.RunListing(); // Call the List running method
            }
            else if (option == "4"){
                replay = false;
            }
            else {
                hint = true; 
            }
        }
        Console.Clear();
        Console.WriteLine("\nWe hope you enjoyed these Mindfulness Progrom.");
        Console.WriteLine("\nSee you again soon and have the marvellous day you deserve.\n\n");
    }
}