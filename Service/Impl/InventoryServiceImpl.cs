using dotnet_enigpus.Model;

namespace dotnet_enigpus.Service.Impl;

public class InventoryServiceImpl : IInventoryService
{
    private readonly List<Book> _books;

    public InventoryServiceImpl(List<Book>? books = null)
    {
        this._books = books ?? [];
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public List<Book> SearchBook(string title)
    {
        return _books.FindAll(book => book.GetTitle().Equals(title, StringComparison.InvariantCultureIgnoreCase)).ToList();
    }

    public List<Book> GetAllBook()
    {
        return _books;
    }
}