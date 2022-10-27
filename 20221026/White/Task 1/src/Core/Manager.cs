namespace White.Core;

class Manager : Imeneger
{
    IApiDataManager manager;
    public List<IResult> SearchDataByTitle(string title, int page)
    {  
        List<IResult> list = manager.SearchDataByTitle(title, page);
        return SortDataByType(list);
    }
    public List<IResult> SortDataByType(List<IResult> list)
    {
        List<IResult> temp = new List<IResult>();
        foreach (var item in list)
        {
            if(item.Type == "movie")
            {
                temp.Add(item);
            }
        }

        foreach (var item in list)
        {
            if(item.Type == "series")
            {
                temp.Add(item);
            }
        }

        foreach (var item in list)
        {
            if(item.Type == "episode")
            {
                temp.Add(item);
            }
        }

        return temp;
    }
}