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
    public class HorarioController : ControllerBase
    {
        private readonly ILogger<HorarioController> logger;
        private IHorarioDAL horarioDAL;




        #region Convertir
        private HorarioModel Convertir(Horario entity)
        {
            return new HorarioModel
            {
                IdHorario = entity.IdHorario,
                IdDiaFk = entity.IdDiaFk,
                IdDoctorFk = entity.IdDoctorFk,
                HoraEntrada = entity.HoraEntrada,
                HoraSalida = entity.HoraSalida


            };
        }


        private Horario Convertir(HorarioModel model)
        {
            return new Horario
            {
                IdHorario = model.IdHorario,
                IdDiaFk = model.IdDiaFk,
                IdDoctorFk = model.IdDoctorFk,
                HoraEntrada = model.HoraEntrada,
                HoraSalida = model.HoraSalida

            };
        }
        #endregion

        #region Constructor
        public HorarioController(ILogger<HorarioController> logger)
        {
            horarioDAL = new HorarioDALImpl(new Entities.CONSULTORIOContext());
            this.logger = logger;
        }
        #endregion


        #region Consultar
        // GET: api/<HorarioController>
        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                logger.LogDebug("Ingreso a Get All Categories ");
                IEnumerable<Horario> categories = horarioDAL.GetAll();

                List<HorarioModel> lista = new List<HorarioModel>();

                foreach (var horario in categories)
                {
                    lista.Add(Convertir(horario)

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

        // GET api/<HorarioController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Horario horario;
            horario = horarioDAL.Get(id);



            return new JsonResult(Convertir(horario));

        }
        #endregion

        #region Agregar
        // POST api/<HorarioController>
        [HttpPost]
        public JsonResult Post([FromBody] HorarioModel horario)
        {

            Horario entity = Convertir(horario);
            horarioDAL.Add(entity);
            return new JsonResult(Convertir(entity));

        }

        #endregion

        #region Modificar
        // PUT api/<HorarioController>/5
        [HttpPut]
        public JsonResult Put([FromBody] HorarioModel horario)
        {

            horarioDAL.Update(Convertir(horario));
            return new JsonResult(Convertir(horario));

        }
        #endregion

        #region Eliminar
        // DELETE api/<HorarioController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Horario horario = new Horario { IdHorario = id };
            horarioDAL.Remove(horario);

            return new JsonResult(Convertir(horario));


        }


        #endregion
    }
}
