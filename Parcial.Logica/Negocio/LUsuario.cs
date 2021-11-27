using Parcial.Datos.DAO;
using Parcial.Utilitarios.Modelos;
using Parcial.Utilitarios.Response;
using System;
using System.Net;

namespace Parcial.Logica.Negocio
{
    public class LUsuario
    {
        private Respuesta respuesta = new Respuesta();
        public Respuesta CrearUsuario(UsuarioDTO usuario)
        {
            try
            {
                Usuario entidad = new Usuario { Edad = usuario.Edad, Nombre = usuario.Nombre };
                new DAOUsuario().CrearUsuario(entidad);
                respuesta.Mensaje = "se creo satisfactoriamente";
                respuesta.StatusCode = (int)HttpStatusCode.Created;
                return respuesta;
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = $"Error{ex.Message}";
                return respuesta;
            }

        }
    }
}
