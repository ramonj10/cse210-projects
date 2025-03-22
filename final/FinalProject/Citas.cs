public class Citas : Escrituras{
    // Atributos
    private int _posiciónInicial;
    private int _posiciónFinal;
    private int? _año;
    private string?  _prefijo;
    private string? _sufijjo;
    private string? _notasSobreCita;

    // Constructores
    public Citas(string libro, int capítulo, int versículo, string escritura, int posiciónInicial, string libroCanónico) 
                : base(libro, capítulo, versículo, escritura, libroCanónico){
        _posiciónInicial = posiciónInicial;
        _posiciónFinal = escritura.Length-1;
    }
    public Citas(string libro, int capítulo, int versículo, string escritura, int posiciónInicial, int posiciónFinal, string libroCanónico) 
                : base(libro, capítulo, versículo, escritura, libroCanónico){
        _posiciónInicial = posiciónInicial;
        _posiciónFinal = posiciónFinal;
    }

    public Citas(string libro, int capítulo, int versículo, string escritura, int posiciónInicial, int posiciónFinal, string notasSobreCitas, string libroCanónico) 
                : base(libro, capítulo, versículo, escritura, libroCanónico){
        _posiciónInicial = posiciónInicial;
        _posiciónFinal = posiciónFinal;
        _notasSobreCita = notasSobreCitas;
    }

    // Acciones
    //Getters & Setters
    string cita;
    public int GetPosiciónInicial(){
        return _posiciónInicial;
    }
    public int GetPosiciónFinal(){
        return _posiciónFinal;
    }
    public string GetNotasSobreCita(){
        return _notasSobreCita;
    }
    public string GetCita(){
        for (int i=_posiciónInicial; i<_posiciónFinal; i++){
            cita = GetEscritura().Substring(_posiciónInicial, _posiciónFinal);
        }
        return cita;
    }
    public void SetNotasSobreCita(string notasSobreCitas){
        _notasSobreCita = notasSobreCitas;
    }

    //
    public override void Mostrar(){
        for (int i=_posiciónInicial; i<_posiciónFinal; i++){
            cita = GetEscritura().Substring(_posiciónInicial, _posiciónFinal);
        }
        Console.Write($"{GetLibro} {GetCapítulo}:{GetVersículo} {cita}\n  Notas sobre esta cita: {_notasSobreCita}");
    }

    //
    public void MostrarSoloCita(){
        for (int i=_posiciónInicial; i<_posiciónFinal; i++){
            cita = GetEscritura().Substring(_posiciónInicial, _posiciónFinal);
        }
        Console.Write(cita);
    }
}