using ConcertBooking.Domain;

namespace ConcertBooking.Application.Services;

public interface IEventTypeService {
	Task<EventType> AddEventType(CreateEventType eventType);
}