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
    public class EstadoController : ApiController
    {
        public List<EstadoCLS> Get()
        {
            EstadoDAL oEstadoDAL = new EstadoDAL();
            return oEstadoDAL.listarEstado();
        }
    }
}
