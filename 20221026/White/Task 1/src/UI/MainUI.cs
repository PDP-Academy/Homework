namespace White.UI;
using White.Core;

internal class MainUI
{
    Imeneger manager;
    public MainUI(Imeneger manager)
    {
        this.manager = manager;
        Home();
    }

    void Home(string message = null)
    {
        if (message != null)
            Console.WriteLine(message);
        Console.WriteLine("Type any title: ");
        string s = Console.ReadLine();
        SearchAndPrintByTitle(s);
    }

    void PrintOneResult(IResult result, int index)
    {
        Console.WriteLine($"|{(index + 1).ToString().PadRight(5)}|{result.Title.PadRight(30)}|{result.Type.PadRight(10)}|{result.imdbID.PadRight(10)}|");
    }

    void SearchAndPrintByTitle(string title, int page = 1)
    {
        Console.WriteLine($"|{"T/R".ToString().PadRight(5)}|{"Title".PadRight(30)}|{"Type".PadRight(10)}|{"ImdbId".PadRight(10)}|");
        List<IResult> movies = manager.SearchDataByTitle(title, page);
        foreach ((var item, int index) in movies.Select((x, index) => (x, index)))
            PrintOneResult(item, index);
    }

}