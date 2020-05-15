using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;
        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;

        }
        public async Task Transfer(TransferDto transferDto)
        {
            //var uri = "http://localhost:5000/api/Banking";
            var uri = "https://localhost:5001/Banking";
            var transferContent = new 
                StringContent(JsonConvert.SerializeObject(transferDto), 
                Encoding.UTF8,"application/json");
            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
