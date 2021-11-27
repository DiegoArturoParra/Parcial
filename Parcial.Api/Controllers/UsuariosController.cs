using Parcial.Logica.Negocio;
using Parcial.Utilitarios.Response;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Parcial.Controllers
{
    [RoutePrefix("api/usuarios")]
    public class UsuariosController : ApiController
    {
        // GET: api/Usuarios
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Usuarios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuarios
        [HttpPost]
        [Route("crear")]
        public IHttpActionResult Post(UsuarioDTO usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Modelo invalido.");
            }
            try
            {
                var respuesta = new LUsuario().CrearUsuario(usuario);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)
        {
        }
    }
}
