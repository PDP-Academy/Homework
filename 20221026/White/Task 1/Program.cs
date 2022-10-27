namespace White;
using White.Core;
class Program
{
    static void Main(string[] args)
    {
        ApiDataManager manager = new ApiDataManager();
        var res = manager.SearchDataByTitle("galaxy", 1);
        Console.WriteLine(res.Count);
    }
}
