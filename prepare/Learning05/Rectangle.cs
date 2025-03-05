public class Rectangle : Shape{
    // Attributes
    double _side1;
    double _side2; 

    // Constructors
    public Rectangle(string color, double side1, double side2) : base(color){
        _side1 = side1;
        _side2 = side2;
    }

    //Behaviours
    public override double GetArea(){
        return _side1 *_side2;
    }
}