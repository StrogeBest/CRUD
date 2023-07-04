using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Pasajero pasajeroUno = new Pasajero("Qwerty", "Jackson", 12345678);
        Pasajero pasajeroDos = new Pasajero("Jhoe", "Robinson", 84678548);
        Pasajero pasajeroTres = new Pasajero("Mark", "Mayer", 84678548);

        List<Pasajero> lista = new List<Pasajero>();

        lista.Add(pasajeroUno);
        lista.Add(pasajeroDos);

        ProveedorDatos<Pasajero>.EscribirJson("Datos/pasajero.json", pasajeroUno);
        ProveedorDatos<Pasajero>.EscribirListaXml("Datos/pasajeros.xml", lista);
        ProveedorDatos<Pasajero>.EscribirListaJson("Datos/pasajeros.json", lista);
    }
}