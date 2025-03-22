public class Imaginaciones : Citas{
    // Atributos
    private string _imaginación;
    private string? _notasSobreImaginación;
    
    // Constructores
    Imaginaciones(string libro, int capítulo, int versículo, string escritura, int posiciónInicial, string imaginación, string libroCanónico) 
                : base (libro, capítulo, versículo, escritura, posiciónInicial, libroCanónico){
        _imaginación = imaginación;
    }
    Imaginaciones(string libro, int capítulo, int versículo, string escritura, int posiciónInicial, int posiciónFinal, string imaginación, string libroCanónico) 
                : base (libro, capítulo, versículo, escritura, posiciónInicial, posiciónFinal, libroCanónico){
        _imaginación = imaginación;
    }
    Imaginaciones(string libro, int capítulo, int versículo, string escritura, int posiciónInicial, string imaginación, string notasSobreImaginación,  string libroCanónico) 
                : base (libro, capítulo, versículo, escritura, posiciónInicial, libroCanónico){
        _imaginación = imaginación;
        _notasSobreImaginación = notasSobreImaginación;
    }
    Imaginaciones(string libro, int capítulo, int versículo, string escritura, int posiciónInicial, int posiciónFinal, string imaginación, string notasSobreImaginación, string libroCanónico) 
                : base (libro, capítulo, versículo, escritura, posiciónInicial, posiciónFinal, libroCanónico){
        _imaginación = imaginación;
        _notasSobreImaginación = notasSobreImaginación;
    }

    // Acciones
    //Getters & Setters
    public string GetImaginación(){
        return _imaginación;
    }
    public string GetNotasSobreImaginación(){
        return _notasSobreImaginación;
    }   
    public void SetNotasSobreImaginación(string notasSobreImaginación){
        _notasSobreImaginación = notasSobreImaginación;
    }

    //
    public override void Mostrar()
    {
        base.Mostrar();
        Console.Write($"{_imaginación}.\nNotas sobre la narración: {_notasSobreImaginación}");
    }

    //
    public void MostrarSoloImaginación()
    {
        Console.Write(_imaginación);
    }
    
    //
    public void MostrarSoloImaginaciónConNotas()
    {
        Console.Write($"{_imaginación}.\nNotas sobre la narración: {_notasSobreImaginación}");
    }
}