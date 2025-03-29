using System;
using System.IO;
using System.Reflection;

class Menus{
    // Attributes
    private string _option;
    public string Option {get; set;}
    private string _idOption;
    public string IdOption {get; set;}
    private string _menuName;
    public string MenuName {get; set;}
    private string _menuId;
    public string MenuId {get; set;}
    
    // Constructors
    public Menus(string menuId, string menuName, string idOption, string option){
        _menuId = menuId;
        _menuName = menuName;
        _idOption = idOption;
        _option = option;
        MenuId = _menuId;
        MenuName =_menuName;
        IdOption = _idOption;
        Option = _option;
    }

    // Actions
    public string GetMenuName(){
        return _menuName;
    }
    public void Display(){
        Console.WriteLine($"{_menuId}, {_menuName}, {_idOption}, {_option}");
    }

    public void DisplayMenu(List<Menus> menusList){
            Console.WriteLine($"- - - - - {menusList[0]._menuName.ToUpper()} - - - - -");
            foreach (Menus opctions in menusList){
                Console.WriteLine($"   {opctions._idOption} )\t{opctions._option}");
            }
            Console.WriteLine($"- - - - - - - - - - - - - - - - - - -\n");
    }
}

    
