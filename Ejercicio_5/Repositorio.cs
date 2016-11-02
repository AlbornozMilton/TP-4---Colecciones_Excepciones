using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Repositorio :IRepositoriosUsuarios
    {
        IDictionary<String, Usuario> iEvaluadoresPorCliente = new Dictionary<String, Usuario>(); //ver si es mejor Dictionary/SortedDictionary/SortedList

        public Repositorio()
        {
            //cargar intancias de usuarios <codigo,usuario>
        }


        public void AgregarUsuario(Usuario pUsuario)
        {

        }

        public void Actualizar(Usuario pUsuario)
        {

        }

        public void Eliminar(string pCodigo)
        {

        }

        public List<Usuario> ObtenerTodos()
        {
            return null;
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            return null;
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            return null;
        }
       
    }
}
