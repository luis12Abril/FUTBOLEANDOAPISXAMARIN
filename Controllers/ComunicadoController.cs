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
    public class ComunicadoController : ApiController
    {
        public List<ComunicadoCLS> Get(int idtorneo)
        {
            ComunicadoDAL oComunicadoDAL = new ComunicadoDAL();
            return oComunicadoDAL.listarComunicado(idtorneo);
        }
    }
}
