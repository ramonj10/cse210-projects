public class StandardBooks{
    // Atributos
    private string _standardBook;
    
    // Constructors
    public StandardBooks(string standardBook){
        _standardBook = standardBook;
    }

    // Actions
    //Getters & Setters
    public string GetStandardBook(){
        return _standardBook;
    }

    // Display standard books attributes
    public virtual void Display(){
        Console.Write($"{_standardBook} ");
    }

    // Display all elements of the list
    public virtual void DisplayListElements(List<StandardBooks> list){
        foreach(StandardBooks standardBooks in list){
            standardBooks.Display();
        }
    }

    // Add new Standard book if it doesn´t exit in the list
    public void AddNewStandardBook(string standardBook, List<StandardBooks> oStandardBooksList){
        bool exists = oStandardBooksList.Any(a => a.GetStandardBook() == standardBook);
        if (exists == false){
            StandardBooks oStandardBook = new StandardBooks(standardBook);
            oStandardBooksList.Add(oStandardBook);
        }
    }
}