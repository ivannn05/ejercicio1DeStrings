using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1DeStrings.Servicios
{
    internal interface pedirAlUsuarioInterfaz
    {
        public string[] solicitarNombreCompleto();

        public void solicitarDNICompleto();

        public void solicitarCodigoPostalCompleto();

        public string[] concatenizacionDeNombre(string[] datosCliente);

        public string concatenizacionDeApellidos(string[] datosApellidos);

        public void contarLetrasDeNombre(string[] datosCliente);

        public void mostrarDecimoCaracter(string[] datosCliente);

        public void buscarLetra(string[] datosCliente);

        public void separarNombre(string[] datosCliente);

        public void buscarARC(string[] datosCliente);
    }
}
