public class Verses : Chapters{
    // Attributes
    private int _verse;

    // Constructores
    public Verses(string book, int chapter, int verse, int lineNumber, string standardBook) : base(book, chapter, lineNumber, standardBook){
        _verse = verse;
    }

    // Actions
    // Getters y Setters
    public int GetVerse(){
        return _verse;
    }

    // Display verse attributes
    public override void Display()
    {
        base.Display();
        Console.Write($":{_verse} ");
    }

    // Display all elements of the list
    public virtual void DisplayListElements(List<Verses> list){
        foreach(Verses verse in list){
            verse.Display();
        }
    }

    // Verify if the verse already exist in VerseList
    public void AddNewVerse(string book, int chapter, int verse, int lineNumber, string standardBook, List<Verses> oVersesList){
        bool exists = oVersesList.Any(a => a.GetVerse() == verse & a.GetChapter() == chapter & a.GetBook() == book);
        if (exists == false){
            Verses oVerse = new Verses(book, chapter, verse, lineNumber, standardBook);
            oVersesList.Add(oVerse);
        }    
    }
}