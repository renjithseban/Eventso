using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using BusinessEntities.Common;
using AutoMapper;
using Evento.Areas.Common.Models;

namespace Evento.Areas.Common.Controllers
{
    public class UsersController : Controller
    {
        HttpClient client;
        string url = "http://192.169.1.103:52153/api/Admin/Users";

        public UsersController()
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

                var userEntities = JsonConvert.DeserializeObject<IEnumerable<UserEntity>>(responseData);
                
                var users = Mapper.Map<IEnumerable<UserEntity>, IEnumerable<UserViewModel>>(userEntities);
                return View(users);
            }
            return View();
        }

        // GET: States/Details/5
        public async Task<ActionResult> Details(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var userEntity = JsonConvert.DeserializeObject<UserEntity>(responseData);

                
                var users = Mapper.Map<UserEntity, UserViewModel>(userEntity);
                return View(users);
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
        public async Task<ActionResult> Create(Models.UserViewModel user)
        {
            try
            {
                var userEntity = Mapper.Map<UserViewModel, UserEntity>(user);
                HttpResponseMessage responseMessage = await client.PostAsJsonAsync(url + "/Add", userEntity);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
            catch (Exception)
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

                var user = JsonConvert.DeserializeObject<Models.UserViewModel>(responseData);

                return View(user);
            }
            return View();
        }

        // POST: States/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, Models.UserViewModel user)
        {
            try
            {
                
                var userEntity = Mapper.Map<UserViewModel, UserEntity>(user);
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(url + "/Update/" + id, userEntity);
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

                var user = JsonConvert.DeserializeObject<Models.UserViewModel>(responseData);

                return View(user);
            }
            return View();
        }

        // POST: States/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, Models.UserViewModel user)
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
