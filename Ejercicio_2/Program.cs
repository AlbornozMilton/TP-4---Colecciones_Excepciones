using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operacion de Division Entera");
            Console.WriteLine();
            FachadaMat iFachadaMat = new FachadaMat();
            int dividendo, divisor;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Operacion de Division Entera");
                    Console.WriteLine();
                    Console.WriteLine("Ingrese Dividendo: ");
                    dividendo = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Divisor: ");
                    divisor = Int32.Parse(Console.ReadLine());
                    Console.Write("Resultado: ");
                    Console.WriteLine(iFachadaMat.DividicionEntera(dividendo, divisor));
                    Console.ReadKey();
                }
                catch (FormatException pE)
                {
                    Console.WriteLine("Los Parametros ingresados son invalido. Ambos deben ser enteros.");
                    Console.WriteLine("Mensaje Exception Original: {0}", pE.Message);
                    Console.WriteLine("CallStack:");
                    Console.WriteLine(pE.StackTrace);
                    Console.ReadKey();

                }
                catch (ArgumentException pE)
                {
                    Console.WriteLine("Los Parametros ingresados son invalido. Ambos deben ser enteros.");
                    Console.WriteLine("Mensaje Exception Original: {0}",pE.Message);
                    Console.WriteLine("CallStack:");
                    Console.WriteLine(pE.StackTrace);
                    Console.ReadKey();

                }
                catch (DivisionPorCeroException pE)
                {
                    Console.WriteLine(pE.Message);
                    Console.WriteLine("Mensaje Exception Original: {0}", pE.InnerException.Message);
                    Console.WriteLine("CallStack:");
                    Console.WriteLine(pE.StackTrace);
                    Console.ReadKey();

                }

            } while (true);
        }
    }
}
