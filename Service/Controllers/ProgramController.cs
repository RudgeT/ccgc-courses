using System.Collections.Generic;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Commands.Programs;
using Business.Queries.Programs;
using Business.Queries.Dtos;
using System.Threading;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/programs")]
    public class ProgramController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public ProgramController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<ProgramDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllProgramsQueryHandler, List<ProgramDto>>();
            return Ok(results);
        }

        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(ProgramDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProgramById([FromRoute] GetProgramByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("addprogram")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddProgram([FromBody] AddProgramCommand query)

        {
            var results =
            await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("removeprogram")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> RemoveProgram([FromBody] RemoveProgramByIdCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

        [HttpPost, Route("updateprogram")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateProgram([FromBody] UpdateProgramCommandHandler command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

    }
}