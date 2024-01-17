using ejercicio1DeStrings.Servicios;

namespace ejercicio1DeStrings;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("En el nombre y apellidos que se ponga debe existir al menos una a una r y el conjunto de letras arc.");

        pedirAlUsuarioInterfaz pa = new pedirAlUsuarioImplementacion();


        string[] datosCliente= pa.solicitarNombreCompleto();
        pa.solicitarDNICompleto();  
        pa.solicitarCodigoPostalCompleto();
       string[] datosApellidos= pa.concatenizacionDeNombre(datosCliente);
        pa.concatenizacionDeApellidos(datosApellidos);
        pa.mostrarDecimoCaracter(datosCliente);
        pa.buscarLetra(datosCliente);
        pa.contarLetrasDeNombre(datosCliente);
        pa.separarNombre(datosCliente);
        pa.buscarARC(datosCliente);
    }
}


