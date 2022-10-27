namespace White.UI;
using White.Core;

internal class MainUI
{
    Manager manager;
    public MainUI(Manager manager)
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

    void PrintOneResult(IMovie result, int index)
    {
        Console.WriteLine($"|{(index + 1).ToString().PadRight(5)}|{result.Title.PadRight(60)}|{result.Type.PadRight(10)}|{result.ImdbId.PadRight(10)}|");
    }

    void SearchAndPrintByTitle(string title, int page = 1)
    {
        Console.WriteLine($"|{"T/R".ToString().PadRight(5)}|{"Title".PadRight(60)}|{"Type".PadRight(10)}|{"ImdbId".PadRight(10)}|");
        List<IMovie> movies = manager.SearchByTitle(title, page);
        foreach ((var item, int index) in movies.Select((x, index) => (x, index)))
            PrintOneResult(item, index);
    }

}