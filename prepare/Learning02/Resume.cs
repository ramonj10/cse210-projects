using System;
public class Resume
{
   public string _name;
    // Remmember to initialize your list to a new list 
   public List<Job> _jobs = new List<Job>(); 

   public void Display()
   {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        // Loops through the Job type
        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();
        }
   }
}