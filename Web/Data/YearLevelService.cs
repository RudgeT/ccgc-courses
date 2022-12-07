using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Data
{
    public class YearLevelService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public YearLevelService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<YearLevel[]> GetYearLevels()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<YearLevel[]>("/api/yearlevels");
            return list;
        }
        public async Task<YearLevel[]> GetYearLevelById(int Id)
        {
            string url = $"/api/yearlevels/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<YearLevel[]>(url);
        }
    }
}
