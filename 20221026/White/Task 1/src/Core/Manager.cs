namespace White.Core;

class Manager : Imeneger
{
    IApiDataManager manager;
    public List<Object> SearchDataByTitle(string title, int page)
    {
        
        
        var list = manager.SearchDataByTitle(title);

    }
    public List<IResult> SortDataByType(List<IResult> list)
    {

    }
}