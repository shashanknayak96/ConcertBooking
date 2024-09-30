
using Microsoft.AspNetCore.Mvc;

[ApiController]
class VenueController : ControllerBase {
	public VenueController() {

	}

	[HttpGet]
	public async Task<IActionResult> GetAllVenues() {
		return Ok();
	}
}