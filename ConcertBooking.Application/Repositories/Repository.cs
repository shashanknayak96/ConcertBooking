using ConcertBooking.Domain;
using Microsoft.EntityFrameworkCore;

namespace ConcertBooking.Application.Services;

public class Repository<T> : IRepository<T> where T : BaseName {

	private readonly ConcertBookingContext _context;

	public Repository(ConcertBookingContext context) {
		_context = context;
	}

	public async Task<IEnumerable<T>> GetAllAsync() {
		return await _context.Set<T>().ToListAsync();
	}

	public async Task<T?> GetByIdAsync(Guid guid) {
		return await _context.Set<T>().Where(x => x.Id == guid).FirstOrDefaultAsync();
	}

	public async Task<T?> GetByNameAsync(string name) {
		return await _context.Set<T>().Where(x => x.Name == name).FirstOrDefaultAsync();
	}

	public async Task AddItemAsync(T item) {
		await _context.Set<T>().AddAsync(item);
		await _context.SaveChangesAsync();
	}

	public Task RemoveItemAsync(T item) {
		throw new NotImplementedException();
	}
}