using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Data
{
    public class DepartmentService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public DepartmentService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<Department[]> GetDepartments()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<Department[]>("/api/departments");
            return list;
        }
        public async Task<Department[]> GetDepartmentById(int Id)
        {
            string url = $"/api/departments/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<Department[]>(url);
        }
    }
}