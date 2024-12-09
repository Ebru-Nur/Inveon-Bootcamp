using LibraryApp.Entities;
using LibraryApp.Enums;
using LibraryApp.Exceptions;

namespace LibraryApp.Repositories;

public class BookRepository
{
    private static readonly List<Book> Books = new List<Book>();
    private static int primaryId = 1;

    public IEnumerable<Book> GetAll(int pageNumber, int pageSize)
    {
        return Books.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
    }

    public Book GetById(int id) => Books.FirstOrDefault(b => b.Id == id);

    public void Add(Book book)
    {
        book.Id = primaryId++;
        Books.Add(book);
    }

    public void Update(Book book)
    {
        var existing = GetById(book.Id);
        if (existing != null)
        {
            existing.Title = book.Title;
            existing.Author = book.Author;
            existing.Year = book.Year;
        }
        else
        {
            throw new ApiException("Kitap Bulunamadı", ErrorCodes.NotFound);
        }
    }

    public void Delete(int id)
    {
        var book = GetById(id);
        if (book == null) throw new ApiException("Silinecek kitap bulunamadı", ErrorCodes.NotFound);
        Books.Remove(book);
    }
}
