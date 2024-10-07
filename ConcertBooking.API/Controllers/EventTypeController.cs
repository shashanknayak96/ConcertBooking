using AutoMapper;
using ConcertBooking.Application.Models;
using ConcertBooking.Application.Services;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class EventTypeController : ControllerBase {
	private readonly IEventTypeService _service;
	private readonly IMapper _mapper;
	private readonly IValidator<CreateEventType> _validator;

	public EventTypeController(IEventTypeService service, IMapper mapper, IValidator<CreateEventType> validator) {
		_service = service;
		_mapper = mapper;
		_validator = validator;
	}

	[HttpGet]
	public async Task<IActionResult> GetAllEventTypes() {
		var response = await _service.GetAllEventTypes();
		return Ok(response);
	}

	[HttpPost]
	public async Task<IActionResult> AddEventType(CreateEventType eventType) {
		var validationResult = await _validator.ValidateAsync(eventType);
		if (!validationResult.IsValid) {
			var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
			var errorResponse = new ApiResponse<object>(false, "Validation failed", null, errors);
			return BadRequest(errorResponse);
		}

		var response = await this._service.AddEventType(eventType);
		if (!response.Success) {
			return BadRequest(response);
		}

		return Ok(response);
	}
}