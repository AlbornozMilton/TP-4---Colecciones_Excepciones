using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Repositorio :IRepositoriosUsuarios ,IComparer<Usuario>
    {
        IDictionary<String, Usuario> iRepoUsuarios = new SortedDictionary<String, Usuario>(); 

        public Repositorio()
        {
           
        }

        ////METODO DE INTERFACE ICOMPARER----------
        //public int Compare(Usuario pUsuario1, Usuario pUsuario2)
        //{
        //    return pUsuario1.CompareTo(pUsuario2);
        //}

        public void AgregarUsuario(Usuario pUsuario)
        {
            if (!this.iRepoUsuarios.ContainsKey(pUsuario.Codigo))
            {
                this.iRepoUsuarios.Add(pUsuario.Codigo, pUsuario);
            }
            else throw new Exception("Usuario Existente");
        }

        public void Actualizar(Usuario pUsuario)
        {
            if (iRepoUsuarios.ContainsKey(pUsuario.Codigo))
            {
                this.iRepoUsuarios.Add(pUsuario.Codigo, pUsuario);
            }
            else throw new Exception("Usuario Inexistente");
        }

        public void Eliminar(string pCodigo)
        {
            if (this.iRepoUsuarios.ContainsKey(pCodigo))
            {
                this.iRepoUsuarios.Remove(pCodigo);
            }
            else throw new Exception("Usuario Inexistente");
        }

        public IList<Usuario> ObtenerTodos()
        {
            IList<Usuario> mListaUsuarios = new List<Usuario>();
            IEnumerator<KeyValuePair<string,Usuario>> mEnumerador = this.iRepoUsuarios.GetEnumerator();

            while (mEnumerador.MoveNext())
            {
                mListaUsuarios.Add(mEnumerador.Current.Value);
            }

            return mListaUsuarios; //?????          
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            if (this.iRepoUsuarios.ContainsKey(pCodigo)) //necesario???
            {
                return this.iRepoUsuarios[pCodigo];
            }
            else return null; 
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            //IList<Usuario> mListaUsuarios = this.ObtenerTodos();
            ////METODO DE INTERFACE ICOMPARER----------
            // pComparador.Compare(mListaUsuarios.c, Usuario pUsuario2)
            //  {
            //     return pUsuario1.CompareTo(pUsuario2);
            //  }

            return null;
        }

    }
}
