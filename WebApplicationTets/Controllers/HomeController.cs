using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationTets.Models;
namespace WebApplicationTets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index(CancellationToken cancellationToke)
        {
            await DownloadAsync( "http://www.baidu.com",100, cancellationToke);
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        static async Task DownloadAsync(string url, int n, CancellationToken cancellationToken)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                for (int i = 0; i < n; i++)
                {
                    string html = await httpclient.GetStringAsync(url, cancellationToken);
                    
                    Debug.WriteLine(html);
                }
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}