namespace dotnet_enigpus.Model;

public class Novel : Book
{
    private string _title;
    private string Code { get; set; }
    private string Publisher { get; set; }
    private int Year { get; set; }
    private string Author { get; set; }
    
    public override string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }
}