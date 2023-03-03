using BackEnd.Models;
using DAL.Implementations;
using DAL.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpedienteController : ControllerBase
    {
        private readonly ILogger<ExpedienteController> logger;
        private IExpedienteDAL expedienteDAL;




        #region Convertir
        private ExpedienteModel Convertir(Expediente entity)
        {
            return new ExpedienteModel
            {
                IdExpediente = entity.IdExpediente,
                IdUsuarioFk = entity.IdUsuarioFk,
                IdDoctorFk = entity.IdDoctorFk,
                Padecimiento = entity.Padecimiento,
                Tratamiento = entity.Tratamiento


            };
        }


        private Expediente Convertir(ExpedienteModel model)
        {
            return new Expediente
            {
                IdExpediente = model.IdExpediente,
                IdUsuarioFk = model.IdUsuarioFk,
                IdDoctorFk = model.IdDoctorFk,
                Padecimiento = model.Padecimiento,
                Tratamiento = model.Tratamiento

            };
        }
        #endregion

        #region Constructor
        public ExpedienteController(ILogger<ExpedienteController> logger)
        {
            expedienteDAL = new ExpedienteDALImpl(new Entities.CONSULTORIOContext());
            this.logger = logger;
        }
        #endregion


        #region Consultar
        // GET: api/<ExpedienteController>
        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                logger.LogDebug("Ingreso a Get All Categories ");
                IEnumerable<Expediente> categories = expedienteDAL.GetAll();

                List<ExpedienteModel> lista = new List<ExpedienteModel>();

                foreach (var expediente in categories)
                {
                    lista.Add(Convertir(expediente)

                        );
                }
                return new JsonResult(lista);
            }
            catch (Exception e)
            {
                logger.LogError("");
                return new JsonResult(null);
            }


        }

        // GET api/<ExpedienteController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Expediente expediente;
            expediente = expedienteDAL.Get(id);



            return new JsonResult(Convertir(expediente));

        }
        #endregion

        #region Agregar
        // POST api/<ExpedienteController>
        [HttpPost]
        public JsonResult Post([FromBody] ExpedienteModel expediente)
        {

            Expediente entity = Convertir(expediente);
            expedienteDAL.Add(entity);
            return new JsonResult(Convertir(entity));

        }

        #endregion

        #region Modificar
        // PUT api/<ExpedienteController>/5
        [HttpPut]
        public JsonResult Put([FromBody] ExpedienteModel expediente)
        {

            expedienteDAL.Update(Convertir(expediente));
            return new JsonResult(Convertir(expediente));

        }
        #endregion

        #region Eliminar
        // DELETE api/<ExpedienteController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Expediente expediente = new Expediente { IdExpediente = id };
            expedienteDAL.Remove(expediente);

            return new JsonResult(Convertir(expediente));


        }


        #endregion
    }
}
