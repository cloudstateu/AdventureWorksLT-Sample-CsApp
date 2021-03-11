using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using System.Net;

namespace AdventureWorksLT_Sample_CsApp.Pages
{
  public class Cat
  {
    public string Url { get; set; }
  }

  public class ExternalModel : PageModel
  {
    private readonly ILogger<ExternalModel> _logger;

    public string ImgUrl { get; set; }

    public ExternalModel(ILogger<ExternalModel> logger)
    {
      _logger = logger;
    }

    public void OnGet()
    {
      using (var wc = new WebClient())
      {
        var resp = wc.DownloadString("https://api.thecatapi.com/v1/images/search");
        var data = JsonConvert.DeserializeObject<Cat[]>(resp);

        ImgUrl = data.First().Url;
      }
    }
  }
}
