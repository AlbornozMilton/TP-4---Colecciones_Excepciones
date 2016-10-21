using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class CapaPersistencia
    {
        private DateTime iFechayHora;
        public CapaPersistencia()
        {
            this.iFechayHora = DateTime.Now;
            throw new ErrorPuntualException();
            
        }
        public void Ejecutar()
        {

        }
    }
}
