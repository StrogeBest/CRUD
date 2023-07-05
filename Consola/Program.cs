using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Pasajero pasajeroUno = new Pasajero("Qwerty", "Jackson", 12345678);
        Pasajero pasajeroDos = new Pasajero("Jhoe", "Robinson", 84678548);
        Pasajero pasajeroTres = new Pasajero("Mark", "Mayer", 84678548);
        Pasajero pasajeroCuatro = new Pasajero("Peter", "Parker", 87621648);

        List<Pasajero> lista = new List<Pasajero>();

        lista.Add(pasajeroUno);
        // lista.Add(pasajeroDos);
        // lista.Add(pasajeroTres);
        // lista.Add(pasajeroCuatro);

        ProveedorDatos<Pasajero>.EscribirXml("Datos/pasajero.xml", pasajeroCuatro);
        ProveedorDatos<Pasajero>.EscribirJson("Datos/pasajero.json", pasajeroCuatro);
        ProveedorDatos<Pasajero>.EscribirListaXml("Datos/pasajeros.xml", lista);
        ProveedorDatos<Pasajero>.EscribirListaJson("Datos/pasajeros.json", lista);

        List<Pasajero> pasajeros = new List<Pasajero>();

        pasajeros = ProveedorDatos<Pasajero>.LeerListaXml("Datos/pasajeros.xml");

        Console.WriteLine("\nDeserializando lista XML\n");
        foreach (Pasajero pasajero in pasajeros)
        {
            Console.WriteLine($"Nombre: {pasajero.Nombre}");
            Console.WriteLine($"Apellido: {pasajero.Apellido}");
            Console.WriteLine($"Dni: {pasajero.Dni}");
        }

        pasajeros = ProveedorDatos<Pasajero>.LeerListaJson("Datos/pasajeros.json");

        Console.WriteLine("\nDeserializando lista JSON\n");
        foreach (Pasajero pasajero in pasajeros)
        {
            Console.WriteLine($"Nombre: {pasajero.Nombre}");
            Console.WriteLine($"Apellido: {pasajero.Apellido}");
            Console.WriteLine($"Dni: {pasajero.Dni}");
        }
    }
}