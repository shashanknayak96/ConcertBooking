using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;


namespace API.Controller {

	[ApiController]
	[Route("[controller]")]
	public class TestController : ControllerBase {
		[HttpGet]
		public async Task<IActionResult> Index() {
			return Ok(new List<string>() { "Shashank", "Arya" });
		}
	}
}