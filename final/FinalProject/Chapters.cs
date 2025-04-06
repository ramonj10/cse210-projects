using System.Security.Principal;

public class Chapters : Books{
    // Attributes
    private int _chapter;
    private int? _lineNumber;


    // Constructors
    public Chapters(string book, string standardBook) : base(book, standardBook){
        _chapter = 0;
    }
    public Chapters(string book, int chapter, int lineNumber, string standardBook) : base(book, standardBook){
        _chapter = chapter;
        _lineNumber = lineNumber;
    }
    
    // Actions
    //Getters & Setters
    public int GetChapter(){
        return _chapter;
    }

    // Display chapter attributes
    public override void Display()
    {
        base.Display();
        Console.Write($"{_chapter}");
    }

    // Display all elements of the list

    public virtual void DisplayListElements(List<Chapters> list){
        foreach(Chapters chapter in list){
            chapter.Display();
        }
    }

    // Verify if the chapter already exist in ChapterList
    public void AddNewChapter(string book, int chapter, int lineNumber, string standardBook, List<Chapters> oChaptersList){
        bool exists = oChaptersList.Any(a => a.GetChapter() == chapter & a.GetBook() == book);
        if (exists == false){
            Chapters oChapter = new Chapters(book, chapter, lineNumber, standardBook);
            oChaptersList.Add(oChapter);
        }    
    }
}