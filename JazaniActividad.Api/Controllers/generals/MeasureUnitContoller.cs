using JazaniActividad.Application.Generals.Dtos.Invesments;
using JazaniActividad.Application.Generals.Dtos.MeasuredUnit;
using JazaniActividad.Application.Generals.Services;
using JazaniActividad.Application.Generals.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JazaniActividad.Api.Controllers.generals
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasureUnitContoller : ControllerBase
    {
        private readonly IMeasureUnitService _measureUnitService;

        public MeasureUnitContoller(IMeasureUnitService measureUnitService)
        {
            _measureUnitService = measureUnitService;
        }


        // GET: api/<MeasureUnitContoller>
        [HttpGet]
        public async Task<IEnumerable<MeasuredUnitDto>> Get()
        {
            return await _measureUnitService.FindAllAsync();
        }

        // GET api/<MeasureUnitContoller>/5
        [HttpGet("{id}")]
        public async Task<MeasuredUnitDto> Get(int id)
        {
            return await _measureUnitService.FindByIdAsync(id);
        }

        // POST api/<MeasureUnitContoller>
        [HttpPost]
        public async Task<MeasuredUnitDto> Post([FromBody] MeasuredUnitSaveDto saveDto)
        {
            return await _measureUnitService.CreateAsync(saveDto);
        }

        // PUT api/<MeasureUnitContoller>/5
        [HttpPut("{id}")]
        public async Task<MeasuredUnitDto> Put(int id, [FromBody] MeasuredUnitSaveDto saveDto)
        {
            return await _measureUnitService.EditAsync(id, saveDto);
        }

        // DELETE api/<MeasureUnitContoller>/5
        [HttpDelete("{id}")]
        public async Task<MeasuredUnitDto> Delete(int id)
        {
            return await _measureUnitService.DisabledAsync(id);
        }
    }
}
