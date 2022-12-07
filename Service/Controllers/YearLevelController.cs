using System.Collections.Generic;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Commands.YearLevels;
using Business.Queries.YearLevels;
using Business.Queries.Dtos;
using System.Threading;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/yearlevels")]
    public class YearLevelController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public YearLevelController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<YearLevelDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllYearLevelsQueryHandler, List<YearLevelDto>>();
            return Ok(results);
        }

        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(YearLevelDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetYearLevelById([FromRoute] GetYearLevelByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("addyearlevel")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddYearLevel([FromBody] AddYearLevelCommand query)

        {
            var results =
            await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("removeyearlevel")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> RemoveYearLevel([FromBody] RemoveYearLevelByIdCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

        [HttpPost, Route("updateyearlevel")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateYearLevel([FromBody] UpdateYearLevelCommandHandler command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

    }
}