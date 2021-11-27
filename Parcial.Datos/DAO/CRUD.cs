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

            using (var _db = new Mapeo())
            {
                try
                {
                    _db.Entry(entidad).State = EntityState.Added;
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
        #endregion

        #region Metodo Actualizar Async

        public static void Update(Object entidad)
        {

            using (var _db = new Mapeo())
            {
                _db.Entry(entidad).State = EntityState.Modified;
                try
                {
                    _db.SaveChanges();
                }
                catch (DbUpdateException ex) // catch _dbUpdateException
                {
                    throw ex;
                }
            }
        }
        #endregion

        #region Metodo Delete
        public static void Delete(Object entidad)
        {
            using (var _db = new Mapeo())
            {
                try
                {
                    _db.Entry(entidad).State = EntityState.Deleted;
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        #endregion
    }
}
