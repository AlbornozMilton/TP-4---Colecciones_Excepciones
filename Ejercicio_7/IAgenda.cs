using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    public interface IAgenda
    {
        void AgregarEvento(Evento pEvento);
        void AgregarCalendario(Calendario pCalendario);
        void ModificarEvento(Evento pEvento);
        void ModificarCalendario(Calendario pCalendario);
        void EliminarEvento(string pCodigoEvento);
        void EliminarCalendario(string pCodigoCalendario);
        IList<Evento> ObtenerTodosEventos();
        IList<Calendario> ObtenerTodosCalendarios();
        Evento ObtenerEventoPorCodigo(Evento pEvento);
        Calendario ObtenerCalendarioPorCodigo(Evento pEvento);
        IList<Evento> ObtenerEventosOrdenadoPor(IComparer<Evento> pComparadorEvento);
        IList<Calendario> ObtenerCalendariosOrdenadoPor(IComparer<Calendario> pComparadorCalendario);
    }
}
