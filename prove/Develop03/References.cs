class References
{
    // Declares attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _finalVerse;

    // Set up Cosntructors
    public References(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _finalVerse = 0;
    }
    public References(string book, int chapter, int verse, int finalVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _finalVerse = finalVerse;
    } 

    public string GetRefernce()
    {
        string reference;
        if (_finalVerse > 0){
            reference = $"{_book} {_chapter}:{_verse}-{_finalVerse}";
        }
        else{
            reference = $"{_book} {_chapter}:{_verse}";
        }
        return reference;
    }
}