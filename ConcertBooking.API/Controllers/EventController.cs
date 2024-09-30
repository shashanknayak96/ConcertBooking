using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase {
	public EventController() {

	}

	[HttpGet]
	public async Task<IActionResult> GetAllEvents() {
		return Ok("test");
	}

	// Create

	// Update

	// Delete
}