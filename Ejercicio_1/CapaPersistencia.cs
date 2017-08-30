using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class CapaPersistencia
    {
        //se lanza la expecion creada por nosotros de nuestra clase ErrorPuntualException
        public void Ejecutar()
        {
            throw new ErrorPuntualException();
        }
    }
}
