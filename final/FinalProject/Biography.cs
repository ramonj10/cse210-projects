public class Biography : People{
    // Attributes
    private List<Scriptures> _references;
    private List<Quotes>? _literalBiography;
    private List<Narrations>? _narrationsBiography;
    private List<Imaginations>? _imaginativeBiography;

    // Constructores
    public Biography(string name, People father, List<People> children, List<Scriptures> reference) : base(name, father, children){
        _references = reference;
    }

    // Actions
    //Getters & Setters
    public List<Scriptures> GetReference(){
        return _references;
    }
    public List<Quotes> GetLiteralBiography(){
        return _literalBiography;
    }
    public List<Narrations> GetNarrationsBiography(){
        return _narrationsBiography;
    }
    public List<Imaginations> GetImaginativeBiography(){
        return _imaginativeBiography;
    }
    public void SetReferences(List<Scriptures> reference){
        _references = reference;
    }
    public void GetLiteralBiography(List<Quotes> literalBiography){
        _literalBiography = literalBiography;
    }
    public void GetNarrationsBiography(List<Narrations> narrationsBiography){
        _narrationsBiography = narrationsBiography;
    }
    public void GetImaginativeBiography(List<Imaginations> imaginativeBiography){
        _imaginativeBiography = imaginativeBiography;
    }

    //
    public override void Display(){
        Console.Write($"\nThese are the reference's list where {GetName()} is mentioned: ");
        foreach (Scriptures reference in _references){
            reference.DisplayReference();
        }
        Console.Write($"\nThese are the literal quotes where {GetName()} appear in: ");
        DisplayLiteralBiography();
        Console.Write($"\nThis is how I think {GetName()} was based on the quotes about him: ");
        DisplayNarrationsBiography();
        Console.Write($"\nThis is how I imagine {GetName()} been like at his time: ");
        DisplayImaginativeBiography();
    }

    //
    public void DisplayLiteralBiography(){
        foreach (Quotes oQuote in _literalBiography){
            Console.Write($"{oQuote.GetBook()} {oQuote.GetChapter()}:{oQuote.GetVerse()}; {oQuote.GetQuote()}");
        } 
    }

    //
    public void DisplayLiteralBiographyConNotas(){
        foreach (Quotes oQuote in _literalBiography){
            Console.Write($"{oQuote.GetBook()} {oQuote.GetChapter()}:{oQuote.GetVerse()}; {oQuote.GetQuote()} \n{oQuote.GetNotesAboutQuotes()}");
        } 
    }

    //
    public void DisplayNarrationsBiography(){
        foreach (Narrations oBiography in _narrationsBiography){
            Console.Write($"{oBiography.GetBook()} {oBiography.GetChapter()}:{oBiography.GetVerse()}; {oBiography.GetNarration()}");
        } 
    }

    //
    public void DisplayNarrationsBiographyConNotas(){
        foreach (Narrations oBiography in _narrationsBiography){
            Console.Write($"{oBiography.GetBook()} {oBiography.GetChapter()}:{oBiography.GetVerse()}; {oBiography.GetNarration()}" +
            $"\n{oBiography.GetNotesAboutNarrations()}");
        } 
    }
    
    //
    public void DisplayImaginativeBiography(){
        foreach (Imaginations oBiography in _imaginativeBiography){
            Console.Write($"{oBiography.GetBook()} {oBiography.GetChapter()}:{oBiography.GetVerse()}; {oBiography.GetImagination()}");
        } 
    }

    //
    public void DisplayImaginativeBiographyConNotas(){
        foreach (Imaginations oBiography in _imaginativeBiography){
            Console.Write($"{oBiography.GetBook()} {oBiography.GetChapter()}:{oBiography.GetVerse()}; {oBiography.GetImagination()}" +
            $"\n{oBiography.GetNotesAboutImagination()}");
        } 
    }
}