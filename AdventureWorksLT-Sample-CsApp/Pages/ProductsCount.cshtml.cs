using AdventureWorksLT_Sample_CsApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace AdventureWorksLT_Sample_CsApp.Pages
{
  public class ProductsCountModel : PageModel
  {
    private readonly ILogger<ProductsCountModel> _logger;
    private readonly SampleDatabaseContext _dbContext;

    public int Count { get; set; }

    public ProductsCountModel(ILogger<ProductsCountModel> logger, SampleDatabaseContext dbContext)
    {
      _logger = logger;
      _dbContext = dbContext;
    }

    public void OnGet()
    {
      Count = _dbContext.Products
        .Where(_ => _.SellEndDate == null)
        .Count();
    }
  }
}
