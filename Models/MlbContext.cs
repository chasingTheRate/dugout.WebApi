using Microsoft.EntityFrameworkCore;  

namespace dugout.WebApi.Models {     
public class MlbContext : DbContext     
  {         
    public MlbContext(DbContextOptions<MlbContext> options) : base(options)         
{         
}       
    public DbSet<Team> Teams { get; set; }     
  
   } 
}