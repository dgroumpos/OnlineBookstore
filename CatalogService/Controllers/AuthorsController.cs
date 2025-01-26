using CatalogService.Models;
using CatalogService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorsController(IRepository<Author> repository): ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Author>>> GetAllAuthors()
    {
        var authors = await repository.GetAllAsync();
        return Ok(authors);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Author>> GetAuthorById(int id)
    {
        var author = await repository.GetByIdAsync(id);
        return Ok(author);
    }

    [HttpPost]
    public async Task<ActionResult<Author>> AddAuthor([FromBody] Author author)
    {
        await repository.AddAsync(author);
        return CreatedAtAction(nameof(GetAuthorById), new { id = author.Id }, author);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<Author>> UpdateAuthor(int id, [FromBody] Author author)
    {
        if(id != author.Id)
            return BadRequest("The ID in the route does not match the ID in the request body.");
        
        var existingAuthor = await repository.GetByIdAsync(id);
        if(existingAuthor == null)
            return NotFound($"Author with ID {id} not found.");
        
        await repository.UpdateAsync(author);
        
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Author>> DeleteAuthor(int id)
    {
        var author = await repository.GetByIdAsync(id); 
        
        if(author == null)
            return NotFound($"Author with ID {id} not found.");

        await repository.DeleteAsync(id);
        return Ok(author);
    }
}