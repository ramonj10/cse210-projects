public class HistoriaLugares : Lugares{
    // Atributos
    private List<Escrituras> _referencia;
    private List<Citas>? _historiaLugarLiteral;
    private List<Narraciones>? _historiaLugarNarrativa;
    private List<Imaginaciones>? _historiaLugarImaginativa;
    
    // Constructores
    HistoriaLugares(string nombre, string pais, List<Escrituras> referencia) : base(nombre, pais){
        _referencia = referencia;
    }
    HistoriaLugares(string nombre, string pais, string región, List<Escrituras> referencia) : base(nombre, pais, región){
        _referencia = referencia;
    }
    HistoriaLugares(string nombre, string pais, string región, string área, List<Escrituras> referencia) : base(nombre, pais, región, área){
        _referencia = referencia;
    }
    HistoriaLugares(string nombre, string pais, string región, string área, Personajes nombradoPor, List<Escrituras> referencia) 
                    : base(nombre, pais, región, área, nombradoPor){
        _referencia = referencia;
    }

    // Acciones
    //Getters & Setters
    public List<Escrituras> GetReferencias(){
        return _referencia;
    }
    public List<Citas> GethistoriaLugarLiteral(){
        return _historiaLugarLiteral;
    }
    public List<Narraciones> GetHistoriaLugarNarrativa(){
        return _historiaLugarNarrativa;
    }
    public List<Imaginaciones> GetHistoriaLugarImaginativa(){
        return _historiaLugarImaginativa;
    }
    public void SetReferencias(List<Escrituras> referencia){
        _referencia = referencia;
    }
    public void GetHistoriaLugarLiteral(List<Citas> historiaLugarLiteral){
        _historiaLugarLiteral = historiaLugarLiteral;
    }
    public void GetHistoriaLugarNarrativa(List<Narraciones> historiaLugarNarrativa){
        _historiaLugarNarrativa = historiaLugarNarrativa;
    }
    public void GetHistoriaLugarImaginativa(List<Imaginaciones> historiaLugarImaginativa){
        _historiaLugarImaginativa = historiaLugarImaginativa;
    }

    //
    public override void Mostrar(){
        Console.Write($"\nEsta es la relación de referencias donde se menciona {GetNombre}: ");
        foreach (Escrituras referencia in _referencia){
            referencia.MostrarReferencia();
        }
        Console.Write($"\nEstas son las citas literales donde se habla de {GetNombre}: ");
        MostrarHistoriaLugarLiteral();
        Console.Write($"\nAsí es como yo entiendo que era {GetNombre} basado en las citas que hay sobre ella: ");
        MostrarHistoriaLugarNarrativa();
        Console.Write($"\nAsí es como yo me imagino {GetNombre} en su época: ");
        MostrarHistoriaLugarImaginativa();
    }

     //
    public void MostrarHistoriaLugarLiteral(){
        foreach (Citas oCita in _historiaLugarLiteral){
            Console.Write($"{oCita.GetLibro()} {oCita.GetCapítulo()}:{oCita.GetVersículo()}; {oCita.GetCita()}");
        } 
    }

    //
    public void MostrarHistoriaLugarLiteralConNotas(){
        foreach (Citas oCita in _historiaLugarLiteral){
            Console.Write($"{oCita.GetLibro()} {oCita.GetCapítulo()}:{oCita.GetVersículo()}; {oCita.GetCita()} \n{oCita.GetNotasSobreCita()}");
        } 
    }

    //
    public void MostrarHistoriaLugarNarrativa(){
        foreach (Narraciones ohistoriaLugar in _historiaLugarNarrativa){
            Console.Write($"{ohistoriaLugar.GetLibro()} {ohistoriaLugar.GetCapítulo()}:{ohistoriaLugar.GetVersículo()}; {ohistoriaLugar.GetNarración()}");
        } 
    }

    //
    public void MostrarHistoriaLugarNarrativaConNotas(){
        foreach (Narraciones ohistoriaLugar in _historiaLugarNarrativa){
            Console.Write($"{ohistoriaLugar.GetLibro()} {ohistoriaLugar.GetCapítulo()}:{ohistoriaLugar.GetVersículo()}; {ohistoriaLugar.GetNarración()}" +
            $"\n{ohistoriaLugar.GetNotasSobreNarración()}");
        } 
    }
    
    //
    public void MostrarHistoriaLugarImaginativa(){
        foreach (Imaginaciones ohistoriaLugar in _historiaLugarImaginativa){
            Console.Write($"{ohistoriaLugar.GetLibro()} {ohistoriaLugar.GetCapítulo()}:{ohistoriaLugar.GetVersículo()}; {ohistoriaLugar.GetImaginación()}");
        } 
    }

    //
    public void MostrarHistoriaLugarImaginativaConNotas(){
        foreach (Imaginaciones ohistoriaLugar in _historiaLugarImaginativa){
            Console.Write($"{ohistoriaLugar.GetLibro()} {ohistoriaLugar.GetCapítulo()}:{ohistoriaLugar.GetVersículo()}; {ohistoriaLugar.GetImaginación()}" +
            $"\n{ohistoriaLugar.GetNotasSobreImaginación()}");
        } 
    }
    
}