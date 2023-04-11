using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using NuGet.Common;

namespace FrontEnd.Controllers
{
    public class ExpedienteController : Controller
    {
        private ExpedienteHelper expedienteHelper;
        private UsuarioHelper usuarioHelper;
        

        // GET: ExpedienteController
        public ActionResult Index()
        {

            string token = HttpContext.Session.GetString("token");
            expedienteHelper = new ExpedienteHelper(token);
            List<ExpedienteViewModel> lista = expedienteHelper.GetAll();
            return View(lista);
        }

        // GET: ExpedienteController/Details/5
        public ActionResult Details(int id)
        {
            string token = HttpContext.Session.GetString("token");
            expedienteHelper = new ExpedienteHelper(token);
            ExpedienteViewModel expediente = expedienteHelper.Get(id);
            return View(expediente);
        }

        // GET: ExpedienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExpedienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ExpedienteViewModel expediente)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                expedienteHelper = new ExpedienteHelper(token);
                expediente = expedienteHelper.Create(expediente);

                return RedirectToAction("Details", new { id = expediente.IdExpediente });
            }
            catch
            {
                return View();
            }
        }

        // GET: ExpedienteController/Edit/5
        public ActionResult Edit(int id)
        {
            string token = HttpContext.Session.GetString("token");
            expedienteHelper = new ExpedienteHelper(token);
            ExpedienteViewModel expediente = expedienteHelper.Get(id);

            return View();
        }

        // POST: ExpedienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ExpedienteViewModel expediente)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                ExpedienteHelper expedienteHelper = new ExpedienteHelper(token);
                expediente = expedienteHelper.Edit(expediente);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExpedienteController/Delete/5
        public ActionResult Delete(int id)
        {
            string token = HttpContext.Session.GetString("token");
            expedienteHelper = new ExpedienteHelper(token);
            ExpedienteViewModel expediente = expedienteHelper.Get(id);
            return View();
        }


        // POST: ExpedienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ExpedienteViewModel expediente)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                expedienteHelper = new ExpedienteHelper(token);
                expedienteHelper.Delete(expediente.IdExpediente);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
