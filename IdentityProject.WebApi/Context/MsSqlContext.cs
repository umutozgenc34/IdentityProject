using IdentityProject.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.WebApi.Context;

public class MsSqlContext : DbContext
{
    public MsSqlContext(DbContextOptions opt) : base(opt)
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Docker kurulu olanlar
        //optionsBuilder.UseSqlServer("Server= localhost,1433;Database = Identity_db; User=sa; Password=admin123456789");

        //Local Db

        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database = Identity_db; Trusted_Connection = true");

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
}
