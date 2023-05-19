using Business.Queries.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.OpenApi.Expressions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DataModel;

namespace Admin.Data
{
    public class DisciplineService
    {
        private readonly IHttpClientFactory _clientFactory;

        public DisciplineService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<Discipline[]> GetAllDisciplines()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<Discipline[]>("/api/disciplines");
            return list;
        }

        public async Task<int> PostDiscipline(object Parameters)
        {
            var data = new Discipline();

            string url = $"/api/disciplines/adddiscipline";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.PostJsonAsync<int>(url, Parameters);
        }

        public async Task DeleteDiscipline(object Parameters)
        {
            string url = $"/api/disciplines/removediscipline";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync(url, Parameters);
        }

        public async Task UpdateDiscipline(object Parameters)
        {
            string url = $"/api/disciplines/updateDiscipline";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync(url, Parameters);
        }

        internal async Task<Discipline> GetDiscipline(int id)
        {
            string url = $"/api/disciplines/{id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<Discipline>(url);

        }
    }
}
