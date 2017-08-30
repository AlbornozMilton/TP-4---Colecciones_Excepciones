using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_3
{
    class FachadaStream
    {
        private StreamReader iStreamR;

        public string BuscarArchivo(string pRuta)
        {
           // C:\Csharp\Buscado.txt
           // si se produce una excepcion sera atrapada por los catch del program
            try
            {
                this.iStreamR = new StreamReader(@pRuta);
                return this.iStreamR.ReadToEnd();                 
            }

            finally
            {
                if (this.iStreamR != null) this.iStreamR.Close();
            }
        }
    }
}
