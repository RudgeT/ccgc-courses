using Business.Queries.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.OpenApi.Expressions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;
using DataModel;

namespace Admin.Data
{
    public class CourseService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CourseService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<CourseDto[]> GetAllCourses()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<CourseDto[]>("/api/courses");
            return list;
        }

        public async Task<int> PostCourse(object Parameters)
        {
            string url = "/api/courses/addcourse";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.PostJsonAsync<int>(url, Parameters);
        }

        public async Task DeleteCourse(object Parameters)
        {
            string url = $"/api/courses/removecourse";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync(url, Parameters);
        }

        public async Task UpdateCourse(object Parameters)
        {
            string url = $"/api/courses/updatecourse";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync(url,Parameters);
        }

        internal async Task<Course> GetCourse(int id)
        {
            string url = $"/api/courses/{id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<Course>(url);
        }
    }
}
