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
    public class GolesdelJuegoController : ApiController
    {
        public List<GolesdelJuegoCLS> Get(int idjuego, int idequipo)
        {
            GolesdelJuegoDAL oGolesdelJuegoDAL = new GolesdelJuegoDAL();
            return oGolesdelJuegoDAL.listarGolesdelJuego(idjuego, idequipo);
        }
    }
}
