using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Evento
    {
        private string iTitulo;
        private TimeSpan iFechaComienzo;
        private TimeSpan iHoraComienzo;
        private int iDuracion;
        private Frecuencia iFrecuencia;

        public Evento(string pTitulo, TimeSpan pFechaComienzo, TimeSpan pHoraComienzo, int pDuracion, Frecuencia pFrecuencia)
        {
            this.iFechaComienzo = pFechaComienzo;
            this.iTitulo = pTitulo;
            this.iHoraComienzo = pHoraComienzo;
            this.iDuracion = pDuracion;
            this.iFrecuencia = pFrecuencia;
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
