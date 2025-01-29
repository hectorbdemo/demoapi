# TextController Documentation

## Overview

The `TextController` class is an ASP.NET Core API controller that provides text manipulation endpoints. It includes methods to reverse a given text and to remove vowels from a given text.

## Endpoints

### Reverse Text

#### Description

Reverses the input text.

#### HTTP Method

`GET`

#### URL

`/text/reverse`

#### Query Parameters

- `text` (string): The text to be reversed. This parameter is required.

#### Responses

- `200 OK`: Returns the reversed text.
- `400 Bad Request`: If the `text` parameter is null or empty.

#### Example Request

```http
GET /text/reverse?text=example
```

#### Example Response

```json
{
  "result": "elpmaxe"
}
```

### Disemvowel Text

#### Description

Removes all vowels from the input text.

#### HTTP Method

`GET`

#### URL

`/text/disemvowel`

#### Query Parameters

- `text` (string): The text from which vowels will be removed. This parameter is required.

#### Responses

- `200 OK`: Returns the text with vowels removed.
- `400 Bad Request`: If the `text` parameter is null or empty.

#### Example Request

```http
GET /text/disemvowel?text=example
```

#### Example Response

```json
{
  "result": "xmpl"
}
```

## Code

```csharp
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
```

hectorbdemo_hbdemo: add curls calls

GitHub Copilot: # TextController Documentation

## Overview

The `TextController` class is an ASP.NET Core API controller that provides text manipulation endpoints. It includes methods to reverse a given text and to remove vowels from a given text.

## Endpoints

### Reverse Text

#### Description

Reverses the input text.

#### HTTP Method

`GET`

#### URL

`/text/reverse`

#### Query Parameters

- `text` (string): The text to be reversed. This parameter is required.

#### Responses

- `200 OK`: Returns the reversed text.
- `400 Bad Request`: If the `text` parameter is null or empty.

#### Example Request

```http
GET /text/reverse?text=example
```

#### Example Response

```json
{
  "result": "elpmaxe"
}
```

#### cURL Example

```sh
curl -X GET "http://localhost:5000/text/reverse?text=example"
```

### Disemvowel Text

#### Description

Removes all vowels from the input text.

#### HTTP Method

`GET`

#### URL

`/text/disemvowel`

#### Query Parameters

- `text` (string): The text from which vowels will be removed. This parameter is required.

#### Responses

- `200 OK`: Returns the text with vowels removed.
- `400 Bad Request`: If the `text` parameter is null or empty.

#### Example Request

```http
GET /text/disemvowel?text=example
```

#### Example Response

```json
{
  "result": "xmpl"
}
```

#### cURL Example

```sh
curl -X GET "http://localhost:5000/text/disemvowel?text=example"
```

## Code

```csharp
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
```