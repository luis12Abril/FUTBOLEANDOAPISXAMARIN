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
    public class MunicipioController : ApiController
    {
        public List<MunicipioCLS> Get(int idestado)
        {
            // LLAMO A LA CAPA DE DATOS
            MunicipioDAL oMunicipioDAL = new MunicipioDAL();
            return oMunicipioDAL.listarMunicipio(idestado);
        }
    }
}
