# demoapi
otra linea
njhjhjh

# TextController API Documentation

## Overview

The `TextController` API provides two main operations: reversing a text string and removing vowels from a text string (disemvowel). Both operations are accessible via HTTP GET requests.

## Endpoints

### 1. Reverse Text

**Endpoint:** `GET /api/text/reverse`

**Description:** Reverses the input text string.

**Query Parameters:**
- `text` (required): The text string to be reversed.

**Responses:**
- `200 OK`: Returns the reversed text string.
- `400 Bad Request`: If the `text` query parameter is missing or empty.

**Example Request:**
```bash
curl -X GET "http://localhost:5000/api/text/reverse?text=example"

