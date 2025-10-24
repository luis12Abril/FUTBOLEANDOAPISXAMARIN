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
    public class DondefueronlosgolesController : ApiController
    {
        public List<DondefueronlosgolesCLS> Get(int idjugador)
        {
            // LLAMO A LA CAPA DE DATOS
            DondefueronlosgolesDAL oDondefueronlosgolesDAL = new DondefueronlosgolesDAL();
            return oDondefueronlosgolesDAL.listarDondefueronlosgoles(idjugador);
        }

    }
}
