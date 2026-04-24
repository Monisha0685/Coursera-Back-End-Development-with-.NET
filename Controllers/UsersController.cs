[HttpGet("{id}")]
public IActionResult GetById(int id)
{
    try
    {
        var user = _repository.GetById(id);
        if (user == null) return NotFound(new { message = "User not found" });
        return Ok(user);
    }
    catch (Exception ex)
    {
        return StatusCode(500, new { message = "Internal server error", detail = ex.Message });
    }
}

[HttpPost]
public IActionResult Create(User user)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

    try
    {
        _repository.Add(user);
        return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
    }
    catch (Exception ex)
    {
        return StatusCode(500, new { message = "Error creating user", detail = ex.Message });
    }
}
