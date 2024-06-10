using dotnet_enigpus.Model;

namespace dotnet_enigpus.Service;

public interface IInventoryService
{
    void AddBook(Book book);
    List<Book> SearchBook(string title);
    List<Book> GetAllBook();
}