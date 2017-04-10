namespace Cinema_Seat_Reservation.DatabaseConnection
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }


        public virtual DbSet<Person> Person { get; set; }

        public virtual DbSet<Ticket> Ticket { get; set; }
    }
}
