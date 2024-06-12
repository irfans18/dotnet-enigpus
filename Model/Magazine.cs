namespace dotnet_enigpus.Model;

public class Magazine : Book
{
    private string _title;
    public string Code { get; set; }
    public string Publisher { get; set; }
    public int Year { get; set; }

    public override string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public Magazine(string title, string code, string publisher, int year)
    {
        _title = title;
        Code = code;
        Publisher = publisher;
        Year = year;
    }
}