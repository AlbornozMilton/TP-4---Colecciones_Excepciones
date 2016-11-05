using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    public class Usuario : IComparable<Usuario>
    {
        private string iCodigo;
        private string iNombreCompleto;
        private string iCorreoElectronico;

        public int CompareTo(Usuario pUsuario)
        {
            return this.iCodigo.CompareTo(pUsuario.iCodigo);
        }
        public override bool Equals(Usuario pUsuario)
        {
            return this.GetHashCode() == pUsuario.GetHashCode();
        }

        public override int GetHashCode()
        {
            return this.iCodigo.GetHashCode();
        }

        public string Codigo
        {
            get { return this.iCodigo; }
        }

    }
}
