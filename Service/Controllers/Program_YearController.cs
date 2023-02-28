using Business.Commands.Courses;
using Business.Queries.Courses;
using Business.Queries.Dtos;
using Business.Queries.Program_Year;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/program_years")]
    public class Program_YearController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;
        public Program_YearController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _commandSender = commandSender;
            _queryProvider = queryProvider;
        }
        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<Program_YearDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllProgramYearsQueryHandler, List<Program_YearDto>>();
            return Ok(results);
        }

        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(Program_YearDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] GetProgramYearByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
            


        
    }
}



