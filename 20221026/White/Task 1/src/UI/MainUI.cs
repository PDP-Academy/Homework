namespace White.UI;
using White.Core;

public class MainUI
{
    MainUI()
    {

    }

    void Home(string message = null)
    {
        if (message != null)
            Console.WriteLine(message);
    }
}