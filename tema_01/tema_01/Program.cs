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
            string codigo = "", carrera="", bienvenido = "";
            
            do 
            {
                Console.WriteLine("===========Menu=========");
                Console.WriteLine("Leer codigo de estudiantes y carrera ");
                Console.WriteLine("2.Formar una etiqueta  textualizada con ambos");
                Console.WriteLine("3. Mostrar longitud  de  codigo , carrera  y etiqueta");
                Console.WriteLine("4.Mostrar  el primer y ultimo  caracter ");
                Console.WriteLine("5.Imprimir  la carrera caracter por");
                Console.WriteLine("6.Cree una nueva  etiqueta de bienvenida  agregada ");
                Console.WriteLine("7.Salir del menu");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:Console.WriteLine("Ingrese el codigo");
                        codigo= Console.ReadLine();
                        Console.WriteLine("carrera: ");
                        carrera=Console.ReadLine();
                        break;
                    case 2:
                        bienvenido=codigo +"  | carrera: "+ carrera ;
                        Console.WriteLine(" etiqueta generada " + bienvenido);

                        break;
                    case 3:
                        Console.WriteLine("la longitud  es:"+ codigo.Length);
                        Console.WriteLine("la longitud  es:" + carrera.Length);
                        Console.WriteLine("la longitud  es:" + bienvenido.Length);
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:Console.WriteLine("Hasta luego.......chauuuuuuuuuuuuuuuuuuuuuuuuuuu");
                        break;
                    default: Console.WriteLine("Error");
                        break;
                }


            }  while (opcion !=7);
        }
    }
}
