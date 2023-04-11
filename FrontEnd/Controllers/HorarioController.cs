using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class HorarioController : Controller
    {
        HorarioHelper horarioHelper;
        // GET: HorarioController
        public ActionResult Index()
        {
            string token = HttpContext.Session.GetString("token");

            horarioHelper = new HorarioHelper();
            List<HorarioViewModel> lista = horarioHelper.GetAll();
            return View(lista);
        }

        // GET: HorarioController/Details/5
        public ActionResult Details(int id)
        {
            horarioHelper = new HorarioHelper();
            HorarioViewModel horario = horarioHelper.Get(id);
            return View(horario);
        }

        // GET: HorarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HorarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HorarioViewModel horario)
        {
            try
            {
                horarioHelper = new HorarioHelper();
                horario = horarioHelper.Create(horario);

                return RedirectToAction("Details", new { id = horario.IdHorario });
            }
            catch
            {
                return View();
            }
        }

        // GET: HorarioController/Edit/5
        public ActionResult Edit(int id)
        {
            horarioHelper = new HorarioHelper();
            HorarioViewModel horario = horarioHelper.Get(id);

            return View();
        }

        // POST: HorarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HorarioViewModel horario)
        {
            try
            {
                HorarioHelper horarioHelper = new HorarioHelper();
                horario = horarioHelper.Edit(horario);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HorarioController/Delete/5
        public ActionResult Delete(int id)
        {
            horarioHelper = new HorarioHelper();
            HorarioViewModel horario = horarioHelper.Get(id);
            return View();
        }


        // POST: HorarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(HorarioViewModel horario)
        {
            try
            {
                horarioHelper = new HorarioHelper();
                horarioHelper.Delete(horario.IdHorario);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
