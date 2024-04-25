using System;

class Program
{
    static void Main(string[] args)
    {
        // Mensaje de ejemplo
        Console.WriteLine("Este es el ejemplo de programación orientada a objetos en C#");

        // Ejemplos de uso
        // Abstracción
        Console.WriteLine("\nAbstracción:");
        Jedi obiWanKenobi = new Jedi();
        Console.WriteLine("El Jedi ataca con su sable de luz.");
        Console.WriteLine("El Jedi desvía los disparos con la Fuerza.");

        // Herencia
        Console.WriteLine("\nHerencia:");
        CazaEstelar xWing = new CazaEstelar();
        xWing.Nombre = "X-Wing";
        xWing.Velocidad = 1000;
        Console.WriteLine($"La nave {xWing.Nombre} tiene una velocidad de {xWing.Velocidad} km/h.");
        Console.WriteLine("Escudos activados para el caza estelar.");

        // Polimorfismo
        Console.WriteLine("\nPolimorfismo:");
        Console.WriteLine("El Jedi usa la Fuerza para mover objetos.");
        Console.WriteLine("El Sith ejerce su poder para asfixiar a sus enemigos.");

        // Encapsulación
        Console.WriteLine("\nEncapsulación:");
        Droide r2d2 = new Droide("Astromecánico", "Reparación");
        Console.WriteLine($"El droide es de tipo {r2d2.Funcionalidad}.");

        // Interfaces
        Console.WriteLine("\nInterfaces:");
        IFaccion rebelde = new Alianza();
        Console.WriteLine($"La facción es: {rebelde.ObtenerFaccion()}");

        // Delegados
        Console.WriteLine("\nDelegados:");
        DelegadoLider liderAlianza = LiderAlianza;
        liderAlianza(new Jedi());

        // Eventos
        Console.WriteLine("\nEventos:");
        Batalla batalla = new Batalla();
        batalla.InicioBatalla += (sender, e) =>
        {
            Console.WriteLine($"La batalla ha comenzado en {e.Lugar}. Resultado: {e.Resultado}");
        };
        batalla.EmpezarBatalla("Hoth");

        // Indexadores
        Console.WriteLine("\nIndexadores:");
        Galaxia galaxia = new Galaxia();
        Console.WriteLine($"El tercer planeta de la galaxia es: {galaxia[2]}");

        // Propiedades
        Console.WriteLine("\nPropiedades:");
        Arma sableLuz = new Arma();
        sableLuz.Tipo = "Sable de luz";
        Console.WriteLine($"El arma del Jedi es un {sableLuz.Tipo}.");
    }

    static void LiderAlianza(Personaje lider)
    {
        Console.WriteLine($"El líder de la Alianza es un {lider.GetType().Name}");
    }
}
