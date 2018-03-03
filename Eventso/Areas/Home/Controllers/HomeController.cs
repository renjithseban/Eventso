using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Evento.Areas.Home.Controllers
{
    public class HomeController : Controller
    {

        HttpClient client;
        string url = "http://192.169.1.103:52153/api/Admin/Users";

        public HomeController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET: Home/Home
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            return View();
        }
    }
}