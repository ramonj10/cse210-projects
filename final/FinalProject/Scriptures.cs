public class Scriptures : Verses{
    // Attributes
    private string _scriptures;
    
    // Constructores
    public Scriptures(string book, int chapter, int verse, string scripture, int lineNumber, string standardBooks) : base(book, chapter, verse, lineNumber, standardBooks){
        _scriptures = scripture;
    }

    // Actions
    //Getters & Setters
    public string GetScripture(){
        return _scriptures;
    }

    //
    public override void Display()
    {
        base.Display();
        Console.Write($"{_scriptures}\n");
    }

    // Display all elements of the list
    public virtual void DisplayListElements(List<Scriptures> list){
        foreach(Scriptures scripture in list){
            scripture.Display();
        }
    }

    //
    public void DisplayScripture(){
        Console.Write(_scriptures);
    }

    //
    public void DisplayReference(){
        Console.Write($"{GetBook()} {GetChapter()}:{GetVerse()}; ");
    }

    //
    public void DisplayReferenceAbbreviation(){
        Console.Write($"{GetAbbreviation()} {GetChapter()}:{GetVerse()}; ");
    }
    
}