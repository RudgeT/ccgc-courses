using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Data
{
    public class CourseService : IDataService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CourseService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        
        public async Task<Course[]> GetCourses()
        {
            using var httpClient = _clientFactory.CreateClient("api");
            var list = await httpClient.GetJsonAsync<Course[]>("/api/courses");
            return list;
        }
        public async Task<Course> GetCourseById(int Id)
        {
            string url = $"/api/courses/{Id}";
            using var httpClient = _clientFactory.CreateClient("api");
            return await httpClient.GetJsonAsync<Course>(url);
        }
    }
}
