using BackEnd.Models;
using DAL.Implementations;
using DAL.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> logger;
        private IUsuarioDAL usuarioDAL;




        #region Convertir
        private UsuarioModel Convertir(Usuario entity)
        {
            return new UsuarioModel
            {
                IdUsuario = entity.IdUsuario,
                Nombre = entity.Nombre,
                PrimerApellido = entity.PrimerApellido,
                SegundoApellido = entity.SegundoApellido,
                Cedula = entity.Cedula,
                Telefono = entity.Telefono,
                Email = entity.Email,
                Genero = entity.Genero,
                FechaNacimiento = entity.FechaNacimiento,
                Contrasenna = entity.Contrasenna,
                IdTipoUsuarioFk = entity.IdTipoUsuarioFk,
                State = entity.State


            };
        }


        private Usuario Convertir(UsuarioModel model)
        {
            return new Usuario
            {
                IdUsuario = model.IdUsuario,
                Nombre = model.Nombre,
                PrimerApellido = model.PrimerApellido,
                SegundoApellido = model.SegundoApellido,
                Cedula = model.Cedula,
                Telefono = model.Telefono,
                Email = model.Email,
                Genero = model.Genero,
                FechaNacimiento = model.FechaNacimiento,
                Contrasenna = model.Contrasenna,
                IdTipoUsuarioFk = model.IdTipoUsuarioFk,
                State = model.State

            };
        }
        #endregion

        #region Constructor
        public UsuarioController(ILogger<UsuarioController> logger)
        {
            usuarioDAL = new UsuarioDALImpl(new Entities.CONSULTORIOContext());
            this.logger = logger;
        }
        #endregion


        #region Consultar
        // GET: api/<UsuarioController>
        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                logger.LogDebug("Ingreso a Get All Categories ");
                IEnumerable<Usuario> categories = usuarioDAL.GetAll();

                List<UsuarioModel> lista = new List<UsuarioModel>();

                foreach (var usuario in categories)
                {
                    lista.Add(Convertir(usuario)

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

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Usuario usuario;
            usuario = usuarioDAL.Get(id);



            return new JsonResult(Convertir(usuario));

        }
        #endregion

        #region Agregar
        // POST api/<UsuarioController>
        [HttpPost]
        public JsonResult Post([FromBody] UsuarioModel usuario)
        {

            Usuario entity = Convertir(usuario);
            usuarioDAL.Add(entity);
            return new JsonResult(Convertir(entity));

        }

        #endregion

        #region MOdificar
        // PUT api/<UsuarioController>/5
        [HttpPut]
        public JsonResult Put([FromBody] UsuarioModel usuario)
        {

            usuarioDAL.Update(Convertir(usuario));
            return new JsonResult(Convertir(usuario));

        }
        #endregion

        #region Eliminar
        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Usuario usuario = new Usuario { IdUsuario = id };
            usuarioDAL.Remove(usuario);

            return new JsonResult(Convertir(usuario));


        }


        #endregion
    }
}
