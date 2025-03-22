public class LibrosCanónicos{
    // Atributos
    private string _libroCanónico;
    
    // Constructores
    public LibrosCanónicos(string libroCanónico){
        _libroCanónico = libroCanónico;
    }

    // Acciones
    //Getters & Setters
    public string GetLibrosCanónicos(){
        return _libroCanónico;
    }

    public virtual void Mostrar(){
        Console.Write($"{_libroCanónico} ");
    }
}