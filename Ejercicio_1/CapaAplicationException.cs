using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class CapaAplicationException : ApplicationException
    {
        //aca es donde genereamos una excepcion
        //podemos tomar decisiones a partir de las propierdades de pE, y generer nueva excepcion para luego mostrar informacion convenionte.
        //ejemplo: Si pE.Message que contiene error de conexion de una IP determinada, no mostramos error pasando la IP, sino solo "Error de Conexion"
        public CapaAplicationException(ErrorPuntualException pE) : base("Error de Servidor" + " Fecha: " + pE.FechaHora+pE.FechaHora.TimeOfDay,pE)
        {
            base.Source = "Source Capa Aplicacion";
        }
    }
}
