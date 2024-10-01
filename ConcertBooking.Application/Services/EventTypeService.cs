using AutoMapper;
using ConcertBooking.Application.Models;
using ConcertBooking.Domain;

namespace ConcertBooking.Application.Services;

public class EventTypeService : IEventTypeService {
	private readonly IEventTypeRepository _eventTypeRepository;
	private readonly IMapper _mapper;

	public EventTypeService(IEventTypeRepository eventTypeRepository, IMapper mapper) {
		_eventTypeRepository = eventTypeRepository;
		_mapper = mapper;
	}

	public async Task<ApiResponse<object>> AddEventType(CreateEventType eventType) {
		var eventTypeModel = _mapper.Map<EventType>(eventType);

		var existingEventType = await _eventTypeRepository.GetByNameAsync(eventType.Name);
		if (existingEventType != null) {
			return new ApiResponse<object>(false, "Eventtype already exists", null, new List<string> { "Eventtype with the same name already exists!" });
		}

		await _eventTypeRepository.AddEventTypeAsync(eventTypeModel);

		return new ApiResponse<object>(true, "Eventtype created successfully", eventType);
	}

	public async Task<ApiResponse<IEnumerable<EventType>>> GetAllEventTypes() {
		var eventTypes = await _eventTypeRepository.GetAllEventsAsync();

		return new ApiResponse<IEnumerable<EventType>>(true, data: eventTypes);
	}
}