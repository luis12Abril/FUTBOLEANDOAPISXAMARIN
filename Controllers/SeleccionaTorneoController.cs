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
    public class SeleccionaTorneoController : ApiController
    {
        public SeleccionaTorneoCLS Get(int idtorneo)
        {
            // LLAMO A LA CAPA DE DATOS
            SeleccionaTorneoDAL oSeleccionaTorneoDAL = new SeleccionaTorneoDAL();
            return oSeleccionaTorneoDAL.listarSeleccionaTorneo(idtorneo);
        }
    }
}
