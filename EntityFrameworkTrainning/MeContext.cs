using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTrainning
{
    class MeContext : DbContext
    {
        public MeContext() : base(@"Data Source=CESAR;Initial Catalog=MyTestDb;Integrated Security=True;Pooling=False")
        {
        }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Video>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }
    }
}
