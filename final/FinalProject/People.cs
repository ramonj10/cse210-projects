public class People : ProperNames{
    // Attributos
    private People _father;
    private List<People>? _children;
    private Places _birthPlace;
    private Places _deathPlace;
    private List<Places> _placesWhereHeWas;  

    // Cosntructors
    //People oProperNames = new People("Unknown");
    
    // A new People just with the name
    public People(string name) : base(name){
        //_father = oProperNames;
    }

    // A new People with the name and his father name
    public People(string name, People father) : base(name){
        _father = father;
    }

    // A new People with the name and his children names
    public People(string name, List<People> children) : base(name){
        _children = children;
    }

    // A new People with the name, his father name and birthdate
    public People(string name, People father, DateTime startDate) 
                    : base(name, startDate){
        _father = father;
    }

    // A new People with the name, his father name, birthdate and death date.
    public People(string name, People father, DateTime startDate, DateTime endDate) 
                    : base(name, startDate, endDate){
        _father = father;
    }

    // A new People with the name, his father name and place of birth
    public People(string name, People father, Places birthPlace) : base(name){
        _father = father;
        _birthPlace = birthPlace;
    }

    public People(string name, People father, List<People> children) : base(name){
        _father = father;
        _children = children;
    }

    public People(string name, People father, List<People> children, Places birthPlace) : base(name){
        _father = father;
        _children = children;
        _birthPlace = birthPlace;
    }

    public People(string name, People father, List<People> children, Places birthPlace, DateTime startDate) : base(name, startDate){
        _father = father;
        _children = children;
        _birthPlace = birthPlace;
    }

    public People(string name, People father, List<People> children, Places birthPlace, DateTime startDate, DateTime endDate) 
                        : base(name, startDate, endDate){
        _father = father;
        _children = children;
        _birthPlace = birthPlace;
    } 

    public People(string name, People father, List<People> children, DateTime startDate) 
                    : base(name, startDate){
        _father = father;
        _children = children;
    }

    public People(string name, People father, List<People> children, DateTime startDate, DateTime endDate)
                    : base(name, startDate, endDate){
        _father = father;
        _children = children;
    }  

    // Actions
    // Getters y Setters
    public People GetFather(){
        return _father;
    }

    public List<People> GetChildren(){
        return _children;
    }

    public Places GetBirthPlace(){
        return _birthPlace;
    }
    
    public Places GetDeathPlace(){
        return _deathPlace;
    }

    public List<Places> GetPlacesWhereHeWas(){
        return _placesWhereHeWas;
    }
    
    public void SetFather(People father){
        _father = father;
    }

    public void SetChildren(List<People> children){
        _children = children;
    }

    public void SetBirthPlace(Places birthPlace){
        _birthPlace = birthPlace;
    }

    public void SetDeathPlace(Places deathPlace){
        _deathPlace = deathPlace;
    }

    public void SetPlacesWhereHeWas(List<Places> placesWhereHeWas){
        _placesWhereHeWas = placesWhereHeWas;
    }

    // Display people´s attributes
    public override void Display(){
        if (GetStartDate() != null & GetEndDate() != null & _birthPlace != null & _deathPlace != null){
            Console.WriteLine($"{GetName()}, son of {_father} has these children {_children}, born at {_birthPlace} in year {GetStartDate()} and pass away at {_deathPlace} in year {GetEndDate()}.");
            }
        
        else if (GetStartDate() != null & GetEndDate() != null & _birthPlace != null){
            Console.WriteLine($"{GetName()}, son of {_father} has these children {_children}, born at {_birthPlace} in year {GetStartDate()} and pass away in year {GetEndDate()}.");
        }
        else if (GetStartDate() != null & GetEndDate() != null){
            Console.WriteLine($"{GetName()}, son of {_father} has these children {_children}, born in year {GetStartDate()} and pass away in year {GetEndDate()}.");
        }
        else if (GetStartDate() != null){
            Console.WriteLine($"{GetName()}, son of {_father} has these children {_children}, born in year {GetStartDate()}.");
        }
        else {
            Console.WriteLine($"{GetName()}, son of {_father} has these children {_children}.");
        }
    }

    // Display all elements of the list
    public virtual void DisplayListElements(List<People> list){
        foreach(People people in list){
            people.Display();
        }
    }

    //
    private string ChildrenNames(){

        string names ="children ";
        foreach (People child in _children){
            names += ", " + child.GetName();
        }
        return names;
    }

    //
    public void DisplayWithChildren(){
        if (GetStartDate() != null & GetEndDate() != null & _birthPlace != null & _deathPlace != null){
            Console.WriteLine($"{GetName()}, son of {_father} has these children {ChildrenNames()}, born at {_birthPlace} in year {GetStartDate()} and pass away at {_deathPlace} in year {GetEndDate()}.");
            }
        
        else if (GetStartDate() != null & GetEndDate() != null & _birthPlace != null){
            Console.WriteLine($"{GetName()}, son of {_father} has these children {ChildrenNames()}, born at {_birthPlace} in year {GetStartDate()} and pass away in year {GetEndDate()}.");
        }
        else if (GetStartDate() != null & GetEndDate() != null){
            Console.WriteLine($"{GetName()}, son of {_father} has these children {ChildrenNames()}, born in year {GetStartDate()} and pass away in year {GetEndDate()}.");
        }
        else if (GetStartDate() != null){
            Console.WriteLine($"{GetName()}, son of {_father} has these children {ChildrenNames()}, born in year {GetStartDate()}.");
        }
        else {
            Console.WriteLine($"{GetName()}, son of {_father} has these children {ChildrenNames()}.");
        }
    }

    
    // Add new people to ListPeople
    public void AddNewPeople(People oPeople, List<People> oListPeople){
        if (oListPeople.Contains(oPeople) == false){
            oListPeople.Add(oPeople);
        }
    }
    
    // People Genealogical line (father, grandfather, great grandfather, etc.)
    public List<ProperNames> Genealogy(){
        List<ProperNames> genealogy = new List<ProperNames>();
        // .........
        
        return genealogy;
    }
}