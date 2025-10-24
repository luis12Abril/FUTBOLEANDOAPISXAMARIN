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
    public class TorneoController : ApiController
    {
        public List<TorneoCLS> Get(int idliga)
        {
            // LLAMO A LA CAPA DE DATOS
            TorneoDAL oTorneoDAL = new TorneoDAL();
            return oTorneoDAL.ListarTorneo(idliga);
        }

        public List<TorneoCLS> Get()
        {
            // LLAMO A LA CAPA DE DATOS
            TorneoDAL oTorneoDAL = new TorneoDAL();
            return oTorneoDAL.listarVisitasTorneo();
        }

        public int Get(int idtorneo, int num)
        {
            // LLAMO A LA CAPA DE DATOS
            TorneoDAL oTorneoDAL = new TorneoDAL();
            return oTorneoDAL.EstaTorneoHabilitado(idtorneo);
        }

        public int GetSumarVisitasTorneoCelular(int idtorneo)
        {
            // LLAMO A LA CAPA DE DATOS
            TorneoDAL oTorneoDAL = new TorneoDAL();
            return oTorneoDAL.SumarVisitasTorneoCelular(idtorneo);
        }
    }
}
