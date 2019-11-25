using Jordan.MiniBicks.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Jordan.MiniBicks.Data
{
    public class BicksContext : DbContext

    {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniBicks;");
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Absence> Absences { get; set; }
    public DbSet<AbsenceUser> AbsenceUsers { get; set; }
    public DbSet<Remboursement> Remboursements { get; set; }
    public DbSet<RemboursementUser> RemboursementUsers { get; set; }

    }
}
