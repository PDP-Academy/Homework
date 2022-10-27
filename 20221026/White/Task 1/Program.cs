namespace White;
using White.Core;
using White.UI;
class Program
{
    static void Main(string[] args)
    {
        Imeneger manager = new Manager();
        new MainUI(manager);
    }
}
