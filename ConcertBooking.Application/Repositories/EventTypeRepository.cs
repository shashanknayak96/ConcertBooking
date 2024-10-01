using ConcertBooking.Application;
using ConcertBooking.Domain;
using Microsoft.EntityFrameworkCore;

public class EventTypeRepository : IEventTypeRepository {
	private readonly ConcertBookingContext _context;

	public EventTypeRepository(ConcertBookingContext context) {
		_context = context;
	}

	public async Task AddEventTypeAsync(EventType eventType) {
		await this._context.EventType.AddAsync(eventType);
		await this._context.SaveChangesAsync();
	}

	public async Task<IEnumerable<EventType>> GetAllEventsAsync() {
		return await _context.EventType.ToListAsync();
	}

	public async Task<EventType?> GetByNameAsync(string name) {
		return await this._context.EventType.Where(et => et.Name == name).FirstOrDefaultAsync();
	}

	public Task RemoveEventTypeAsync(EventType eventType) {
		throw new NotImplementedException();
	}
}