using System.Web.Mvc;

namespace Evento.Areas.Vendor.Controllers
{
    public class TestimonialsController : Controller
    {
        // GET: Vendor/Testimonials
        public ActionResult Index()
        {
            return View();
        }

        // GET: Vendor/Testimonials/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vendor/Testimonials/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vendor/Testimonials/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vendor/Testimonials/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vendor/Testimonials/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vendor/Testimonials/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vendor/Testimonials/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
