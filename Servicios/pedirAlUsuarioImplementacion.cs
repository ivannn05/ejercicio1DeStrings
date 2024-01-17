using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1DeStrings.Servicios
{
    internal class pedirAlUsuarioImplementacion : pedirAlUsuarioInterfaz
    {
     
        public string[] solicitarNombreCompleto()
        {
            Console.WriteLine("\tIntroduzca su nombre");
            string nombreUsu = Console.ReadLine();

            Console.WriteLine("\tIntroduzca su 1ºApellido");
            string primerApellidoUsu = Console.ReadLine();

            Console.WriteLine("\tIntroduzca su 2ºApellido");
            string segundoApellidoUsu = Console.ReadLine();

            string[] nombreCompleto = { nombreUsu,primerApellidoUsu,segundoApellidoUsu };

            string nombreConcatenado = string.Concat(nombreUsu,primerApellidoUsu, segundoApellidoUsu );

            do
            {

                if (!nombreUsu.Equals(primerApellidoUsu) & !nombreUsu.Equals(segundoApellidoUsu))
                {

                }
                else
                {
                    Console.WriteLine("Su nombre coincide con su primer apellido, Cambielo");
                    Console.WriteLine("\tIntroduzca su nombre");
                    nombreUsu = Console.ReadLine();

                    Console.WriteLine("\tIntroduzca su 1ºApellido");
                    primerApellidoUsu = Console.ReadLine();

                    Console.WriteLine("\tIntroduzca su 2ºApellido");
                    segundoApellidoUsu = Console.ReadLine();
                }
            }while (nombreUsu.Equals(primerApellidoUsu) || nombreUsu.Equals(segundoApellidoUsu));

            return nombreCompleto;
  
        } 
        
        public void solicitarDNICompleto()
        {
            Console.WriteLine("\tIntroduzca sus numeros del DNI");
            int DNInumeros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tIntroduzca su letra del DNI");
            string DNIletra = Console.ReadLine();

          int resultado = DNInumeros % 23;

            string[] posicionLetraDNI = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B",
                "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            string letraCalculada = posicionLetraDNI[resultado];
            do
            {

                if (letraCalculada.Equals(DNIletra))
                {

                }
                else
                {
                    Console.WriteLine("Su DNI no coincide existe");

                    Console.WriteLine("\tIntroduzca sus numeros del DNI");
                    DNInumeros = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\tIntroduzca su letra del DNI");
                    DNIletra = Console.ReadLine();

                }
            } while (!letraCalculada.Equals(DNIletra));
        }

        public void solicitarCodigoPostalCompleto()
        {
            Console.WriteLine("\tIntroduzca su codigo postal");
            string codigoPostal = Console.ReadLine();

            do
            {
                if (codigoPostal[0].Equals("4") & codigoPostal[1].Equals("1") & codigoPostal[2].Equals("0"))
                {

                }
                else
                {
                    
                }
            } while (!codigoPostal[0].Equals("4") & codigoPostal[1].Equals("1") & !codigoPostal[2].Equals("0"));
        }
        public string[] concatenizacionDeNombre(string[] datosApellidos)
        {
          string[] nombreCompleto=datosApellidos;

            string nombreUsu= nombreCompleto[0];
            string primerApellido= nombreCompleto[1];
            string segundoApellido = nombreCompleto[2];

            string[] apellidosUsu = {primerApellido,segundoApellido };

            string nombreConcatenado = string.Concat(primerApellido, segundoApellido, nombreUsu);

            string apellidosConcatenados = string.Concat(primerApellido, segundoApellido);

            return apellidosUsu;
        }
        public string concatenizacionDeApellidos(string[] datosApellidos)
        {
            string[] apellidosUsu = datosApellidos;

            string primerApellido = apellidosUsu[0];
                string segundoApellido= apellidosUsu[1];


            string apellidosConcatenados = primerApellido+ segundoApellido;
            Console.WriteLine("Su apellido concatenado es=" + apellidosConcatenados);
            return apellidosConcatenados;
        }
        public void contarLetrasDeNombre(string[] datosCliente)
        {
            
            string[] nombreCompleto = datosCliente;

            string nombreUsu = nombreCompleto[0];
            string primerApellido = nombreCompleto[1];
            string segundoApellido = nombreCompleto[2];

            string nombreConcatenado = string.Concat(primerApellido,"," ,segundoApellido, nombreUsu,".");

            Console.WriteLine("Numero de letras en su nombre completo es="+nombreConcatenado.Length);
        }

        public void mostrarDecimoCaracter(string[] datosCliente)
        {
           

            string[] apellidos = datosCliente;

            
            string primerApellido = apellidos[1];
            string segundoApellido = apellidos[2];

            string apellidosCompletos = primerApellido + segundoApellido;

            Console.WriteLine("Su decimo caracter es="+apellidosCompletos[10]);
        }

        public void buscarLetra(string[] datosCliente)
        {
            string[] nombre = datosCliente;



            string nombreUsu = nombre[0];
            string primerApellido = nombre[1];
            string segundoApellido = nombre[2];

            string nombreCompleto = nombreUsu + primerApellido + segundoApellido;

            Console.WriteLine("Si su nombre tiene a es 1, si no tiene sera -1 =" + nombreCompleto.IndexOf("a"));
            
            Console.WriteLine(nombreCompleto.IndexOf('a' , 3, 10));
        }

        public void separarNombre(string[] datosCliente)
        {
            string[] nombreCompleto = datosCliente;
            string nombreUsu = nombreCompleto[0];
            string aux = "";

            for (int i = 0; i < nombreUsu.Length; i++)
            {
                aux = aux + nombreUsu[i] + " ";

            }

            string nombreNuevo = aux;
            Console.WriteLine("Su nombre separado es="+nombreNuevo);

            
        }
        public void buscarARC(string[] datosCliente)
        {
            string[] nombreCompleto = datosCliente;
            string nombreUsu = nombreCompleto[0];
            Console.WriteLine("El arc de su nombre se encuentra en la letra =" + nombreUsu.IndexOf("arc",0)+1 );
        }
    }
}
