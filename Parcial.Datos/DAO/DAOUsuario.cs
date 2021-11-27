using Parcial.Utilitarios.Modelos;

namespace Parcial.Datos.DAO
{
    public class DAOUsuario
    {
        private readonly Mapeo _db = new Mapeo();
        public void CrearUsuario(Usuario usuario)
        {
            CRUD.Insert(usuario);
        }

    }
}
