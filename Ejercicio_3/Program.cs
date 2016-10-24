using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaStream iFachada = new FachadaStream();

            Console.WriteLine("Ingrese ruta de archivo:");
            string mRuta = Console.ReadLine();

            Console.WriteLine(iFachada.BuscarArchivo(mRuta));

            Console.WriteLine("----------FIN-----------");
            
            Console.ReadKey();
        }
    }
}