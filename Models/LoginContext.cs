#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace LoginRegAssignment.Models;
public class LoginContext : DbContext 
{ 
    public LoginContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; } 
}