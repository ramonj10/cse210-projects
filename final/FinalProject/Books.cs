public class Books : StandardBooks{
    // Attributes
    private string _book;
    private string? _abbreviation;
    private People? _author;
    private int? _startLine;
    
    // Constructores
    public Books(string standardBook) : base(standardBook){
        _book = "Unknown";
    }
    public Books (string book, string standardBook) : base(standardBook){
        _book = book;
    }
    public Books (string book, int startLine, string standardBook) : base(standardBook){
        _book = book;
        _startLine = startLine;
    }

    public Books (string book, string abbreviation, string standardBok) : base(standardBok){
        _book = book;
        _abbreviation = abbreviation;
    }

    public Books (string book, string abbreviation, People author, string standardBok) : base(standardBok){
        _book = book;
        _abbreviation = abbreviation;
        _author = author;
    }

    // Actions
    //Getters & Setters
    public string GetBook(){
        return _book;
    }
    public string GetAbbreviation(){
        return _abbreviation;
    }
    public People GetAuthor(){
        return _author;
    }
    public void SetAbbreviation(string abbreviation){
        _abbreviation = abbreviation;
    }
    public void SetAuthor(People author){
        _author = author;
    }

    // Display books attributes
    public override void Display()
    {
        Console.Write($"{_book} {_abbreviation} written by {_author} it belongs to the book of ");
        base.Display();
    }

    // Display all elements of the list
    public virtual void DisplayListElements(List<Books> list){
        foreach(Books books in list){
            books.Display();
        }
    }

    // Verify if the title already exist in BookList
    public void AddNewBook(string book, int lineNumber, string standardBook, List<Books> oBooksList){
        bool exists = oBooksList.Any(a => a.GetBook() == book);
        if (exists == false){
            Books oBook = new Books(book, lineNumber, standardBook);
            oBooksList.Add(oBook);
        }    
    }
}