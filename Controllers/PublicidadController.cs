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
    public class PublicidadController : ApiController
    {
        public List<PublicidadCLS> Get(int idtorneo)
        {
            // LLAMO A LA CAPA DE DATOS
            PublicidadDAL oPublicidadDAL = new PublicidadDAL();
            return oPublicidadDAL.listarPublicidad(idtorneo);
        }
    }
}
