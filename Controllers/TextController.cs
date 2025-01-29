using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace demoapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextController : ControllerBase
    {
        private readonly ILogger<TextController> _logger;

        public TextController(ILogger<TextController> logger)
        {
            _logger = logger;
        }

        [HttpGet("reverse")]
        public IActionResult Reverse([FromQuery] string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return BadRequest("Text cannot be null or empty.");
            }

            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return Ok(new string(charArray));
        }

        [HttpGet("disemvowel")]
        public IActionResult Disemvowel([FromQuery] string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return BadRequest("Text cannot be null or empty.");
            }

            string disemvoweledText = new string(text.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
            return Ok(disemvoweledText);
        }
    }
}