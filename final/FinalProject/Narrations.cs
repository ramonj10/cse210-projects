public class Narrations : Quotes{
    // Attributs
    private string _narration;
    private string _notesAboutNarration;
    
    // Constructors
    Narrations(string book, int chapter, int verse, string scripture, int initialPosition, string narration, int lineNumber, string standardBooks) 
                : base (book, chapter, verse, scripture, initialPosition, lineNumber, standardBooks){
        _narration = narration;
    }
    Narrations(string book, int chapter, int verse, string scripture, int initialPosition, int finalPosition, string narration, string standardBooks) 
                : base (book, chapter, verse, scripture, initialPosition, finalPosition, standardBooks){
        _narration = narration;
    }
    Narrations(string book, int chapter, int verse, string scripture, int initialPosition, string narration, string notesAboutNarration,  int lineNumber, string standardBooks) 
                : base (book, chapter, verse, scripture, initialPosition, lineNumber, standardBooks){
        _narration = narration;
        _notesAboutNarration = notesAboutNarration;
    }
    Narrations(string book, int chapter, int verse, string scripture, int initialPosition, int finalPosition, string narration, string notesAboutNarration, string standardBooks) 
                : base (book, chapter, verse, scripture, initialPosition, finalPosition, standardBooks){
        _narration = narration;
        _notesAboutNarration = notesAboutNarration;
    }

    // Actions
    //Getters & Setters
    public string GetNarration(){
        return _narration;
    }
    public string GetNotesAboutNarrations(){
        return _notesAboutNarration;
    }   
    public void SetNotesAboutNarration(string notesAboutNarration){
        _notesAboutNarration = notesAboutNarration;
    }

    //
    public override void Display()
    {
        base.Display();
        Console.Write($"{_narration}.\nNotes about narrations: {_notesAboutNarration}");
    }

    // Display all elements of the list
    public virtual void DisplayListElements(List<Narrations> list){
        foreach(Narrations narration in list){
            narration.Display();
        }
    }
    
    //
    public void DisplayOnlyNarration()
    {
        Console.Write(_narration);
    }
    
    //
    public void DisplayOnlyNarrationWithNotes()
    {
        Console.Write($"{_narration}.\nNotes about narrations: {_notesAboutNarration}");
    }
}