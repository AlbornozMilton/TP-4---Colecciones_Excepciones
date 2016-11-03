using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public class Usuario:IComparable<Usuario>
    {
        private string iCodigo; 
        private string iNombreCompleto;
        private string iCorreoElectronico; 

        public int CompareTo(Usuario pUsuario)
        {
            return this.iCodigo.CompareTo(pUsuario.iCodigo);
        }

        public string Codigo
        {
            get { return this.iCodigo; }
        }
      
    }
}
