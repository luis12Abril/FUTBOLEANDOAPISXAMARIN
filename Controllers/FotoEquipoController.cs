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
    public class FotoEquipoController : ApiController
    {
        public int Post([FromBody] FotoEquipoCLS oFotoEquipoCLS)
        {
            FotoEquipoDAL oFotoEquipoDAL = new FotoEquipoDAL();
            return oFotoEquipoDAL.guardarFotoEquipo(oFotoEquipoCLS);
        }
    }
}
