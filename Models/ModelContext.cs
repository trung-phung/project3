using System;
using System.Data.Entity;
using System.Linq;

namespace Project3.Models
{
    public class ModelContext : DbContext
    {
        // Your context has been configured to use a 'ModelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Project3.Models.ModelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelContext' 
        // connection string in the application configuration file.
        public ModelContext()
            : base("name=DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Project3.Models.Entity.Branch> Branches { get; set; }

        public System.Data.Entity.DbSet<Project3.Models.Entity.Lap> Laps { get; set; }

        public System.Data.Entity.DbSet<Project3.Models.Entity.Device> Devices { get; set; }

        public System.Data.Entity.DbSet<Project3.Models.Entity.Complaint> Complaints { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}