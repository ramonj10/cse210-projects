using System;

class Program
{
    static void Main(string[] args)
    {
        // Lista de objetos de Nombres Propios
        List<NombresPropios> nombresPropios = new List<NombresPropios>();
        List<Personajes> personajes = new List<Personajes>();
        
        // Display a recurrent Menu
        bool replay =true;
        while (replay == true){
            // Menu de opciones
            Console.WriteLine("MENÚ DE NOMBRES PROPIOS\n" + 
                            "1. Añadir\n" +
                            "2. Modificar\n" +
                            "3. Ver\n" +
                            "s. Salir del programa\n");
            Console.Write("Elegir una de las opciones del menú y pulsar enter: ");
            string opción = Console.ReadLine()!;

            // Analizar opción seleccionada
            DateTime fechaInicial = new DateTime();
            DateTime fechaFinal = new DateTime();
            string padreEntrada;
            if (opción == "1"){
                Console.Write("¿Que nombre quieres añadir? ");
                string nombre = Console.ReadLine()!;  // ! null-forgiveness operator
                NombresPropios oNombre = new NombresPropios(nombre);
                
                Console.Write("Introduce la fecha de Nacimiento: (dd-mm-aaaa) y enter o enter si no la conoces.");
                string fechaIni = Console.ReadLine()!;  // ! null-forgiveness operator
                
                if (fechaIni.Length == 10){
                    fechaInicial = DateTime.Parse(fechaIni);
                }
                
                Console.Write("Introduce la fecha de Defunción: (dd-mm-aaaa) y enter o enter si no la conoces.");
                string fechaFin = Console.ReadLine()!;  // ! null-forgiveness operator
                
                if (fechaFin.Length == 10){
                    fechaFinal = DateTime.Parse(fechaFin);
                }

                Console.Write("Nombre del padre: ");
                padreEntrada = Console.ReadLine()!;
                /*
                if (padreEntrada.Length <= 2){
                    padreEntrada = "Desconocido";
                }
                */
                //else{
                    Personajes padre = new Personajes(padreEntrada);
                    // personajes = padreEntrada;
                //}

                List<Personajes> hijos = new List<Personajes>();
                string hijo ="";
                while (hijo != "f"){
                    Console.Write("Nombre de los hijos: (f para finalizar) ");
                    hijo = Console.ReadLine()!;
                    
                    if (hijo == "f"){
                        Console.WriteLine("Entró en la f.");
                        break;
                    }
                    else if (hijo.Length <= 2){
                        hijo = null;
                    }
                    else{
                        Personajes oPersonajeHijo = new Personajes(hijo, oNombre);
                        hijos.Add(oPersonajeHijo);
                    }
                }

                //Determinar el cosntructor a usar             
                // Solo con nombre del personaje
                if (fechaInicial == DateTime.MinValue & fechaFinal == DateTime.MinValue & padre == null & hijos.Count == 0){   // DateTime.MinValue es que no hay fecah (El menor valor posible)
                Personajes nuevoNombre = new Personajes(nombre);
                personajes.Add(nuevoNombre);
                }

                // Solo con nombre del personaje e hijos
                if (fechaInicial == DateTime.MinValue & fechaFinal == DateTime.MinValue & padre == null & hijos.Count != 0){   // DateTime.MinValue es que no hay fecah (El menor valor posible)
                Personajes nuevoNombre = new Personajes(nombre, hijos);
                personajes.Add(nuevoNombre);
                Console.WriteLine($"")
                }

                // Con nombre del Personaje y nombre del Padre
                else if (fechaInicial == DateTime.MinValue & fechaFinal == DateTime.MinValue & padre != null & hijos.Count == 0){
                Personajes nuevoNombre = new Personajes(nombre, padre);
                personajes.Add(nuevoNombre);
                }

                // Con nombre del Personaje, del Padre y fecha de Nacimiento
                else if (fechaInicial != DateTime.MinValue & fechaFinal == DateTime.MinValue & padre != null & hijos.Count == 0){
                Personajes nuevoNombre = new Personajes(nombre, padre, fechaInicial);
                personajes.Add(nuevoNombre);
                }

                // Con nombre del Personaje y fecha de Nacimeinto
                else if ( fechaFinal != DateTime.MinValue & fechaInicial == DateTime.MinValue & padre == null & hijos.Count == 0){
                NombresPropios nuevoNombre = new NombresPropios(nombre, fechaInicial);
                nombresPropios.Add(nuevoNombre);
                }
                
                // Con nombre del Personaje, fecha de Nacimeinto y Defunción
                else if ( fechaInicial != DateTime.MinValue & fechaFinal != DateTime.MinValue & padre == null & hijos.Count == 0){
                NombresPropios nuevoNombre = new NombresPropios(nombre, fechaInicial, fechaFinal);
                nombresPropios.Add(nuevoNombre);
                }
            }

            else if (opción == "2"){

            }
            
            else if (opción == "3"){
                Console.Write("¿Que nombre quieres mostrar? ");
                string nombre = Console.ReadLine()!;  // ! null-forgiveness operator
                Console.WriteLine($"Número de Nombres Propios {nombresPropios.Count}");
                foreach (NombresPropios el in nombresPropios){
                    // Console.WriteLine(el.GetNombre());
                    if (el.GetNombre() == nombre){
                        el.Mostrar();
                    }
                }
            }

            else if (opción == "s"){
                replay = false;
            }
        }
    }
}
