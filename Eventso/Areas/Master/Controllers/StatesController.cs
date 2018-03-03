using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Evento.Areas.Master.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class StatesController : Controller
    {
        HttpClient client;
        string url = "http://192.168.1.103:80/api/Admin/States";

        public StatesController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        // GET: States
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
             if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var states = JsonConvert.DeserializeObject<List<Models.StateViewModel>>(responseData);
                
                if(states!=null)
                    return View(states);
            }
            return View();
        }

        // GET: States/Details/5
        public async Task<ActionResult> Details(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url+"/"+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var states = JsonConvert.DeserializeObject<Models.StateViewModel>(responseData);

                return View(states);
            }
            return View();
        }

        // GET: States/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: States/Create
        [HttpPost]
        public async Task<ActionResult> Create(Models.StateViewModel state)
        {
            try
            {
                HttpResponseMessage responseMessage = await client.PostAsJsonAsync(url+"/Add", state);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
            catch(Exception)
            {
                return View();
            }
        }

        // GET: States/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var states = JsonConvert.DeserializeObject<Models.StateViewModel>(responseData);

                return View(states);
            }
            return View();
        }

        // POST: States/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, Models.StateViewModel state)
        {
            try
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(url + "/Update/" + id, state);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                }

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: States/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var state = JsonConvert.DeserializeObject<Models.StateViewModel>(responseData);

                return View(state);
            }
            return View();
        }

        // POST: States/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, Models.StateViewModel state)
        {
            try
            {
                HttpResponseMessage responseMessage = await client.DeleteAsync(url + "/Drop/" + id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
