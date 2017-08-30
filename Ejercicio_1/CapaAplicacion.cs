using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class CapaAplicacion
    {
        public void Ejecutar()
        {
            try
            {
                CapaDominio mCDomininio = new CapaDominio(); //se instancia la capa N+1 = 4 "Capa Dominio"
                mCDomininio.Ejecutar(); //metodo de la capa dominio
            }

            //se atrapa la excepcion E lanzada desde la capa persistencia 
            //y se crea una nueva excepcion con propiedades a nuestro gusto para ocultar informacion
            //dichas propiedades se especifican en nuestra clase CapaApplicationException 
            catch(ErrorPuntualException E)
            {
                throw new CapaAplicationException(E);
            }
            
        }
    }
}
