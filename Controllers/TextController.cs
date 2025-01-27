using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace demoapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
                return BadRequest("Text query parameter is required.");
            }

            _logger.LogInformation("Input text for reverse: {Text}", text);

            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string reversedText = new string(charArray);

            _logger.LogInformation("Output text for reverse: {ReversedText}", reversedText);

            return Ok(reversedText);
        }

        [HttpGet("disemvowel")]
        public IActionResult Disemvowel([FromQuery] string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return BadRequest("Text query parameter is required.");
            }

            _logger.LogInformation("Input text for disemvowel: {Text}", text);

            string result = new string(text.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());

            _logger.LogInformation("Output text for disemvowel: {Result}", result);

            return Ok(result);
        }
    }
}