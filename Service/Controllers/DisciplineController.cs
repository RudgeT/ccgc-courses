using System.Collections.Generic;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Commands.Disciplines;
using Business.Queries.Disciplines;
using Business.Queries.Dtos;
using System.Threading;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/disciplines")]
    public class DisciplineController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public DisciplineController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<DisciplineDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllDisciplinesQueryHandler, List<DisciplineDto>>();
            return Ok(results);
        }

        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(DisciplineDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDisciplineById([FromRoute] GetDisciplineByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("adddiscipline")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddDiscipline([FromBody] AddDisciplineCommand query)

        {
            var results =
            await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("removediscipline")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> RemoveDiscipline([FromBody] RemoveDisciplineByIdCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

        [HttpPost, Route("updatediscipline")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateDiscipline([FromBody] UpdateDisciplineCommandHandler command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

    }
}