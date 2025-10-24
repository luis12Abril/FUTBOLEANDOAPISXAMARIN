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
    public class EquipoController : ApiController
    {
        public List<EquipoCLS> Get(int idtorneo, int num)
        {
            EquipoDAL oEquipoDAL = new EquipoDAL();
            if (num == 1)
            {              
                return oEquipoDAL.listarEquipo(idtorneo, num);
            }
            if (num == 2)
            {              
                return oEquipoDAL.listarEquipoPosiciones(idtorneo, num);
            }
            if (num == 3)
            {
                return oEquipoDAL.listarEquipoPagina(idtorneo, num);
            }
            if (num == 4)
            {
                return oEquipoDAL.listarEquipoPosicionesPE(idtorneo, num);
            }
            if (num == 5)
            {
                return oEquipoDAL.listarEquipoPosicionesPE(idtorneo, num);
            }

            return oEquipoDAL.listarEquipoPosiciones(idtorneo, 2);
        }

    }
}
