using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using CapaDatosDAL;
using CapaEntidadCLS;

namespace WebApiFutboleando.Controllers
{
    public class JugadoresPorAñoController : ApiController
    {
        public List<JugadoresPorAñoCLS> Get(int idtorneo, int num)
        {
            // LLAMO A LA CAPA DE DATOS
            JugadoresPorAñoDAL oJugadoresPorAñoDAL = new JugadoresPorAñoDAL();
            if (num == 1)
            {
                // AQUI ES TODO EL TORNEO SELECCIONADO
                return oJugadoresPorAñoDAL.listarJugadoresPorAño(idtorneo);
            }
            if (num == 2)
            {
                // AQUI ES EL TORNEO Y EQUIPO SELECCIONADO
                return oJugadoresPorAñoDAL.listarJugadoresPorAñoEquipo(idtorneo);
            }
            return oJugadoresPorAñoDAL.listarJugadoresPorAño(idtorneo);
        }
       
    }
}
