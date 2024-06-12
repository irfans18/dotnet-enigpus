using dotnet_enigpus.Model;
using dotnet_enigpus.Service;
using dotnet_enigpus.Service.Impl;
using dotnet_enigpus.Utils;

namespace dotnet_enigpus.View;

public class Enigpus
{
    private readonly IInventoryService _inventoryService;
    private const int Limit = 50;

    public Enigpus(IInventoryService inventoryService)
    {
        _inventoryService = inventoryService;
    }

    public void Run()
    {
        bool isRunning = true;
        while (isRunning)
        {
            ShowMenu();
            int choice = ScanUtil.ScanInt("Pilih Menu");
            switch (choice)
            {
                case 1: AddNovel();
                    break;
                case 2 : AddMagazine();
                    break;
                case 3 : SearchBook();
                    break;
                case 4: PrintBooks(_inventoryService.GetAllBook());
                    break;
                case 5: isRunning = false;
                    break;
                default: Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        
    }

    private void ShowMenu()
    {
        Console.WriteLine(Enumerable.Repeat("=",Limit));
        Console.WriteLine("Menu");
        Console.WriteLine(Enumerable.Repeat("=",Limit));
        Console.WriteLine("1. Add Novel");
        Console.WriteLine("2. Add Magazine");
        Console.WriteLine("3. Search Book By Title");
        Console.WriteLine("4. Show All Book");
        Console.WriteLine("5. Exit");
        Console.WriteLine(Enumerable.Repeat("=",Limit));
        Console.WriteLine();
    }
    
    

    private void AddNovel()
    {
        string title = ScanUtil.ScanString("Title");
        string code = ScanUtil.ScanString("Code");
        int year = ScanUtil.ScanInt("Year");
        string publisher = ScanUtil.ScanString("Publisher");
        string author = ScanUtil.ScanString("Author");

        Novel novel = new Novel(title, code, publisher, year, author);
        _inventoryService.AddBook(novel);
    }
    
    private void AddMagazine()
    {
        string title = ScanUtil.ScanString("Title");
        string code = ScanUtil.ScanString("Code");
        int year = ScanUtil.ScanInt("Year");
        string publisher = ScanUtil.ScanString("Publisher");
        
        Magazine magazine = new Magazine(title, code, publisher, year);
        _inventoryService.AddBook(magazine);
    }

    private void SearchBook()
    {
        string title = ScanUtil.ScanString("Search By Title :");
        List<Book> books = _inventoryService.SearchBook(title);
        PrintBooks(books);
    }

    private void PrintBooks(List<Book> books)
    {
        // List<Book> books = _inventoryService.GetAllBook();
        Console.WriteLine(Enumerable.Repeat("=",Limit));

        foreach (var book in books)
        {
            if (book.GetType() == typeof(Novel))
            {
                Novel novel = (Novel) book;
                Console.WriteLine("Title\t\t:{0}", novel.GetTitle());
                Console.WriteLine("Code\t\t:{0}", novel.Code);
                Console.WriteLine("Year\t\t:{0}", novel.Year);
                Console.WriteLine("Publisher\t\t:{0}", novel.Publisher);
                Console.WriteLine("Author\t\t:{0}", novel.Author);
            }
            else
            {
                Magazine magazine = (Magazine) book;
                Console.WriteLine("Title\t\t:{0}", magazine.GetTitle());
                Console.WriteLine("Code\t\t:{0}", magazine.Code);
                Console.WriteLine("Year\t\t:{0}", magazine.Year);
                Console.WriteLine("Publisher\t\t:{0}", magazine.Publisher);
            }

            Console.WriteLine("\n");
        }
        Console.WriteLine(Enumerable.Repeat("=",Limit));

    }
}