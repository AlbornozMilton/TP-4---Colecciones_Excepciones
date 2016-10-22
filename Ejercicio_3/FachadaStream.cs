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

        public string Ruta(string pRuta)
        {
            try
            {
                this.iStreamR = new StreamReader(@pRuta);
                return this.iStreamR.ReadToEnd();
            }
            catch (ArgumentException)
            {
                throw new Exception("Ingrese alguna Ruta");
            }
            catch (FileNotFoundException)
            {
                return "Archivo Inexistente";
            }
            catch (DirectoryNotFoundException)
            {
                return "Dirección Invalida";
            }
            
            finally
            {
                if (this.iStreamR == null) this.iStreamR.Close();
                else this.iStreamR.Close();
            }
            
        }
    }
}
