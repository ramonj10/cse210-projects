public class Personajes : NombresPropios{
    // Attributos
    private NombresPropios _padre;
    private List<Personajes> _hijos;
    private Lugares _lugarNacimiento;
    private Lugares _lugarDefunción;
    private List<Lugares> _lugaresDondeEstuvo;  

    // Cosntructores
    NombresPropios oNombrePropio = new NombresPropios("Desconocido");
    List<Personajes> oListaNombrePropio = new List<Person>();
    public Personajes(string nombre) : base(nombre){
        _padre = oNombrePropio;
        
        oListaNombrePropio.Add(oNombrePropio);
        _hijos = oListaNombrePropio;
    }

    public Personajes(string nombre, NombresPropios padre) : base(nombre){
        _padre = padre;

        oListaNombrePropio.Add(oNombrePropio);
        _hijos = oListaNombrePropio;
    }

    public Personajes(string nombre, List<NombresPropios> hijos) : base(nombre){
        oListaNombrePropio.Add(oNombrePropio);
        _hijos = hijos;
    }

    public Personajes(string nombre, NombresPropios padre, DateTime fechaInicio) 
                    : base(nombre, fechaInicio){
        _padre = padre;

        oListaNombrePropio.Add(oNombrePropio);
        _hijos = oListaNombrePropio;
    }

    public Personajes(string nombre, NombresPropios padre, Lugares lugarNacimiento) : base(nombre){
        _padre = padre;
        _lugarNacimiento = lugarNacimiento;

        oListaNombrePropio.Add(oNombrePropio);
        _hijos = oListaNombrePropio;
    }

    public Personajes(string nombre, NombresPropios padre, List<NombresPropios> hijos) : base(nombre){
        _padre = padre;
        _hijos = hijos;
    }

    public Personajes(string nombre, NombresPropios padre, List<NombresPropios> hijos, Lugares lugarNacimiento) : base(nombre){
        _padre = padre;
        _hijos = hijos;
        _lugarNacimiento = lugarNacimiento;
    }

    public Personajes(string nombre, NombresPropios padre, List<NombresPropios> hijos, Lugares lugarNacimiento, DateTime fechaInicio) : base(nombre, fechaInicio){
        _padre = padre;
        _hijos = hijos;
        _lugarNacimiento = lugarNacimiento;
    }

    public Personajes(string nombre, NombresPropios padre, List<NombresPropios> hijos, Lugares lugarNacimiento, DateTime fechaInicio, DateTime fechaFin) 
                        : base(nombre, fechaInicio, fechaFin){
        _padre = padre;
        _hijos = hijos;
        _lugarNacimiento = lugarNacimiento;
    } 

    public Personajes(string nombre, NombresPropios padre, List<NombresPropios> hijos, DateTime fechaInicio) 
                    : base(nombre, fechaInicio){
        _padre = padre;
        _hijos = hijos;
    }

    public Personajes(string nombre, NombresPropios padre, List<NombresPropios> hijos, DateTime fechaInicio, DateTime fechaFin)
                    : base(nombre, fechaInicio, fechaFin){
        _padre = padre;
        _hijos = hijos;
    }  

    // Acciones
    // Getters y Setters
    public NombresPropios GetPadre(){
        return _padre;
    }

    public List<NombresPropios> GetHijos(){
        return _hijos;
    }

    public Lugares GetLugarNacimiento(){
        return _lugarNacimiento;
    }
    
    public Lugares GetLugarDefunción(){
        return _lugarDefunción;
    }

    public List<Lugares> GetLugaresDondeEstuvo(){
        return _lugaresDondeEstuvo;
    }
    
    public void SetPadre(NombresPropios padre){
        _padre = padre;
    }

    public void SetHijos(List<NombresPropios> hijos){
        _hijos = hijos;
    }

    public void SetLugarNacimiento(Lugares lugarNacimiento){
        _lugarNacimiento = lugarNacimiento;
    }

    public void SetLugarDefunción(Lugares lugarDefunción){
        _lugarDefunción = lugarDefunción;
    }

    public void SetLugaresDondeEstuvo(List<Lugares> lugaresDondeEstuvo){
        _lugaresDondeEstuvo = lugaresDondeEstuvo;
    }

    // Mostrar parametros del Personaje
    public override void Mostrar(){
        if (GetFechaInicio != null & GetFechaFin != null & _lugarNacimiento != null & _lugarDefunción != null){
            Console.WriteLine($"{GetNombre()}, hijo de {_padre} tuvo estos hijos {_hijos}, nacido en {_lugarNacimiento} el año {GetFechaInicio} y fallecido en {_lugarDefunción} el año {GetFechaFin}.");
            }
        
        else if (GetFechaInicio != null & GetFechaFin != null & _lugarNacimiento != null){
            Console.WriteLine($"{GetNombre()}, hijo de {_padre} tuvo estos hijos {_hijos}, nacido en {_lugarNacimiento} el año {GetFechaInicio} y fallecido el año {GetFechaFin}.");
        }
        else if (GetFechaInicio != null & GetFechaFin != null){
            Console.WriteLine($"{GetNombre()}, hijo de {_padre} tuvo estos hijos {_hijos}, nacido el año {GetFechaInicio} y fallecido el año {GetFechaFin}.");
        }
        else if (GetFechaInicio != null){
            Console.WriteLine($"{GetNombre()}, hijo de {_padre} tuvo estos hijos {_hijos}, nacido el año {GetFechaInicio}.");
        }
        else {
            Console.WriteLine($"{GetNombre()}, hijo de {_padre} tuvo estos hijos {_hijos}.");
        }
    }

    // Linea genealógica del Personaje (Padre, Abuelo, Bisabuelo, etc.)
    public List<NombresPropios> Genealogía(){
        List<NombresPropios> genealogía = new List<NombresPropios>();
        // .........
        
        return genealogía;
    }
}
