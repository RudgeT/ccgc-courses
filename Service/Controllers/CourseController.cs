using System.Collections.Generic;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Commands.Courses;
using Business.Queries.Courses;
using Business.Queries.Dtos;
using System.Threading;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/courses")]
    public class CourseController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public CourseController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<CourseDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllCoursesQueryHandler, List<CourseDto>>();
            return Ok(results);
        }

        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(CourseDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] GetCourseByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
        [HttpPost, Route("addcourse")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddCourse([FromBody] AddCourseCommand query)

        {
            var results =
            await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("removecourse")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> RemoveCourse([FromBody] RemoveCourseByIdCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

        [HttpPost, Route("updatecourse")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateCourse([FromBody] UpdateCourseCommandHandler command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

    }
}