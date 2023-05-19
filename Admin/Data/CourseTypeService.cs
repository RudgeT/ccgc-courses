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
    public class CourseTypeService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CourseTypeService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<CourseType[]> GetAllCourseTypes()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<CourseType[]>("/api/coursetypes");
            return list;
        }
        public async Task<CourseType> GetCourseType(int id)
        {
            string url = $"/api/coursetypes/{id}";
            using var httpClient = _clientFactory.CreateClient("api");
            var type = await httpClient.GetJsonAsync<CourseType>(url);
            return type;
        }

        public async Task<int> PostCourse(object Parameters)
        {
            var data = new CourseType();

            string url = $"/api/courses/addcoursetype";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.PostJsonAsync<int>(url, Parameters);
        }

        public async Task DeleteCourse(object Parameters)
        {
            string url = $"/api/courses/removecoursetype";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync(url, Parameters);
        }

        public async Task UpdateCourse(object Parameters)
        {
            string url = $"/api/courses/updatecoursetype";
            using var httpClient = _clientFactory.CreateClient("api");
            await httpClient.PostJsonAsync(url, Parameters);
        }
    }
}
