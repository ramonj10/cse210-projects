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
}