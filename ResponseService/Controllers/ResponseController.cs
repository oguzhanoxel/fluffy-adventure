using Microsoft.AspNetCore.Mvc;

namespace ResponseService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ResponseController : ControllerBase
	{
		[Route("{id}")]
		public ActionResult GiveAResponse(int id)
		{
			Random random = new Random();
			int rndInt = random.Next(1, 101);
			if(rndInt >= id)
			{
				Console.WriteLine($"-> Return 500");
				return StatusCode(StatusCodes.Status500InternalServerError);
			}

			Console.WriteLine($"-> Return 200");
			return Ok();
		}
	}
}

