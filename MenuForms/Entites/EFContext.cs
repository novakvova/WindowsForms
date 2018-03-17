namespace MenuForms.Entites
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EFContext : DbContext
    {
        public EFContext()
            : base("name=EFContextConnection")
        {
            Database.SetInitializer<EFContext>(
                null
                //new DropCreateDatabaseAlways<EFContext>()
                );
        }
        public DbSet<User> Users { get; set; }

    }
    
}