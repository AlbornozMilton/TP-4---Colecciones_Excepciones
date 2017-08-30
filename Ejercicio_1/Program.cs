using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
     Las clases que se deben crear recrean un sistema N-Tier y se listan a continuación. 
     Todas las mismas tienen un sólo método llamado Ejecutar el cual instancia y ejecuta el método del NIVEL N+1.

        Nivel 1: clase CapaVista
        Nivel 2: clase CapaControlador
        Nivel 3: clase CapaAplicacion
        Nivel 4: clase CapaDominio
        Nivel 5: clase CapaPersistencia
         */
    class Program
    {
        static void Main(string[] args)
        {
            CapaVista mCV = new CapaVista(); //se instancia la capa N = 1 "Capa Vista"
            mCV.Ejecutar(); //metodo de capa vista
            Console.ReadKey();
        }
    }
}
