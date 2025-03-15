using System;

class Program
{  
    // public List<Goals> listGoals = new List<Goals>();    
    static void Main(string[] args)
    {
        int actualPoints = 0;                       // Variabel to track Total points achieved
        List<Goals> listGoals = new List<Goals>();  // Create a list object to gather all goals

        // Loop for Menu display with the boolena variable repeatOver
        bool repeatOver = true;
        while (repeatOver == true){
            // Display Main Menu
            // Console.Clear();
            Console.WriteLine($"\nYou have {actualPoints} points.\n");
            Console.WriteLine("Menu Options:\n" +
                                "1. Create New Goal\n" +
                                "2. List Goals\n" +
                                "3. Save Goals\n" +
                                "4. Load Goals\n" +
                                "5. Record Event\n" +
                                "6. Quit\n");
            Console.Write("Select a choice from the menu: ");
            string userOption = Console.ReadLine();             // Save Menu Option selected in userOption

            // Analice the selected option with if statements
            if (userOption == "1"){
                // Display type of Goals Menu
                Console.WriteLine("\n\tThe types of Goals are:\n" +
                                    "\t1. Simple Goal\n" +
                                    "\t2. Eternal Goal\n" +
                                    "\t3. CheckList Goal");
                Console.Write("\n\tWhat type of Goal would you like to create: ");
                string userGoalType = Console.ReadLine();       // Save Type of Goals Option selected in userGoalType

                // Analice the selected option with if statements
                //Steps to create a Simple Goal            
                if (userGoalType == "1"){
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int point = Int32.Parse(Console.ReadLine());        // Transform the input string into integer
                    SimpleGoals goal= new SimpleGoals(name, description, point);   // Create a SimpleGoal object
                    listGoals.Add(goal);                                           // Add that object into the list of goals
                }
                // Steps to create an Eternal Goal
                if (userGoalType == "2"){
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int point = Int32.Parse(Console.ReadLine());          // Transform the input string into integer
                    Console.Write("How many times to complete the goal to increase its point´s level? ");
                    int timesToLevelUp = Int32.Parse(Console.ReadLine());   // Transform the input string into integer
                    Console.Write("Number of points to increase point's level. ");
                    int levelPoints = Int32.Parse(Console.ReadLine());     // Transform the input string into integer
                    EternalGoals goal= new EternalGoals(name, description, point, timesToLevelUp, levelPoints);   // Create an EternalGoal object
                    listGoals.Add(goal);                                    // Add that object into the list of goals
                }

                // Steps to create a Checklist Goal
                if (userGoalType == "3"){
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int point = Int32.Parse(Console.ReadLine());
                    Console.Write("How many times takes to complete the goal? ");
                    int timesToComplete = Int32.Parse(Console.ReadLine());
                    Console.Write("How many extra point upon goal completition?  ");
                    int extraPoints = Int32.Parse(Console.ReadLine());
                    CheckListGoals goal= new CheckListGoals(name, description, point, timesToComplete, extraPoints);  // Create an Checklist lGoal object
                    listGoals.Add(goal);        // Add that object into the list of goals
                }
            }
            
            // Dispaly every goal in the list line by line
            else if (userOption == "2"){
                if (listGoals.Count() == 0){
                    Console.WriteLine("\nYou have not added any goals to the list yet. \n " +
                                    "You may add them with option 1 or uploaded them with option 4.\n");
                }
                foreach (Goals goal in listGoals){      // Loop thrpugh the goals in the list
                    goal.DisplayGoal();                 // Display the goal using the appropiate override method 
                }
            }

            // Save goals information and the actual points 
            else if (userOption == "3"){
                foreach (Goals goal in listGoals){
                    goal.SaveGoals("myGoals.txt", listGoals, actualPoints);   // Save using the method SaveGoals
                }
                Console.WriteLine($"\nYou have successfully save {listGoals.Count()} goals.");
            }

            // Load goals and actual points from the text file
            else if (userOption == "4"){
                string [] lines = System.IO.File.ReadAllLines("myGoals.txt");   // Read the entire file line by line and upload them
                actualPoints = int.Parse(lines[0]);      // Transform first line string into integer. Contains actual pooints

                for (int i = 1; i < lines.Length; i++){    // Loop from the second line to the last line
                    string[] parts = lines[i].Split(",");    // Split line string by separator character into parts
                    
                    // Identify the type of goal by analicing the first part
                    if (parts[0] == "Simple :"){
                        listGoals.Add(new SimpleGoals(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]))); // Create Simple goal object and add it to the list of goals
                    }

                    if (parts[0] == "Eternal :"){
                        listGoals.Add(new EternalGoals(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]))); // Create Eternal goal object and add it to the list of goals
                    }

                    if (parts[0] == "Checklist :"){
                        listGoals.Add(new CheckListGoals(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]))); // Create Checklist goal object and add it to the list of goals
                    }
                } 
                Console.WriteLine($"\nYou have successfully upload {lines.Length} goals.");
            }

            // Record a goal event
            else if (userOption == "5"){
                bool repeatOver5 = true;
                Console.Clear();
                while (repeatOver5 == true) {
                    Console.WriteLine("Your goals are:");
                    
                    int i = 1;
                    foreach (Goals goal in listGoals){            // Loop throght all the goals in the list
                        Console.WriteLine($"\t{i}. {goal.GetName()}");   // Display the goal names with a correlative number 
                        i += 1;
                    }

                    Console.Write("Which goal did you accomplish? (press \"0\" to return to the previous menu): ");
                    int userAccomplish = int.Parse(Console.ReadLine())-1;  // As list began with 0 index, a -1 is needed in the input correlative number 
                    
                    if (userAccomplish == -1){
                        repeatOver5 = false;
                    }

                    else if (userAccomplish <= listGoals.Count()){
                        listGoals[userAccomplish].GoalDone();           // Indicate goal done with the override method acordin gto each type of goal
                        actualPoints += listGoals[userAccomplish].GetPoint() + listGoals[userAccomplish].AdditionalPoints();  // Increase actual point wiht goal points and bonus if any apply.
                        //listGoals[userAccomplish].DisplayGoal();
                        repeatOver5 = false;
                    }

                    else {
                        Console.WriteLine("The selected goal does not exist. Please choose a valid one form the list below.");
                    }
                }
            }

            // Leave the applications
            else if (userOption == "6"){
                    repeatOver = false;
                }
        
            else {
                Console.WriteLine("\nYour option is not on the Menu. \nPlease choose a valid optione form the menu below: ");
            }
        }
    }
}
