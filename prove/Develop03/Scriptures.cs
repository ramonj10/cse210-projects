using System.Collections.Generic;

class Scriptures
{
    // Declare Attibutes
    private List<Words> _scripture;
    private References _reference;
    private int _length;

    //Contractors
    public Scriptures(List<Words> scripture, References reference)
    {
        _scripture = scripture;
        _reference = reference;
        _length = _scripture.Count;
    }

    // Behaviours
    public void SetScripture(List<Words> scriptureText, References reference)
    {
        _scripture = scriptureText;
        _reference = reference;
    }

    public String[] GetScripture()
    {
       String[] fullScripture = [$"{_reference}", $"{_scripture}"];
       return fullScripture;
    }

    // Display the Scripture with the characters of the word
    public void Display()
    {
       Console.Clear();
       Console.WriteLine(_reference.GetRefernce());
       
       //Display every Word object according with its _hide boolena value
       foreach (Words element in _scripture)
       {
            if (element.GetHide() == false)
            {
                Console.Write($"{element.ShowWord()}");
            }
            else
            {
                Console.Write($"{element.HideWord()}");
            }
       }
    }
    
    // Hide the random words with _____
    public void Hide()
    {
        // Get a random number witin the length of the List
        Random random = new Random();
        int i = 0;
        while (i < 3)
        {
            int number = random.Next(_length);
            Words word =_scripture[number];
           word.SetHide();
            i += 1;
        }
    }

    // Verify if all words are hidden to quit the program
    public bool IsHidden()
    {
        bool hide = false;
        foreach (Words word in _scripture)
        {
            if (word.GetHide() == true)
            {
                hide = true;
            }
            else
            {
                hide = false;
                break;
            }
        }
    
        return hide;
    }
}