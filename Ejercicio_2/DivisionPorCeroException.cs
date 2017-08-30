using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class DivisionPorCeroException:DivideByZeroException
    {
        public DivisionPorCeroException(DivideByZeroException pE) : base("El divisor no puede ser cero", pE)
        {

        }
    }
}
