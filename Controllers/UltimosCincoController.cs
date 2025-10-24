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
    public class UltimosCincoController : ApiController
    {
        public List<UltimosCincoCLS> Get(int idtorneo)
        {
            // LLAMO A LA CAPA DE DATOS
            UltimosCincoDAL oUltimosCincoDAL = new UltimosCincoDAL();
            return oUltimosCincoDAL.ultimoscinco(idtorneo);
        }
    }
}