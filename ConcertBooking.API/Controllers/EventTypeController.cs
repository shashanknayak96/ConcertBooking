using AutoMapper;
using ConcertBooking.Application.Models;
using ConcertBooking.Application.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class EventType : ControllerBase {
	private readonly IEventTypeService _service;
	private readonly IMapper _mapper;

	public EventType(IEventTypeService service, IMapper mapper) {
		_service = service;
		_mapper = mapper;
	}

	[HttpGet]
	public async Task<IActionResult> GetAllEventTypes() {
		var eventTypes = new List<string> { "Concert", "Party" };

		return Ok(new ApiResponse<List<string>>(true, "Event types successfully retrieved", eventTypes));
	}

	[HttpPost]
	public async Task<IActionResult> AddEventType(CreateEventType eventType) {
		await this._service.AddEventType(eventType);

		return Ok();
	}
}