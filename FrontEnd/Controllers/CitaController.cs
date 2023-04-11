using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace FrontEnd.Controllers
{
    public class CitaController : Controller
    {
        CitaHelper citaHelper;
        // GET: CitaController
        public ActionResult Index()
        {
            string token = HttpContext.Session.GetString("token");

            citaHelper = new CitaHelper();
            List<CitaViewModel> lista = citaHelper.GetAll();
            return View(lista);
        }

        // GET: CitaController/Details/5
        public ActionResult Details(int id)
        {
            citaHelper = new CitaHelper();
            CitaViewModel cita = citaHelper.Get(id);
            return View(cita);
        }

        // GET: CitaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CitaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CitaViewModel cita)
        {
            try
            {
                citaHelper = new CitaHelper();
                cita = citaHelper.Create(cita);

                return RedirectToAction("Details", new { id = cita.IdCitas});
            }
            catch
            {
                return View();
            }
        }

        // GET: CitaController/Edit/5
        public ActionResult Edit(int id)
        {
            citaHelper = new CitaHelper();
            CitaViewModel cita = citaHelper.Get(id);

            return View();
        }

        // POST: CitaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CitaViewModel cita)
        {
            try
            {
                CitaHelper citaHelper = new CitaHelper();
                cita = citaHelper.Edit(cita);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CitaController/Delete/5
        public ActionResult Delete(int id)
        {
            citaHelper = new CitaHelper();
            CitaViewModel cita = citaHelper.Get(id);
            return View();
        }


        // POST: CitaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(CitaViewModel cita)
        {
            try
            {
                citaHelper = new CitaHelper();
                citaHelper.Delete(cita.IdCitas);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
