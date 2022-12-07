using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Data
{
    public class ProgramService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProgramService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<Program[]> GetPrograms()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<Program[]>("/api/programs");
            return list;
        }
        public async Task<Program[]> GetProgramById(int Id)
        {
            string url = $"/api/programs/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<Program[]>(url);
        }
    }
}
