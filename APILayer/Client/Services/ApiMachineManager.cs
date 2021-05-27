using APILayer.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APILayer.Client.Services
{
    public class ApiMachineManager : IMachineManager
    {
        private readonly HttpClient httpClient;

        public ApiMachineManager(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<List<Machine>> GetAllMachines()
        {
            string baseUrl = "machiens";
            var result = await httpClient.GetAsync(baseUrl);
            result.EnsureSuccessStatusCode();
            var response = await result.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<MachineResponse>(response);
            if (content.Success)
            {
                return content.Machine;

            }
            else
            {
                return new List<Machine>();
            }
        }
    }
}
