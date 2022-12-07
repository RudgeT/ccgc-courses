using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Data
{
    public class CourseTypeService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CourseTypeService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<CourseType[]> GetCourseTypes()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<CourseType[]>("/api/coursetypes");
            return list;
        }
        public async Task<CourseType[]> GetCourseTypeById(int Id)
        {
            string url = $"/api/coursetypes/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<CourseType[]>(url);
        }
    }
}
