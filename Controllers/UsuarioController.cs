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
    public class UsuarioController : ApiController
    {
        public UsuarioCLS Get(string usuario, string contra)
        {
            UsuarioDAL oUsuarioDAL = new UsuarioDAL();
            return oUsuarioDAL.login(usuario, contra);
        }

        public UsuarioCLS Get(string usuario, string contra, int num)
        {
            UsuarioDAL oUsuarioDAL = new UsuarioDAL();
            return oUsuarioDAL.login2(usuario, contra, num);
        }

        public int Get(string usuario)
        {
            UsuarioDAL oUsuarioDAL = new UsuarioDAL();
            return oUsuarioDAL.ValidarSiEstaUsuario(usuario);
        }

        public int Get(int id)
        {
            UsuarioDAL oUsuarioDAL = new UsuarioDAL();
            return oUsuarioDAL.SumarVisitasCelular(id);
        }

        // GET api/values
        public List<UsuarioCLS> Get()
        {
            UsuarioDAL oUsuarioDAL = new UsuarioDAL();
            return oUsuarioDAL.listarVisitas();
        }

        public int Post([FromBody] UsuarioCLS oUsuarioCLS)
        {
            UsuarioDAL oPersonaDAL = new UsuarioDAL();
            return oPersonaDAL.GuardarUsuario(oUsuarioCLS);
        }
    }
}
