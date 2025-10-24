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
    public class ComentarioController : ApiController
    {
        public int Get(int idjuego)
        {
            ComentarioDAL oComentarioDAL = new ComentarioDAL();
            return oComentarioDAL.vecesComentario(idjuego);
        }

        public List<ComentarioCLS> Get(int idjuego, int num)
        {
            ComentarioDAL oComentarioDAL = new ComentarioDAL();
            return oComentarioDAL.listarComentario(idjuego, num);
        }

        public int Post([FromBody] ComentarioCLS oComentarioCLS)
        {
            ComentarioDAL oComentarioDAL = new ComentarioDAL();
            return oComentarioDAL.guardarComentario(oComentarioCLS);
        }
    }
}
