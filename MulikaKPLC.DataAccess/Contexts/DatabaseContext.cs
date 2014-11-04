using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MulikaKPLC.DataLayer.Models;

namespace MulikaKPLC.DataAccess.Contexts
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {

        }
        public static DatabaseContext Create()
        {
            return new DatabaseContext();
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<GalileoClient> GalileoClients { get; set; }
        public virtual DbSet<PowerReading> PowerReadings { get; set; }
        public virtual DbSet<WaterFlowReading> WaterFlowReadings { get; set; }
    }
}
