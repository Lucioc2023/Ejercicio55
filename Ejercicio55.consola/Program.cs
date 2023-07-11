using System.Reflection.PortableExecutable;

namespace Ejercicio55.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int limiteMenor = 0, limiteMayor = 0;
            //int numeroIngresado;

            //Console.WriteLine("Ingrese un numero entero");
            //numeroIngresado = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese Limite inferior");
            //limiteMenor = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese limite superior");
            //limiteMayor = int.Parse(Console.ReadLine());
            int cantidadMultiplos = 0;
            int numeroIngresado = ValidaEntero("Ingrese un numero entero: ");
            int limiteMenor = ValidaEntero("Ingrese el limite Menor: ");
            int limiteMayor = ValidaEntero("Ingrese el limite Mayor: ");
            Console.WriteLine($" Multiplos del numero {numeroIngresado} .");

            for (int contador = limiteMenor; contador < limiteMayor; contador++)
            {
                if (EsMultiplo(contador, numeroIngresado))
                {
                    cantidadMultiplos = cantidadMultiplos + 1;
                    Console.WriteLine($"{contador} ");
                }
            }
            Console.WriteLine($"Son {cantidadMultiplos} en total");
            Console.ReadLine();
        }
        private static int ValidaEntero(string Mensaje)//recibe un mensaje y devuelve un entero
        {
            int Nro=0;
            do
            {
                Console.Write(Mensaje);
                string strConsola =Console.ReadLine();
                if (!int.TryParse(strConsola,out Nro))//SI NO LO PODES CONVERTIR A ENTERO
                {
                    Console.WriteLine("VALOR MAL INGRESADO / INGRESE NUEVAMENTE");

                }
                else
                {
                    break;
                }

            } while (true);
            return Nro;
        }
        private static bool EsMultiplo(int contador, int numeroIngresado)
        {
            return contador % numeroIngresado == 0;
        }
    }
}