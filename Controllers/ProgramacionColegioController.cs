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
    public class ProgramacionColegioController : ApiController
    {
        // GET: ProgramacionColegio
        public List<ProgramacionColegioCLS> Get()
        {
            // LLAMO A LA CAPA DE DATOS
            ProgramacionColegioDAL oProgramacionColegioDAL = new ProgramacionColegioDAL();
            return oProgramacionColegioDAL.listarProgramacionColegio();
        }

        public List<ProgramacionColegioCLS> Get(int idarbitro, int num)
        {
            if (num == 1)
            {
                // TODOS LOS JUEGOS DEL COLEGIO
                ProgramacionColegioDAL oProgramacionColegioDAL = new ProgramacionColegioDAL();
                return oProgramacionColegioDAL.listarPorColegio(idarbitro);
            }
            else
            {
                // TODOS LOS JUEGOS DEL ARBITRO
                ProgramacionColegioDAL oProgramacionColegioDAL = new ProgramacionColegioDAL();
                return oProgramacionColegioDAL.listarPorArbitro(idarbitro);
            }
              
        }

        public int Post([FromBody] ProgramacionColegioCLS oProgramacionColegioCLS)
        {
            ProgramacionColegioDAL oProgramacionColegioDAL = new ProgramacionColegioDAL();
            return oProgramacionColegioDAL.guardarCedula(oProgramacionColegioCLS);
        }
    }
}