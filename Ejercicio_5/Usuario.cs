using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Usuario:IComparable<Usuario>
    {
        public int CompareTo(Usuario pUsuario)
        {
            if (this.iCodigo==pUsuario.iCodigo)
            {
                return this.iNombreCompleto.CompareTo(pUsuario.iNombreCompleto);
            }
            return this.iCodigo.CompareTo(pUsuario.iCodigo);
        }
        private string iCodigo { get; set; }
        private string iNombreCompleto { get; set; }
        private string iCorreoElectronico { get; set; }

    }
}
