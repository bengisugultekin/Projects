namespace IZSU.Entity.Model.DatabaseConnection
{
    using System.Data.Entity;

    public class IzsuDBContext : DbContext
    {
        
        public IzsuDBContext()
            : base("name=IzsuDB")
        {
        }

       
        public virtual DbSet<Abone> Abone { get; set; }
        public virtual DbSet<AboneTuru> AboneTuru { get; set; }

        public virtual DbSet<Fatura> Fatura { get; set; }
    }

   
}