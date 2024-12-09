using LibraryApp.Entities;
using LibraryApp.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/books")]
public class BooksController : ControllerBase
{
    private readonly BookService service;
    public BooksController(BookService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult GetBooks([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        var books = service.GetBooks(pageNumber, pageSize);
        return Ok(books);
    }

    [HttpGet("{id}")]
    public IActionResult GetBookById(int id)
    {
        var books = service.GetBookById(id);
        return Ok(books);
    }

    [HttpPost]
    public IActionResult AddBook([FromBody] Book book)
    {
        service.AddBook(book);
        return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, [FromBody] Book book)
    {
        if (id != book.Id) return BadRequest("ID bulunamadı");
        service.UpdateBook(book);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        service.DeleteBook(id);
        return NoContent();
    }
}
