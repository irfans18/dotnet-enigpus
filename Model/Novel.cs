namespace dotnet_enigpus.Model;

public class Novel : Book
{
    private string _title;
    public string Code { get; set; }
    public string Publisher { get; set; }
    public int Year { get; set; }
    public string Author { get; set; }
    public override string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public Novel(string title, string code, string publisher, int year, string author)
    {
        _title = title;
        Code = code;
        Publisher = publisher;
        Year = year;
        Author = author;
    }
}