public class Imaginations : Quotes{
    // Attributes
    private string _imagination;
    private string? _notesAboutImagination;
    
    // Constructors
    Imaginations(string book, int chapter, int verse, string scripture, int initialPosition, string imagination, int lineNumber, string standardBooks) 
                : base (book, chapter, verse, scripture, initialPosition, lineNumber, standardBooks){
        _imagination = imagination;
    }
    Imaginations(string book, int chapter, int verse, string scripture, int initialPosition, int finalPosition, string imagination, string standardBooks) 
                : base (book, chapter, verse, scripture, initialPosition, finalPosition, standardBooks){
        _imagination = imagination;
    }
    Imaginations(string book, int chapter, int verse, string scripture, int initialPosition, string imagination, string notesAboutImagination, int lineNumber, string standardBooks) 
                : base (book, chapter, verse, scripture, initialPosition, lineNumber, standardBooks){
        _imagination = imagination;
        _notesAboutImagination = notesAboutImagination;
    }
    Imaginations(string book, int chapter, int verse, string scripture, int initialPosition, int finalPosition, string imagination, string notesAboutImagination, string standardBooks) 
                : base (book, chapter, verse, scripture, initialPosition, finalPosition, standardBooks){
        _imagination = imagination;
        _notesAboutImagination = notesAboutImagination;
    }

    // Actions
    //Getters & Setters
    public string GetImagination(){
        return _imagination;
    }
    public string GetNotesAboutImagination(){
        return _notesAboutImagination;
    }   
    public void SetNotesAboutImagination(string notesAboutImagination){
        _notesAboutImagination = notesAboutImagination;
    }

    //
    public override void Display()
    {
        base.Display();
        Console.Write($"{_imagination}.\nNotes about what I have imagined: {_notesAboutImagination}");
    }

    // Display all elements of the list
    public virtual void DisplayListElements(List<Imaginations> list){
        foreach(Imaginations imagination in list){
            imagination.Display();
        }
    }

    //
    public void DisplayOnlyImagination()
    {
        Console.Write(_imagination);
    }
    
    //
    public void DisplayOnlyImaginationWithNotes()
    {
        Console.Write($"{_imagination}.\nNotes about what I have imagined: {_notesAboutImagination}");
    }
}