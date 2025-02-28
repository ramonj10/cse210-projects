class Reflecting : Activity{
    //Attributes
    private List<string> _prompt;
    private List<string> _question;

    // Constructors
    public Reflecting(string name, int time, string description, string finalRemarks, List<string> prompt, List<string> question)
                      : base(name, time, description, finalRemarks) {
        _prompt = prompt;
        _question = question;
    }

    // Behaviors

    // Establish the methods calling in secuence to run the Reflecting Activity
    public void RunReflecting(){
        DisplayStartingMessage();
        List<string> spinBar = SpinnerAnimation();
        List<string> empty = new List<string>();
        empty.Add("");
        
        Console.Clear();
        Console.Write("Get ready... ");
        CountdownPause(4, spinBar);
        DisplayPrompt();  
                
        DisplayQuestion(spinBar);
            
        Console.WriteLine();
        DisplayEndingMessage();
        CountdownPause(4, spinBar);
    }

    // Get a random prompt
    public string GetRandomPrompt(){
        Random random= new Random();
        int number = random.Next(_prompt.Count);
        string prompt = _prompt[number];
        return prompt;
    }

    // Get a random question
    public string GetRandomQuestion(){
        // Get a random question
        Random randomq = new Random();
        int number = randomq.Next(_question.Count);
        string question = _question[number];
        return question;
    }

    // Display the prompt
    public void DisplayPrompt(){
        Console.WriteLine("\nConsider the following propmt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
    }

    // Display the question
    public void DisplayQuestion(List<string> spinBar){
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may began in: ");
        List<string> countdown = CountdownAnimation(6);
        CountdownPause(1, countdown);
        Console.Clear();
        CountdownEmpty(GetTime(), spinBar);
    }

    // Countdown while displaying random questions without any display
    public void CountdownEmpty(int seconds, List<string> spin){
        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(seconds);
    
        while (end > now){
            Console.Write($"{GetRandomQuestion()}");
            CountdownPause(15, SpinnerAnimation());
            Console.WriteLine();
            now = DateTime.Now;
        }
    }
}