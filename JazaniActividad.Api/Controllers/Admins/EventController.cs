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
    public class EventController : Controller
    {
        private readonly IEventRepository _eventRepository;
        private readonly IEventService _eventService;


        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }



        // GET: api/<EventController>
        [HttpGet]
        public async Task<IEnumerable<EventDto>> Get()
        {
            return await _eventService.FindAllAsync();
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public async Task<EventDto> Get(int id)
        {
            return await _eventService.FindByIdAsync(id);
        }

        // POST api/<EventController>
        [HttpPost]
        public async Task<EventDto> Post([FromBody] EventSaveDto eventSaveDto)
        {
            return await _eventService.CreateAsync(eventSaveDto);
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public async Task<EventDto> Put(int id, [FromBody] EventSaveDto eventSaveDto)
        {
            return await _eventService.EditAsync(id, eventSaveDto);
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public async Task<EventDto> Delete(int id)
        {
            return await _eventService.DisabledAsync(id);
        }
    }
}
