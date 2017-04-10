namespace WebApplicationForm_Library.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryModel : DbContext
    {
        // Your context has been configured to use a 'LibraryModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WebApplicationForm_Library.Models.LibraryModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LibraryModel' 
        // connection string in the application configuration file.
        public LibraryModel()
            : base("name=LibraryModel")
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<RentedBook> RentedBook { get; set; }

    }

    
}