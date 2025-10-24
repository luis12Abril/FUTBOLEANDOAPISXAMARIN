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
    public class JuegosdelEquipoController : ApiController
    {
        public List<JuegosdelEquipoCLS> Get(int idtorneo, int idequipo)
        {
            JuegosdelEquipoDAL oJuegosdelEquipoDAL = new JuegosdelEquipoDAL();
            return oJuegosdelEquipoDAL.listarJuegosdelEquipo(idtorneo, idequipo);
        }

        public List<JuegosdelEquipoCLS> Get(int idtorneo)
        {
            JuegosdelEquipoDAL oJuegosdelEquipoDAL = new JuegosdelEquipoDAL();
            return oJuegosdelEquipoDAL.listarJuegosdelTorneo(idtorneo);
        }
    }
}
