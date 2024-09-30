using ConcertBooking.Domain;

public interface IEventTypeRepository {
	Task<IEnumerable<EventType>> GetAllEventsAsync();
	Task<EventType> GetByIdAsunc(Guid id);
	Task AddEventTypeAsync(EventType eventType);
	Task RemoveEventTypeAsync(EventType eventType);
}