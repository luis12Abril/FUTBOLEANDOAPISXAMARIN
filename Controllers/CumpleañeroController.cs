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
    public class CumpleañeroController : ApiController
    {
        public List<JugadorCLS> Get(int idtorneo)
        {
            // LLAMO A LA CAPA DE DATOS
            CumpleañeroDAL oCumpleañeroDAL = new CumpleañeroDAL();
            return oCumpleañeroDAL.listarCumpleañero(idtorneo);
        }
    }
}
