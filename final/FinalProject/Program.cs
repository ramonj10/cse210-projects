using System;
using System.Text.RegularExpressions;

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
        string title = "";
        int chapter= 0;
        int verse = 0;
        DateTime startDate = new DateTime();
        DateTime endDate = new DateTime();

        // Declare objects
        StandardBooks oStandardBook =  new StandardBooks(standardBook);
        Books oBook = new Books(standardBook);
        Chapters oChapter = new Chapters(title, chapter, lineNumber, standardBook);
        Verses oVerse = new Verses(title, chapter, verse, lineNumber, standardBook);
        People father = new People("Unkown");
        People oPeople = new People("", father);
        People person = new People("", father);
        People oPeopleFound = new People("", father);
        People unkownFather = new People("Unkown", father);

        oStandardBook.AddNewStandardBook(standardBook, oStandardBooksList);

        foreach (string line in bookLines){
            lineNumber += 1;
            if (line.Length == 0){   // If the line is empty do nothing with it and go to next line

            }
            else if (line.Contains("Chapter")){
                int position = line.IndexOf("Chapter");
                title = line.Substring(0,position-1);
                // Console.WriteLine($"Ha llegado hasta aquí {position} y final {line.Length-1}");
                string chapterText = line.Substring(line.Length-(position+8));
                int.TryParse(chapterText, out chapter);
                
                oChapter = new Chapters(title, standardBook);
                oBook.AddNewBook(title, lineNumber, standardBook, oBooksList);    
                oChapter.AddNewChapter(title, chapter, lineNumber, standardBook, oChaptersList);
            }
            
            // SIN TERMINAR
            else if (Regex.IsMatch(line[0].ToString(), @"[\d]")){
                int initialPosition = line.IndexOf(":");
                int finalPosition = line.IndexOf(" ", initialPosition);
                int verseNumber = int.Parse(line.Substring(initialPosition+1, finalPosition-1-initialPosition));
                oVerse = new Verses(title, chapter, verseNumber, lineNumber, standardBook);
            }

            // SIN TERMINAR
            /*
            Console.Write("The Standard Books are:");
            oStandardBook.DisplayListElements(oStandardBooksList);
            
            
            Console.Write("The Books are:");
            oBook.DisplayListElements(oBooksList); 
        
            Console.Write("The Chapters are:");
            oChapter.DisplayListElements(oChaptersList); 
            
            Console.Write("The Verses are:");
            oVerse.DisplayListElements(oVersesList);
            */
        }

        
        Console.WriteLine($"It has Upload {oStandardBooksList.Count} Standard Books");
        Console.WriteLine($"It has Upload {oBooksList.Count} Books");
        Console.WriteLine($"It has Upload {oChaptersList.Count} Chapters");
        Console.WriteLine($"It has Upload {oVersesList.Count} Verses");
        */
        
        // Upload the Menus
        List<Menus> menusList = new List<Menus>();
        string filenameMenu = "Menus.txt";
        string [] menuLine = System.IO.File.ReadAllLines(filenameMenu);
        foreach (string line in menuLine){
            string[] part = line.Split(",");

            string menuId = part[0];
            string menuName = part[1];
            string idOption = part[2];
            string Option = part[3];
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
        List<Menus> menuList7 = new List<Menus>();
        List<Menus> menuList8 = new List<Menus>();
        List<Menus> menuList1_1 = new List<Menus>();
        List<Menus> menuList1_2 = new List<Menus>();
        List<Menus> menuList1_3 = new List<Menus>();
        List<Menus> menuList1_4 = new List<Menus>();
        List<Menus> menuList1_5 = new List<Menus>();
        List<Menus> menuList1_6 = new List<Menus>();
        List<Menus> menuList1_7 = new List<Menus>();
        List<Menus> menuList1_8 = new List<Menus>();
        List<Menus> menuList2_1 = new List<Menus>();
        List<Menus> menuList2_2 = new List<Menus>();
        List<Menus> menuList2_3 = new List<Menus>();
        List<Menus> menuList2_4 = new List<Menus>();
        List<Menus> menuList2_5 = new List<Menus>();
        List<Menus> menuList2_6 = new List<Menus>();
        List<Menus> menuList2_7 = new List<Menus>();
        List<Menus> menuList2_8 = new List<Menus>();
        List<Menus> menuList3_1 = new List<Menus>();
        List<Menus> menuList3_2 = new List<Menus>();
        List<Menus> menuList3_3 = new List<Menus>();
        List<Menus> menuList3_4 = new List<Menus>();
        List<Menus> menuList3_5 = new List<Menus>();
        List<Menus> menuList3_6 = new List<Menus>();
        List<Menus> menuList3_7 = new List<Menus>();
        List<Menus> menuList3_8 = new List<Menus>(); 
        List<Menus> menuList4_1 = new List<Menus>();
        List<Menus> menuList4_2 = new List<Menus>();
        List<Menus> menuList4_3 = new List<Menus>();
        List<Menus> menuList4_4 = new List<Menus>();
        List<Menus> menuList4_5 = new List<Menus>();
        List<Menus> menuList4_6 = new List<Menus>(); 
        List<Menus> menuList4_7 = new List<Menus>(); 
        List<Menus> menuList4_8 = new List<Menus>(); 
        List<Menus> menuList5_1 = new List<Menus>();
        List<Menus> menuList5_2 = new List<Menus>();
        List<Menus> menuList5_3 = new List<Menus>();
        List<Menus> menuList5_4 = new List<Menus>();
        List<Menus> menuList5_5 = new List<Menus>();
        List<Menus> menuList5_6 = new List<Menus>(); 
        List<Menus> menuList6_1 = new List<Menus>();
        List<Menus> menuList6_2 = new List<Menus>();
        List<Menus> menuList6_3 = new List<Menus>();
        List<Menus> menuList6_4 = new List<Menus>();
        List<Menus> menuList6_5 = new List<Menus>();
        List<Menus> menuList6_6 = new List<Menus>(); 
        List<Menus> menuList6_7 = new List<Menus>();
        List<Menus> menuList6_8 = new List<Menus>();
        List<Menus> menuList7_1 = new List<Menus>();
        List<Menus> menuList7_2 = new List<Menus>();
        List<Menus> menuList7_3 = new List<Menus>();
        List<Menus> menuList7_4 = new List<Menus>();
        List<Menus> menuList7_5 = new List<Menus>();
        List<Menus> menuList7_6 = new List<Menus>(); 
        List<Menus> menuList7_7 = new List<Menus>(); 
        List<Menus> menuList7_8 = new List<Menus>(); 
        List<Menus> menuList8_1 = new List<Menus>();
        List<Menus> menuList8_2 = new List<Menus>();
        List<Menus> menuList8_3 = new List<Menus>();
        List<Menus> menuList8_4 = new List<Menus>();
        List<Menus> menuList8_5 = new List<Menus>();
        List<Menus> menuList8_6 = new List<Menus>(); 
        List<Menus> menuList8_7 = new List<Menus>(); 
        List<Menus> menuList8_8 = new List<Menus>(); 
        List<Menus> menuList1_1_1 = new List<Menus>();
        List<Menus> menuList2_1_1 = new List<Menus>();
        List<Menus> menuList3_1_1 = new List<Menus>();
        List<Menus> menuList4_1_1 = new List<Menus>();
        List<Menus> menuList5_1_1 = new List<Menus>();
        List<Menus> menuList6_1_1 = new List<Menus>();
        List<Menus> menuList7_1_1 = new List<Menus>();
        List<Menus> menuList8_1_1 = new List<Menus>();

        for (int i=0; i<menusList.Count ; i++) {
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
                if (menusList[i].MenuId == "7"){
                    menuList7.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "8"){
                    menuList8.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1_1"){
                    menuList1_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1_2"){
                    menuList1_2.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1_3"){
                    menuList1_3.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1_4"){
                    menuList1_4.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1_5"){
                    menuList1_5.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1_6"){
                    menuList1_6.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1_7"){
                    menuList1_7.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1_8"){
                    menuList1_8.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "2_1"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "2_2"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "2_3"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "2_4"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "2_5"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "2_6"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "2_7"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "2_8"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "3_1"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "3_2"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "3_3"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "3_4"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "3_5"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "3_6"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "3_7"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "3_8"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "4_1"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "5_1"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "6_1"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "7_1"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "8_1"){
                    menuList2_1.Add(menusList[i]);
                }
                if (menusList[i].MenuId == "1_1_1"){
                    menuList1_1_1.Add(menusList[i]);
                }
        }
        
        // Display the recurrent Main Menu
        bool replay0 =true;
        while (replay0 == true){
            
            menuList0[0].DisplayMenu(menuList0);           
            Console.Write("Choose an option from the Menu: ");
            string? choice = Console.ReadLine(); 
            while (choice != "0"){
                if (choice == "1"){
                    
                    bool replay1 = true;
                    while (replay1 == true){
                        menuList1[0].DisplayMenu(menuList1);
                        Console.Write("Choose an option from the Menu: ");
                        string? choice1 = Console.ReadLine();
                        while (choice1 != "0"){
                            if (choice1 == "1"){
                                oPeople.InputNewPeople(oPeopleList);
                                //choice1 = "";
                            }
                            
                            else if (choice1 == "2"){
                                Console.WriteLine($"Which person do you want to modify?");
                                string name = Console.ReadLine();
                                if (oPeopleList.Any(a => a.GetName() == name)){
                                    Console.WriteLine($"This is the actual information about this person: {name}.");
                                    oPeopleFound = oPeople.FindPeopleObject(name, oPeopleList);
                                    oPeopleFound.Display();
                                    menuList1_2[0].DisplayMenu(menuList1_2);
                                    Console.Write("Choose an option from the Menu: ");
                                    string? choice1_2 = Console.ReadLine();
                                    
                                    bool replay1_2 = true;
                                    while (replay1_2 == true){
                                        //menuList1_2[0].DisplayMenu(menuList1_2);
                                        //Console.Write("Choose an option from the Menu: ");
                                        //choice1_2 = Console.ReadLine();
                                        while (choice1_2 != "0"){
                                            if (choice1_2 == "1"){
                                                Console.WriteLine($"Which new name you want for {oPeopleFound.GetName()}: ");
                                                string newName = Console.ReadLine();
                                                oPeopleFound.ModifyName(oPeopleFound.GetName(), newName, oPeopleList);

                                                menuList1_2[0].DisplayMenu(menuList1_2);
                                                Console.Write("Choose an option from the Menu: ");
                                                choice1_2 = Console.ReadLine();
                                                /*
                                                bool replayMenu1_1_1 = true;
                                                while (replayMenu1_1_1 == true){
                                                    menuList1_1_1[0].DisplayMenu(menuList1_1_1);
                                                    Console.Write("Choose an option from the Menu: ");
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
                                                            Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                                            menuList1_1_1[0].DisplayMenu(menuList1_1_1);
                                                            Console.Write("Choose an option from the Menu: ");
                                                            choice1_1_1 = Console.ReadLine();
                                                        }
                                                    }    
                                                    if (choice1_1_1 == "0"){
                                                        replayMenu1_1_1 = false;
                                                        choice1_1 = "";
                                                    }
                                                    
                                                }*/
                                            }
                                            else if (choice1_2 == "2"){
                                                oPeopleFound.Display();
                                                People oFather = oPeopleFound.GetFather(); 
                                                Console.WriteLine($"His actual father is {oFather.GetName()} and it will change to: ");
                                                string newFather = Console.ReadLine();
                                                People oNewFather = oFather.FindPeopleObject(newFather,oPeopleList);
                                                oPeopleFound.ModifyFather(oFather.GetName(), oNewFather, oPeopleList);

                                                menuList1_2[0].DisplayMenu(menuList1_2);
                                                Console.Write("Choose an option from the Menu: ");
                                                choice1_2 = Console.ReadLine();
                                            }
                                            else if (choice1_2 == "3"){
                                                menuList3[0].DisplayMenu(menuList3);
                                            }
                                            else{
                                                Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                                menuList1_2[0].DisplayMenu(menuList1_2);
                                                Console.Write("Choose an option from the Menu: ");
                                                choice1_2 = Console.ReadLine();
                                            }
                                        }
                                        if (choice1_2 == "0"){
                                            replay1_2 = false;
                                            choice1 = "";
                                        }
                                        //menuList1[0].DisplayMenu(menuList1);
                                        //Console.Write("Choose an option from the Menu: ");
                                        //choice1 = Console.ReadLine();
                                    }
                                }
                                else{
                                    Console.WriteLine($"The {name} doesn´t exist");
                                }
                            }
                            
                            else if (choice1 == "3"){
                                oPeople.DisplayListElements(oPeopleList);
                                //choice = "";
                                //menuList1[0].DisplayMenu(menuList1);
                                //Console.Write("Choose an option from the Menu: ");
                                //choice1 = Console.ReadLine();
                            }
                            
                            else if (choice1 == "4"){
                                Console.WriteLine($"Which person do you want to delete?");
                                string name = Console.ReadLine();
                                oPeople.DeletePerson(name, oPeopleList);
                                choice = "";
                            }

                            else if (choice1 == "5"){
                                oPeople.ListElements(oPeopleList);
            
                                choice = "";
                            }

                            else if (choice1 == "6"){
                                Console.WriteLine("Sorry, this option is under development.");

                                choice = "";
                            }
                            
                            else{
                                Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                //choice = "";
                                //menuList1[0].DisplayMenu(menuList1);
                                //Console.Write("Choose an option from the Menu: ");
                                //choice1 = Console.ReadLine();
                            }
                            menuList1[0].DisplayMenu(menuList1);
                            Console.Write("Choose an option from the Menu: ");
                            choice1 = Console.ReadLine();
                        }
                        if (choice1 == "0"){
                            replay1 = false;
                            choice = "";
                        }
                    }
                }
                
                else if (choice == "2"){
                    menuList2[0].DisplayMenu(menuList2);
                    bool replay2 = true;
                    while (replay2 == true){
                        menuList2[0].DisplayMenu(menuList2);
                        Console.Write("Choose an option from the Menu: ");
                        string? choice2 = Console.ReadLine();
                        while (choice2 != "0"){
                            if (choice2 == "1"){
                                oPeople.InputNewPeople(oPeopleList);
                                /*bool replayMenu2_1 = true;
                                while (replayMenu2_1 == true){
                                    menuList2_1[0].DisplayMenu(menuList2_1);
                                    Console.Write("Choose an option from the Menu: ");
                                    string? choice2_1 = Console.ReadLine();
                                    while (choice2_1 != "0"){
                                        if (choice2_1 == "1"){
                                        
                                            bool replayMenu2_1_1 = true;
                                            while (replayMenu2_1_1 == true){
                                                menuList2_1_1[0].DisplayMenu(menuList2_1_1);
                                                Console.Write("Choose an option from the Menu: ");
                                                string? choice2_1_1 = Console.ReadLine();
                                                while (choice2_1_1 != "0"){
                                                    if (choice2_1_1 == "1"){
                                                    }
                                                    else if (choice2_1_1 == "2"){
                                                        menuList2[0].DisplayMenu(menuList2);
                                                    }
                                                    else if (choice2_1_1 == "3"){
                                                        menuList3[0].DisplayMenu(menuList3);
                                                    }
                                                    else{
                                                        Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                                        menuList2_1_1[0].DisplayMenu(menuList2_1_1);
                                                        Console.Write("Choose an option from the Menu: ");
                                                        choice2_1_1 = Console.ReadLine();
                                                    }
                                                }    
                                                if (choice2_1_1 == "0"){
                                                    replayMenu2_1_1 = false;
                                                    choice2_1 = "";
                                                }
                                                
                                            }
                                        }
                                        else if (choice2_1 == "2"){
                                            menuList2[0].DisplayMenu(menuList2);
                                        }
                                        else if (choice2_1 == "3"){
                                            menuList3[0].DisplayMenu(menuList3);
                                        }
                                        else{
                                            Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                            menuList2_1[0].DisplayMenu(menuList2_1);
                                            Console.Write("Choose an option from the Menu: ");
                                            choice2_1 = Console.ReadLine();
                                        }
                                    }
                                    if (choice2_1 == "0"){
                                        replayMenu2_1 = false;
                                        choice2 = "";
                                    }
                                }*/
                            }
                            else if (choice2 == "2"){
                                menuList2[0].DisplayMenu(menuList2);
                            }
                            else if (choice2 == "3"){
                                menuList3[0].DisplayMenu(menuList3);
                            }
                            else{
                                Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                menuList1[0].DisplayMenu(menuList1);
                                Console.Write("Choose an option from the Menu: ");
                                choice2 = Console.ReadLine();
                            }
                        }
                        if (choice2 == "0"){
                            replay2 = false;
                            choice = "";
                        }
                    }
                }
                
                else if (choice == "3"){
                    menuList3[0].DisplayMenu(menuList3);
                    bool replay3 = true;
                    while (replay3 == true){
                        menuList3[0].DisplayMenu(menuList3);
                        Console.Write("Choose an option from the Menu: ");
                        string? choice3 = Console.ReadLine();
                        while (choice3 != "0"){
                            if (choice3 == "1"){
                            
                                bool replayMenu3_1 = true;
                                while (replayMenu3_1 == true){
                                    menuList3_1[0].DisplayMenu(menuList3_1);
                                    Console.Write("Choose an option from the Menu: ");
                                    string? choice3_1 = Console.ReadLine();
                                    while (choice3_1 != "0"){
                                        if (choice3_1 == "1"){
                                        
                                            bool replayMenu3_1_1 = true;
                                            while (replayMenu3_1_1 == true){
                                                menuList3_1_1[0].DisplayMenu(menuList3_1_1);
                                                Console.Write("Choose an option from the Menu: ");
                                                string? choice3_1_1 = Console.ReadLine();
                                                while (choice3_1_1 != "0"){
                                                    if (choice3_1_1 == "1"){
                                                    }
                                                    else if (choice3_1_1 == "2"){
                                                        menuList3[0].DisplayMenu(menuList3);
                                                    }
                                                    else if (choice3_1_1 == "3"){
                                                        menuList3[0].DisplayMenu(menuList3);
                                                    }
                                                    else{
                                                        Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                                        menuList3_1_1[0].DisplayMenu(menuList3_1_1);
                                                        Console.Write("Choose an option from the Menu: ");
                                                        choice3_1_1 = Console.ReadLine();
                                                    }
                                                }    
                                                if (choice3_1_1 == "0"){
                                                    replayMenu3_1_1 = false;
                                                    choice3_1 = "";
                                                }
                                                
                                            }
                                        }
                                        else if (choice3_1 == "2"){
                                            menuList3[0].DisplayMenu(menuList3);
                                        }
                                        else if (choice3_1 == "3"){
                                            menuList3[0].DisplayMenu(menuList3);
                                        }
                                        else{
                                            Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                            menuList3_1[0].DisplayMenu(menuList3_1);
                                            Console.Write("Choose an option from the Menu: ");
                                            choice3_1 = Console.ReadLine();
                                        }
                                    }
                                    if (choice3_1 == "0"){
                                        replayMenu3_1 = false;
                                        choice3 = "";
                                    }
                                }
                            }
                            else if (choice3 == "2"){
                                menuList3[0].DisplayMenu(menuList3);
                            }
                            else if (choice3 == "3"){
                                menuList3[0].DisplayMenu(menuList3);
                            }
                            else{
                                Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                menuList1[0].DisplayMenu(menuList1);
                                Console.Write("Choose an option from the Menu: ");
                                choice3 = Console.ReadLine();
                            }
                        }
                        if (choice3 == "0"){
                            replay3 = false;
                            choice = "";
                        }
                    }
                }
                
                else if (choice == "4"){
                    menuList4[0].DisplayMenu(menuList4);
                    bool replay4 = true;
                    while (replay4 == true){
                        menuList4[0].DisplayMenu(menuList4);
                        Console.Write("Choose an option from the Menu: ");
                        string? choice4 = Console.ReadLine();
                        while (choice4 != "0"){
                            if (choice4 == "1"){
                            
                                bool replayMenu4_1 = true;
                                while (replayMenu4_1 == true){
                                    menuList4_1[0].DisplayMenu(menuList4_1);
                                    Console.Write("Choose an option from the Menu: ");
                                    string? choice4_1 = Console.ReadLine();
                                    while (choice4_1 != "0"){
                                        if (choice4_1 == "1"){
                                        
                                            bool replayMenu4_1_1 = true;
                                            while (replayMenu4_1_1 == true){
                                                menuList4_1_1[0].DisplayMenu(menuList4_1_1);
                                                Console.Write("Choose an option from the Menu: ");
                                                string? choice4_1_1 = Console.ReadLine();
                                                while (choice4_1_1 != "0"){
                                                    if (choice4_1_1 == "1"){
                                                    }
                                                    else if (choice4_1_1 == "2"){
                                                        menuList4[0].DisplayMenu(menuList4);
                                                    }
                                                    else if (choice4_1_1 == "3"){
                                                        menuList3[0].DisplayMenu(menuList3);
                                                    }
                                                    else{
                                                        Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                                        menuList4_1_1[0].DisplayMenu(menuList4_1_1);
                                                        Console.Write("Choose an option from the Menu: ");
                                                        choice4_1_1 = Console.ReadLine();
                                                    }
                                                }    
                                                if (choice4_1_1 == "0"){
                                                    replayMenu4_1_1 = false;
                                                    choice4_1 = "";
                                                }
                                                
                                            }
                                        }
                                        else if (choice4_1 == "2"){
                                            menuList4[0].DisplayMenu(menuList4);
                                        }
                                        else if (choice4_1 == "3"){
                                            menuList3[0].DisplayMenu(menuList3);
                                        }
                                        else{
                                            Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                            menuList4_1[0].DisplayMenu(menuList4_1);
                                            Console.Write("Choose an option from the Menu: ");
                                            choice4_1 = Console.ReadLine();
                                        }
                                    }
                                    if (choice4_1 == "0"){
                                        replayMenu4_1 = false;
                                        choice4 = "";
                                    }
                                }
                            }
                            else if (choice4 == "2"){
                                menuList4[0].DisplayMenu(menuList4);
                            }
                            else if (choice4 == "3"){
                                menuList3[0].DisplayMenu(menuList3);
                            }
                            else{
                                Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                menuList1[0].DisplayMenu(menuList1);
                                Console.Write("Choose an option from the Menu: ");
                                choice4 = Console.ReadLine();
                            }
                        }
                        if (choice4 == "0"){
                            replay4 = false;
                            choice = "";
                        }
                    } 
                }

                else if (choice == "5"){
                    menuList5[0].DisplayMenu(menuList5);
                    bool replay5 = true;
                    while (replay5 == true){
                        menuList5[0].DisplayMenu(menuList5);
                        Console.Write("Choose an option from the Menu: ");
                        string? choice5 = Console.ReadLine();
                        while (choice5 != "0"){
                            if (choice5 == "1"){
                            
                                bool replayMenu5_1 = true;
                                while (replayMenu5_1 == true){
                                    menuList5_1[0].DisplayMenu(menuList5_1);
                                    Console.Write("Choose an option from the Menu: ");
                                    string? choice5_1 = Console.ReadLine();
                                    while (choice5_1 != "0"){
                                        if (choice5_1 == "1"){
                                        
                                            bool replayMenu5_1_1 = true;
                                            while (replayMenu5_1_1 == true){
                                                menuList5_1_1[0].DisplayMenu(menuList5_1_1);
                                                Console.Write("Choose an option from the Menu: ");
                                                string? choice5_1_1 = Console.ReadLine();
                                                while (choice5_1_1 != "0"){
                                                    if (choice5_1_1 == "1"){
                                                    }
                                                    else if (choice5_1_1 == "2"){
                                                        menuList5[0].DisplayMenu(menuList5);
                                                    }
                                                    else if (choice5_1_1 == "3"){
                                                        menuList3[0].DisplayMenu(menuList3);
                                                    }
                                                    else{
                                                        Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                                        menuList5_1_1[0].DisplayMenu(menuList5_1_1);
                                                        Console.Write("Choose an option from the Menu: ");
                                                        choice5_1_1 = Console.ReadLine();
                                                    }
                                                }    
                                                if (choice5_1_1 == "0"){
                                                    replayMenu5_1_1 = false;
                                                    choice5_1 = "";
                                                }
                                                
                                            }
                                        }
                                        else if (choice5_1 == "2"){
                                            menuList5[0].DisplayMenu(menuList5);
                                        }
                                        else if (choice5_1 == "3"){
                                            menuList3[0].DisplayMenu(menuList3);
                                        }
                                        else{
                                            Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                            menuList5_1[0].DisplayMenu(menuList5_1);
                                            Console.Write("Choose an option from the Menu: ");
                                            choice5_1 = Console.ReadLine();
                                        }
                                    }
                                    if (choice5_1 == "0"){
                                        replayMenu5_1 = false;
                                        choice5 = "";
                                    }
                                }
                            }
                            else if (choice5 == "2"){
                                menuList5[0].DisplayMenu(menuList5);
                            }
                            else if (choice5 == "3"){
                                menuList3[0].DisplayMenu(menuList3);
                            }
                            else{
                                Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                menuList1[0].DisplayMenu(menuList1);
                                Console.Write("Choose an option from the Menu: ");
                                choice5 = Console.ReadLine();
                            }
                        }
                        if (choice5 == "0"){
                            replay5 = false;
                            choice = "";
                        }
                    }
                } 

                else if (choice == "6"){
                    menuList6[0].DisplayMenu(menuList6);
                    bool replay6 = true;
                    while (replay6 == true){
                        menuList6[0].DisplayMenu(menuList6);
                        Console.Write("Choose an option from the Menu: ");
                        string? choice6 = Console.ReadLine();
                        while (choice6 != "0"){
                            if (choice6 == "1"){
                            
                                bool replayMenu6_1 = true;
                                while (replayMenu6_1 == true){
                                    menuList6_1[0].DisplayMenu(menuList6_1);
                                    Console.Write("Choose an option from the Menu: ");
                                    string? choice6_1 = Console.ReadLine();
                                    while (choice6_1 != "0"){
                                        if (choice6_1 == "1"){
                                        
                                            bool replayMenu6_1_1 = true;
                                            while (replayMenu6_1_1 == true){
                                                menuList6_1_1[0].DisplayMenu(menuList6_1_1);
                                                Console.Write("Choose an option from the Menu: ");
                                                string? choice6_1_1 = Console.ReadLine();
                                                while (choice6_1_1 != "0"){
                                                    if (choice6_1_1 == "1"){
                                                    }
                                                    else if (choice6_1_1 == "2"){
                                                        menuList6[0].DisplayMenu(menuList6);
                                                    }
                                                    else if (choice6_1_1 == "3"){
                                                        menuList3[0].DisplayMenu(menuList3);
                                                    }
                                                    else{
                                                        Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                                        menuList6_1_1[0].DisplayMenu(menuList6_1_1);
                                                        Console.Write("Choose an option from the Menu: ");
                                                        choice6_1_1 = Console.ReadLine();
                                                    }
                                                }    
                                                if (choice6_1_1 == "0"){
                                                    replayMenu6_1_1 = false;
                                                    choice6_1 = "";
                                                }
                                                
                                            }
                                        }
                                        else if (choice6_1 == "2"){
                                            menuList6[0].DisplayMenu(menuList6);
                                        }
                                        else if (choice6_1 == "3"){
                                            menuList3[0].DisplayMenu(menuList3);
                                        }
                                        else{
                                            Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                            menuList6_1[0].DisplayMenu(menuList6_1);
                                            Console.Write("Choose an option from the Menu: ");
                                            choice6_1 = Console.ReadLine();
                                        }
                                    }
                                    if (choice6_1 == "0"){
                                        replayMenu6_1 = false;
                                        choice6 = "";
                                    }
                                }
                            }
                            else if (choice6 == "2"){
                                menuList6[0].DisplayMenu(menuList6);
                            }
                            else if (choice6 == "3"){
                                menuList3[0].DisplayMenu(menuList3);
                            }
                            else{
                                Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                menuList1[0].DisplayMenu(menuList1);
                                Console.Write("Choose an option from the Menu: ");
                                choice6 = Console.ReadLine();
                            }
                        }
                        if (choice6 == "0"){
                            replay6 = false;
                            choice = "";
                        }
                    }
                } 

                else if (choice == "7"){
                    menuList7[0].DisplayMenu(menuList7);
                    bool replay7 = true;
                    while (replay7 == true){
                        menuList7[0].DisplayMenu(menuList7);
                        Console.Write("Choose an option from the Menu: ");
                        string? choice7 = Console.ReadLine();
                        while (choice7 != "0"){
                            if (choice7 == "1"){
                            
                                bool replayMenu2_1 = true;
                                while (replayMenu2_1 == true){
                                    menuList7_1[0].DisplayMenu(menuList7_1);
                                    Console.Write("Choose an option from the Menu: ");
                                    string? choice7_1 = Console.ReadLine();
                                    while (choice7_1 != "0"){
                                        if (choice7_1 == "1"){
                                        
                                            bool replayMenu2_1_1 = true;
                                            while (replayMenu2_1_1 == true){
                                                menuList7_1_1[0].DisplayMenu(menuList7_1_1);
                                                Console.Write("Choose an option from the Menu: ");
                                                string? choice7_1_1 = Console.ReadLine();
                                                while (choice7_1_1 != "0"){
                                                    if (choice7_1_1 == "1"){
                                                    }
                                                    else if (choice7_1_1 == "2"){
                                                        menuList7[0].DisplayMenu(menuList7);
                                                    }
                                                    else if (choice7_1_1 == "3"){
                                                        menuList3[0].DisplayMenu(menuList3);
                                                    }
                                                    else{
                                                        Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                                        menuList7_1_1[0].DisplayMenu(menuList7_1_1);
                                                        Console.Write("Choose an option from the Menu: ");
                                                        choice7_1_1 = Console.ReadLine();
                                                    }
                                                }    
                                                if (choice7_1_1 == "0"){
                                                    replayMenu2_1_1 = false;
                                                    choice7_1 = "";
                                                }
                                                
                                            }
                                        }
                                        else if (choice7_1 == "2"){
                                            menuList7[0].DisplayMenu(menuList7);
                                        }
                                        else if (choice7_1 == "3"){
                                            menuList3[0].DisplayMenu(menuList3);
                                        }
                                        else{
                                            Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                            menuList7_1[0].DisplayMenu(menuList7_1);
                                            Console.Write("Choose an option from the Menu: ");
                                            choice7_1 = Console.ReadLine();
                                        }
                                    }
                                    if (choice7_1 == "0"){
                                        replayMenu2_1 = false;
                                        choice7 = "";
                                    }
                                }
                            }
                            else if (choice7 == "2"){
                                menuList7[0].DisplayMenu(menuList7);
                            }
                            else if (choice7 == "3"){
                                menuList3[0].DisplayMenu(menuList3);
                            }
                            else{
                                Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                menuList1[0].DisplayMenu(menuList1);
                                Console.Write("Choose an option from the Menu: ");
                                choice7 = Console.ReadLine();
                            }
                        }
                        if (choice7 == "0"){
                            replay7 = false;
                            choice = "";
                        }
                    }
                } 

                else if (choice == "8"){
                    menuList8[0].DisplayMenu(menuList8);
                    bool replay8 = true;
                    while (replay8 == true){
                        menuList7[0].DisplayMenu(menuList7);
                        Console.Write("Choose an option from the Menu: ");
                        string? choice8 = Console.ReadLine();
                        while (choice8 != "0"){
                            if (choice8 == "1"){
                            
                                bool replayMenu2_1 = true;
                                while (replayMenu2_1 == true){
                                    menuList7_1[0].DisplayMenu(menuList7_1);
                                    Console.Write("Choose an option from the Menu: ");
                                    string? choice8_1 = Console.ReadLine();
                                    while (choice8_1 != "0"){
                                        if (choice8_1 == "1"){
                                        
                                            bool replayMenu2_1_1 = true;
                                            while (replayMenu2_1_1 == true){
                                                menuList7_1_1[0].DisplayMenu(menuList7_1_1);
                                                Console.Write("Choose an option from the Menu: ");
                                                string? choice8_1_1 = Console.ReadLine();
                                                while (choice8_1_1 != "0"){
                                                    if (choice8_1_1 == "1"){
                                                    }
                                                    else if (choice8_1_1 == "2"){
                                                        menuList7[0].DisplayMenu(menuList7);
                                                    }
                                                    else if (choice8_1_1 == "3"){
                                                        menuList3[0].DisplayMenu(menuList3);
                                                    }
                                                    else{
                                                        Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                                        menuList7_1_1[0].DisplayMenu(menuList7_1_1);
                                                        Console.Write("Choose an option from the Menu: ");
                                                        choice8_1_1 = Console.ReadLine();
                                                    }
                                                }    
                                                if (choice8_1_1 == "0"){
                                                    replayMenu2_1_1 = false;
                                                    choice8_1 = "";
                                                }
                                                
                                            }
                                        }
                                        else if (choice8_1 == "2"){
                                            menuList7[0].DisplayMenu(menuList7);
                                        }
                                        else if (choice8_1 == "3"){
                                            menuList3[0].DisplayMenu(menuList3);
                                        }
                                        else{
                                            Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                            menuList7_1[0].DisplayMenu(menuList7_1);
                                            Console.Write("Choose an option from the Menu: ");
                                            choice8_1 = Console.ReadLine();
                                        }
                                    }
                                    if (choice8_1 == "0"){
                                        replayMenu2_1 = false;
                                        choice8 = "";
                                    }
                                }
                            }
                            else if (choice8 == "2"){
                                menuList7[0].DisplayMenu(menuList7);
                            }
                            else if (choice8 == "3"){
                                menuList3[0].DisplayMenu(menuList3);
                            }
                            else{
                                Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                                menuList1[0].DisplayMenu(menuList1);
                                Console.Write("Choose an option from the Menu: ");
                                choice8 = Console.ReadLine();
                            }
                        }
                        if (choice8 == "0"){
                            replay8 = false;
                            choice = "";
                        }
                    }
                } 

                else{
                    Console.WriteLine("Your option is not valid.\nChoose an option between 1 to 0.\n\n");
                    menuList0[0].DisplayMenu(menuList0);
                    Console.Write("Choose an option from the Menu: ");
                    choice = Console.ReadLine();
                }
            }
            
            if (choice == "0"){
                replay0 = false;
            }
        }
    }
}

