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
            try
            {
                this.iStreamR = new StreamReader(@pRuta);
                return this.iStreamR.ReadToEnd();
                    
            }

            catch (ArgumentNullException E)//el path es null
            {

                return "camino Nulo";
            }

            catch (ArgumentException)//el path es cadena vacia
            {
                return "camino vacio";
            }

            catch (UnauthorizedAccessException)//al querer abrir una carpeta y que liste sus elementos
            {
                //ejemplo: C:\Csharp
                return "Direccion No Autorizada";
            }

            catch (FileNotFoundException) //no se pude encontrar el archivo
            {
                return "Archivo No encontrado";
            }

            catch (DirectoryNotFoundException)//La ruta de acceso especificada no es válida, por ejemplo, está en una unidad no asignada.
            {
                return "Dirección Invalida";
            }
            
            finally
            {
                if (this.iStreamR != null) this.iStreamR.Close();
            }           
        }
    }
}
