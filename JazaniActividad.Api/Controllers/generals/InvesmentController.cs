using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.Invesmenttypes;
using JazaniActividad.Application.Generals.Services;
using JazaniActividad.Application.Generals.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JazaniActividad.Api.Controllers.Generals
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvesmentController : ControllerBase
    {
        private readonly IInvesmentService _invesmentService;

        public InvesmentController(IInvesmentService invesmentService)
        {
            _invesmentService = invesmentService;

        }

        // GET: api/<InvesmentController>
        [HttpGet]
        public async Task<IEnumerable<InvesmentDto>> Get()
        {
            return await _invesmentService.FindAllAsync();
        }

        // GET api/<InvesmentController>/5
        [HttpGet("{id}")]
        public async Task<InvesmentDto> Get(int id)
        {
            return await _invesmentService.FindByIdAsync(id);
        }

        // POST api/<InvesmentController>
        [HttpPost]
        public async Task<InvesmentDto> Post([FromBody] InvesmentSaveDto saveDto)
        {
            return await _invesmentService.CreateAsync(saveDto);
        }

        // PUT api/<InvesmentController>/5
        [HttpPut("{id}")]
        public async Task<InvesmentDto> Put(int id, [FromBody] InvesmentSaveDto saveDto)
        {
            return await _invesmentService.EditAsync(id, saveDto);
        }

        // DELETE api/<InvesmentController>/5
        [HttpDelete("{id}")]
        public async Task<InvesmentDto> Delete(int id)
        {
            return await _invesmentService.DisabledAsync(id);
        }
    }
}
