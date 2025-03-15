using System.IO;
// using System.Collections.Generic;

public abstract class Goals
{
    // Atributes
    private string _name;
    private string _description;
    private int _point;

    // Constructors
    public Goals(string name){
        _name = name;
    }
    
    public Goals(string name, string description, int point){
        _name = name;
        _description = description;
        _point = point;
    }

    // Behaviours
    //Setter and Getters
    public string GetName(){
        return _name;
    }

    public string GetDescription(){
        return _description;
    }

    public int GetPoint(){
        return _point;
    }

    public void SetDesscription(string description){
        _description = description;
    }

    public void SetPoint(int point){
        _point = point;
    }

    // Display the goals in its appropiate format by overriting the Abstract method
    public abstract void DisplayGoal();

    // Prepare the goal with all its appropiate parameters as a List of strings
    public abstract List<string> GetStringParameters();
    
    // Record goal done acording to the type of goal
    public abstract void GoalDone();

    // Obtains the additional points if any acording to the type of goal
    public abstract int AdditionalPoints();

    // Save into a text file all goals attributes and the actual points 
    public void SaveGoals(string filename, List<Goals> listGoals, int actualPoint){
        using(StreamWriter outputFile = new StreamWriter(filename)){    // Create an StreamWriter object to allocate every line of data
            outputFile.WriteLine(actualPoint.ToString());               // Write in the first line the actualPoints value as a string
            foreach (Goals goal in listGoals){   
                List<string> goalstring = goal.GetStringParameters();   // Get all goals attributes as a list of strings
                string line = String.Join(",", goalstring.ToArray());   // Trasnform the list of strings into one string, separating the attributes by commas 
                outputFile.WriteLine(line);                             // Write line after line the previous string
            }
        }
    }

}