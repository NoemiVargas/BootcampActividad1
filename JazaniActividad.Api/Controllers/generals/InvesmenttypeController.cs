using JazaniActividad.Application.Generals.Dtos.Invesmenttypes;
using JazaniActividad.Application.Generals.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JazaniActividad.Api.Controllers.Generals
{

    [Route("api/[controller]")]
    [ApiController]
    public class InvesmenttypeController : ControllerBase
    {
        private readonly IInvesmenttypeService _invesmenttypeService;

        public InvesmenttypeController(IInvesmenttypeService invesmenttypeService)
        {
            _invesmenttypeService = invesmenttypeService;

        }


        // GET: api/<InvesmenttypeController>
        [HttpGet]
        public async Task<IEnumerable<InvesmenttypeDto>> Get()
        {
            return await _invesmenttypeService.FindAllAsync();
        }

        // GET api/<InvesmenttypeController>/5
        [HttpGet("{id}")]
        public async Task<InvesmenttypeDto> Get(int id)
        {
            return await _invesmenttypeService.FindByIdAsync(id);
        }

        // POST api/<InvesmenttypeController>
        [HttpPost]
        public async Task<InvesmenttypeDto> Post([FromBody] InvesmenttypeSaveDto saveDto)
        {
            return await _invesmenttypeService.CreateAsync(saveDto);
        }

        // PUT api/<InvesmenttypeController>/5
        [HttpPut("{id}")]
        public async Task<InvesmenttypeDto> Put(int id, [FromBody] InvesmenttypeSaveDto saveDto)
        {
            return await _invesmenttypeService.EditAsync(id, saveDto);
        }

        // DELETE api/<InvesmenttypeController>/5
        [HttpDelete("{id}")]
        public async Task<InvesmenttypeDto> Delete(int id)
        {
            return await _invesmenttypeService.DisabledAsync(id);
        }
    }
}
