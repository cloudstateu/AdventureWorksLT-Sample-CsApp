using Microsoft.EntityFrameworkCore;

namespace AdventureWorksLT_Sample_CsApp
{
  public class SampleDbContext : DbContext
  {
    public SampleDbContext(DbContextOptions<SampleDbContext> contextOptions) : base(contextOptions)
    {

    }
  }
}
