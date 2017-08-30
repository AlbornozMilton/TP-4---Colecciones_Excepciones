using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    static public class Matematica
    {
        static public double Divir(int pDividendo, int pDivisor)
        {

            try
            {
                return pDividendo / pDivisor;
            }
            catch (DivideByZeroException pE)
            {

                throw new DivisionPorCeroException(pE);
            }
        }
    }
}
