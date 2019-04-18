using Microsoft.EntityFrameworkCore;  

namespace dugout.WebApi.Models {     
public class MlbContext : DbContext     
  {         
    public MlbContext(DbContextOptions<MlbContext> options) : base(options)         
{         
}       
    public DbSet<Team> Teams { get; set; }   
    public DbSet<Roster> Roster { get; set; } 
    public DbSet<MlbRosters> MlbRosters { get; set; } 

    public DbSet<Person> Person { get; set; } 


   } 
}