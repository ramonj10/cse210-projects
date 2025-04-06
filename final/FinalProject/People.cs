using System.Linq;

public class People : ProperNames{
    // Attributos
    private People _father;
    private List<People>? _children;
    private Places _birthPlace;
    private Places _deathPlace;
    private List<Places> _placesWhereHeWas;  

    // Cosntructors
    
    // A new People just with the name
    public People(string name) : base(name){
        //_father = oProperNames;
    }

    // A new People with the name and his father name
    public People(string name, People father) : base(name){
        _father = father;
    }

    // A new People with the name and his children names
    public People(string name, People father, List<People> children) : base(name){
        _father = father;
        _children = children;
    }

    // A new People with the name, his father name and birthdate
    public People(string name, People father, List<People> children, DateTime startDate) 
                    : base(name, startDate){
        _father = father;
        _children = children;
    }

    // A new People with the name, his father name, birthdate and death date.
    public People(string name, People father, List<People> children, DateTime startDate, DateTime endDate) 
                    : base(name, startDate, endDate){
        _father = father;
        _children = children;
    }

    // A new People with the name, his father name and place of birth
    public People(string name, People father, List<People> children, DateTime startDate, DateTime endDate, Places birthPlace) 
                : base(name, startDate, endDate){
        _father = father;
        _children = children;
        _birthPlace = birthPlace;
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
        if (_children != null){
            if (GetStartDate() == DateTime.MinValue & _father == null){
                foreach( People oChild in _children){
                    Console.WriteLine($"{GetName()}, has these children: {oChild.ChildrenNames(_children)}.");
                }
            }
            else if (GetStartDate() == DateTime.MinValue & _father != null){
                foreach( People oChild in _children){
                    Console.WriteLine($"{GetName()}, son of {FatherName()} has these children: {oChild.ChildrenNames(_children)}.");
                }
            }
        }
        else{
            if (GetStartDate() != DateTime.MinValue & GetEndDate() != DateTime.MinValue & _birthPlace != null & _deathPlace != null & _father != null){
                Console.WriteLine($"{GetName()}, son of {FatherName()}, born at {_birthPlace} in year {GetStartDate()} and pass away at {_deathPlace} in year {GetEndDate()}.");
                }
            
            else if (GetStartDate() == DateTime.MinValue & GetEndDate() != DateTime.MinValue & _birthPlace != null & _father != null){
                Console.WriteLine($"{GetName()}, son of {FatherName()}, born at {_birthPlace} in year {GetStartDate()} and pass away in year {GetEndDate()}.");
            }
            else if (GetStartDate() == DateTime.MinValue & GetEndDate() != DateTime.MinValue & _father != null){
                Console.WriteLine($"{GetName()}, son of {FatherName()}, born in year {GetStartDate()} and pass away in year {GetEndDate()}.");
            }
            else if (GetStartDate() == DateTime.MinValue & _father != null){
                Console.WriteLine($"{GetName()}, son of {FatherName()}.");
            }
            else {
                Console.WriteLine($"{GetName()}.");  // , has these children {_children[0].ChildrenNames(_children)}.
            }
        }
    }

    // Display all elements of the list
    public virtual void DisplayListElements(List<People> list){
        if (list.Count() == 0){
                Console.WriteLine("There is no people on the list at this time\n");
            }
        else{
            foreach(People people in list){
                if (people._children == null){
                    people.Display();
                }
                else{
                    people.DisplayWithChildren();
                }
            }
        }
    }

    //
    public virtual void ListElements(List<People> list){
        if (list.Count() == 0){
                Console.WriteLine("There is no people on the list at this time\n");
            }
        else{
            foreach(People people in list){
                Console.Write($"{people.GetName()}, ");
            }
            Console.WriteLine();
        }
    }

    //
    private string FatherName(){
        return (GetFather()).GetName();
    }
    
    //
    private string ChildrenNames(List<People> children){
        string names ="";
        foreach (People child in children){
            names += child.GetName() + ", ";
        }
        return names;
    }

    //
    public void DisplayWithChildren(){
        if (GetStartDate() != null & GetEndDate() != null & _birthPlace != null & _deathPlace != null){
            Console.WriteLine($"{GetName()}, son of {_father.GetName()} has these children: {ChildrenNames(_children)}, born at {_birthPlace} in year {GetStartDate()} and pass away at {_deathPlace} in year {GetEndDate()}.");
            }
        
        else if (GetStartDate() != null & GetEndDate() != null & _birthPlace != null){
            Console.WriteLine($"{GetName()}, son of {_father.GetName()} has these children: {ChildrenNames(_children)}, born at {_birthPlace} in year {GetStartDate()} and pass away in year {GetEndDate()}.");
        }
        else if (GetStartDate() != null & GetEndDate() != null){
            Console.WriteLine($"{GetName()}, son of {_father.GetName()} has these children: {ChildrenNames(_children)}, born in year {GetStartDate()} and pass away in year {GetEndDate()}.");
        }
        else if (GetStartDate() != null){
            Console.WriteLine($"{GetName()}, son of {_father.GetName()} has these children: {ChildrenNames(_children)}, born in year {GetStartDate()}.");
        }
        else {
            Console.WriteLine($"{GetName()}, son of {_father.GetName()} has these children: {ChildrenNames(_children)}.");
        }
    }

    
    // Add new people to ListPeople
    public void AddNewPeople(People oPeople, List<People> oPeopleList){
        if (oPeopleList.Contains(oPeople) == false){
            oPeopleList.Add(oPeople);
        }
    }
    
    // Input new people through the People Add Option
    public void InputNewPeople (List<People> oPeopleList){
        //Create needed variables to collect input to Add People
        DateTime startDate = new DateTime();
        DateTime endDate = new DateTime();
        People person = new People("");
        People father = new People("Unkown");
        People unkownFather = new People("Unkown", father);
        string fatherInput;
        List<People> children = new List<People>();

        // To prevent oPeopleList to be empty
        if (oPeopleList.Count == 0){
            oPeopleList.Add(unkownFather);
        }
        
        Console.Write("\nWhat name do you want to Add? ");
        string name = Console.ReadLine()!;  // ! null-forgiveness operator
        if (oPeopleList.Any(a => a.GetName() != name)){
                
            Console.Write("\nInput the birthday (mm-dd-yyyy) and enter or just enter if you don´t know it. ");
            string birthday = Console.ReadLine()!;  // ! null-forgiveness operator
                    
            if (birthday.Length == 10){
                startDate = DateTime.Parse(birthday);  //ERROR if year has less than 4 digit
            }
                    
            Console.Write("\nInput the Death Date (mm-dd-yyyy) and enter or just enter if you don´t know it. ");
            string deathDate = Console.ReadLine()!;  // ! null-forgiveness operator
                    
            if (deathDate.Length == 10){
                endDate = DateTime.Parse(deathDate);    //ERROR if year has less than 4 digit
            }

            Console.Write("\nFather´s Name: (or Enter to skip)");
            fatherInput = Console.ReadLine()!;
            if (fatherInput.Length >= 2){
                father = new People(fatherInput, father);
                father.AddNewPeople(father, oPeopleList);
            }
            else{
                father = unkownFather;
            }

            // 
            if (oPeopleList.Any(a => a.GetName() != name)){
                person = new People(name, father);
                
                foreach (People oChild in children){
                    oChild.ModifyFather(oChild.GetName(), person, oPeopleList);
                }
            }

            string child ="";
            while (child != "q"){
                Console.Write("\nChildren's name: (q to quit) ");
                child = Console.ReadLine()!;
                People oPeopleChild = new People(child, person);

                // A child name must have more than two character        
                if (child.Length <= 2 & child != "q"){
                    oPeopleChild = null;
                }
                //
                else if (child.Length > 2){
                    Console.WriteLine($"{oPeopleChild.GetName()} is son of {person.GetName()}");
                    oPeopleChild.AddNewPeople(oPeopleChild, oPeopleList);
                    children.Add(oPeopleChild);
                }
                else if (child == "q"){
                    person.AddChildren(children);
                    person.Display();
                }
            } 
        }

        else {
            Console.WriteLine($"Already there is a {name} created with this data:\n");
        }

        //Determine the constuctor to be use    
               
        // Only with people name
        if (startDate == DateTime.MinValue & endDate == DateTime.MinValue & father == unkownFather & children.Count == 0){   // DateTime.MinValue es que no hay fecah (El menor valor posible)
            People newName = new People(name);
            oPeopleList.Add(newName);
            //oPeopleList.AddNewPeople(newName, oPeopleList);
        }

        // Only with people name and children
        if (startDate == DateTime.MinValue & endDate == DateTime.MinValue & father == unkownFather & children.Count != 0){   // DateTime.MinValue es que no hay fecah (El menor valor posible)
            People newName = new People(name, father, children);
            oPeopleList.Add(newName);
            //oPeopleList.AddNewPeople(newName, oPeopleList);
        }

        // With people and fathers name
        else if (startDate == DateTime.MinValue & endDate == DateTime.MinValue & father != unkownFather & children.Count == 0){
            People newName = new People(name, father);
            oPeopleList.Add(newName);
            //oPeopleList.AddNewPeople(newName, oPeopleList);
        }

        // With people and fathers name and birthday
        else if (startDate != DateTime.MinValue & endDate == DateTime.MinValue & father != unkownFather & children.Count == 0){
            People newName = new People(name, father, children, startDate);
            oPeopleList.Add(newName);
            //oPeopleList.AddNewPeople(newName, oPeopleList);
        }

        // With people name and birthday
        else if ( endDate == DateTime.MinValue & startDate != DateTime.MinValue & father == unkownFather & children.Count == 0){
            People newName = new People(name, father, children, startDate);
            oPeopleList.Add(newName);
            //oPeopleList.AddNewPeople(newName, oPeopleList);
        }
                
        // With People name, birth and death date
        else if ( startDate != DateTime.MinValue & endDate != DateTime.MinValue & father == unkownFather & children.Count == 0){
            People newName = new People(name, father, children, startDate, endDate);
            oPeopleList.Add(newName);
            //oPeopleList.AddNewPeople(newName, oPeopleList);
        }
    }

    // Find a People object within List of people    
    public People FindPeopleObject(string name, List<People> oPeopleList){
        var oFound = oPeopleList.Where(p => p.GetName() == name).ToList();
        return oFound[0];
    }

    public People FindPeopleObjectOrCreateIt(string name, List<People> oPeopleList){
        People value = new People(name);
        // Verify if there is an object with that name
        foreach (People oP in oPeopleList){
            if (Equals(name)){
                value = oP;
            }
            else{
                // Invite to create a person with that name if doesn´t exist already
                string userAnswer = "";
                while (userAnswer == ""){
                    Console.WriteLine($"Do you want to create a new person for {name}? (y/n)");
                    userAnswer = Console.ReadLine();
                    if (userAnswer == "y" || userAnswer =="Y"){
                        value.AddNewPeople(value, oPeopleList);
                    }
                    else if (userAnswer == "n" || userAnswer == "N"){
                        value = null;
                        userAnswer = " ";
                    }
                    else{
                        userAnswer = "";
                    }
                }
            }
        } 
        return value;
    }
    
    // Modify a peron's name with a different one
    public void ModifyName(string name, string newName, List<People> oPeopleList){
        foreach (People oP in oPeopleList){
            if (oP.GetName() == name){
                oP.SetName(newName);
                //Update the people in the list
                int index = oPeopleList.FindIndex(p => p.GetName() == name);
                if (index != -1){
                    oPeopleList[index] = oP;
                }
            }
        }
    }

    public void ModifyFather(string name, People newFather, List<People> oPeopleList){
        // Verify that newFather exist or create it
        if (newFather.FindPeopleObject(newFather.GetName(), oPeopleList) != null){
            Console.WriteLine($"Encontró el nombre del padre: {newFather.GetName()}");
            
            // Find the person to modify its father
            int index = oPeopleList.FindIndex(p => p.FatherName() == name);
                if (index != -1){
                    oPeopleList[index].SetFather(newFather);
                }
        }
    }

    // Add children to their father
    public void AddChildren(List<People> children){
        SetChildren(children);
    }

    // Delete a person data
    public void DeletePerson(string name, List<People> oPeopleList){
        List<People> toRemove = new List<People>();

        foreach (People oPeople in oPeopleList){
            if (oPeople.GetName() == name){
                toRemove.Add(oPeople);
            }
       }
       foreach (People oP in toRemove){
            if (oP.GetName() == name){
                oPeopleList.Remove(oP);                
            }
       }
    }
    
    // People Genealogical line (father, grandfather, great grandfather, etc.)
    public List<ProperNames> Genealogy(){
        List<ProperNames> genealogy = new List<ProperNames>();
        // .........
        
        return genealogy;
    }
}