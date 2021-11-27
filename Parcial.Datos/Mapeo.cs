using Parcial.Utilitarios.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Datos
{
    public class Mapeo : DbContext
    {
        static Mapeo()
        {
            Database.SetInitializer<Mapeo>(null);
        }
        public Mapeo()
            : base("name=Conexion") { }
        #region Dbset Tablas Mapeo
        public DbSet<Usuario> TablaUsuarios { get; set; }
        #endregion
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema("public");
            base.OnModelCreating(builder);
        }
    }
}
