using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Repositorio : IRepositoriosUsuarios 
    {
        IList< Usuario> iRepoUsuarios = new List<Usuario>();

        //constructor
        public Repositorio()
        {

        }

        

        public void AgregarUsuario(Usuario pUsuario)
        {
            if (!this.iRepoUsuarios.Contains(pUsuario))
            {
                this.iRepoUsuarios.Add(pUsuario);
            }
            else throw new Exception("Usuario Existente");
        }

        public void Actualizar(Usuario pUsuario)
        {
            if (iRepoUsuarios.Contains(pUsuario))
            {
                this.iRepoUsuarios.Add(pUsuario);
            }
            else throw new Exception("Usuario Inexistente");
        }

        public void Eliminar(string pCodigo)
        {
            if (this.iRepoUsuarios.Contains())
            {
                this.iRepoUsuarios.Remove(pCodigo);
            }
            else throw new Exception("Usuario Inexistente");
        }

        public IList<Usuario> ObtenerTodos()
        {
            IList<Usuario> mListaUsuarios = new List<Usuario>();
            IEnumerator<KeyValuePair<string, Usuario>> mEnumerador = this.iRepoUsuarios.GetEnumerator();

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
            else throw new Exception("Usuario Inexistente");
        }

        //public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        //{
        //    List<Usuario> mUsuarios = this.ObtenerTodos().ToList();

        //    mUsuarios.OrderBy<Usuario, string>(Func < Usuario, string > key, IComparer < string > Compare);

        //    return null;
        //}

    }
}
