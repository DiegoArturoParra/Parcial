using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace Parcial.Datos.DAO
{
    public static class CRUD
    {
        #region Metodo Insertar

        public static void Insert(Object entidad)
        {

            Mapeo db = new Mapeo();
            try
            {
                db.Entry(entidad).State = EntityState.Added;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodo Actualizar Async

        public static async Task Update(Object entidad)
        {

            Mapeo db = new Mapeo();
            db.Entry(entidad).State = EntityState.Modified;
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException ex) // catch DbUpdateException
            {
                throw ex;
            }
        }
        #endregion

        #region Metodo Delete

        public static void Delete(Object entidad)
        {
            Mapeo db = new Mapeo();
            try
            {
                db.Entry(entidad).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
