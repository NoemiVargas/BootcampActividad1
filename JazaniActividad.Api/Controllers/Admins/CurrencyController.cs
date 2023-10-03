using Microsoft.AspNetCore.Mvc;
using JazaniActividad.Domain.Admins.Models;
using JazaniActividad.Domain.Admins.Repositories;
using JazaniActividad.Application.Admins.Services;
using JazaniActividad.Application.Admins.Dtos.Currencies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JazaniActividad.Api.Controllers.Admins
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : Controller
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrencyService _currencyService;


        public CurrencyController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }



        // GET: api/<CurrencyController>
        [HttpGet]
        public async Task<IEnumerable<CurrencyDto>> Get()
        {
            return await _currencyService.FindAllAsync();
        }

        // GET api/<CurrencyController>/5
        [HttpGet("{id}")]
        public async Task<CurrencyDto> Get(int id)
        {
            return await _currencyService.FindByIdAsync(id);
        }

        // POST api/<CurrencyController>
        [HttpPost]
        public async Task<CurrencyDto> Post([FromBody] CurrencySaveDto currencySaveDto)
        {
            return await _currencyService.CreateAsync(currencySaveDto);
        }

        // PUT api/<CurrencyController>/5
        [HttpPut("{id}")]
        public async Task<CurrencyDto> Put(int id, [FromBody] CurrencySaveDto currencySaveDto)
        {
            return await _currencyService.EditAsync(id, currencySaveDto);
        }

        // DELETE api/<CurrencyController>/5
        [HttpDelete("{id}")]
        public async Task<CurrencyDto> Delete(int id)
        {
            return await _currencyService.DisabledAsync(id);
        }
    }
}
