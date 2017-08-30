using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class CapaControlador
    {
        public void Ejecutar()
        {
            CapaAplicacion mCApp = new CapaAplicacion();//se instancia la capa N+1 = 3 "Capa Aplicacion"
            mCApp.Ejecutar(); //metodo de la capa aplicacion
        }
    }
}
