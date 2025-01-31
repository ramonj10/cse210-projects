using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class PromptGenerator
{
   // Declare needed attributes, list of prompts
   List<string> prompts = new List<string>(new string[]{});

   // Provide a random prompt to the user
   public string Generator()
   {
      Random rnd = new Random();
      string sugestion = prompts[rnd.Next(prompts.Count)];
      return sugestion;
   }

   // Display all the prompts line by line
   public void Display()
   {
      foreach (string line in prompts)
      {
         Console.WriteLine(line);
      }
   }

   // Add a new prompt to the existing ones
   public void AddPrompts(string prompt)
   {
      prompts.Add(prompt);
   }

   // Upload the existing prompt formm the prompt.txt file
   public void Load(string fileName)
   {
      // Read the entire file into an array of strings (one per line)
      string [] lines = System.IO.File.ReadAllLines("prompt.txt");

      // Loop to split every line in their 3 parts
      foreach (string line in lines)
      {
         prompts.Add(line);
      }
   }

   // Save the prompts on RAM into prompt.txt file
   public void Save(string fileName)
   {
      Console.WriteLine("Wait while the entries are being save to a file...");
      Console.WriteLine();

        // using function will close the file automaticly right after I end using it
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string prompt in prompts)
            {
               outputFile.WriteLine(prompt);  
            }
        }
   }
}