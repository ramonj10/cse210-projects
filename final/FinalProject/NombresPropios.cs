using static System.DateTime;

public class NombresPropios {
    // Attributos
    private string _nombre;
    private DateTime _fechaInicio;
    private DateTime _fechaFin;

    // Constructores
    public NombresPropios(){
        _nombre = "Desconocido";
    }

    public NombresPropios(string nombre){
        _nombre = nombre;
    }

    public NombresPropios(string nombre, DateTime fechaInicio){
        _nombre = nombre;
        _fechaInicio = fechaInicio;
    }

    public NombresPropios(string nombre, DateTime fechaInicio, DateTime fechaFin){
        _nombre = nombre;
        _fechaInicio = fechaInicio;
        _fechaFin = fechaFin;
    }

    // Acciones
    //Getters & Setters
    public string GetNombre(){
        return _nombre;
    }

    public DateTime GetFechaInicio (){
        return _fechaInicio;
    }

    public DateTime GetFechaFin(){
        return _fechaFin;
    }

    public void SetFechaInicio (DateTime fechaInicio){
        _fechaInicio = fechaInicio;
    }

    public void SetFechaFin (DateTime fechaFin){
        _fechaFin = fechaFin;
    }

    // Mostrar parametros del Nombre propio
    public virtual void Mostrar(){
        Console.WriteLine($"{_nombre} ({_fechaInicio.Year} - {_fechaFin.Year})");
    }

}