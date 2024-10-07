namespace ConcertBooking.Application.Services;

public interface IRepository<T> {
	Task<IEnumerable<T>> GetAllAsync();
	Task<T?> GetByIdAsync(Guid guid);
	Task<T?> GetByNameAsync(string name);
	Task AddItemAsync(T item);
	Task RemoveItemAsync(T item);
}