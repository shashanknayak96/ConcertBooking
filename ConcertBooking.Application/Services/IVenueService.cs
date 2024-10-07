using ConcertBooking.Application.Models;
using ConcertBooking.Domain;

namespace ConcertBooking.Application.Services;

public interface IVenueService {
	Task<ApiResponse<IEnumerable<Venue>>> GetAllVenuesAsync();
	Task<ApiResponse<object>> AddVenueAsync(CreateVenue venue);
}