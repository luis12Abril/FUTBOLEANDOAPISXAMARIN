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
    public class TipoUsuarioController : ApiController
    {
        public List<TipoUsuarioCLS> Get()
        {
            TipoUsuarioDAL oTipoUsuarioDAL = new TipoUsuarioDAL();
            return oTipoUsuarioDAL.listarTipoUsuario();
        }
    }
}
