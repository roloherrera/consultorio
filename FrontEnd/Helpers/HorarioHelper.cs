using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class HorarioHelper
    {
        private ServiceRepository ServiceRepository;


        public HorarioHelper()
        {
            ServiceRepository = new ServiceRepository();

        }

        public HorarioHelper(string token)
        {
            ServiceRepository = new ServiceRepository(token);

        }


        public List<HorarioViewModel> GetAll()
        {
            List<HorarioViewModel> lista = new List<HorarioViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/horario");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<HorarioViewModel>>(content);
            }

            return lista;

        }




        public HorarioViewModel Get(int id)
        {
            HorarioViewModel HorarioViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/horario/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            HorarioViewModel = JsonConvert.DeserializeObject<HorarioViewModel>(content);



            return HorarioViewModel;
        }


        public HorarioViewModel Create(HorarioViewModel horario)
        {


            HorarioViewModel HorarioViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/horario/", horario);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            HorarioViewModel = JsonConvert.DeserializeObject<HorarioViewModel>(content);



            return HorarioViewModel;
        }
        public HorarioViewModel Edit(HorarioViewModel horario)
        {


            HorarioViewModel Horario;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/horario/", horario);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Horario = JsonConvert.DeserializeObject<HorarioViewModel>(content);



            return Horario;
        }



        public HorarioViewModel Delete(int id)
        {


            HorarioViewModel Horario;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/horario/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Horario = JsonConvert.DeserializeObject<HorarioViewModel>(content);



            return Horario;
        }
    }
}
