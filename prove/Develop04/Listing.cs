class Listing : Activity{
    //Attributes
    private int _duration;
    private int _numberEntries = 0;
    private List<string> _prompt;

    //Constructors
    public Listing(string name, int time, string description, string finalRemarks, int duration, List<string> prompt)
                    : base(name, time, description, finalRemarks){
        _name = name;
        _time = time;
        _description = description;
        _finalRemarks = finalRemarks;
        _numberEntries = 0;
        _duration = duration;
        _prompt = prompt;
    }

    //Behaviors
    //Calls to the running steps for the Listinig Activity.
    public void RunListing(){
        DisplayStartingMessage();
        List<string> spinBar = SpinnerAnimation();
        List<string> empty = new List<string>();
        empty.Add("");
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        CountdownPause(4, spinBar);
        DisplayPrompt(empty);  
            
        DisplayEndingMessage();
        CountdownPause(4, spinBar);
    }

    //Get a random prompt of the list prompts
    public string GetRandomPrompt() { //POSIBLEMENTE TENGA QUE IR EN CLASS ACTIVITY PORQUE REFLECTING LO TIENE TAMBIEN
        Random random = new Random();
        int number = random.Next(_prompt.Count());
        string prompt = _prompt[number]; 
        return prompt;
    }

    //Display the prompt to the user in the screen 
    public void DisplayPrompt(List<string> empty){  // SI ES IGUAL QUE EL DE REFLECTING CAMBIARLO A ACTIVITY CLASS
        Console.WriteLine($"\nList as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.Write($"You may begin in: ");
        List<string> countdown = CountdownAnimation(6);
        CountdownPause(1, countdown);
        Console.WriteLine();
        CountdownEmpty(GetTime(), empty);
    }

    //Count the number of entries type by the use for this prompt
    public void CountEntries(){
        Console.Write("> ");
        Console.ReadLine();
        _numberEntries += 1; 
    }

    // Countdown while typing entries without animation
    public void CountdownEmpty(int seconds, List<string> spin){
        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(seconds);
    
        while (end > now){
            CountEntries();
            now = DateTime.Now;
        }
        Console.WriteLine($"You listed {_numberEntries} items!");
    }
}
      