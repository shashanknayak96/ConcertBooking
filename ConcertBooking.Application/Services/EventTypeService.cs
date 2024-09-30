using AutoMapper;
using ConcertBooking.Domain;

namespace ConcertBooking.Application.Services;

public class EventTypeService : IEventTypeService {
	private readonly IEventTypeRepository _eventTypeRepository;
	private readonly IMapper _mapper;

	public EventTypeService(IEventTypeRepository eventTypeRepository, IMapper mapper) {
		_eventTypeRepository = eventTypeRepository;
		_mapper = mapper;
	}

	public async Task<EventType> AddEventType(CreateEventType eventType) {
		var eventTypeModel = _mapper.Map<EventType>(eventType);
		await _eventTypeRepository.AddEventTypeAsync(eventTypeModel);

		return eventTypeModel;
	}
}