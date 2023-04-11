using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class CitaHelper
    {
        private ServiceRepository ServiceRepository;


        public CitaHelper()
        {
            ServiceRepository = new ServiceRepository();

        }
        public CitaHelper(string token)
        {
            ServiceRepository = new ServiceRepository(token);

        }



        public List<CitaViewModel> GetAll()
        {
            List<CitaViewModel> lista = new List<CitaViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/cita");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<CitaViewModel>>(content);
            }

            return lista;

        }




        public CitaViewModel Get(int id)
        {
            CitaViewModel CitaViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/cita/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            CitaViewModel = JsonConvert.DeserializeObject<CitaViewModel>(content);



            return CitaViewModel;
        }


        public CitaViewModel Create(CitaViewModel cita)
        {


            CitaViewModel CitaViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/cita/", cita);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            CitaViewModel = JsonConvert.DeserializeObject<CitaViewModel>(content);



            return CitaViewModel;
        }
        public CitaViewModel Edit(CitaViewModel cita)
        {


            CitaViewModel Cita;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/cita/", cita);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Cita = JsonConvert.DeserializeObject<CitaViewModel>(content);



            return Cita;
        }



        public CitaViewModel Delete(int id)
        {


            CitaViewModel Cita;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/cita/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Cita = JsonConvert.DeserializeObject<CitaViewModel>(content);



            return Cita;
        }
    }
}
