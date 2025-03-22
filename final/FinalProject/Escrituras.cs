public class Escrituras : Versículos{
    // Atributos
    private string _escritura;
    
    // Constructores
    public Escrituras(string libro, int capítulo, int versículo, string escritura, string libroCanónico) : base(libro, capítulo, versículo, libroCanónico){
        _escritura = escritura;
    }

    // Acciones
    //Getters & Setters
    public string GetEscritura(){
        return _escritura;
    }

    //
    public override void Mostrar()
    {
        base.Mostrar();
        Console.Write($"{_escritura}\n");
    }

    public void MostrarEscritura(){
        Console.Write(_escritura);
    }

    //
    public void MostrarReferencia(){
        Console.Write($"{GetLibro()} {GetCapítulo()}:{GetVersículo()}; ");
    }

    //
    public void MostrarReferenciaAbreviada(){
        Console.Write($"{GetAbreviatura()} {GetCapítulo()}:{GetVersículo()}; ");
    }
    
}