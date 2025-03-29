public class Quotes : Scriptures{
    // Attributes
    private int _initialPosition;
    private int _finalPosition;
    private int? _year;
    private string?  _prefix;
    private string? _suffix;
    private string? _notesAboutQuote;

    // Constructores
    public Quotes(string book, int chapter, int verse, string scripture, int initialPosition, int lineNumber, string standardBook) 
                : base(book, chapter, verse, scripture, lineNumber, standardBook){
        _initialPosition = initialPosition;
        _finalPosition = scripture.Length-1;
    }
    public Quotes(string book, int chapter, int verse, string scripture, int initialPosition, int finalPosition, int lineNumber, string standardBook) 
                : base(book, chapter, verse, scripture, lineNumber, standardBook){
        _initialPosition = initialPosition;
        _finalPosition = finalPosition;
    }
        
    public Quotes(string book, int chapter, int verse, string scripture, int initialPosition, int finalPosition, int lineNumber, string notesAboutQuotes, string standardBook) 
                : base(book, chapter, verse, scripture, lineNumber, standardBook){
        _initialPosition = initialPosition;
        _finalPosition = finalPosition;
        _notesAboutQuote = notesAboutQuotes;
    }

    // ACctions
    //Getters & Setters
    string quote;
    public int GetInitialPosition(){
        return _initialPosition;
    }
    public int GetFinalPosition(){
        return _finalPosition;
    }
    public string GetNotesAboutQuotes(){
        return _notesAboutQuote;
    }
    public string GetQuote(){
        for (int i=_initialPosition; i<_finalPosition; i++){
            quote = GetScripture().Substring(_initialPosition, _finalPosition);
        }
        return quote;
    }
    public void GetNotesAboutQuotes(string notesAboutQuotes){
        _notesAboutQuote = notesAboutQuotes;
    }

    //
    public override void Display(){
        for (int i=_initialPosition; i<_finalPosition; i++){
            quote = GetScripture().Substring(_initialPosition, _finalPosition);
        }
        Console.Write($"{GetBook()} {GetChapter()}:{GetVerse()} {quote}\n  Notes about this quote: {_notesAboutQuote}");
    }

    // Display all elements of the list
    public virtual void DisplayListElements(List<Quotes> list){
        foreach(Quotes quote in list){
            quote.Display();
        }
    }

    //
    public void DisplayOnlyQuote(){
        for (int i=_initialPosition; i<_finalPosition; i++){
            quote = GetScripture().Substring(_initialPosition, _finalPosition);
        }
        Console.Write(quote);
    }
}