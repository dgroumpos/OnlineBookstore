using CatalogService.Models;
using CatalogService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController(IRepository<Book> repository) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
    {
        var books = await repository.GetAllAsync();
        return Ok(books);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Book>> GetBookById(int id)
    {
        var book = await repository.GetByIdAsync(id);
        return Ok(book);
    }

    [HttpPost]
    public async Task<ActionResult<Book>> AddBook([FromBody] Book book)
    {
        await repository.AddAsync(book);
        return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<Book>> UpdateBook(int id, [FromBody] Book book)
    {
        if (id != book.Id)
            return BadRequest("The ID in the route does not match the ID in the request body.");

        var existingBook = await repository.GetByIdAsync(id);
        if (existingBook == null)
            return NotFound($"Book with ID {id} not found.");

        await repository.UpdateAsync(book);

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Book>> DeleteBook(int id)
    {
        var book = await repository.GetByIdAsync(id);
        if (book == null)
        {
            return NotFound($"Book with ID {id} not found.");
        }

        await repository.DeleteAsync(id);
        return Ok(book);
    }
}