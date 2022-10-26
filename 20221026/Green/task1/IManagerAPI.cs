
namespace Task1;

internal interface IManagerAPI
{
    public string GetApiKey { get;  }

    public  string GetContentString(string url);
}
