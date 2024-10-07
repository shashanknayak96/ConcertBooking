using AutoMapper;
using ConcertBooking.Application.Models;
using ConcertBooking.Domain;

namespace ConcertBooking.Application.Services;

public class VenueService : IVenueService {
	private readonly IRepository<Venue> _repository;
	private readonly IMapper _mapper;

	public VenueService(IRepository<Venue> repository, IMapper mapper) {
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<ApiResponse<IEnumerable<Venue>>> GetAllVenuesAsync() {
		var venues = await _repository.GetAllAsync();
		return new ApiResponse<IEnumerable<Venue>>(true, data: venues);
	}

	public async Task<ApiResponse<object>> AddVenueAsync(CreateVenue venue) {
		var venueModel = _mapper.Map<Venue>(venue);
		await _repository.AddItemAsync(venueModel);

		return new ApiResponse<object>(true, "Venue added successfully", venueModel);
	}
}