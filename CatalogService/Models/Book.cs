namespace CatalogService.Models;

public class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int AuthorId { get; set; }
    public int GenreId { get; set; }
    public Author? Author { get; set; }
    public Genre? Genre { get; set; }
}