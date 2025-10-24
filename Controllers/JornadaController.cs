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
    public class JornadaController : ApiController
    {
        public List<JornadaCLS> Get(int idtorneo)
        {
            JornadaDAL oJornadaDAL = new JornadaDAL();
            return oJornadaDAL.listarJornada(idtorneo);
        }
    }
}
