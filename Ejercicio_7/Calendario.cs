using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Calendario
    {
        private string iTitulo;
        private DateTime iFechaCreacion;

        public Calendario(string pTitulo)
        {
            this.iFechaCreacion = DateTime.Now;
            this.iTitulo = pTitulo;
        }

        public string Titulo
        {
            get { return this.iTitulo; }
        }

        public DateTime FechaCreacion
        {
            get { return this.iFechaCreacion.Date; }
        }

        public TimeSpan HoraCreacion
        {
            get { return this.iFechaCreacion.TimeOfDay; }
        }
    }
}
