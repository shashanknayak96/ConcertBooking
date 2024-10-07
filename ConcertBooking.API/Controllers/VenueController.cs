
using ConcertBooking.Application.Models;
using ConcertBooking.Application.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class VenueController : ControllerBase {
	private readonly IVenueService _venueService;

	public VenueController(IVenueService venueService) {
		_venueService = venueService;
	}

	[HttpGet]
	public async Task<IActionResult> GetAllVenues() {
		var response = await _venueService.GetAllVenuesAsync();
		return Ok(response);
	}

	[HttpPost]
	public async Task<IActionResult> AddVenue(CreateVenue venue) {
		// Venue model validations

		await _venueService.AddVenueAsync(venue);
		return Ok();
	}
}