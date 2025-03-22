using System.Diagnostics.Contracts;

public class Lugares : NombresPropios{
    // Atributos
    private string _pais;
    private string _región;
    private string _área;
    private Personajes _nombradoPor;
    
    // Constructores
    public Lugares(string nombre, string pais) : base(nombre){
        _pais = pais;
    }
    public Lugares(string nombre, DateTime fechaInicio, string pais) : base(nombre, fechaInicio){
        _pais = pais;
    }
    public Lugares(string nombre, string pais, string región) : base(nombre){
        _pais = pais;
        _región = región;
    }
    public Lugares(string nombre, DateTime fechaInicio, string pais, string región) : base(nombre, fechaInicio){
        _pais = pais;
        _región = región;
    }
    public Lugares(string nombre, string pais, string región, string área) : base(nombre){
        _pais = pais;
        _región = región;
        _área = área;
    }
    public Lugares(string nombre, DateTime fechaInicio, string pais, string región, string área) : base(nombre, fechaInicio){
        _pais = pais;
        _región = región;
        _área = área;
    }
    public Lugares(string nombre, string pais, string región, string área, Personajes nombradoPor) : base(nombre){
        _pais = pais;
        _región = región;
        _área = área;
        _nombradoPor = nombradoPor;
    }
    public Lugares(string nombre, DateTime fechaInicio, string pais, string región, string área, Personajes nombradoPor) : base(nombre, fechaInicio){
        _pais = pais;
        _región = región;
        _área = área;
        _nombradoPor = nombradoPor;
    }

    // Acciones
    //Getters & Setters
    public string GetPais(){
        return _pais;
    }        
    public string GetRegión(){
        return _región;
    } 
    public string GetÁrea(){
        return _área;
    } 
    public Personajes GetNombradoPor(){
        return _nombradoPor;
    } 
    public void SetRegión(string región){
        _región = región;
    } 
    public void SetÁrea(string área){
        _área = área;
    } 
    public void SetNombradoPor(Personajes nombradoPor){
        _nombradoPor = nombradoPor;
    }

    // 
    public override void Mostrar(){
        base.Mostrar();
        Console.Write($"Ubicado en {_área}, {_región}, {_pais}; fue nombrado por {GetNombradoPor} en {GetFechaInicio}.");
    }

    //
    public List<string> Localización(){
        List<string> localización = new List<string>();
            localización.Add( _área);
            localización.Add( _región);
            localización.Add(_pais);

        return localización;
    }

    //
    public void MostrarLocalización(){
        foreach (string elemento in Localización()){
            Console.Write($"{elemento} ,");
        }
    }
}