using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeslist = new List<Shape>();

        Square sq = new Square("red", 5);
        shapeslist.Add(sq);       
    
        Rectangle rc = new Rectangle("blue", 10, 3);
        shapeslist.Add(rc);
    
        Circle cr = new Circle("green", 7);
        shapeslist.Add(cr);

        foreach (Shape shape in shapeslist){
            Console.WriteLine($"The area of a {shape.GetColor()} is {shape.GetArea()} sqcentimeters");    
        }
    }
}