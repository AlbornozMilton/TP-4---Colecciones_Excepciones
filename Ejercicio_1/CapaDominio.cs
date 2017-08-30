using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class CapaDominio
    {
        public void Ejecutar()
        {
            CapaPersistencia mCPersistencia = new CapaPersistencia();//se instancia la capa N+1 = 5 "Capa Persistencia"

            mCPersistencia.Ejecutar(); //metodo de la capa persistencia
        }
    }
}
