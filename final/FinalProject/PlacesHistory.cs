public class PlacesHistory : Places{
    // Attributes
    private List<Scriptures> _reference;
    private List<Quotes>? _literalHistoryOfaPlace;
    private List<Narrations>? _narrationHistoryOfaPalce;
    private List<Imaginations>? _imaginativeHistoryOfaPlace;
    
    // Constructores
    PlacesHistory(string name, string country, List<Scriptures> reference) : base(name, country){
        _reference = reference;
    }
    PlacesHistory(string name, string country, string region, List<Scriptures> reference) : base(name, country, region){
        _reference = reference;
    }
    PlacesHistory(string name, string country, string region, string area, List<Scriptures> reference) : base(name, country, region, area){
        _reference = reference;
    }
    PlacesHistory(string name, string country, string region, string area, People namedBy, List<Scriptures> reference) 
                    : base(name, country, region, area, namedBy){
        _reference = reference;
    }

    // Actions
    //Getters & Setters
    public List<Scriptures> GetReference(){
        return _reference;
    }
    public List<Quotes> GetLiteralHistoryOfaPlace(){
        return _literalHistoryOfaPlace;
    }
    public List<Narrations> GeNarrativeHistroyOfaPlace(){
        return _narrationHistoryOfaPalce;
    }
    public List<Imaginations> GetImaginativeHistroyOfaPlace(){
        return _imaginativeHistoryOfaPlace;
    }
    public void SetReferences(List<Scriptures> reference){
        _reference = reference;
    }
    public void GetLiteralHistoryOfaPlace(List<Quotes> literalHistoryOfaPlace){
        _literalHistoryOfaPlace = literalHistoryOfaPlace;
    }
    public void SetNarrativeHistroyOfaPlace(List<Narrations> SetNarrativeHistroyOfaPlace){
        _narrationHistoryOfaPalce = SetNarrativeHistroyOfaPlace;
    }
    public void SetImaginativeHistroyOfaPlace(List<Imaginations> imaginativeHistoryOfaPlace){
        _imaginativeHistoryOfaPlace = imaginativeHistoryOfaPlace;
    }

    //
    public override void Display(){
        Console.Write($"\nThese are the reference´s list where {GetName()} is mentioned: ");
        foreach (Scriptures reference in _reference){
            reference.DisplayReference();
        }
        Console.Write($"\nThese are the  literal quotes where {GetName()} is mentioned: ");
        DisplayLiteralHistoryOfaPlace();
        Console.Write($"\nThis is how I think that {GetName()} was like base on the quotes about it: ");
        DisplayNarrationsHistoryOfaPlace();
        Console.Write($"\n Thsi is how I imagined {GetName()} was like in those days: ");
        DisplayImaginativeHistoryOfaPlace();
    }

    // Display all elements of the list
    public virtual void DisplayListElements(List<PlacesHistory> list){
        foreach(PlacesHistory placeHistory in list){
            placeHistory.Display();
        }
    }
    
    //
    public void DisplayLiteralHistoryOfaPlace(){
        foreach (Quotes oQuote in _literalHistoryOfaPlace){
            Console.Write($"{oQuote.GetBook()} {oQuote.GetChapter()}:{oQuote.GetVerse()}; {oQuote.GetQuote()}");
        } 
    }

    //
    public void DisplayLiteralHistoryOfaPlaceWithNotes(){
        foreach (Quotes oQuote in _literalHistoryOfaPlace){
            Console.Write($"{oQuote.GetBook()} {oQuote.GetChapter()}:{oQuote.GetVerse()}; {oQuote.GetQuote()} \n{oQuote.GetNotesAboutQuotes()}");
        } 
    }

    //
    public void DisplayNarrationsHistoryOfaPlace(){
        foreach (Narrations oPlaceHistory in _narrationHistoryOfaPalce){
            Console.Write($"{oPlaceHistory.GetBook()} {oPlaceHistory.GetChapter()}:{oPlaceHistory.GetVerse()}; {oPlaceHistory.GetNarration()}");
        } 
    }

    //
    public void DisplayNarrationsHistoryOfaPlaceWithNotes(){
        foreach (Narrations oPlaceHistory in _narrationHistoryOfaPalce){
            Console.Write($"{oPlaceHistory.GetBook()} {oPlaceHistory.GetChapter()}:{oPlaceHistory.GetVerse()}; {oPlaceHistory.GetNarration()}" +
            $"\n{oPlaceHistory.GetNotesAboutNarrations()}");
        } 
    }
    
    //
    public void DisplayImaginativeHistoryOfaPlace(){
        foreach (Imaginations oPlaceHistory in _imaginativeHistoryOfaPlace){
            Console.Write($"{oPlaceHistory.GetBook()} {oPlaceHistory.GetChapter()}:{oPlaceHistory.GetVerse()}; {oPlaceHistory.GetImagination()}");
        } 
    }

    //
    public void MostrarHistoriaLugarImaginativaWithNotes(){
        foreach (Imaginations oPlaceHistory in _imaginativeHistoryOfaPlace){
            Console.Write($"{oPlaceHistory.GetBook()} {oPlaceHistory.GetChapter()}:{oPlaceHistory.GetVerse()}; {oPlaceHistory.GetImagination()}" +
            $"\n{oPlaceHistory.GetNotesAboutImagination()}");
        } 
    }
    
}