using ConcertBooking.Domain;

public interface IEventTypeRepository {
	Task<IEnumerable<EventType>> GetAllEventsAsync();
	Task<EventType?> GetByNameAsync(string name);
	Task AddEventTypeAsync(EventType eventType);
	Task RemoveEventTypeAsync(EventType eventType);
}