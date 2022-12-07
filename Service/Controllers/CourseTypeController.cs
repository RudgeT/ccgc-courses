using System.Collections.Generic;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Commands.CourseTypes;
using Business.Queries.CourseTypes;
using Business.Queries.Dtos;
using System.Threading;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/coursetypes")]
    public class CourseTypeController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public CourseTypeController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<CourseTypeDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllCourseTypesQueryHandler, List<CourseTypeDto>>();
            return Ok(results);
        }

        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(CourseTypeDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] GetCourseTypeByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
        [HttpPost, Route("addcoursetype")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddCourseType([FromBody] AddCourseTypeCommand query)

        {
            var results =
            await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("removecoursetype")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> RemoveCourseType([FromBody] RemoveCourseTypeByIdCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

        [HttpPost, Route("updatecoursetype")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateCourseType([FromBody] UpdateCourseTypeCommandHandler command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

    }
}