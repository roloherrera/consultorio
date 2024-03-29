﻿using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class ExpedienteHelper
    {
        private ServiceRepository ServiceRepository;


        public ExpedienteHelper()
        {
            ServiceRepository = new ServiceRepository();

        }

        public ExpedienteHelper(string token)
        {
            ServiceRepository = new ServiceRepository(token);

        }



        public List<ExpedienteViewModel> GetAll()
        {
            List<ExpedienteViewModel> lista = new List<ExpedienteViewModel>();

            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/expediente");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<ExpedienteViewModel>>(content);
            }

            return lista;

        }




        public ExpedienteViewModel Get(int id)
        {
            ExpedienteViewModel ExpedienteViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/expediente/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ExpedienteViewModel = JsonConvert.DeserializeObject<ExpedienteViewModel>(content);



            return ExpedienteViewModel;
        }


        public ExpedienteViewModel Create(ExpedienteViewModel expediente)
        {


            ExpedienteViewModel ExpedienteViewModel;


            HttpResponseMessage responseMessage = ServiceRepository.PostResponse("api/expediente/", expediente);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ExpedienteViewModel = JsonConvert.DeserializeObject<ExpedienteViewModel>(content);



            return ExpedienteViewModel;
        }
        public ExpedienteViewModel Edit(ExpedienteViewModel expediente)
        {


            ExpedienteViewModel Expediente;


            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/expediente/", expediente);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Expediente = JsonConvert.DeserializeObject<ExpedienteViewModel>(content);



            return Expediente;
        }



        public ExpedienteViewModel Delete(int id)
        {


            ExpedienteViewModel Expediente;


            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/expediente/" + id.ToString());
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            Expediente = JsonConvert.DeserializeObject<ExpedienteViewModel>(content);



            return Expediente;
        }
    }
}
