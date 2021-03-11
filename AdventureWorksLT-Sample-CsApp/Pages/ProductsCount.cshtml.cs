using AdventureWorksLT_Sample_CsApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace AdventureWorksLT_Sample_CsApp.Pages
{
  public class PrivacyModel : PageModel
  {
    private readonly ILogger<PrivacyModel> _logger;
    private readonly SampleDatabaseContext _dbContext;

    public PrivacyModel(ILogger<PrivacyModel> logger, SampleDatabaseContext dbContext)
    {
      _logger = logger;
      _dbContext = dbContext;
    }

    public void OnGet()
    {
      var count = _dbContext.Products
        .Where(_ => _.SellEndDate == null)
        .Count();

      ViewData["count"] = count;
    }
  }
}
