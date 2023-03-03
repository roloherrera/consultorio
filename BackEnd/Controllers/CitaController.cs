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
    public class CitaController : ControllerBase
    {
        private readonly ILogger<CitaController> logger;
        private ICitaDAL citaDAL;




        #region Convertir
        private CitaModel Convertir(Cita entity)
        {
            return new CitaModel
            {
                IdCitas = entity.IdCitas,
                IdUsuarioFk = entity.IdUsuarioFk,
                IdDoctorFk = entity.IdDoctorFk,
                Condicion = entity.Condicion,
                Dia = entity.Dia,
                Hora = entity.Hora,
                Status = entity.Status




            };
        }


        private Cita Convertir(CitaModel model)
        {
            return new Cita
            {
                IdCitas = model.IdCitas,
                IdUsuarioFk = model.IdUsuarioFk,
                IdDoctorFk = model.IdDoctorFk,
                Condicion = model.Condicion,
                Dia = model.Dia,
                Hora = model.Hora,
                Status = model.Status


            };
        }
        #endregion

        #region Constructor
        public CitaController(ILogger<CitaController> logger)
        {
            citaDAL = new CitaDALImpl(new Entities.CONSULTORIOContext());
            this.logger = logger;
        }
        #endregion


        #region Consultar
        // GET: api/<CitaController>
        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                logger.LogDebug("Ingreso a Get All Categories ");
                IEnumerable<Cita> categories = citaDAL.GetAll();

                List<CitaModel> lista = new List<CitaModel>();

                foreach (var cita in categories)
                {
                    lista.Add(Convertir(cita)

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

        // GET api/<CitaController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Cita cita;
            cita = citaDAL.Get(id);



            return new JsonResult(Convertir(cita));

        }
        #endregion

        #region Agregar
        // POST api/<CitaController>
        [HttpPost]
        public JsonResult Post([FromBody] CitaModel cita)
        {

            Cita entity = Convertir(cita);
            citaDAL.Add(entity);
            return new JsonResult(Convertir(entity));

        }

        #endregion

        #region Modificar
        // PUT api/<CitaController>/5
        [HttpPut]
        public JsonResult Put([FromBody] CitaModel cita)
        {

            citaDAL.Update(Convertir(cita));
            return new JsonResult(Convertir(cita));

        }
        #endregion

        #region Eliminar
        // DELETE api/<CitaController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Cita cita = new Cita { IdCitas = id };
            citaDAL.Remove(cita);

            return new JsonResult(Convertir(cita));


        }


        #endregion
    }
}
