using dotnet_enigpus.Model;

namespace dotnet_enigpus.Service;

public interface IInventoryService
{
    void addBook(Book book);
    List<Book> searchBook(string title);
    List<Book> getAllBook();
}