namespace BengiSuDagitim.DBConnection.MyModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BengiSuDagitimModel : DbContext
    {
        
        public BengiSuDagitimModel()
            : base("name=BengiSuDagitimModel")
        {
        }

        public virtual DbSet<Product> Product { get; set; }

    }

    
}