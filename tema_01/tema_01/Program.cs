using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string codigo = "", carrera = "", bienvenido = "";

            do
            {
                Console.WriteLine("===========Menu=========");
                Console.WriteLine("1.Leer codigo de estudiantes y carrera ");
                Console.WriteLine("2.Formar una etiqueta  textualizada con ambos");
                Console.WriteLine("3.Mostrar longitud  de  codigo , carrera  y etiqueta");
                Console.WriteLine("4.Mostrar  el primer y ultimo  caracter ");
                Console.WriteLine("5.Imprimir  la carrera caracter por");
                Console.WriteLine("6.Cree una nueva  etiqueta de bienvenida  agregada ");
                Console.WriteLine("7.Correo");
                Console.WriteLine("8.salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el codigo");
                        codigo = Console.ReadLine();
                        Console.WriteLine("carrera: ");
                        carrera = Console.ReadLine();
                        break;
                    case 2:
                        bienvenido = codigo + "  | carrera: " + carrera;
                        Console.WriteLine(" etiqueta generada " + bienvenido);

                        break;
                    case 3:
                        Console.WriteLine("la longitud  es:" + codigo.Length);
                        Console.WriteLine("la longitud  es:" + carrera.Length);
                        Console.WriteLine("la longitud  es:" + bienvenido.Length);
                        break;
                    case 4:
                        Console.WriteLine("El primer caracter es: " + carrera[0]);
                        Console.WriteLine("el ultimo caracter es: " + carrera[carrera.Length - 1]);
                        break;
                    case 5: //ingenieria S I S T E M A S 
                        for (int i = 0; i < carrera.Length; i++)
                        {
                            Console.WriteLine(carrera[i]);
                        }
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine("Ingrese sus nombres: ");
                        string alumno = Console.ReadLine();

                        string[] partes = alumno.Split(' ');


                        string primerNombre = partes[0];
                        string iniciales = "";
                        for (int i = 0; i > partes.Length; i++)
                        {
                            iniciales += partes[i].Substring(0, 1);

                        }
                        Console.WriteLine($"{primerNombre}{iniciales}@upn.pe");
                        break;
                    case 8:
                        Console.WriteLine("Hasta luego.......chau");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }


            } while (opcion != 8);
        }
    }
}
