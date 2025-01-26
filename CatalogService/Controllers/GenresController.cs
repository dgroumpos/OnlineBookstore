using CatalogService.Models;
using CatalogService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GenresController(IRepository<Genre> repository):ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Genre>>> GetAllGenres()
    {
        var genres = await repository.GetAllAsync();
        return Ok(genres);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Genre>> GetGenreById(int id)
    {
        var genre = await repository.GetByIdAsync(id);
        return Ok(genre);
    }

    [HttpPost]
    public async Task<ActionResult<Genre>> AddGenre([FromBody] Genre genre)
    {
        await repository.AddAsync(genre);
        return CreatedAtAction(nameof(GetGenreById), new { id = genre.Id }, genre);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<Genre>> UpdateGenre(int id, [FromBody] Genre genre)
    {
        if(id != genre.Id)
            return BadRequest("The ID in the route does not match the ID in the request body.");
        
        var existingGenre = await repository.GetByIdAsync(id);
        if(existingGenre == null)
            return NotFound($"Genre with ID {id} not found.");
        
        await repository.UpdateAsync(existingGenre);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Genre>> DeleteGenre(int id)
    {
        var genre = await repository.GetByIdAsync(id);
        if(genre == null)
            return NotFound($"Genre with ID {id} not found.");

        await repository.DeleteAsync(id);
        return Ok(genre);
    }
}