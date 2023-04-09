using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class UsuarioHelper
    {
        private ServiceRepository ServiceRepository;


        public UsuarioHelper()
        {
            ServiceRepository = new ServiceRepository();

        }



        public List<UsuarioViewModel> GetAll()
        {
            List<UsuarioViewModel> lista = new List<UsuarioViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/usuario");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<UsuarioViewModel>>(content);
            }

            return lista;

        }




        public UsuarioViewModel Get(int id)
        {
            UsuarioViewModel UsuarioViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/usuario/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            UsuarioViewModel = JsonConvert.DeserializeObject<UsuarioViewModel>(content);



            return UsuarioViewModel;
        }


        public UsuarioViewModel Create(UsuarioViewModel usuario)
        {


            UsuarioViewModel UsuarioViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/usuario/", usuario);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            UsuarioViewModel = JsonConvert.DeserializeObject<UsuarioViewModel>(content);



            return UsuarioViewModel;
        }
    }
}
