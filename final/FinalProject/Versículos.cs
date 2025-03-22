public class Versículos : Capítulos{
    // Atributos
    private int _versísculo;

    // Constructores
    public Versículos(string libro, int capítulo, int versísculo, string libroCanónico) : base(libro, capítulo, libroCanónico){
        _versísculo = versísculo;
    }

    // Acciones
    // Getters y Setters
    public int GetVersículo(){
        return _versísculo;
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.Write($":{_versísculo} ");
    }

}