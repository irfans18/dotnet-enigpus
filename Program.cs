using dotnet_enigpus.Service;
using dotnet_enigpus.Service.Impl;
using dotnet_enigpus.View;

namespace dotnet_enigpus;

class Program
{
    static void Main(string[] args)
    {
        IInventoryService service = new InventoryServiceImpl([]);
        new Enigpus(service).Run();
    }
}