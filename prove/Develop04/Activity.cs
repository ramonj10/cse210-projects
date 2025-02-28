using System.Threading.Tasks;

public class Activity{
    //Attributes
    protected string _name;
    protected int _time;
    protected string _description;
    protected string _finalRemarks;

    //Constructors
    public Activity(string name, int time, string description, string finalRemarks ){
        _name = name;
        _time = time;
        _description = description;
        _finalRemarks = finalRemarks;
    }

    // Behaviors
    // Setter and Getters
    public void SetTime(int time){
    _time = time;
    }

    public int GetTime (){
        return _time;
    }

    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        SetTime(int.Parse(Console.ReadLine()));   
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"\nYou have completed another {_time} seconds of the {_name} Activity.");
    }

    // Select the animation to use with its speed in miliseconds
    public async Task AnimationSpeed(List<string> animation, int sleepMiliSeconds){
        foreach (string element in animation){
            Console.Write(element);
            Thread.Sleep(sleepMiliSeconds);
            string nBackSpace = new string('\b', element.Length);
            Console.Write(nBackSpace);
            string nSpaces = new string(' ', element.Length);
            Console.Write(nSpaces);
            Console.Write(nBackSpace);   
        }
    }

    // Pause program execution during selected seconds with the chosen animation
    public void CountdownPause(int seconds, List<string> spin){
        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(seconds);

        while (end > now){
            AnimationSpeed(spin, 400);
            now = DateTime.Now;
        }
        Console.WriteLine();
    }

    // Build the SpinnerAnimation with different bar cahracters
    public List<string> SpinnerAnimation(){
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");    
        return animation;
    }

    // Build the CountdownAnimation from the number selected down to 0
    public List<string> CountdownAnimation(int number){
        List<string> animation = new List<string>();
        for (int i = number; i >= 0; i--){
            animation.Add(Convert.ToString(i));
        }  
        return animation;
    }
    
}
