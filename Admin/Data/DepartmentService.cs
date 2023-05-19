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
    public class DepartmentService
    {
        private readonly IHttpClientFactory _clientFactory;

        public DepartmentService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<Department[]> GetAllDepartments()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<Department[]>("/api/departments");
            return list;
        }

        public async Task<int> PostDepartment(object Parameters)
        {
            var data = new Department();

            string url = $"/api/Departments/adddepartment";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.PostJsonAsync<int>(url, Parameters);
        }

        public async Task DeleteDepartment(object Parameters)
        {
            string url = $"/api/Departments/removedepartment";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync(url, Parameters);
        }

        public async Task UpdateDepartment(object Parameters)
        {
            string url = $"/api/Departments/updatedepartment";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync(url, Parameters);
        }

        internal async Task<Department> GetDepartment(int id)
        {
            string url = $"/api/departments/{id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<Department>(url);
        }
    }
}
