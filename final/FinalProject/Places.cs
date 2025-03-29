using System.Diagnostics.Contracts;

public class Places : ProperNames{
    // Attributes
    private string _country;
    private string _region;
    private string _area;
    private People _namedBy;
    
    // Constructores
    public Places(string name, string country) : base(name){
        _country = country;
    }
    public Places(string name, DateTime startDate, string country) : base(name, startDate){
        _country = country;
    }
    public Places(string name, string country, string region) : base(name){
        _country = country;
        _region = region;
    }
    public Places(string name, DateTime startDate, string country, string region) : base(name, startDate){
        _country = country;
        _region = region;
    }
    public Places(string name, string country, string region, string area) : base(name){
        _country = country;
        _region = region;
        _area = area;
    }
    public Places(string name, DateTime startDate, string country, string region, string area) : base(name, startDate){
        _country = country;
        _region = region;
        _area = area;
    }
    public Places(string name, string country, string region, string area, People namedBy) : base(name){
        _country = country;
        _region = region;
        _area = area;
        _namedBy = namedBy;
    }
    public Places(string name, DateTime startDate, string country, string region, string area, People namedBy) : base(name, startDate){
        _country = country;
        _region = region;
        _area = area;
        _namedBy = namedBy;
    }

    // Actions
    //Getters & Setters
    public string GetCountry(){
        return _country;
    }        
    public string GetRegion(){
        return _region;
    } 
    public string GetArea(){
        return _area;
    } 
    public People GetNamedBy(){
        return _namedBy;
    } 
    public void SetRegion(string region){
        _region = region;
    } 
    public void SetArea(string area){
        _area = area;
    } 
    public void SetNamedBy(People namedBy){
        _namedBy = namedBy;
    }

    // 
    public override void Display(){
        base.Display();
        Console.Write($"Located in {_area}, {_region}, {_country}; was maned by {_namedBy} in {GetStartDate()}.");
    }

    // Display all elements of the list
    public virtual void DisplayListElements(List<Places> list){
        foreach(Places place in list){
            place.Display();
        }
    }

    //
    public List<string> Location(){
        List<string> location = new List<string>();
            location.Add( _area);
            location.Add( _region);
            location.Add(_country);

        return location;
    }

    //
    public void DisplayLocation(){
        foreach (string element in Location()){
            Console.Write($"{element} ,");
        }
    }
}