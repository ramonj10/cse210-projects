using System.Security.Principal;

public class Capítulos : Libros{
    // Atributos
    private int _capítulo;

    // Constructores
    public Capítulos(string libro, int capítulo, string libroCanónico) : base(libro, libroCanónico){
        _capítulo = capítulo;
    }
    
    // Acciones
    //Getters & Setters
    public int GetCapítulo(){
        return _capítulo;
    }

    // 
    public override void Mostrar()
    {
        base.Mostrar();
        Console.Write($"{_capítulo}");
    }
}