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
    public class ArbitroColegioController : ApiController
    {
        // GET: ArbitroColegio
        public List<ArbitroColegioCLS> Get(int id, int num)
        {
            if (num == 1)
            {
                ArbitroColegioDAL oArbitroColegioDAL= new ArbitroColegioDAL();
                return oArbitroColegioDAL.listarPorColegio(id);
            }else 
            {
                ArbitroColegioDAL oArbitroColegioDAL = new ArbitroColegioDAL();
                // AQUI ES EL ID DEL ARBITRO
                return oArbitroColegioDAL.listarPorArbitro(id);
            }
           
        }
    }
}