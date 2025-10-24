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
    public class LigaController : ApiController
    {
        public List<LigaCLS> Get(int idmunicipio)
        {
            // LLAMO A LA CAPA DE DATOS
            LigaDAL oLigaDAL = new LigaDAL();
            return oLigaDAL.listarLiga(idmunicipio);
        }
    }
}
