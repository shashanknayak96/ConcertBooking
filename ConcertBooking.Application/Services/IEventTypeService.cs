using ConcertBooking.Application.Models;
using ConcertBooking.Domain;

namespace ConcertBooking.Application.Services;

public interface IEventTypeService {
	Task<ApiResponse<IEnumerable<EventType>>> GetAllEventTypes();
	Task<ApiResponse<object>> AddEventType(CreateEventType eventType);
}