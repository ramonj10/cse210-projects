class Menu {
    private string _number;
    private string _option;

    public Menu(string number, string option){
        _number = number;
        _option = option;
    }

    public void DisplayMenu(){
        Console.WriteLine("Menu Options:\n");

        Console.Write("Select a choice from the menu: ");
    }
}