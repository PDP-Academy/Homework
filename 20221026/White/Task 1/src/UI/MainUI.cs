namespace White.UI;
using White.Core;

public class MainUI
{
    Imeneger manager;
    MainUI(Imeneger manager)
    {
        this.manager = manager;
    }

    void Home(string message = null)
    {
        if (message != null)
            Console.WriteLine(message);
        Console.WriteLine("Type any title: ");
        string s = Console.ReadLine();
    }

    void PrintOneResult(IResult result, int index)
    {
        Console.WriteLine($"|{(index + 1).ToString().PadRight(5)}|{result.Title.PadRight(30)}|{result.Type.PadRight(10)}|{result.ImdbId}|");
    }

    void SearchAndPrintByTitle(string title, int page = 1)
    {
        List<Object> movies = manager.SearchDataByTitle(title, page);
        PrintOneResult((IResult)movies[0], 1);
    }
}