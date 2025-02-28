using System.Text;

public class Breathing : Activity{
    //Attributes
    private int _duration;

    //Constructors
    public Breathing(string name, int time, string description, string finalRemarks, int duration) : base(name, 
    time, description, finalRemarks){
        _duration = duration;
    }

    //Behaviours
    public void SetDuration(int duration){
        _duration = duration;
    }

    public int GetDuration(){
        return _duration;
    }

    // Establish the methods calling in secuence to run the Breath Activity
    public void RunBreathing(){
        DisplayStartingMessage();
        Console.Write("Set the length of each breathing (6 is recomended): ");
        string duration = Console.ReadLine();
        int durationNumber = Convert.ToInt32(duration)*2;  //To get always an odd int number.
        SetDuration(durationNumber);

        Console.Clear();
        Console.CursorVisible = false;  //Hide the cursor on the terminal
        Console.Write("Get ready... ");
       
        List<string> spinBar = SpinnerAnimation();
        CountdownPause(3, spinBar);

        List<string> spinIn = BreathInAnimation(GetDuration());
        List<string> spinOut = BreathOutAnimation(GetDuration());
        
        CountdownPauseBreath(GetTime(), spinIn, spinOut);
    
        DisplayEndingMessage();
        CountdownPause(3, spinBar);
    }
    
    // Display the breath animation In and Out.
    public async Task DisplayBreath(List<string> animationIn, List<string> animationOut){
        //Console.CursorVisible = false;   // Hide the cursos on terminal for cleaner display
        Console.Write("\nBreath in...");
        AnimationSpeed(animationIn, 800);
    
        Console.Write("\nBreath out...");
        AnimationSpeed(animationOut, 800);
        Console.WriteLine();

    }
    
    // Countdown while repeating the breathign animation 
    public void CountdownPauseBreath(int seconds, List<string>breathIn, List<string> breathOut){
        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(seconds);
        while (end > now){
            DisplayBreath(breathIn, breathOut);  // Calling the animation display
            now = DateTime.Now;
        }
        // Console.CursorVisible = true;   // Display back the cursos on terminal 
    } 

    // Build the BreathIntAnimation from the center to the edges with the selected █ character 
    // It adjust its size dinamically to the breath's seconds number selected
    public List<string> BreathInAnimation(int seconds){
        List<string> animation = new List<string>();  //Empty returning list of strings
        string stringAnimation = new string(' ', seconds);  // string within a list full of empty spaces (one per second) 
        int half = seconds/2;
        List<int> roundsList = new List<int>();   // Auxiliar empty list for the loops 
        for (int k = 0; k < half; k++){
            roundsList.Add(k);                    // Adding secuencial values to that auxiliar list (0,1,2,3 ... half) 
        }
        
        foreach (int i in roundsList){            // Loop to find the initial and final postion of everystring within the auxiliar list
            int positionFirst = half-i;
            int positionLast = positionFirst+(2*i)+1;
            for (int j=positionFirst-1; j<=positionLast-1; j++){        // Loop to replace █ symbol within the range of initial and final position in every string
                StringBuilder sb = new StringBuilder(stringAnimation);   // StrinigBuilder() helps to modify unmutable strings
                sb[j] = '█';                                                                                                     //         ██ 
                stringAnimation = sb.ToString();                                                                                 //        ████
            }                                                                                                                    //       ██████
            animation.Add(stringAnimation);        // Adding every modified string to the returning list of strings              //    .............
        }
        return animation;
    }

    // Build the BreathOutAnimation by reversing the BreathInAnimation
    public List<string> BreathOutAnimation(int seconds){
        List<string> animation = new List<string>();
        List<string> animationIn = BreathInAnimation(seconds); // Generate again the previous BreathInAnimation
        for (int i=animationIn.Count-1; i>=0; i--){              // Loop to reserve the string position within BreathInAnimation //    .............
            animation.Add(animationIn[i]);                                                                                       //       ██████
        }                                                                                                                        //        ████
        return animation;                                                                                                        //         ██
    }
}