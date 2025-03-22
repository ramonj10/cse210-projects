public class Biografías : Personajes{
    // Atributos
    private List<Escrituras> _referencia;
    private List<Citas>? _biografíaLiteral;
    private List<Narraciones>? _biografíaNarrativa;
    private List<Imaginaciones>? _biografíaImaginativa;

    // Constructores
    public Biografías(string nombre, Personajes padre, List<NombresPropios> hijos, List<Escrituras> referencia) : base(nombre, padre, hijos){
        _referencia = referencia;
    }

    // Acciones
    //Getters & Setters
    public List<Escrituras> GetReferencias(){
        return _referencia;
    }
    public List<Citas> GetBiografíaLiteral(){
        return _biografíaLiteral;
    }
    public List<Narraciones> GetBiografíaNarrativa(){
        return _biografíaNarrativa;
    }
    public List<Imaginaciones> GetBiografíaImaginativa(){
        return _biografíaImaginativa;
    }
    public void SetReferencias(List<Escrituras> referencia){
        _referencia = referencia;
    }
    public void GetBiografíaLiteral(List<Citas> biografíaLiteral){
        _biografíaLiteral = biografíaLiteral;
    }
    public void GetBiografíaNarrativa(List<Narraciones> biografíaNarrativa){
        _biografíaNarrativa = biografíaNarrativa;
    }
    public void GetBiografíaImaginativa(List<Imaginaciones> biografíaImaginativa){
        _biografíaImaginativa = biografíaImaginativa;
    }

    //
    public override void Mostrar(){
        Console.Write($"\nEsta es la relación de referencias donde se menciona a {GetNombre}: ");
        foreach (Escrituras referencia in _referencia){
            referencia.MostrarReferencia();
        }
        Console.Write($"\nEstas son las citas literales donde se habla de {GetNombre}: ");
        MostrarBiografíaLiteral();
        Console.Write($"\nAsí es como yo entiendo que fue {GetNombre} basado en las citas que hay sobre él: ");
        MostrarBiografíaNarrativa();
        Console.Write($"\nAsí es como yo me imagino a {GetNombre} en su época: ");
        MostrarBiografíaImaginativa();
    }

    //
    public void MostrarBiografíaLiteral(){
        foreach (Citas oCita in _biografíaLiteral){
            Console.Write($"{oCita.GetLibro()} {oCita.GetCapítulo()}:{oCita.GetVersículo()}; {oCita.GetCita()}");
        } 
    }

    //
    public void MostrarBiografíaLiteralConNotas(){
        foreach (Citas oCita in _biografíaLiteral){
            Console.Write($"{oCita.GetLibro()} {oCita.GetCapítulo()}:{oCita.GetVersículo()}; {oCita.GetCita()} \n{oCita.GetNotasSobreCita()}");
        } 
    }

    //
    public void MostrarBiografíaNarrativa(){
        foreach (Narraciones oBiografía in _biografíaNarrativa){
            Console.Write($"{oBiografía.GetLibro()} {oBiografía.GetCapítulo()}:{oBiografía.GetVersículo()}; {oBiografía.GetNarración()}");
        } 
    }

    //
    public void MostrarBiografíaNarrativaConNotas(){
        foreach (Narraciones oBiografía in _biografíaNarrativa){
            Console.Write($"{oBiografía.GetLibro()} {oBiografía.GetCapítulo()}:{oBiografía.GetVersículo()}; {oBiografía.GetNarración()}" +
            $"\n{oBiografía.GetNotasSobreNarración()}");
        } 
    }
    
    //
    public void MostrarBiografíaImaginativa(){
        foreach (Imaginaciones oBiografía in _biografíaImaginativa){
            Console.Write($"{oBiografía.GetLibro()} {oBiografía.GetCapítulo()}:{oBiografía.GetVersículo()}; {oBiografía.GetImaginación()}");
        } 
    }

    //
    public void MostrarBiografíaImaginativaConNotas(){
        foreach (Imaginaciones oBiografía in _biografíaImaginativa){
            Console.Write($"{oBiografía.GetLibro()} {oBiografía.GetCapítulo()}:{oBiografía.GetVersículo()}; {oBiografía.GetImaginación()}" +
            $"\n{oBiografía.GetNotasSobreImaginación()}");
        } 
    }
}