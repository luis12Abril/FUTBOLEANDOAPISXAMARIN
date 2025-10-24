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
    public class ColegioController : ApiController
    {
        public List<ColegioCLS> Get()
        {
            // LLAMO A LA CAPA DE DATOS
            ColegioDAL oColegioDAL = new ColegioDAL();
            return oColegioDAL.listarColegio();
        }
    }
}