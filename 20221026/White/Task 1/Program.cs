namespace White;
using White.Core;
using White.UI;
class Program
{
    static void Main(string[] args)
    {
        ApiDataManager apiManager = new ApiDataManager();
        Manager manager = new Manager(apiManager);
        new MainUI(manager);
        // var res = manager.SearchDataByTitle("galaxy", 1);
        // // Console.WriteLine(res.Count);
    }
}
