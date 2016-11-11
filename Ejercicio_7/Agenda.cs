using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Agenda : IAgenda
    {
        public void AgregarCalendario(Calendario pCalendario)
        {
            throw new NotImplementedException();
        }

        public void AgregarEvento(Evento pEvento)
        {
            throw new NotImplementedException();
        }

        public void EliminarCalendario(string pCodigoCalendario)
        {
            throw new NotImplementedException();
        }

        public void EliminarEvento(string pCodigoEvento)
        {
            throw new NotImplementedException();
        }

        public void ModificarCalendario(Calendario pCalendario)
        {
            throw new NotImplementedException();
        }

        public void ModificarEvento(Evento pEvento)
        {
            throw new NotImplementedException();
        }

        public Calendario ObtenerCalendarioPorCodigo(Evento pEvento)
        {
            throw new NotImplementedException();
        }

        public IList<Calendario> ObtenerCalendariosOrdenadoPor(IComparer<Calendario> pComparadorCalendario)
        {
            throw new NotImplementedException();
        }

        public Evento ObtenerEventoPorCodigo(Evento pEvento)
        {
            throw new NotImplementedException();
        }

        public IList<Evento> ObtenerEventosOrdenadoPor(IComparer<Evento> pComparadorEvento)
        {
            throw new NotImplementedException();
        }

        public IList<Calendario> ObtenerTodosCalendarios()
        {
            throw new NotImplementedException();
        }

        public IList<Evento> ObtenerTodosEventos()
        {
            throw new NotImplementedException();
        }
    }
}
