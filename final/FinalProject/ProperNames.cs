using static System.DateTime;

public class ProperNames {
    // Attributes
    private string _name;
    private DateTime _startDate;
    private DateTime _endDate;

    // Constructors
    public ProperNames(){
        _name = "Desconocido";
    }

    public ProperNames(string name){
        _name = name;
    }

    public ProperNames(string name, DateTime startDate){
        _name = name;
        _startDate = startDate;
    }

    public ProperNames(string name, DateTime startDate, DateTime endDate){
        _name = name;
        _startDate = startDate;
        _endDate = endDate;
    }

    // Actions
    //Getters & Setters
    public string GetName(){
        return _name;
    }

    public DateTime GetStartDate (){
        return _startDate;
    }

    public DateTime GetEndDate(){
        return _endDate;
    }

    public void SetName( string name){
        _name = name;
    }
    public void SetStartDate (DateTime startDate){
        _startDate = startDate;
    }

    public void SetEndDate (DateTime endDate){
        _endDate = endDate;
    }

    // Display proper name attributes
    public virtual void Display(){
        Console.WriteLine($"{_name} ({_startDate.Year} - {_endDate.Year})");
    }
    
    // Display all elements of the list
    public virtual void DisplayListElements(List<ProperNames> list){
        foreach (ProperNames properNames in list){
            properNames.Display();
        }
    }  
}