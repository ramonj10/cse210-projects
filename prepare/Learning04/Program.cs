using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Jesús", "Programming with classes" );
        MathAssignmnet mathAssignmnet1 = new MathAssignmnet("Manu", "Welding", "7.3", "8-19");
        WrittingAssignment writtingAssignment1 = new WrittingAssignment("Mary Waters",
                                "European History", "The causes of World War II");
  
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(mathAssignmnet1.GetSummary());
        Console.WriteLine(mathAssignmnet1.GetHomeworkList());
        Console.WriteLine(writtingAssignment1.GetSummary());
        Console.WriteLine(writtingAssignment1.GetWrittingInfo());        
    }
}