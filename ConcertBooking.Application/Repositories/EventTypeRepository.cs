using ConcertBooking.Application;
using ConcertBooking.Domain;

public class EventTypeRepository : IEventTypeRepository {

	private readonly ConcertBookingContext _context;

	public EventTypeRepository(ConcertBookingContext context) {
		_context = context;
	}

	public async Task AddEventTypeAsync(EventType eventType) {
		await this._context.EventType.AddAsync(eventType);
		await this._context.SaveChangesAsync();
	}

	public Task<IEnumerable<EventType>> GetAllEventsAsync() {
		throw new NotImplementedException();
	}

	public Task<EventType> GetByIdAsunc(Guid id) {
		throw new NotImplementedException();
	}

	public Task RemoveEventTypeAsync(EventType eventType) {
		throw new NotImplementedException();
	}
}