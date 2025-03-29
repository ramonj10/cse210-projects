using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Declare objects list needed
        List<ProperNames> oProperNamesList = new List<ProperNames>();
        List<People> oPeopleList = new List<People>();
        List<StandardBooks> oStandardBooksList = new List<StandardBooks>();
        List<Books> oBooksList = new List<Books>();
        List<Chapters> oChaptersList = new List<Chapters>();
        List<Verses> oVersesList = new List<Verses>();
        List<Scriptures> oScripturesList = new List<Scriptures>();  

        
        // Upload Scriptures Files
        string scriptureFile = "BookOfMormon.txt";
        string standardBook = "Book of Mormon";
        string[] bookLines = System.IO.File.ReadAllLines(scriptureFile);
        
        // Declare variables
        int lineNumber = 0;
        string title;
        int chapter;
        int verse;

        // Declare objects
        StandardBooks oStandardBook =  new StandardBooks(standardBook);
        Books oBook = new Books(standardBook);
        Chapters oChapter = new Chapters("Unknown", standardBook);
        

        oStandardBook.AddNewStandardBook(standardBook, oStandardBooksList);

        foreach (string line in bookLines){
            lineNumber += 1;
            if (line.Contains("Chapter")){
                int position = line.IndexOf("Chapter");
                title = line.Substring(0,position-1);
                Console.WriteLine($"Ha llegado hasta aquí {position} y final {line.Length-1}");
                string chapterText = line.Substring(line.Length-(position+8));
                int.TryParse(chapterText, out chapter);
                
                oChapter = new Chapters(title, standardBook);
                oBook.AddNewBook(title, lineNumber, standardBook, oBooksList);    
                oChapter.AddNewChapter(title, chapter, lineNumber, standardBook, oChaptersList);
            }
            // SIN TERMINAR
            if (Regex.IsMatch(line[0], "^(1|2|3|4|5|6|7|8|9)")){
                int position = line.IndexOf(" ");
                int verse = ParseInt(line[0,position-1]);
                Verses oVerse = new Verses(title, chapter, verse, standardBooks)
            }
            // SIN TERMINAR
            Console.Write("The Standard Books are:");
            oStandardBook.DisplayListElements(oStandardBooksList);

            Console.Write("The Books are:");
            oBook.DisplayListElements(oBooksList); 
        
            Console.Write("The Chapters are:");
            oChapter.DisplayListElements(oChaptersList); 
        }
        
        // Upload the Menus
        List<Menus> menusList = new List<Menus>();
        string filenameMenu = "Menus.txt";
        string [] menuLine = System.IO.File.ReadAllLines(filenameMenu);
        foreach (string line in menuLine){
            string[] part = line.Split(",");

            string menuId = part[0];
            string menuName = part[1];
            string idOption = part [2];
            string Option = part [3];
            Menus Menu = new Menus(menuId, menuName, idOption, Option);
            menusList.Add(Menu);
        }

        List<Menus> menuList0 = new List<Menus>();
        List<Menus> menuList1 = new List<Menus>();
        List<Menus> menuList2 = new List<Menus>();
        List<Menus> menuList3 = new List<Menus>();
        List<Menus> menuList4 = new List<Menus>();
        List<Menus> menuList5 = new List<Menus>();
        List<Menus> menuList6 = new List<Menus>();
        List<Menus> menuList1_1 = new List<Menus>();

        List<Menus> menuList1_2 = new List<Menus>();
        List<Menus> menuList1_3 = new List<Menus>();
        List<Menus> menuList1_4 = new List<Menus>();
        List<Menus> menuList1_5 = new List<Menus>();
        List<Menus> menuList1_6 = new List<Menus>();
        List<Menus> menuList2_1 = new List<Menus>();
        List<Menus> menuList2_2 = new List<Menus>();
        List<Menus> menuList2_3 = new List<Menus>();
        List<Menus> menuList2_4 = new List<Menus>();
        List<Menus> menuList2_5 = new List<Menus>();
        List<Menus> menuList2_6 = new List<Menus>();
        List<Menus> menuList3_1 = new List<Menus>();
        List<Menus> menuList3_2 = new List<Menus>();
        List<Menus> menuList3_3 = new List<Menus>();
        List<Menus> menuList3_4 = new List<Menus>();
        List<Menus> menuList3_5 = new List<Menus>();
        List<Menus> menuList3_6 = new List<Menus>();
        
        
        List<Menus> menuList1_1_1 = new List<Menus>();
        
        //menusList[0].AnaliceMenuOptions();
        for (int i=0; i<menusList.Count ; i++) {
            Console.WriteLine($"El MenuId es: {menusList[i].MenuId} para {menusList[i].GetMenuName}");
                if (menusList[i].MenuId == "0"){
                    menuList0.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1"){
                    menuList1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "2"){
                    menuList2.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "3"){
                    menuList3.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "4"){
                    menuList4.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "5"){
                    menuList5.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "6"){
                    menuList6.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1_1"){
                    menuList1_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1_1_1"){
                    menuList1_1_1.Add(menusList[i]);
                }
        }
        
        // menusList[0].AnaliceMenuOptions();
        
        // Display the recurrent Main Menu
        bool replay0 =true;
        while (replay0 == true){
            
            menuList0[0].DisplayMenu(menuList0);           
            Console.Write("Choose an choice from the Menu: ");
            string? choice = Console.ReadLine(); 
            while (choice != "0"){
                if (choice == "1"){
                    
                    bool replay1 = true;
                    while (replay1 == true){
                        menuList1[0].DisplayMenu(menuList1);
                        Console.Write("Choose an choice from the Menu: ");
                        string? choice1 = Console.ReadLine();
                        while (choice1 != "0"){
                            if (choice1 == "1"){
                            
                                bool replayMenu1_1 = true;
                                while (replayMenu1_1 == true){
                                    menuList1_1[0].DisplayMenu(menuList1_1);
                                    Console.Write("Choose an choice from the Menu: ");
                                    string? choice1_1 = Console.ReadLine();
                                    while (choice1_1 != "0"){
                                        if (choice1_1 == "1"){
                                        
                                            bool replayMenu1_1_1 = true;
                                            while (replayMenu1_1_1 == true){
                                                menuList1_1_1[0].DisplayMenu(menuList1_1_1);
                                                Console.Write("Choose an choice from the Menu: ");
                                                string? choice1_1_1 = Console.ReadLine();
                                                while (choice1_1_1 != "0"){
                                                    if (choice1_1_1 == "1"){
                                                    }
                                                    else if (choice1_1_1 == "2"){
                                                        menuList2[0].DisplayMenu(menuList2);
                                                    }
                                                    else if (choice1_1_1 == "3"){
                                                        menuList3[0].DisplayMenu(menuList3);
                                                    }
                                                    else{
                                                        Console.WriteLine("Your choice is not valid.\nChoose an choice between 1 to 0.\n\n");
                                                        menuList1_1_1[0].DisplayMenu(menuList1_1_1);
                                                        Console.Write("Choose an choice from the Menu: ");
                                                        choice1_1_1 = Console.ReadLine();
                                                    }
                                                }    
                                                if (choice1_1_1 == "0"){
                                                    replayMenu1_1_1 = false;
                                                    choice1_1 = "";
                                                }
                                                
                                            }
                                        }
                                        else if (choice1_1 == "2"){
                                            menuList2[0].DisplayMenu(menuList2);
                                        }
                                        else if (choice1_1 == "3"){
                                            menuList3[0].DisplayMenu(menuList3);
                                        }
                                        else{
                                            Console.WriteLine("Your choice is not valid.\nChoose an choice between 1 to 0.\n\n");
                                            menuList1_1[0].DisplayMenu(menuList1_1);
                                            Console.Write("Choose an choice from the Menu: ");
                                            choice1_1 = Console.ReadLine();
                                        }
                                    }
                                    if (choice1_1 == "0"){
                                        replayMenu1_1 = false;
                                        choice1 = "";
                                    }
                                }
                            }
                            else if (choice1 == "2"){
                                menuList2[0].DisplayMenu(menuList2);
                            }
                            else if (choice1 == "3"){
                                menuList3[0].DisplayMenu(menuList3);
                            }
                            else{
                                Console.WriteLine("Your choice is not valid.\nChoose an choice between 1 to 0.\n\n");
                                menuList1[0].DisplayMenu(menuList1);
                                Console.Write("Choose an choice from the Menu: ");
                                choice1 = Console.ReadLine();
                            }
                        }
                        if (choice1 == "0"){
                            replay1 = false;
                            choice = "";
                        }
                    }
                }
                else if (choice == "2"){
                    menuList2[0].DisplayMenu(menuList2);
                }
                else if (choice == "3"){
                    menuList3[0].DisplayMenu(menuList3);
                    Console.Write("Choose an choice from the Menu: ");
                    string? choice3 = Console.ReadLine(); 
                }
                else{
                    Console.WriteLine("Your choice is not valid.\nChoose an choice between 1 to 0.\n\n");
                    menuList0[0].DisplayMenu(menuList0);
                    Console.Write("Choose an choice from the Menu: ");
                    choice = Console.ReadLine();
                }
            }
            
            if (choice == "0"){
                replay0 = false;
            }
        
        
            /*// choice Menu
            Console.WriteLine("PROPER NAME MENU\n" + 
                            "1. Add\n" +
                            "2. Modify\n" +
                            "3. Display\n" +
                            "q. Quit the program\n");
            Console.Write("Choose one of the menu choices and press enter: ");
            string choice = Console.ReadLine()!;
            */
            
            // Analice selected choice
            if (choice == "1"){
                //Create needed variables to collect input
                DateTime startDate = new DateTime();
                DateTime endDate = new DateTime();
                People unkownFather = new People("Unkown");
                People father = new People("");
                string fatherInput;
                List<People> children = new List<People>();

                Console.Write("\n¿What name do you want to Add? ");
                string name = Console.ReadLine()!;  // ! null-forgiveness operator
                
                Console.Write("\nInput the birthday (mm-dd-yyyy) and enter or just enter if you don´t know it. ");
                string birthday = Console.ReadLine()!;  // ! null-forgiveness operator
                
                if (birthday.Length == 10){
                    startDate = DateTime.Parse(birthday);
                }
                
                Console.Write("\nInput the Death Date (mm-dd-yyyy) and enter or just enter if you don´t know it. ");
                string deathDate = Console.ReadLine()!;  // ! null-forgiveness operator
                
                if (deathDate.Length == 10){
                    endDate = DateTime.Parse(deathDate);
                }

                Console.Write("\nFather´s Name: ");
                fatherInput = Console.ReadLine()!;
                if (fatherInput.Length >= 2){
                    father = new People(fatherInput);
                    father.AddNewPeople(father, oPeopleList);
                }
                else{
                    father = unkownFather;
                }

                string child ="";
                while (child != "q"){
                    Console.Write("\nChildren's name: (q to quit) ");
                    child = Console.ReadLine()!;
                    
                    if (child == "q"){
                        break;
                    }
                    else if (child.Length <= 2){
                        Console.WriteLine($"Child length is {child.Length}");
                        child = null;
                    }
                    else{
                        People oPeopleChild = new People(child);
                        Console.WriteLine($"Child name is {child}");
                        oPeopleChild.AddNewPeople(oPeopleChild, oPeopleList);
                        children.Add(oPeopleChild);
                        oPeopleChild.Display();
                        foreach (People element in children){
                            Console.Write("Hijos: ");
                            element.Display();
                        }
                        foreach (People element in oPeopleList){
                            Console.Write("Personajes: ");
                            element.Display();
                        }
                    }
                }

                //Determine the constuctor to be use    
                
                // Only with people name
                if (startDate == DateTime.MinValue & endDate == DateTime.MinValue & father == unkownFather & children.Count == 0){   // DateTime.MinValue es que no hay fecah (El menor valor posible)
                    People newName = new People(name);
                    oPeopleList.Add(newName);
                }

                // Only with people name and children
                if (startDate == DateTime.MinValue & endDate == DateTime.MinValue & father == unkownFather & children.Count != 0){   // DateTime.MinValue es que no hay fecah (El menor valor posible)
                    People newName = new People(name, children);
                    oPeopleList.Add(newName);
                }

                // With people and fathers name
                else if (startDate == DateTime.MinValue & endDate == DateTime.MinValue & father != unkownFather & children.Count == 0){
                    People newName = new People(name, father);
                    oPeopleList.Add(newName);
                }

                // With people and fathers name and birthday
                else if (startDate != DateTime.MinValue & endDate == DateTime.MinValue & father != unkownFather & children.Count == 0){
                    People newName = new People(name, father, startDate);
                    oPeopleList.Add(newName);
                }

                // With people name and birthday
                else if ( endDate == DateTime.MinValue & startDate != DateTime.MinValue & father == unkownFather & children.Count == 0){
                    People newName = new People(name, unkownFather, startDate);
                    oPeopleList.Add(newName);
                }
                
                // With People name, birth and death date
                else if ( startDate != DateTime.MinValue & endDate != DateTime.MinValue & father == unkownFather & children.Count == 0){
                    People newName = new People(name, unkownFather, startDate, endDate);
                    oPeopleList.Add(newName);
                }
            }
            
            else if (choice == "2"){

            }
            
            else if (choice == "3"){
                Console.Write("\n¿Which name do you want to display? ");
                string name = Console.ReadLine()!;  // ! null-forgiveness operator
                foreach (People el in oPeopleList){
                    if (el.GetName() == name){
                        el.DisplayWithChildren();
                    }
                }
            }

            else if (choice == "0"){
                replay0 = false;
            }
        }
    }
}

