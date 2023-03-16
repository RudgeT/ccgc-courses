using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Data
{
    public class DisciplineService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public DisciplineService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<Discipline[]> GetDisciplines()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<Discipline[]>("/api/disciplines");
            return list;
        }
        public async Task<Discipline> GetDisciplineById(int Id)
        {
            string url = $"/api/disciplines/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<Discipline>(url);
        }
    }
}