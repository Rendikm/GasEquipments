using Microsoft.EntityFrameworkCore;

namespace GasEquipments.Models
{
    public class EquipmentContext : DbContext
    {
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Measurement> Measurements { get; set; }

        public EquipmentContext(DbContextOptions<EquipmentContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
