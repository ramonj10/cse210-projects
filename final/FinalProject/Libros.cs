public class Libros : LibrosCanónicos{
    // Atributos
    private string _libro;
    private string? _abreviatura;
    private Personajes? _autor;
    
    // Constructores
    public Libros (string libro, string libroCanónico) : base(libroCanónico){
        _libro = libro;
    }

    public Libros (string libro, string abreviatura, string libroCanónico) : base(libroCanónico){
        _libro = libro;
        _abreviatura = abreviatura;
    }

    public Libros (string libro, string abreviatura, Personajes autor, string libroCanónico) : base(libroCanónico){
        _libro = libro;
        _abreviatura = abreviatura;
        _autor = autor;
    }

    // Acciones
    //Getters & Setters
    public string GetLibro(){
        return _libro;
    }
    public string GetAbreviatura(){
        return _abreviatura;
    }
    public Personajes GetAutor(){
        return _autor;
    }
    public void SetAbreviatura(string abreviatura){
        _abreviatura = abreviatura;
    }
    public void SetAutor(Personajes autor){
        _autor = autor;
    }

    //
    public override void Mostrar()
    {
        Console.Write($"{_libro} {_abreviatura} escrito por {_autor} pertenece al libro de ");
        base.Mostrar();
    }
}