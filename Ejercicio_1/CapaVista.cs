using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class CapaVista
    {
        public void Ejecutar()
        {
            try
            {
                CapaControlador mCControlador = new CapaControlador(); //se instancia la capa N+1 = 2 "Capa Controlador"
                mCControlador.Ejecutar(); //se llama al metodo ejecutar de la intancia de la capa controlador
            }

            //cuando se atrapa la excepcion de aplicación, usamos sus propiedades para cumplir con la actividad
            catch (CapaAplicationException mAE)
            {
                Console.WriteLine("Mensaje de CapaApplicationException: " + mAE.Message);
                Console.WriteLine("Mensaje de CapaApplicationException: " + mAE.Source);
                Console.WriteLine();
                Console.WriteLine("Mensaje de ClaseErrorPuntual" + mAE.InnerException.Message);
                Console.WriteLine("Mensaje de ClaseErrorPuntual" + mAE.InnerException.Source);
                Console.WriteLine();
                Console.WriteLine("CALLSTACK de CapaApplicationException ");
                Console.WriteLine(mAE.StackTrace);
                Console.WriteLine();
                Console.WriteLine("CALLSTACK de ClaseErrorPuntual ");
                Console.WriteLine(mAE.InnerException.StackTrace);
           
                /*
                    Mensaje de CapaApplicationException: Error de Servidor Fecha: 8/30/2017 4:37:03 AM04:37:03.7841676
                    Mensaje de CapaApplicationException: Source Capa Aplicacion
                    Mensaje de ClaseErrorPuntualError conexion IP: 192.168.1.1
                    Mensaje de ClaseErrorPuntualCapa Persistencia Source

                    CALLSTACK de CapaApplicationException
                       at Ejercicio_1.CapaAplicacion.Ejecutar() 
                       at Ejercicio_1.CapaControlador.Ejecutar() 
                       at Ejercicio_1.CapaVista.Ejecutar() 

                    CALLSTACK de ClaseErrorPuntual
                       at Ejercicio_1.CapaPersistencia.Ejecutar() 
                       at Ejercicio_1.CapaDominio.Ejecutar() 
                       at Ejercicio_1.CapaAplicacion.Ejecutar() 

                 */
            }

        }

    }
}
