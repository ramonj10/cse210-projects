public class Narraciones : Citas{
    // Atributos
    private string _narración;
    private string _notasSobreNarración;
    
    // Constructores
    Narraciones(string libro, int capítulo, int versículo, string escritura, int posiciónInicial, string narración, string libroCanónico) 
                : base (libro, capítulo, versículo, escritura, posiciónInicial, libroCanónico){
        _narración = narración;
    }
    Narraciones(string libro, int capítulo, int versículo, string escritura, int posiciónInicial, int posiciónFinal, string narración, string libroCanónico) 
                : base (libro, capítulo, versículo, escritura, posiciónInicial, posiciónFinal, libroCanónico){
        _narración = narración;
    }
    Narraciones(string libro, int capítulo, int versículo, string escritura, int posiciónInicial, string narración, string notasSobreNarración,  string libroCanónico) 
                : base (libro, capítulo, versículo, escritura, posiciónInicial, libroCanónico){
        _narración = narración;
        _notasSobreNarración = notasSobreNarración;
    }
    Narraciones(string libro, int capítulo, int versículo, string escritura, int posiciónInicial, int posiciónFinal, string narración, string notasSobreNarración, string libroCanónico) 
                : base (libro, capítulo, versículo, escritura, posiciónInicial, posiciónFinal, libroCanónico){
        _narración = narración;
        _notasSobreNarración = notasSobreNarración;
    }

    // Acciones
    //Getters & Setters
    public string GetNarración(){
        return _narración;
    }
    public string GetNotasSobreNarración(){
        return _notasSobreNarración;
    }   
    public void SetNotasSobreNarración(string notasSobreNarración){
        _notasSobreNarración = notasSobreNarración;
    }

    //
    public override void Mostrar()
    {
        base.Mostrar();
        Console.Write($"{_narración}.\nNotas sobre la narración: {_notasSobreNarración}");
    }

    //
    public void MostrarSoloNarración()
    {
        Console.Write(_narración);
    }
    
    //
    public void MostrarSoloNarraciónConNotas()
    {
        Console.Write($"{_narración}.\nNotas sobre la narración: {_notasSobreNarración}");
    }
}