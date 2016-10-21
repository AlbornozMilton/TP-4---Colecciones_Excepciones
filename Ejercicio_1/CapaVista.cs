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
                CapaControlador mCControlador = new CapaControlador();
                mCControlador.Ejecutar();
            }

            catch (CapaAplicationException mAE)
            {
                Console.WriteLine(mAE.Message);
            }
            
        }

    }
}
