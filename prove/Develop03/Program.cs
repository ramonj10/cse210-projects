using System;
using System.Net;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // Hardcoded variables initialized
        string scriptureText = "Pero he aquí, todas las cosas han sido hechas según la sabiduría de aquel que todo lo sabe. Adán cayó para "+
        "que los hombres existiesen; y existen los hombres para que tengan gozo.";
        string book = "2 Nephi";
        int chapter = 2;
        int verse = 24;
        int finalVerse = 25;
        
        // Create a Reference object
        References reference = new References(book, chapter, verse, finalVerse);

        // Declare a list to add words
        List<Words> listWords = new List<Words>();
            
        // Split scriptureText within a List of words
        char splitChar = ' '; //Splitting characters  , ',', '.', ':', ':'
        String[] strList = scriptureText.Split(splitChar, StringSplitOptions.None); //List of words.
        
        // Create a Words boject per word in the list 
        foreach (string word in strList)
        {
            // Words object created
            Words element = new Words(word);
            listWords.Add(element);    
        } 
    
        // Create a Scripture object
        Scriptures scripture = new Scriptures(listWords, reference);
        
        bool quit = false;
        while (quit ==false)
        {
            scripture.Display();
            Console.WriteLine();

            quit = scripture.IsHidden();  // Quit if all words are hidden
            
            char userInput = Console.ReadKey().KeyChar;   // Get the first character from user input
            
            if (userInput != 'q')   // Evaluate user input to repeat the cicle
            {
                scripture.Hide();
            }
            else
            {
                quit = true;
            }  
        }
    }
}