using System.Text.RegularExpressions;

namespace dotnet_enigpus.Utils;

public class ScanUtil
{
    public static string ScanString(string info)
    {
        while (true)
        {
            Console.Write(info + " : ");
            string? readLine = Console.ReadLine();
            if (readLine != null)
            {
                return readLine;
            }
        }
    }
    public static int ScanInt(string info)
    {
        string pattern = @"^\d+$";
        while (true)
        {
            Console.Write(info + " : ");
            string? readLine = Console.ReadLine();
            if (readLine != null && Regex.IsMatch(readLine, pattern))
            {
                if (int.TryParse(readLine, out int num)) {
                    return num;
                }
            }
        }
    }
}