public class Circle : Shape{
    // Attributes
    private double _radius; 

    // Constructors
    public Circle(string color, double radius) : base(color){
        _radius = radius;
    }

    //Behaviours
    public override double GetArea(){
        return _radius * _radius * Math.PI;
    }
}